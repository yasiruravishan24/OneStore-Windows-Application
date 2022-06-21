using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageEmployee_Proj;
using ManageItems_Proj;
using CustomerRegister_Proj;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace oneStore
{
    public partial class manage_employee : Form
    {
        public manage_employee()
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
        public string tableName;

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void manage_employee_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                manageEmployee_pb.Image = Properties.Resources.Red6;
                panel_employee_view.BackColor = Color.Red;
                panel_remove.BackColor = Color.Red;
                panel_logout_second.BackColor = Color.Red;
                panel_add_employee.BackColor = Color.Red;
                panelfinger_print.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                manageEmployee_pb.Image = Properties.Resources.Yellow6;
                panel_employee_view.BackColor = Color.FromArgb(255, 235, 20);
                panel_remove.BackColor = Color.FromArgb(255, 235, 20);
                panel_logout_second.BackColor = Color.FromArgb(255, 235, 20);
                panel_add_employee.BackColor = Color.FromArgb(255, 235, 20);
                panelfinger_print.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                manageEmployee_pb.Image = Properties.Resources.Green6;
                panel_employee_view.BackColor = Color.FromArgb(32, 236, 44);
                panel_remove.BackColor = Color.FromArgb(32, 236, 44);
                panel_logout_second.BackColor = Color.FromArgb(32, 236, 44);
                panel_add_employee.BackColor = Color.FromArgb(32, 236, 44);
                panelfinger_print.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                manageEmployee_pb.Image = Properties.Resources.Cyan6;
                panel_employee_view.BackColor = Color.Cyan;
                panel_remove.BackColor = Color.Cyan;
                panel_logout_second.BackColor = Color.Cyan;
                panel_add_employee.BackColor = Color.Cyan;
                panelfinger_print.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                manageEmployee_pb.Image = Properties.Resources.Blue6;
                panel_employee_view.BackColor = Color.Blue;
                panel_remove.BackColor = Color.Blue;
                panel_logout_second.BackColor = Color.Blue;
                panel_add_employee.BackColor = Color.Blue;
                panelfinger_print.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                manageEmployee_pb.Image = Properties.Resources.Megenta6;
                panel_employee_view.BackColor = Color.Magenta;
                panel_remove.BackColor = Color.Magenta;
                panel_logout_second.BackColor = Color.Magenta;
                panel_add_employee.BackColor = Color.Magenta;
                panelfinger_print.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            lbl_manage_emp.Parent = manageEmployee_pb;
            lbl_manage_emp.BackColor = Color.Transparent;


            btn_exit.Parent = manageEmployee_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = manageEmployee_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            panel_employee_view.Hide();
            rad_showAll.Checked = true;

            panel_logout.Hide();
            panel_logout_second.Hide();
            panel_remove.Hide();
            panel_employee_view.Hide();
            panelfinger_print.Hide();
            panel_add_employee.Show();

            txt_age.Enabled = false;

            ArduinoUno2.PortName = "COM4";
            ArduinoUno.PortName = "COM3";

            ArduinoUno.Close();
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

        private void btn_serch_Click(object sender, EventArgs e)
        {
            try
            {
                if (rad_EID.Checked == true)
                {
                    if (String.IsNullOrEmpty(txt_seach_EID.Text))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_seach_EID.Focus();
                        }
                    }
                    else
                    {
                        ManageEmployee mE1 = new ManageEmployee();
                        DataTable dt = mE1.ViewEmployee("Select Emp_ID,Emp_First_Name,Emp_Second_Name,Emp_Address,Emp_DOB,Age,Emp_TP,Emp_Position,FingerPrint_ID From  Employee  Where Emp_ID = '" + txt_seach_EID.Text + "'");
                        employee_grid.DataSource = dt;
                    }
                }
                else if (rad_name.Checked == true)
                {
                    if (String.IsNullOrEmpty(txt_search_name.Text))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee Name cannot be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_name.Focus();
                        }
                    }
                    else if (txt_search_name.Text.Any(char.IsDigit))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee Name cannot have Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_name.Focus();
                        }
                    }
                    else if (txt_search_name.Text.Any(char.IsWhiteSpace))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee Name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_name.Focus();
                        }
                    }
                    else
                    {
                        ManageEmployee mE1 = new ManageEmployee();
                        DataTable dt = mE1.ViewEmployee("Select Emp_ID,Emp_First_Name,Emp_Second_Name,Emp_Address,Emp_DOB,Age,Emp_TP,Emp_Position,FingerPrint_ID From Employee Where Emp_First_Name = '" + txt_search_name.Text + "' OR Emp_Second_Name = '" + txt_search_name.Text + "' ");
                        employee_grid.DataSource = dt;
                    }

                }
                else
                {
                    ManageEmployee mE1 = new ManageEmployee();
                    DataTable dt = mE1.ViewEmployee("Select Emp_ID,Emp_First_Name,Emp_Second_Name,Emp_Address,Emp_DOB,Age,Emp_TP,Emp_Position,FingerPrint_ID From Employee ");
                    employee_grid.DataSource = dt;
                }


            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_seach_EID.Clear();
                    txt_seach_EID.Clear();
                }
            }
        }

        private void rad_EID_CheckedChanged(object sender, EventArgs e)
        {
            txt_seach_EID.Enabled = true;
            txt_search_name.Clear();
            txt_search_name.Enabled = false;
        }

        private void rad_name_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_name.Enabled = true;
            txt_seach_EID.Enabled = false;
            txt_seach_EID.Clear();

        }

        private void rad_showAll_CheckedChanged(object sender, EventArgs e)
        {
            txt_seach_EID.Clear();
            txt_search_name.Clear();
            txt_search_name.Enabled = false;
            txt_seach_EID.Enabled = false;
        }

        private void btn_view_employee_Click(object sender, EventArgs e)
        {
            panel_employee_view.Show();
            panel_remove.Hide();
            panel_add_employee.Hide();
        }

        private void btn_emp_delete_clear_Click(object sender, EventArgs e)
        {
            txt_remove_employee.Clear();
        }

        public string fid;

        private void btn_emp_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_remove_employee.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_remove_employee.Focus();
                    }
                }
                else if (txt_remove_employee.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot have spaces", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_remove_employee.Focus();
                    }

                }
                else
                {
                    ManageEmployee mE2 = new ManageEmployee();
                    DataTable dt = mE2.ViewEmployee("Select * from Employee Where Emp_ID = '" + txt_remove_employee.Text + "'");

                    if (dt.Rows.Count == 1)
                    {
                        fid = dt.Rows[0]["FingerPrint_ID"].ToString();

                        if(!ArduinoUno.IsOpen)
                        {
                             ArduinoUno.Open();
                        }
                        ArduinoUno.WriteLine(fid);
                        
                    }
                    else
                    {

                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "No Employee Found or invalid Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_remove_employee.Focus();
                        }

                    }
                }
            }
            catch (Exception)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this,"Arduino not connected. Please check arduino port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    ArduinoUno.Close();
                    txt_remove_employee.Clear();
                    txt_remove_employee.Focus();
                }
            }
        }
        private void btn_delete_employee_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoUno2.PortName = "COM3";
                ArduinoUno.PortName = "COM4";
                panel_remove.Show();
                panel_employee_view.Hide();
                panel_add_employee.Hide();

                if (Properties.Settings.Default.ArduinoCode != "Delete")
                {
                    if (Properties.Settings.Default.ArduinoState == "Online")
                    {
                        panel_logout.Show();
                        panel_logout_second.Show();
                        lbl_logout_second.Text = " Arduino code uploading....";

                        arduinoUploadClass auc = new arduinoUploadClass();
                        auc.deletecode();

                        Properties.Settings.Default.ArduinoCode = "Delete";
                        Properties.Settings.Default.Save();

                        panel_logout.Hide();
                        panel_logout_second.Hide();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "ArduinoUno not connected.you cannot remove employee","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
            }
            catch { }

        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            panel_remove.Hide();
            panel_employee_view.Hide();
            panel_add_employee.Show();

            ArduinoUno2.PortName = "COM4";
            ArduinoUno.PortName = "COM3";
        }

        private void ArduinoUno_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                string checkArduino = Convert.ToString(ArduinoUno.ReadLine());


                if (Convert.ToInt32(checkArduino) == 0)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot Romove Employee. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        txt_remove_employee.Clear();
                        txt_remove_employee.Focus();
                        ArduinoUno.Close();

                    }

                }
                else
                {
                    ManageEmployee mE3 = new ManageEmployee();
                    int i = mE3.DeleteEmployee("Delete from Employee where Emp_ID = '" + txt_remove_employee.Text + "' ");

                    if (i == 1)
                    {
                        DialogResult drrr = MetroFramework.MetroMessageBox.Show(this, "Employee remove successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (drrr == DialogResult.OK)
                        {
                            PcName = Environment.MachineName;
                            Operation = "Delete";
                            tableName = "Employee";


                            databaseclass db1 = new databaseclass();
                            db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");

                            txt_remove_employee.Clear();
                            ArduinoUno.Close();
                        }

                    }
                    else
                    {
                        DialogResult drr = MetroFramework.MetroMessageBox.Show(this, "Cannot Romove Employee. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (drr == DialogResult.OK)
                        {
                            txt_remove_employee.Clear();
                            txt_remove_employee.Focus();
                            ArduinoUno.Close();
                        }
                    }

                }
            }
            catch(Exception)
            {
                ArduinoUno.Close();
            }
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fid.Clear();
            txt_emp_id.Clear();
            txt_firstName.Clear();
            txt_secondName.Clear();
            txt_address.Clear();
            dob_picker.Value = DateTime.Now;
            txt_age.Clear();
            txt_tel.Clear();
            txt_password.Clear();
            txt_username.Clear();
            cmb_poition.SelectedItem = null;

            
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_emp_id.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_emp_id.Focus();
                    }
                }
                else if(txt_emp_id.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot have", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_emp_id.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_firstName.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "First Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_firstName.Focus();
                    }
                }
                else if (txt_firstName.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "First Name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_firstName.Focus();
                    }
                }
                else if (txt_firstName.Text.Any(char.IsDigit))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "First Name cannot have numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_firstName.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_secondName.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Second Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_secondName.Focus();
                    }
                }
                else if (txt_secondName.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Second Name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_secondName.Focus();
                    }
                }
                else if (txt_secondName.Text.Any(char.IsDigit))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Second Name cannot have number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_secondName.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_address.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Address cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_address.Focus();
                    }
                }
                else if (!Regex.IsMatch(txt_address.Text, @"^[A-Za-z0-9'\.\-\s\,]"))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid symbols.please check address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_address.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_age.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please select Date of Birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        dob_picker.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_tel.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Telephone Number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tel.Focus();
                    }
                }
                else if (txt_tel.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Telephone Number cannot have letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tel.Focus();
                    }
                }
                else if (txt_tel.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Telephone Number cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tel.Focus();
                    }
                }
                else if (!Regex.IsMatch(txt_tel.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid TelePhone Number. please check TelePhone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tel.Focus();
                    }
                }
                else if (cmb_poition.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Employee position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_poition.Focus();
                    }
                }
                else if(string.IsNullOrEmpty(txt_fid.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Finger Print ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                       txt_fid.Focus();
                    }
                }
                else if(Convert.ToInt32(txt_fid.Text) < 0 || Convert.ToInt32(txt_fid.Text) > 127)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Enter 1-127 value.Check availble finger print Ids in View Employee ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_fid.Focus();
                    }
                }
                else if(String.IsNullOrEmpty(txt_username.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "User Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_username.Focus();
                    }
                }
                else if (txt_username.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "User name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_username.Focus();
                    }
                }
                else if (String.IsNullOrEmpty(txt_password.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Password cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_password.Focus();
                    }
                }
                else if (txt_password.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Password cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_password.Focus();
                    }
                }
                else
                {
                    if(Properties.Settings.Default.ArduinoState == "Online")
                    {
                        if (Properties.Settings.Default.ArduinoCode != "Enroll")
                        {
                            panel_logout.Show();
                            panel_logout_second.Show();
                            arduinoUploadClass auc = new arduinoUploadClass();
                            auc.enrollcode();
                            Properties.Settings.Default.ArduinoCode = "Enroll";
                            Properties.Settings.Default.Save();

                            panel_logout.Hide();
                            panel_logout_second.Hide();
                        }

                        panel_logout.Show();
                        panelfinger_print.Show();
                        btn_save.Enabled = false;
                        btn_Add.Enabled = false;
                        btn_clear.Enabled = false;
                        btn_add_employee.Enabled = false;
                        btn_view_employee.Enabled = false;
                        btn_emp_remove.Enabled = false;
                        btn_back.Enabled = false;
                        btn_emp_remove.Enabled = false;
                        txt_seral_moniter.Text = "Press ADD FINGER PRINT";
                        ArduinoUno.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "ArduinoUno is not connected.you cannot add employee.becasuse employee finger print cannot add if arduinoUno offline", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    }
                }

            }
            catch (FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_emp_id.Clear();
                    txt_fid.Clear();
                    txt_firstName.Clear();
                    txt_secondName.Clear();
                    txt_address.Clear();
                    dob_picker.Value = DateTime.Now;
                    txt_age.Clear();
                    txt_tel.Clear();
                    txt_password.Clear();
                    txt_username.Clear();
                    cmb_poition.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_emp_id.Clear();
                    txt_fid.Clear();
                    txt_firstName.Clear();
                    txt_secondName.Clear();
                    txt_address.Clear();
                    dob_picker.Value = DateTime.Now;
                    txt_age.Clear();
                    txt_tel.Clear();
                    txt_password.Clear();
                    txt_username.Clear();
                    cmb_poition.SelectedItem = null;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into Employee Values('" + txt_emp_id.Text + "','" + txt_firstName.Text + "','" + txt_secondName.Text + "','" + txt_address.Text + "','" + dob_picker.Value + "','" + txt_age.Text + "','" + txt_tel.Text + "','" + cmb_poition.Text + "','" + txt_fid.Text + "','" + txt_username.Text + "', '" + txt_password.Text + "')";
                ManageEmployee mE3 = new ManageEmployee();
                int i = mE3.AddEmployee(query);

                if (i == 1)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee Enroll  successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        PcName = Environment.MachineName;
                        Operation = "Insert";
                        tableName = "Employee";


                        databaseclass db1 = new databaseclass();
                        db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");



                        txt_emp_id.Clear();
                        txt_fid.Clear();
                        txt_firstName.Clear();
                        txt_secondName.Clear();
                        txt_address.Clear();
                        dob_picker.Value = DateTime.Now;
                        txt_age.Clear();
                        txt_tel.Clear();
                        txt_password.Clear();
                        txt_username.Clear();
                        cmb_poition.SelectedItem = null;

                        panel_logout.Hide();
                        panelfinger_print.Hide();
                        ArduinoUno2.Close();

                        btn_Add.Enabled = true;
                        btn_clear.Enabled = true;
                        btn_add_employee.Enabled = true;
                        btn_view_employee.Enabled = true;
                        btn_emp_remove.Enabled = true;
                        btn_back.Enabled = true;
                        btn_add_finger_print.Enabled = true;
                        btn_emp_remove.Enabled = true;

                    }

                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot update your details.please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_emp_id.Clear();
                        txt_firstName.Clear();
                        txt_secondName.Clear();
                        txt_address.Clear();
                        dob_picker.Value = DateTime.Now;
                        txt_age.Clear();
                        txt_tel.Clear();
                        txt_password.Clear();
                        txt_username.Clear();
                        cmb_poition.SelectedItem = null;
                        txt_fid.Clear();

                        panel_logout.Hide();
                        panelfinger_print.Hide();
                        ArduinoUno2.Close();

                        btn_Add.Enabled = true;
                        btn_clear.Enabled = true;
                        btn_add_employee.Enabled = true;
                        btn_view_employee.Enabled = true;
                        btn_emp_remove.Enabled = true;
                        btn_back.Enabled = true;
                        btn_add_finger_print.Enabled = true;
                        btn_emp_remove.Enabled = true;
                    }
                }
            }
            catch(Exception)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot update your details.please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    txt_emp_id.Clear();
                    txt_firstName.Clear();
                    txt_secondName.Clear();
                    txt_address.Clear();
                    dob_picker.Value = DateTime.Now;
                    txt_age.Clear();
                    txt_tel.Clear();
                    txt_password.Clear();
                    txt_username.Clear();
                    cmb_poition.SelectedItem = null;
                    txt_fid.Clear();

                    panel_logout.Hide();
                    panelfinger_print.Hide();
                    ArduinoUno2.Close();
                }
            }
           
        }

        private void btn_add_finger_print_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoUno2.PortName = "COM4";
                txt_seral_moniter.Text = " Place finger when the beep start";

                if(!ArduinoUno2.IsOpen)
                {
                    ArduinoUno2.Open();
                }
  
                ArduinoUno2.Write(txt_fid.Text);


                int c = 1;
                String data;
                while (c <= 5)
                {
                    data = Convert.ToString(ArduinoUno2.ReadLine());

                    if (Convert.ToInt32(data) == 0)
                    {
                        DialogResult dr = MessageBox.Show("finger print not match or Cant enroll finger print to the system !!! .Please Try again", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dr == DialogResult.OK)
                        {
                            txt_seral_moniter.Clear();
                            btn_add_finger_print.Focus();
                            btn_save.Enabled = false;
                            break;

                        }

                       
                    }
                    else if(c == 1)
                    {
                        txt_seral_moniter.Text = "Image taken ";
                    }
                    else if(c == 2)
                    {
                        txt_seral_moniter.Text = "Remove finger and Place same finger again when the beep start";
                    }
                    else if(c == 3)
                    {
                        txt_seral_moniter.Text = "Image taken ";
                    }
                    else if(c == 4)
                    {
                        txt_seral_moniter.Text = "Image converted";
                    }
                    else if(c == 5)
                    {
                        txt_seral_moniter.Text = "Store complete.Click SAVE  ";
                        btn_save.Enabled = true;
                        btn_add_finger_print.Enabled = false;

                    }
 
                    c++;
                }
                ArduinoUno2.Close();

            }
            catch(Exception)
            {
                DialogResult dr = MessageBox.Show("Arduino not connected.Please Check Arduino Port", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {

                    btn_save.Enabled = true;
                    btn_Add.Enabled = true;
                    btn_clear.Enabled = true;
                    btn_add_employee.Enabled = true;
                    btn_view_employee.Enabled = true;
                    btn_emp_remove.Enabled = true;
                    btn_back.Enabled = true;
                    btn_emp_remove.Enabled = true;

                }

          
            }

        }

        private void dob_picker_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dob_picker.Value.Year).ToString();
        }
    }
}
