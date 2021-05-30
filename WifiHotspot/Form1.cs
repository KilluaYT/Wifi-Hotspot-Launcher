using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WifiHotspot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("The Password should be at least 8 Characters long.", "Info");
            }
            else
            {
                string cmd = "netsh wlan set hostednetwork mode=allow ssid=" + textBox1.Text + " key=" + textBox2.Text + "keyUsage=presistent" + Environment.NewLine + "netsh wlan start hostednetwork";
                Directory.CreateDirectory(Path.GetTempPath() + "WifiHotspotLauncher");
                File.WriteAllText(Path.GetTempPath() + "WifiHotspotLauncher\\start.bat", cmd);
                System.Diagnostics.Process.Start(Path.GetTempPath() + "WifiHotspotLauncher\\start.bat");
                label7.Text = "Status: running";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd = "netsh wlan stop hostednetwork";
            Directory.CreateDirectory(Path.GetTempPath() + "WifiHotspotLauncher");
            File.WriteAllText(Path.GetTempPath() + "WifiHotspotLauncher\\stop.bat", cmd);
            System.Diagnostics.Process.Start(Path.GetTempPath() + "WifiHotspotLauncher\\stop.bat");
            label7.Text = "Status: stopped";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KilluaYT");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KilluaYT");
        }
    }
}