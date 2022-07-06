using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SilentCryptoMiner
{
    [DesignerGenerated()]
    public partial class AdvancedOptions : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedOptions));
            this.formAdvancedOptions = new MephTheme();
            this.labelAdvancedOptionDoObfuscation = new System.Windows.Forms.Label();
            this.toggleDoObfuscation = new MephToggleSwitch();
            this.labelAdvancedOptionRunInstall = new System.Windows.Forms.Label();
            this.toggleRunInstall = new MephToggleSwitch();
            this.labelAdvancedOptionOldMinerOverwrite = new System.Windows.Forms.Label();
            this.toggleOldMinerOverwrite = new MephToggleSwitch();
            this.labelAdvancedOptionMemoryWatchdog = new System.Windows.Forms.Label();
            this.toggleMemoryWatchdog = new MephToggleSwitch();
            this.picAdmin1 = new System.Windows.Forms.PictureBox();
            this.labelAdvancedOptionRootkit = new System.Windows.Forms.Label();
            this.toggleRootkit = new MephToggleSwitch();
            this.labelAdvancedOptionDebug = new System.Windows.Forms.Label();
            this.toggleDebug = new MephToggleSwitch();
            this.formAdvancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin1)).BeginInit();
            this.SuspendLayout();
            // 
            // formAdvancedOptions
            // 
            this.formAdvancedOptions.AccentColor = System.Drawing.Color.DarkRed;
            this.formAdvancedOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formAdvancedOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionDoObfuscation);
            this.formAdvancedOptions.Controls.Add(this.toggleDoObfuscation);
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionRunInstall);
            this.formAdvancedOptions.Controls.Add(this.toggleRunInstall);
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionOldMinerOverwrite);
            this.formAdvancedOptions.Controls.Add(this.toggleOldMinerOverwrite);
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionMemoryWatchdog);
            this.formAdvancedOptions.Controls.Add(this.toggleMemoryWatchdog);
            this.formAdvancedOptions.Controls.Add(this.picAdmin1);
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionRootkit);
            this.formAdvancedOptions.Controls.Add(this.toggleRootkit);
            this.formAdvancedOptions.Controls.Add(this.labelAdvancedOptionDebug);
            this.formAdvancedOptions.Controls.Add(this.toggleDebug);
            this.formAdvancedOptions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.formAdvancedOptions.Location = new System.Drawing.Point(0, 0);
            this.formAdvancedOptions.Name = "formAdvancedOptions";
            this.formAdvancedOptions.Size = new System.Drawing.Size(273, 307);
            this.formAdvancedOptions.SubHeader = "";
            this.formAdvancedOptions.TabIndex = 0;
            this.formAdvancedOptions.Text = "Advanced Options";
            // 
            // labelAdvancedOptionDoObfuscation
            // 
            this.labelAdvancedOptionDoObfuscation.AutoEllipsis = true;
            this.labelAdvancedOptionDoObfuscation.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionDoObfuscation.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionDoObfuscation.ForeColor = System.Drawing.Color.Gray;
            this.labelAdvancedOptionDoObfuscation.Location = new System.Drawing.Point(13, 155);
            this.labelAdvancedOptionDoObfuscation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionDoObfuscation.Name = "labelAdvancedOptionDoObfuscation";
            this.labelAdvancedOptionDoObfuscation.Size = new System.Drawing.Size(170, 17);
            this.labelAdvancedOptionDoObfuscation.TabIndex = 120;
            this.labelAdvancedOptionDoObfuscation.Text = "Do built-in obfuscations:";
            // 
            // toggleDoObfuscation
            // 
            this.toggleDoObfuscation.BackColor = System.Drawing.Color.Transparent;
            this.toggleDoObfuscation.Checked = true;
            this.toggleDoObfuscation.ForeColor = System.Drawing.Color.Black;
            this.toggleDoObfuscation.Location = new System.Drawing.Point(188, 152);
            this.toggleDoObfuscation.Margin = new System.Windows.Forms.Padding(2);
            this.toggleDoObfuscation.Name = "toggleDoObfuscation";
            this.toggleDoObfuscation.Size = new System.Drawing.Size(50, 24);
            this.toggleDoObfuscation.TabIndex = 119;
            // 
            // labelAdvancedOptionRunInstall
            // 
            this.labelAdvancedOptionRunInstall.AutoEllipsis = true;
            this.labelAdvancedOptionRunInstall.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionRunInstall.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionRunInstall.ForeColor = System.Drawing.Color.Gray;
            this.labelAdvancedOptionRunInstall.Location = new System.Drawing.Point(13, 127);
            this.labelAdvancedOptionRunInstall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionRunInstall.Name = "labelAdvancedOptionRunInstall";
            this.labelAdvancedOptionRunInstall.Size = new System.Drawing.Size(170, 17);
            this.labelAdvancedOptionRunInstall.TabIndex = 118;
            this.labelAdvancedOptionRunInstall.Text = "Run miner after install:";
            // 
            // toggleRunInstall
            // 
            this.toggleRunInstall.BackColor = System.Drawing.Color.Transparent;
            this.toggleRunInstall.Checked = true;
            this.toggleRunInstall.ForeColor = System.Drawing.Color.Black;
            this.toggleRunInstall.Location = new System.Drawing.Point(188, 124);
            this.toggleRunInstall.Margin = new System.Windows.Forms.Padding(2);
            this.toggleRunInstall.Name = "toggleRunInstall";
            this.toggleRunInstall.Size = new System.Drawing.Size(50, 24);
            this.toggleRunInstall.TabIndex = 117;
            // 
            // labelAdvancedOptionOldMinerOverwrite
            // 
            this.labelAdvancedOptionOldMinerOverwrite.AutoEllipsis = true;
            this.labelAdvancedOptionOldMinerOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionOldMinerOverwrite.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionOldMinerOverwrite.ForeColor = System.Drawing.Color.Gray;
            this.labelAdvancedOptionOldMinerOverwrite.Location = new System.Drawing.Point(13, 99);
            this.labelAdvancedOptionOldMinerOverwrite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionOldMinerOverwrite.Name = "labelAdvancedOptionOldMinerOverwrite";
            this.labelAdvancedOptionOldMinerOverwrite.Size = new System.Drawing.Size(170, 17);
            this.labelAdvancedOptionOldMinerOverwrite.TabIndex = 116;
            this.labelAdvancedOptionOldMinerOverwrite.Text = "Overwrite old miners:";
            // 
            // toggleOldMinerOverwrite
            // 
            this.toggleOldMinerOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.toggleOldMinerOverwrite.Checked = true;
            this.toggleOldMinerOverwrite.ForeColor = System.Drawing.Color.Black;
            this.toggleOldMinerOverwrite.Location = new System.Drawing.Point(188, 96);
            this.toggleOldMinerOverwrite.Margin = new System.Windows.Forms.Padding(2);
            this.toggleOldMinerOverwrite.Name = "toggleOldMinerOverwrite";
            this.toggleOldMinerOverwrite.Size = new System.Drawing.Size(50, 24);
            this.toggleOldMinerOverwrite.TabIndex = 115;
            // 
            // labelAdvancedOptionMemoryWatchdog
            // 
            this.labelAdvancedOptionMemoryWatchdog.AutoEllipsis = true;
            this.labelAdvancedOptionMemoryWatchdog.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionMemoryWatchdog.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionMemoryWatchdog.ForeColor = System.Drawing.Color.Gray;
            this.labelAdvancedOptionMemoryWatchdog.Location = new System.Drawing.Point(12, 71);
            this.labelAdvancedOptionMemoryWatchdog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionMemoryWatchdog.Name = "labelAdvancedOptionMemoryWatchdog";
            this.labelAdvancedOptionMemoryWatchdog.Size = new System.Drawing.Size(170, 17);
            this.labelAdvancedOptionMemoryWatchdog.TabIndex = 114;
            this.labelAdvancedOptionMemoryWatchdog.Text = "Run Watchdog in Memory:";
            // 
            // toggleMemoryWatchdog
            // 
            this.toggleMemoryWatchdog.BackColor = System.Drawing.Color.Transparent;
            this.toggleMemoryWatchdog.Checked = true;
            this.toggleMemoryWatchdog.ForeColor = System.Drawing.Color.Black;
            this.toggleMemoryWatchdog.Location = new System.Drawing.Point(188, 68);
            this.toggleMemoryWatchdog.Margin = new System.Windows.Forms.Padding(2);
            this.toggleMemoryWatchdog.Name = "toggleMemoryWatchdog";
            this.toggleMemoryWatchdog.Size = new System.Drawing.Size(50, 24);
            this.toggleMemoryWatchdog.TabIndex = 113;
            // 
            // picAdmin1
            // 
            this.picAdmin1.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin1.Image = global::SilentCryptoMiner.Properties.Resources.microsoft_admin;
            this.picAdmin1.Location = new System.Drawing.Point(243, 247);
            this.picAdmin1.Name = "picAdmin1";
            this.picAdmin1.Size = new System.Drawing.Size(20, 20);
            this.picAdmin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin1.TabIndex = 112;
            this.picAdmin1.TabStop = false;
            // 
            // labelAdvancedOptionRootkit
            // 
            this.labelAdvancedOptionRootkit.AutoEllipsis = true;
            this.labelAdvancedOptionRootkit.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionRootkit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionRootkit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAdvancedOptionRootkit.Location = new System.Drawing.Point(12, 249);
            this.labelAdvancedOptionRootkit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionRootkit.Name = "labelAdvancedOptionRootkit";
            this.labelAdvancedOptionRootkit.Size = new System.Drawing.Size(170, 17);
            this.labelAdvancedOptionRootkit.TabIndex = 111;
            this.labelAdvancedOptionRootkit.Text = "Install Rootkit:";
            // 
            // toggleRootkit
            // 
            this.toggleRootkit.BackColor = System.Drawing.Color.Transparent;
            this.toggleRootkit.Checked = false;
            this.toggleRootkit.ForeColor = System.Drawing.Color.Black;
            this.toggleRootkit.Location = new System.Drawing.Point(188, 245);
            this.toggleRootkit.Margin = new System.Windows.Forms.Padding(2);
            this.toggleRootkit.Name = "toggleRootkit";
            this.toggleRootkit.Size = new System.Drawing.Size(50, 24);
            this.toggleRootkit.TabIndex = 110;
            // 
            // labelAdvancedOptionDebug
            // 
            this.labelAdvancedOptionDebug.AutoEllipsis = true;
            this.labelAdvancedOptionDebug.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvancedOptionDebug.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelAdvancedOptionDebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAdvancedOptionDebug.Location = new System.Drawing.Point(13, 275);
            this.labelAdvancedOptionDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdvancedOptionDebug.Name = "labelAdvancedOptionDebug";
            this.labelAdvancedOptionDebug.Size = new System.Drawing.Size(170, 17);
            this.labelAdvancedOptionDebug.TabIndex = 109;
            this.labelAdvancedOptionDebug.Text = "DEBUG:";
            // 
            // toggleDebug
            // 
            this.toggleDebug.BackColor = System.Drawing.Color.Transparent;
            this.toggleDebug.Checked = false;
            this.toggleDebug.ForeColor = System.Drawing.Color.Black;
            this.toggleDebug.Location = new System.Drawing.Point(188, 273);
            this.toggleDebug.Margin = new System.Windows.Forms.Padding(2);
            this.toggleDebug.Name = "toggleDebug";
            this.toggleDebug.Size = new System.Drawing.Size(50, 24);
            this.toggleDebug.TabIndex = 108;
            // 
            // AdvancedOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(273, 307);
            this.Controls.Add(this.formAdvancedOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.729167F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 307);
            this.MinimizeBox = false;
            this.Name = "AdvancedOptions";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.advancedOptions_FormClosing);
            this.formAdvancedOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin1)).EndInit();
            this.ResumeLayout(false);

        }

        internal MephTheme formAdvancedOptions;
        internal PictureBox picAdmin1;
        internal Label labelAdvancedOptionRootkit;
        internal MephToggleSwitch toggleRootkit;
        internal Label labelAdvancedOptionDebug;
        internal MephToggleSwitch toggleDebug;
        internal Label labelAdvancedOptionMemoryWatchdog;
        internal MephToggleSwitch toggleMemoryWatchdog;
        internal Label labelAdvancedOptionOldMinerOverwrite;
        internal MephToggleSwitch toggleOldMinerOverwrite;
        internal Label labelAdvancedOptionRunInstall;
        internal MephToggleSwitch toggleRunInstall;
        internal Label labelAdvancedOptionDoObfuscation;
        internal MephToggleSwitch toggleDoObfuscation;
    }
}