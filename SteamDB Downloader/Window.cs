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
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            // RunCommand("dotnet DepotDownloader.dll -app 730 -depot 731 -manifest 7617088375292372759");
            RunCommand("echo hello");
        }

        private void cmdlog_TextChanged(object sender, EventArgs e)
        {
            
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
    }
}