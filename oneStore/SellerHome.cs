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
    public partial class SellerHome : Form
    {
        public SellerHome()
        {
            InitializeComponent();
        }
        public string EmpId;
        public void SetData(string emp_id, string fname, string sname)
        {
            EmpId = emp_id;
            UFName = fname;
            USName = sname;
        }
        public string UFName;
        public string USName;
        public string PcName;
        public string Operation;

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                if(Properties.Settings.Default.ArduinoCode != "Unlock")
                {
                    if (Properties.Settings.Default.ArduinoState == "Online")
                    {
                        panel_logout.Show();
                        panel_logout_second.Show();

                        arduinoUploadClass auc = new arduinoUploadClass();
                        auc.unlockcode();

                        Properties.Settings.Default.ArduinoCode = "Unlock";
                        Properties.Settings.Default.Save();
                    }


                }

                databaseclass st = new databaseclass();
                PcName = System.Environment.MachineName;
                Operation = "Logout";

                string query = "insert into Employee_records(Emp_ID, Emp_First_Name, Emp_Second_Name, Pc_Name, Operation)values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "')";

                st.login_logout_record(query);

                panel_logout.Hide();
                panel_logout_second.Hide();

                Login l1 = new Login();
                l1.Show();
                this.Hide();
                
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    Login l1 = new Login();
                    l1.Show();
                    this.Hide();
                }
            }

        }

        private void SellerHome_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                seller_pb.Image = Properties.Resources.Red5;
                panel_logout_second.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                seller_pb.Image = Properties.Resources.Yellow5;
                panel_logout_second.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                seller_pb.Image = Properties.Resources.Green5;
                panel_logout_second.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                seller_pb.Image = Properties.Resources.Cyan5;
                panel_logout_second.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                seller_pb.Image = Properties.Resources.Blue5;
                panel_logout_second.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                seller_pb.Image = Properties.Resources.Magenta5;
                panel_logout_second.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            btn_exit.Parent = seller_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = seller_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            lbl_homename.Parent = seller_pb;
            lbl_homename.BackColor = Color.Transparent;

            panel_logout.Hide();
            panel_logout_second.Hide();

        }

        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
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

        private void btn_sell_item_Click(object sender, EventArgs e)
        {
            sellItems si = new sellItems();
            si.SetData(EmpId, UFName, USName);
            si.Show();
            this.Hide();
        }

        private void btn_loyalty_reg_Click(object sender, EventArgs e)
        {
            Reg_loyalty rl = new Reg_loyalty();
            rl.SetData(EmpId, UFName, USName);
            rl.Show();
            this.Hide();
        }

        private void btn_view_item_Click(object sender, EventArgs e)
        {
            viewItems vi = new viewItems();
            vi.SetData(EmpId, UFName, USName);
            vi.Show();
            this.Hide();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reportseller rs = new Reportseller();
            rs.SetData(EmpId, UFName, USName);
            rs.Show();
            this.Hide();
        }
        private void btn_pofile_settings_Click(object sender, EventArgs e)
        {
            SellerProfile_settings sps = new SellerProfile_settings();
            sps.SetData(EmpId,UFName,USName);
            sps.Show();
            this.Hide();
        }
    }
}
