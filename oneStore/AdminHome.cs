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
    public partial class AdminHome : Form
    {
        
       
        public AdminHome()
        {
            InitializeComponent();
        }
        
        public void SetData(string emp_ID,string fname,string sname)
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

        private void AdminHome_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                adminh_pb.Image = Properties.Resources.Red4;
                panel_logout_second.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                adminh_pb.Image = Properties.Resources.Yellow4;
                panel_logout_second.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                adminh_pb.Image = Properties.Resources.Green4;
                panel_logout_second.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                adminh_pb.Image = Properties.Resources.Cyan4;
                panel_logout_second.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                adminh_pb.Image = Properties.Resources.Blue4;
                panel_logout_second.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                adminh_pb.Image = Properties.Resources.Magenta4;
                panel_logout_second.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            btn_exit.Parent = adminh_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = adminh_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            lbl_homename.Parent = adminh_pb;
            lbl_homename.BackColor = Color.Transparent;

            btn_mg_employee.Focus();

            panel_logout.Hide();
            panel_logout_second.Hide();
            
        }
        private void btn_Logout_Click_1(object sender, EventArgs e)
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

                PcName = System.Environment.MachineName;
                Operation = "Logout";

                databaseclass st = new databaseclass();
                string query = "insert into Employee_records(Emp_ID, Emp_First_Name, Emp_Second_Name, Pc_Name, Operation)values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "')";

                st.login_logout_record(query);

                panel_logout.Hide();
                panel_logout_second.Hide();

                Login l1 = new Login();
                l1.Show();
                this.Hide();
               
            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dr == DialogResult.OK)
                {
                    Login l1 = new Login();
                    l1.Show();
                    this.Hide();
                   
                }   
            }

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

        private void btn_mg_product_Click(object sender, EventArgs e)
        {
            manage_sell_items msi = new manage_sell_items();
            msi.SetData(EmpId, UFName, USName);
            msi.Show();
            this.Hide();
            
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            Reports r1 = new Reports();
            r1.SetData(EmpId, UFName, USName);
            r1.Show();
            this.Hide();
        }

        private void btn_mg_employee_Click(object sender, EventArgs e)
        {
            manage_employee me = new manage_employee();
            me.SetData(EmpId, UFName, USName);
            me.Show();
            this.Hide();
        }

        private void btn_social_media_Click(object sender, EventArgs e)
        {
            store_social_media ssm = new store_social_media();
            ssm.SetData(EmpId, UFName, USName);
            ssm.Show();
            this.Hide();
        }

        private void btn_ligth_color_Click(object sender, EventArgs e)
        {
            StoreLigth_appColor slac = new StoreLigth_appColor();
            slac.SetData(EmpId, UFName, USName);
            slac.Show();
            this.Hide();
        }

        private void btn_pofile_settings_Click(object sender, EventArgs e)
        {
            adminProfile_settings aps = new adminProfile_settings();
            aps.SetData(EmpId,UFName,USName);
            aps.Show();
            this.Hide();
        }
    }
}
