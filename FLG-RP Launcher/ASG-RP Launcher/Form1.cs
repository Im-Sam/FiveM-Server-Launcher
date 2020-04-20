using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FLG_RP_Launcher
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LaunchGame_Click(object sender, EventArgs e)
        {
            Launcher.PlayGame("fivem://connect/149.56.243.165:30121");
        }

        private void LaunchWebsite_Click(object sender, EventArgs e)
        {
            Launcher.LaunchWebsite("http://www.freshlifegaming.com/");
        }

        private void LaunchCad_Click(object sender, EventArgs e)
        {
            Launcher.LaunchCad("https://freshlifegaming.com/cad/");
        }

     
    }
}
