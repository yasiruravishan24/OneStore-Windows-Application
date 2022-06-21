using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GADYasiru;
using System.Text.RegularExpressions;

namespace oneStore
{
    public partial class SellerProfile_settings : Form
    {
        public SellerProfile_settings()
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

        private void SellerProfile_settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                settings_pb.Image = Properties.Resources.Red6;
                panel_changeDetails.BackColor = Color.Red;
                panel_privacy.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                settings_pb.Image = Properties.Resources.Yellow6;
                panel_changeDetails.BackColor = Color.FromArgb(255, 235, 20);
                panel_privacy.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;

            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                settings_pb.Image = Properties.Resources.Green6;
                panel_changeDetails.BackColor = Color.FromArgb(32, 236, 44);
                panel_privacy.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                settings_pb.Image = Properties.Resources.Cyan6;
                panel_changeDetails.BackColor = Color.Cyan;
                panel_privacy.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                settings_pb.Image = Properties.Resources.Blue6;
                panel_changeDetails.BackColor = Color.Blue;
                panel_privacy.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                settings_pb.Image = Properties.Resources.Megenta6;
                panel_changeDetails.BackColor = Color.Magenta;
                panel_privacy.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            lbl_settings.Parent = settings_pb;
            lbl_settings.BackColor = Color.Transparent;


            btn_exit.Parent = settings_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = settings_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            panel_changeDetails.Show();
            panel_privacy.Hide();

            txt_age.Enabled = false;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            SellerHome sh = new SellerHome();
            sh.Show();
            this.Hide();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_updatepassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_newPassword.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "New Password cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_newPassword.Focus();
                    }
                }
                else if (txt_newPassword.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "New Password cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_newPassword.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_confirmPassWord.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Confrm Password cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_confirmPassWord.Focus();
                    }
                }
                else if (txt_confirmPassWord.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Confrm Password cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_confirmPassWord.Focus();
                    }
                }
                else if (txt_newPassword.Text.Length < 5)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "The Password field must be at least 5 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_newPassword.Focus();
                    }
                }
                else if (txt_newPassword.Text != txt_confirmPassWord.Text)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "The Confirm Password confirmation dose not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_confirmPassWord.Clear();
                        txt_confirmPassWord.Focus();
                    }
                }
                else
                {
                    UpdateEmployee up = new UpdateEmployee();
                    int i = up.updatePrivacy("Update Employee set Emp_Password = '" + txt_confirmPassWord.Text + "' where Emp_ID = '" + EmpId + "' ");

                    if (i == 1)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Your Password has been changed successfully.Click 'Ok' to login again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            PcName = Environment.MachineName;
                            Operation = "Update";
                            tableName = "Employee";


                            databaseclass db1 = new databaseclass();
                            db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");

                            Login l1 = new Login();
                            l1.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot change password.please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_newPassword.Clear();
                            txt_confirmPassWord.Clear();
                            txt_newPassword.Focus();
                        }
                    }

                }
            }
            catch (FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_newPassword.Clear();
                    txt_confirmPassWord.Clear();
                    txt_newPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_newPassword.Clear();
                    txt_confirmPassWord.Clear();
                    txt_newPassword.Focus();
                }
            }
        }

        private void btn_clearpassword_Click(object sender, EventArgs e)
        {
            txt_newPassword.Clear();
            txt_confirmPassWord.Clear();
        }

        private void btn_updateData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_firstName.Text))
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
                else if (string.IsNullOrEmpty(txt_tele.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Telephone Number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Focus();
                    }
                }
                else if (txt_tele.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Telephone Number cannot have letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Focus();
                    }
                }
                else if (txt_tele.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Telephone Number cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Focus();
                    }
                }
                else if (!Regex.IsMatch(txt_tele.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid TelePhone Number. please check TelePhone Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Focus();
                    }
                }
                else
                {

                    string query = "update Employee set Emp_First_Name = '" + txt_firstName.Text + "',Emp_Second_Name = '" + txt_secondName.Text + "',Emp_Address = '" + txt_address.Text + "',Emp_DOB = '" + dob_picker.Value + "',Age = '" + txt_age.Text + "',Emp_TP = '" + txt_tele.Text + "'  where Emp_ID = '" + EmpId + "'  ";
                    UpdateEmployee up = new UpdateEmployee();
                    int i = up.updateDetails(query);

                    if (i == 1)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Your details has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            PcName = Environment.MachineName;
                            Operation = "Update";
                            tableName = "Employee";


                            databaseclass db1 = new databaseclass();
                            db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");

                            txt_firstName.Clear();
                            txt_secondName.Clear();
                            txt_address.Clear();
                            dob_picker.Value = DateTime.Now;
                            txt_age.Clear();
                            txt_tele.Clear();
                        }

                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot update your details.please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_firstName.Clear();
                            txt_secondName.Clear();
                            txt_address.Clear();
                            dob_picker.Value = DateTime.Now;
                            txt_age.Clear();
                            txt_tele.Clear();
                        }
                    }
                }

            }
            catch (FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_firstName.Clear();
                    txt_secondName.Clear();
                    txt_address.Clear();
                    dob_picker.Value = DateTime.Now;
                    txt_age.Clear();
                    txt_tele.Clear();
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_firstName.Clear();
                    txt_secondName.Clear();
                    txt_address.Clear();
                    dob_picker.Value = DateTime.Now;
                    txt_age.Clear();
                    txt_tele.Clear();
                }
            }
        }

        private void btn_ClearData_Click(object sender, EventArgs e)
        {
            txt_firstName.Clear();
            txt_secondName.Clear();
            txt_address.Clear();
            dob_picker.Value = DateTime.Now;
            txt_age.Clear();
            txt_tele.Clear();

        }

        private void btn_changeUserSettings_Click(object sender, EventArgs e)
        {
            
                panel_changeDetails.Show();
                panel_privacy.Hide();
            
        }
        private void btn_privacy_Click(object sender, EventArgs e)
        {
            panel_changeDetails.Hide();
            panel_privacy.Show();
        }

        private void dob_picker_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dob_picker.Value.Year).ToString();
        }
    }
}
