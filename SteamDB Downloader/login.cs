using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamDB_Downloader
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var m = new isthissafe();
            m.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://help.steampowered.com/wizard/HelpWithLoginInfo?issueid=406");
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            //dotnet DepotDownloader.dll -app 70 -depot 74 -manifest 6835489433906213943 -username test -password test
            //remeber to use DepotDownloader files
            //string appId = textBox1.Text, depotId = textBox2.Text, username = loginuser.Text, password = loginpassw.Text, svalidate = " -validate";
            //manifest = textBox3.Text;
            //command = "dotnet DepotDownloader.dll -app " + appId + " -depot " + depotId + " -manifest " + manifest + " -username " + username + " -password " + password;
            //if (validate) command += svalidate;
            //command = "mkdir debug";
            //cmdlog_TextChanged(sender, e); //debug
        }
    }
}
