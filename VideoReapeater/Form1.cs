using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoReapeater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
            InitializeComponent();
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            //if (e.Mode == Microsoft.Win32.PowerModes.StatusChange)
            //{
            //    if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
            //    {
            //        MessageBox.Show("No Power, using Batery!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
            {
                MessageBox.Show("No Power, using Batery!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            axPlayer.URL = Environment.GetCommandLineArgs().Last();
            axPlayer.settings.setMode("loop", true);
            axPlayer.settings.volume = 100;
            axPlayer.Ctlcontrols.play();
        }
    }
}
