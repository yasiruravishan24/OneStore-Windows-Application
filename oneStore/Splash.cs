using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoUploader;
using System.IO.Ports;

namespace oneStore
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
            
        }
        Login l1 = new Login();
        private void splash_timer_Tick(object sender, EventArgs e)
        {
            
            sp_pro_bar.Increment(1);
            if(sp_pro_bar.Value == 100)
            {
                sp_pro_bar.Enabled = false;
                splash_timer.Enabled = false;
                Hide();
                l1.Show();
            }
            
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            try
            {
                ArduioUnoPort.Close();
                if(Properties.Settings.Default.ArduinoCode != "Unlock")
                {
                    arduinoUploadClass auc = new arduinoUploadClass();
                    auc.unlockcode();
                    Properties.Settings.Default.ArduinoCode = "Unlock";
                    Properties.Settings.Default.Save();
                }
                if(!ArduioUnoPort.IsOpen)
                {
                    ArduioUnoPort.Open();
                }

                if(Properties.Settings.Default.ArduinoState != "Online")
                {
                    Properties.Settings.Default.ArduinoState = "Online";
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception)
            {
                splash_timer.Enabled = false;
                 DialogResult dr = MetroFramework.MetroMessageBox.Show(this,"Arduino not connected.please check arduino port or login with username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dr == DialogResult.OK)
                {
                    splash_timer.Enabled = true;
                    if (Properties.Settings.Default.ArduinoState != "Offline")
                    {
                        Properties.Settings.Default.ArduinoState = "Offline";
                        Properties.Settings.Default.Save();
                    }

                }
            }
            if(ArduioUnoPort.IsOpen)
            {
                ArduioUnoPort.Close();
            }



            if (Properties.Settings.Default.Theme == "Red")
            {
                pic_splash.Image = Properties.Resources.Red1;
                sp_bar_panel.BackColor = Color.Red;
                sp_pro_bar.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                pic_splash.Image = Properties.Resources.Yellow1;
                sp_bar_panel.BackColor = Color.FromArgb(255, 235, 20);
                sp_pro_bar.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                pic_splash.Image = Properties.Resources.Green1;
                sp_bar_panel.BackColor = Color.FromArgb(32, 236, 44);
                sp_pro_bar.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                pic_splash.Image = Properties.Resources.Cyan1;
                sp_bar_panel.BackColor = Color.Cyan;
                sp_pro_bar.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                pic_splash.Image = Properties.Resources.Blue1;
                sp_bar_panel.BackColor = Color.Blue;
                sp_pro_bar.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                pic_splash.Image = Properties.Resources.Magenta1;
                sp_bar_panel.BackColor = Color.Magenta;
                sp_pro_bar.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }
            sp_pro_bar.Style = MetroFramework.MetroColorStyle.Black;
            
        }
    }
}
