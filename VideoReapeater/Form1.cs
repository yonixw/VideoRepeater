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
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            axPlayer.URL = Environment.GetCommandLineArgs().Last();
            axPlayer.settings.setMode("loop", true);
            axPlayer.settings.volume = 100;
            axPlayer.Ctlcontrols.play();
        }
    }
}
