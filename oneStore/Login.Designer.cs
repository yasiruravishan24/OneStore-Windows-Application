
namespace oneStore
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_loginUswername = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.lbl_login = new System.Windows.Forms.Label();
            this.ArduinoUno = new System.IO.Ports.SerialPort(this.components);
            this.passLogin_pb = new System.Windows.Forms.PictureBox();
            this.finger_pb = new System.Windows.Forms.PictureBox();
            this.userName_p = new System.Windows.Forms.Panel();
            this.lbl_oneStore = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.txt_userName = new MetroFramework.Controls.MetroTextBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.username_pb = new System.Windows.Forms.PictureBox();
            this.finger_correct_panel = new System.Windows.Forms.Panel();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_finger_Correct = new System.Windows.Forms.Label();
            this.btn_finger_loging = new MetroFramework.Controls.MetroButton();
            this.finger_correct_pb = new System.Windows.Forms.PictureBox();
            this.finger_correct_animation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passLogin_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finger_pb)).BeginInit();
            this.userName_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_pb)).BeginInit();
            this.finger_correct_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finger_correct_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finger_correct_animation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loginUswername
            // 
            this.btn_loginUswername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_loginUswername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_loginUswername.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_loginUswername.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_loginUswername.Location = new System.Drawing.Point(60, 298);
            this.btn_loginUswername.Name = "btn_loginUswername";
            this.btn_loginUswername.Size = new System.Drawing.Size(245, 49);
            this.btn_loginUswername.TabIndex = 2;
            this.btn_loginUswername.Text = "Login with Username";
            this.btn_loginUswername.UseSelectable = true;
            this.btn_loginUswername.Click += new System.EventHandler(this.btn_loginUswername_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_exit.Location = new System.Drawing.Point(90, 376);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(183, 49);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(106, 244);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(151, 22);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Place Your Finger";
            // 
            // ArduinoUno
            // 
            this.ArduinoUno.PortName = "COM4";
            this.ArduinoUno.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.fingerprint);
            // 
            // passLogin_pb
            // 
            this.passLogin_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passLogin_pb.Image = global::oneStore.Properties.Resources.login1;
            this.passLogin_pb.Location = new System.Drawing.Point(0, 0);
            this.passLogin_pb.Name = "passLogin_pb";
            this.passLogin_pb.Size = new System.Drawing.Size(358, 559);
            this.passLogin_pb.TabIndex = 0;
            this.passLogin_pb.TabStop = false;
            // 
            // finger_pb
            // 
            this.finger_pb.BackColor = System.Drawing.Color.Transparent;
            this.finger_pb.Image = global::oneStore.Properties.Resources.fingerprint1;
            this.finger_pb.Location = new System.Drawing.Point(1, -69);
            this.finger_pb.Name = "finger_pb";
            this.finger_pb.Size = new System.Drawing.Size(350, 392);
            this.finger_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finger_pb.TabIndex = 1;
            this.finger_pb.TabStop = false;
            // 
            // userName_p
            // 
            this.userName_p.Controls.Add(this.lbl_oneStore);
            this.userName_p.Controls.Add(this.lbl_password);
            this.userName_p.Controls.Add(this.lbl_username);
            this.userName_p.Controls.Add(this.btn_back);
            this.userName_p.Controls.Add(this.btn_Login);
            this.userName_p.Controls.Add(this.txt_userName);
            this.userName_p.Controls.Add(this.txt_password);
            this.userName_p.Controls.Add(this.username_pb);
            this.userName_p.Location = new System.Drawing.Point(1, 1);
            this.userName_p.Name = "userName_p";
            this.userName_p.Size = new System.Drawing.Size(358, 558);
            this.userName_p.TabIndex = 4;
            // 
            // lbl_oneStore
            // 
            this.lbl_oneStore.AutoSize = true;
            this.lbl_oneStore.Font = new System.Drawing.Font("TOP GUN", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oneStore.Location = new System.Drawing.Point(21, 33);
            this.lbl_oneStore.Name = "lbl_oneStore";
            this.lbl_oneStore.Size = new System.Drawing.Size(317, 58);
            this.lbl_oneStore.TabIndex = 5;
            this.lbl_oneStore.Text = "Login to One Store";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(13, 197);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(86, 20);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(13, 137);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(91, 20);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(194, 278);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(111, 40);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(60, 278);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(111, 40);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseSelectable = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_userName
            // 
            // 
            // 
            // 
            this.txt_userName.CustomButton.Image = null;
            this.txt_userName.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txt_userName.CustomButton.Name = "";
            this.txt_userName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_userName.CustomButton.TabIndex = 1;
            this.txt_userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_userName.CustomButton.UseSelectable = true;
            this.txt_userName.CustomButton.Visible = false;
            this.txt_userName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_userName.Lines = new string[0];
            this.txt_userName.Location = new System.Drawing.Point(110, 131);
            this.txt_userName.MaxLength = 32767;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.PasswordChar = '\0';
            this.txt_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userName.SelectedText = "";
            this.txt_userName.SelectionLength = 0;
            this.txt_userName.SelectionStart = 0;
            this.txt_userName.ShortcutsEnabled = true;
            this.txt_userName.Size = new System.Drawing.Size(226, 35);
            this.txt_userName.TabIndex = 1;
            this.txt_userName.UseSelectable = true;
            this.txt_userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_userName_KeyDown);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(110, 189);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(226, 35);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            this.txt_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyUp);
            // 
            // username_pb
            // 
            this.username_pb.Image = global::oneStore.Properties.Resources.login2;
            this.username_pb.Location = new System.Drawing.Point(0, 0);
            this.username_pb.Name = "username_pb";
            this.username_pb.Size = new System.Drawing.Size(358, 559);
            this.username_pb.TabIndex = 6;
            this.username_pb.TabStop = false;
            // 
            // finger_correct_panel
            // 
            this.finger_correct_panel.Controls.Add(this.lbl_position);
            this.finger_correct_panel.Controls.Add(this.lbl_finger_Correct);
            this.finger_correct_panel.Controls.Add(this.btn_finger_loging);
            this.finger_correct_panel.Controls.Add(this.finger_correct_pb);
            this.finger_correct_panel.Location = new System.Drawing.Point(0, 0);
            this.finger_correct_panel.Name = "finger_correct_panel";
            this.finger_correct_panel.Size = new System.Drawing.Size(358, 559);
            this.finger_correct_panel.TabIndex = 5;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.Location = new System.Drawing.Point(148, 246);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(0, 20);
            this.lbl_position.TabIndex = 7;
            // 
            // lbl_finger_Correct
            // 
            this.lbl_finger_Correct.AutoSize = true;
            this.lbl_finger_Correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finger_Correct.Location = new System.Drawing.Point(71, 277);
            this.lbl_finger_Correct.Name = "lbl_finger_Correct";
            this.lbl_finger_Correct.Size = new System.Drawing.Size(0, 29);
            this.lbl_finger_Correct.TabIndex = 7;
            // 
            // btn_finger_loging
            // 
            this.btn_finger_loging.Location = new System.Drawing.Point(58, 309);
            this.btn_finger_loging.Name = "btn_finger_loging";
            this.btn_finger_loging.Size = new System.Drawing.Size(246, 63);
            this.btn_finger_loging.TabIndex = 6;
            this.btn_finger_loging.Text = "Login";
            this.btn_finger_loging.UseSelectable = true;
            this.btn_finger_loging.Click += new System.EventHandler(this.btn_finger_loging_Click);
            // 
            // finger_correct_pb
            // 
            this.finger_correct_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finger_correct_pb.Image = global::oneStore.Properties.Resources.login1;
            this.finger_correct_pb.Location = new System.Drawing.Point(0, 0);
            this.finger_correct_pb.Name = "finger_correct_pb";
            this.finger_correct_pb.Size = new System.Drawing.Size(358, 559);
            this.finger_correct_pb.TabIndex = 5;
            this.finger_correct_pb.TabStop = false;
            // 
            // finger_correct_animation
            // 
            this.finger_correct_animation.BackColor = System.Drawing.Color.Transparent;
            this.finger_correct_animation.Image = global::oneStore.Properties.Resources.fingerprint1;
            this.finger_correct_animation.Location = new System.Drawing.Point(1, -69);
            this.finger_correct_animation.Name = "finger_correct_animation";
            this.finger_correct_animation.Size = new System.Drawing.Size(350, 392);
            this.finger_correct_animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finger_correct_animation.TabIndex = 6;
            this.finger_correct_animation.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 559);
            this.Controls.Add(this.finger_correct_panel);
            this.Controls.Add(this.userName_p);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_loginUswername);
            this.Controls.Add(this.passLogin_pb);
            this.Controls.Add(this.finger_pb);
            this.Controls.Add(this.finger_correct_animation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passLogin_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finger_pb)).EndInit();
            this.userName_p.ResumeLayout(false);
            this.userName_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.username_pb)).EndInit();
            this.finger_correct_panel.ResumeLayout(false);
            this.finger_correct_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finger_correct_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finger_correct_animation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox passLogin_pb;
        private System.Windows.Forms.PictureBox finger_pb;
        private MetroFramework.Controls.MetroButton btn_loginUswername;
        private MetroFramework.Controls.MetroButton btn_exit;
        private System.Windows.Forms.Label lbl_login;
        private System.IO.Ports.SerialPort ArduinoUno;
        private System.Windows.Forms.Panel userName_p;
        private System.Windows.Forms.Label lbl_oneStore;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_Login;
        private MetroFramework.Controls.MetroTextBox txt_userName;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private System.Windows.Forms.PictureBox username_pb;
        private System.Windows.Forms.Panel finger_correct_panel;
        private System.Windows.Forms.PictureBox finger_correct_pb;
        private System.Windows.Forms.Label lbl_finger_Correct;
        private MetroFramework.Controls.MetroButton btn_finger_loging;
        private System.Windows.Forms.PictureBox finger_correct_animation;
        private System.Windows.Forms.Label lbl_position;
    }
}