using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace oneStore
{
    public partial class StoreLigth_appColor : Form
    {
        public StoreLigth_appColor()
        {
            InitializeComponent();
        }
        public void SetData(string emp_ID, string fname, string sname)
        {
            EmpId = emp_ID;
            UFName = fname;
            USName = sname;
        }

        public string EmpId;
        public string UFName;
        public string USName;
        public string PcName;
        public string Operation;

        private void StoreLigth_appColor_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Theme == "Red")
            {
                storeLightColor_pb.Image = Properties.Resources.Red6;
                applicationColor_panel.BackColor = Color.Red;
                light_panel.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if(Properties.Settings.Default.Theme == "Yellow")
            {
                storeLightColor_pb.Image = Properties.Resources.Yellow6;
                applicationColor_panel.BackColor = Color.FromArgb(255, 235, 20);
                light_panel.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                storeLightColor_pb.Image = Properties.Resources.Green6;
                applicationColor_panel.BackColor = Color.FromArgb(32, 236, 44);
                light_panel.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                storeLightColor_pb.Image = Properties.Resources.Cyan6;
                applicationColor_panel.BackColor = Color.Cyan;
                light_panel.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                storeLightColor_pb.Image = Properties.Resources.Blue6;
                applicationColor_panel.BackColor = Color.Blue;
                light_panel.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                storeLightColor_pb.Image = Properties.Resources.Megenta6;
                applicationColor_panel.BackColor = Color.Magenta;
                light_panel.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            cmb_colorPick.Text = Properties.Settings.Default.Theme;

            lbl_storeLigthColor.Parent = storeLightColor_pb;
            lbl_storeLigthColor.BackColor = Color.Transparent;


            btn_exit.Parent = storeLightColor_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = storeLightColor_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            applicationColor_panel.Hide();
            light_panel.Show();
        }

        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }
        public void chagenColor(string colorcode)
        {
            try
            {
                arduinoNano.Open();
                arduinoNano.Write(colorcode);
                arduinoNano.Close();

            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Light system not found.please check", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            chagenColor("255,0,0");
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            chagenColor("255,255,0");
        }

        private void btn_lime_Click(object sender, EventArgs e)
        {
            chagenColor("0,255,0");
        }

        private void btn_cyan_Click(object sender, EventArgs e)
        {
            chagenColor("0,255,255");
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            chagenColor("0,0,255");
        }

        private void btn_megenta_Click(object sender, EventArgs e)
        {
            chagenColor("255,0,255");
        }

        private void btn_saveTheme_Click(object sender, EventArgs e)
        {
            try
            {
                switch(cmb_colorPick.SelectedIndex)
                {
                    case 0:
                        storeLightColor_pb.Image = Properties.Resources.Red6;
                        applicationColor_panel.BackColor = Color.Red;
                        light_panel.BackColor = Color.Red;
                        this.Icon = Properties.Resources.RedIcon;
                        Properties.Settings.Default.Theme = "Red";
                        Properties.Settings.Default.Save();
                        break;
                    case 1:
                        storeLightColor_pb.Image = Properties.Resources.Yellow6;
                        applicationColor_panel.BackColor = Color.FromArgb(255, 235, 20);
                        light_panel.BackColor = Color.FromArgb(255, 235, 20);
                        this.Icon = Properties.Resources.YellowIcon;
                        Properties.Settings.Default.Theme = "Yellow";
                        Properties.Settings.Default.Save();
                        break;
                    case 2:
                        storeLightColor_pb.Image = Properties.Resources.Green6;
                        applicationColor_panel.BackColor = Color.FromArgb(33, 255, 44);
                        light_panel.BackColor = Color.FromArgb(33, 255, 44);
                        this.Icon = Properties.Resources.GreenIcon;
                        Properties.Settings.Default.Theme = "Green";
                        Properties.Settings.Default.Save();
                        break;
                    case 3:
                        storeLightColor_pb.Image = Properties.Resources.Cyan6;
                        applicationColor_panel.BackColor = Color.Cyan;
                        light_panel.BackColor = Color.Cyan;
                        this.Icon = Properties.Resources.CyanIcon;
                        Properties.Settings.Default.Theme = "Cyan";
                        Properties.Settings.Default.Save();
                        break;
                    case 4:
                        storeLightColor_pb.Image = Properties.Resources.Blue6;
                        applicationColor_panel.BackColor = Color.Blue;
                        light_panel.BackColor = Color.Blue;
                        this.Icon = Properties.Resources.BlueIcon;
                        Properties.Settings.Default.Theme = "Blue";
                        Properties.Settings.Default.Save();
                        break;
                    case 5:
                        storeLightColor_pb.Image = Properties.Resources.Megenta6;
                        applicationColor_panel.BackColor = Color.Magenta;
                        light_panel.BackColor = Color.Magenta;
                        this.Icon = Properties.Resources.MagentaIcon;
                        Properties.Settings.Default.Theme = "Magenta";
                        Properties.Settings.Default.Save();
                        break;
                }

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_storeLigthColor_Click(object sender, EventArgs e)
        {
            applicationColor_panel.Hide();
            light_panel.Show();
        }

        private void btn_appColor_Click(object sender, EventArgs e)
        {
            applicationColor_panel.Show();
            light_panel.Hide();
        }
    }
}
