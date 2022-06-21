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
using System.Data.SqlClient;


namespace oneStore
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                username_pb.Image = Properties.Resources.Red3;
                finger_correct_pb.Image = Properties.Resources.Red2;
                passLogin_pb.Image = Properties.Resources.Red2;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                username_pb.Image = Properties.Resources.Yellow3;
                finger_correct_pb.Image = Properties.Resources.Yellow2;
                passLogin_pb.Image = Properties.Resources.Yellow2;
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                username_pb.Image = Properties.Resources.Green3;
                finger_correct_pb.Image = Properties.Resources.Green2;
                passLogin_pb.Image = Properties.Resources.Green2;
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                username_pb.Image = Properties.Resources.Cyan3;
                finger_correct_pb.Image = Properties.Resources.Cyan2;
                passLogin_pb.Image = Properties.Resources.Cyan2;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                username_pb.Image = Properties.Resources.Blue3;
                finger_correct_pb.Image = Properties.Resources.Blue2;
                passLogin_pb.Image = Properties.Resources.Blue2;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                username_pb.Image = Properties.Resources.Magenta3;
                finger_correct_pb.Image = Properties.Resources.Magenta2;
                passLogin_pb.Image = Properties.Resources.Magenta2;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            btn_loginUswername.Focus();
            finger_pb.Parent = passLogin_pb;
            finger_pb.BackColor = Color.Transparent;

            lbl_login.Parent = finger_pb;
            lbl_login.BackColor = Color.Transparent;

            userName_p.Hide();
            btn_loginUswername.Focus();

            finger_pb.Image = Properties.Resources.fingerprint1;

            finger_correct_panel.Hide();

            
            sql_con = new SqlConnection(Properties.Settings.Default.connectionString);


            try
            {
                if(!ArduinoUno.IsOpen)
                {
                    ArduinoUno.Open();
                }

                
            }
            catch { }            
        }

        private void btn_loginUswername_Click(object sender, EventArgs e)
        {
            userName_p.Show();
            lbl_username.Parent = username_pb;
            lbl_username.BackColor = Color.Transparent;

            lbl_password.Parent = username_pb;
            lbl_password.BackColor = Color.Transparent;

            lbl_oneStore.Parent = username_pb;
            lbl_oneStore.BackColor = Color.Transparent;
            btn_Login.Focus();

            ArduinoUno.Close();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            ArduinoUno.Close();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            userName_p.Hide();
            finger_correct_panel.Hide();

            try
            {
                if (!ArduinoUno.IsOpen)
                {
                    ArduinoUno.Open();
                }
            }
            catch (Exception) { }

        }
        SqlConnection sql_con;
        SqlDataAdapter sql_ada;
        public string UFName;
        public string USName;
        public string UPosition;
        public string Emp_id;
        public string PcName;
        public string Operation;
        



        private void fingerprint(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                int rowCount;
               
                int Id = Convert.ToInt32(ArduinoUno.ReadLine());

                DataTable Dt = new DataTable();

                if (Id == 0)
                {
                    finger_pb.Image = Properties.Resources.wrong;
                    ArduinoUno.Close();
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid Fingerprint ! Try Again","Warning" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                    if (dr == DialogResult.OK)
                    {
                        ArduinoUno.Open();
                        finger_pb.Image = Properties.Resources.fingerprint1;
                        
                    }
                }
                else
                {
                    
                    
                   
                    sql_con.Open();
                    string Quary = "Select * From Employee Where FingerPrint_ID = '" +Id+ "'";

                    sql_ada = new SqlDataAdapter(Quary, sql_con);
                    sql_ada.Fill(Dt);
                    rowCount = Dt.Rows.Count;

                    if(rowCount == 1)
                    {
                        UFName = Dt.Rows[0]["Emp_First_Name"].ToString();
                        UPosition = Dt.Rows[0]["Emp_Position"].ToString();
                        Emp_id = Dt.Rows[0]["Emp_ID"].ToString();
                        USName = Dt.Rows[0]["Emp_Second_Name"].ToString();
                        PcName = PcName = System.Environment.MachineName;
                        Operation = "Login";


                        finger_correct_animation.Parent = finger_correct_pb;
                        finger_correct_animation.BackColor = Color.Transparent;

                        lbl_finger_Correct.Parent = finger_correct_animation;
                        lbl_finger_Correct.BackColor = Color.Transparent;

                        lbl_position.Parent = finger_correct_animation;
                        lbl_position.BackColor = Color.Transparent;

                        finger_correct_panel.Show();
                        btn_finger_loging.Focus();
                        finger_correct_animation.Image = Properties.Resources.corret1;

                        lbl_position.Text = UPosition;
                        lbl_finger_Correct.Text = "Welcome " + UFName.ToString();
                        btn_finger_loging.Focus();

                        sql_con.Close();
                        ArduinoUno.Close();


                    }
                    
                }  
            }
            catch(SqlException ex)
            {
                ArduinoUno.Close();
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    ArduinoUno.Open();
                }
            }
            catch (Exception ex)
            {
                ArduinoUno.Close();
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    ArduinoUno.Open();
                }
            }
        }
        private void btn_finger_loging_Click(object sender, EventArgs e)
        {
            databaseclass dt1 = new databaseclass();
            string query = "insert into Employee_records(Emp_ID, Emp_First_Name, Emp_Second_Name, Pc_Name, Operation)values('" + Emp_id + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "')";

            dt1.login_logout_record(query);

            if (UPosition == "Admin")
            {
                ArduinoUno.Close();
                AdminHome aHome = new AdminHome();
                aHome.SetData(Emp_id,UFName,USName);
                aHome.Show();
                this.Hide();
            }
            else
            {
                ArduinoUno.Close();
                SellerHome sHome = new SellerHome();
                sHome.SetData(Emp_id,UFName,USName);
                sHome.Show();
                this.Hide();            
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_userName.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "User Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_userName.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_password.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Password cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_password.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_userName.Text) && string.IsNullOrEmpty(txt_password.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "All fields should be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_userName.Focus();
                    }
                }
                else
                {
                    sql_con.Open();
                    string Query = "Select * from Employee where Emp_UserName = '" + txt_userName.Text + "' And Emp_Password = '" + txt_password.Text + "' ";
                    DataTable dtt = new DataTable();
                    sql_ada = new SqlDataAdapter(Query, sql_con);
                    sql_ada.Fill(dtt);
                    if (dtt.Rows.Count == 1)
                    {
                        Emp_id = dtt.Rows[0]["Emp_ID"].ToString();
                        UPosition = dtt.Rows[0]["Emp_Position"].ToString();
                        UFName = dtt.Rows[0]["Emp_First_Name"].ToString();
                        USName = dtt.Rows[0]["Emp_Second_Name"].ToString();
                        PcName = PcName = System.Environment.MachineName;
                        Operation = "Login";
                        databaseclass dt1 = new databaseclass();
                        string query = "insert into Employee_records(Emp_ID, Emp_First_Name, Emp_Second_Name, Pc_Name, Operation)values('"+Emp_id+"','"+UFName+"','"+USName+"','"+PcName+"','"+Operation+"')";

                        dt1.login_logout_record(query);

                        if (UPosition == "Admin")
                        {
                            ArduinoUno.Close();
                            AdminHome aHome = new AdminHome();
                            aHome.SetData(Emp_id,UFName,USName);
                            aHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            ArduinoUno.Close();
                            SellerHome sHome = new SellerHome();
                            sHome.SetData(Emp_id,UFName,USName);
                            sHome.Show();
                            this.Hide();
                        }


                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid username or password, Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_userName.Clear();
                            txt_password.Clear();

                            txt_userName.Focus();
                        }
                    }

                    sql_con.Close();
                }
            }
            catch(SqlException ex)
            {
                 MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                btn_Login.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                txt_userName.Focus();
            }
        }
    }
}
