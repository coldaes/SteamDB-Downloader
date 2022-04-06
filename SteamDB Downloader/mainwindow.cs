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
using System.IO;

namespace SteamDB_Downloader
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
        }

        bool validate = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (validate) validate = false; else validate = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string command, manifest;
        private void button1_Click(object sender, EventArgs e)
        {
            // dotnet DepotDownloader.dll -app 70 -depot 74 -manifest 6835489433906213943 -username test -password test
            // remeber to use DepotDownloader files
            // string appId = textBox1.Text, depotId = textBox2.Text, username = textBox5.Text, password = textBox4.Text, svalidate = " -validate";
            // manifest = textBox3.Text;
            // command = "dotnet DepotDownloader.dll -app " + appId + " -depot " + depotId + " -manifest " + manifest + " -username " + username + " -password " + password;
            // if (validate) command += svalidate;
            //command = "mkdir debug_tits";
            // cmdlog_TextChanged(sender, e); //debug

            var m = new login();
            m.Show();
        }

        private void cmdlog_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = @"/C " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            string cmdoutput = "";
            while (!process.HasExited)
            {
                cmdoutput += process.StandardOutput.ReadToEnd();

            }
            textareaLog.Text = cmdoutput;
            if(log)
            {
                string output = cmdoutput + Environment.NewLine;
                File.WriteAllText("./Log/Output for " + manifest + ".log", output);
            }
        }

        private void RunCommand(string command)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo("cmd")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Arguments = String.Format("/c \"{0}\"", command),
                }
            };
            process.OutputDataReceived += (s, e) => logcmd(e.Data);
            process.Start();
            process.BeginOutputReadLine();

            process.WaitForExit();
        }

        private void logcmd(string message)
        {
            Invoke(new Action(() =>
            {
                textareaLog.Text += message + "\n\r";
            }));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool log = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (log) log = false; else log = true;
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "dir");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C start https://www.youtube.com/watch?v=fJ9rUzIMcZQ");
        }
    }
}