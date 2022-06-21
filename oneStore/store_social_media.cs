using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneStore
{
    public partial class store_social_media : Form
    {
        public store_social_media()
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void store_social_media_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                store_social_pb.Image = Properties.Resources.Red6;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                store_social_pb.Image = Properties.Resources.Yellow6;
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                store_social_pb.Image = Properties.Resources.Green6;
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                store_social_pb.Image = Properties.Resources.Cyan6;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                store_social_pb.Image = Properties.Resources.Blue6;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                store_social_pb.Image = Properties.Resources.Megenta6;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            lbl_Store.Parent = store_social_pb;
            lbl_Store.BackColor = Color.Transparent;


            btn_exit.Parent = store_social_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = store_social_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

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

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            try
            {
                StoreBrowser.Navigate("http://www.facebook.com/");
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            try
            {
                StoreBrowser.Navigate("http://www.instagram.com/");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_web_back_Click(object sender, EventArgs e)
        {
            if(StoreBrowser.CanGoBack)
            {
                StoreBrowser.GoBack();
            }
        }

        private void btn_web_forward_Click(object sender, EventArgs e)
        {
            if(StoreBrowser.CanGoForward)
            {
                StoreBrowser.GoForward();
            }
        }

        private void btn_web_reload_Click(object sender, EventArgs e)
        {
            StoreBrowser.Refresh();
        }

        private void btn_google_Click(object sender, EventArgs e)
        {
            try
            {
                StoreBrowser.Navigate("http://www.google.com/");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
