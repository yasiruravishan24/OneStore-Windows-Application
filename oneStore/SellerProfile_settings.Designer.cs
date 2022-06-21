
namespace oneStore
{
    partial class SellerProfile_settings
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
            this.settings_pb = new System.Windows.Forms.PictureBox();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.btn_changeUserSettings = new MetroFramework.Controls.MetroTile();
            this.btn_privacy = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_privacy = new System.Windows.Forms.Panel();
            this.panel_changeDetails = new System.Windows.Forms.Panel();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_ClearData = new MetroFramework.Controls.MetroTile();
            this.btn_updateData = new MetroFramework.Controls.MetroTile();
            this.txt_secondName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_tele = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_SecondName = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.btn_clearpassword = new MetroFramework.Controls.MetroTile();
            this.btn_updatepassword = new MetroFramework.Controls.MetroTile();
            this.txt_confirmPassWord = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.profile_setting_control = new JDragControl.JDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.settings_pb)).BeginInit();
            this.panel_privacy.SuspendLayout();
            this.panel_changeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_pb
            // 
            this.settings_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.settings_pb.Location = new System.Drawing.Point(0, 0);
            this.settings_pb.Name = "settings_pb";
            this.settings_pb.Size = new System.Drawing.Size(923, 552);
            this.settings_pb.TabIndex = 0;
            this.settings_pb.TabStop = false;
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.Location = new System.Drawing.Point(235, 14);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(247, 37);
            this.lbl_settings.TabIndex = 1;
            this.lbl_settings.Text = "Profile Settings";
            // 
            // btn_changeUserSettings
            // 
            this.btn_changeUserSettings.ActiveControl = null;
            this.btn_changeUserSettings.Location = new System.Drawing.Point(12, 72);
            this.btn_changeUserSettings.Name = "btn_changeUserSettings";
            this.btn_changeUserSettings.Size = new System.Drawing.Size(203, 50);
            this.btn_changeUserSettings.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_changeUserSettings.TabIndex = 2;
            this.btn_changeUserSettings.Text = "Change User Details";
            this.btn_changeUserSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_changeUserSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_changeUserSettings.UseSelectable = true;
            this.btn_changeUserSettings.Click += new System.EventHandler(this.btn_changeUserSettings_Click);
            // 
            // btn_privacy
            // 
            this.btn_privacy.ActiveControl = null;
            this.btn_privacy.Location = new System.Drawing.Point(12, 128);
            this.btn_privacy.Name = "btn_privacy";
            this.btn_privacy.Size = new System.Drawing.Size(203, 50);
            this.btn_privacy.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_privacy.TabIndex = 2;
            this.btn_privacy.Text = "Privacy ";
            this.btn_privacy.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_privacy.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_privacy.UseSelectable = true;
            this.btn_privacy.Click += new System.EventHandler(this.btn_privacy_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(26, 431);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(176, 50);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = global::oneStore.Properties.Resources.minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(847, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::oneStore.Properties.Resources.exit;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(883, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 32);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // panel_privacy
            // 
            this.panel_privacy.BackColor = System.Drawing.Color.Red;
            this.panel_privacy.Controls.Add(this.btn_clearpassword);
            this.panel_privacy.Controls.Add(this.btn_updatepassword);
            this.panel_privacy.Controls.Add(this.txt_confirmPassWord);
            this.panel_privacy.Controls.Add(this.txt_newPassword);
            this.panel_privacy.Controls.Add(this.lbl_confirm_password);
            this.panel_privacy.Controls.Add(this.lbl_newPassword);
            this.panel_privacy.Location = new System.Drawing.Point(235, 72);
            this.panel_privacy.Name = "panel_privacy";
            this.panel_privacy.Size = new System.Drawing.Size(680, 468);
            this.panel_privacy.TabIndex = 4;
            // 
            // panel_changeDetails
            // 
            this.panel_changeDetails.BackColor = System.Drawing.Color.Red;
            this.panel_changeDetails.Controls.Add(this.dob_picker);
            this.panel_changeDetails.Controls.Add(this.txt_tele);
            this.panel_changeDetails.Controls.Add(this.txt_age);
            this.panel_changeDetails.Controls.Add(this.txt_address);
            this.panel_changeDetails.Controls.Add(this.btn_ClearData);
            this.panel_changeDetails.Controls.Add(this.btn_updateData);
            this.panel_changeDetails.Controls.Add(this.txt_secondName);
            this.panel_changeDetails.Controls.Add(this.txt_firstName);
            this.panel_changeDetails.Controls.Add(this.lbl_tele);
            this.panel_changeDetails.Controls.Add(this.lbl_age);
            this.panel_changeDetails.Controls.Add(this.lbl_dob);
            this.panel_changeDetails.Controls.Add(this.lbl_address);
            this.panel_changeDetails.Controls.Add(this.lbl_SecondName);
            this.panel_changeDetails.Controls.Add(this.lbl_firstname);
            this.panel_changeDetails.Location = new System.Drawing.Point(235, 72);
            this.panel_changeDetails.Name = "panel_changeDetails";
            this.panel_changeDetails.Size = new System.Drawing.Size(680, 468);
            this.panel_changeDetails.TabIndex = 5;
            // 
            // dob_picker
            // 
            this.dob_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Location = new System.Drawing.Point(259, 212);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(406, 31);
            this.dob_picker.TabIndex = 2;
            this.dob_picker.ValueChanged += new System.EventHandler(this.dob_picker_ValueChanged);
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(259, 328);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(406, 31);
            this.txt_tele.TabIndex = 1;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(259, 270);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(406, 31);
            this.txt_age.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(259, 151);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(406, 31);
            this.txt_address.TabIndex = 1;
            // 
            // btn_ClearData
            // 
            this.btn_ClearData.ActiveControl = null;
            this.btn_ClearData.Location = new System.Drawing.Point(370, 394);
            this.btn_ClearData.Name = "btn_ClearData";
            this.btn_ClearData.Size = new System.Drawing.Size(176, 50);
            this.btn_ClearData.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_ClearData.TabIndex = 1;
            this.btn_ClearData.Text = "CLEAR";
            this.btn_ClearData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ClearData.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_ClearData.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_ClearData.UseSelectable = true;
            this.btn_ClearData.Click += new System.EventHandler(this.btn_ClearData_Click);
            // 
            // btn_updateData
            // 
            this.btn_updateData.ActiveControl = null;
            this.btn_updateData.Location = new System.Drawing.Point(142, 394);
            this.btn_updateData.Name = "btn_updateData";
            this.btn_updateData.Size = new System.Drawing.Size(176, 50);
            this.btn_updateData.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_updateData.TabIndex = 1;
            this.btn_updateData.Text = "UPDATE";
            this.btn_updateData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_updateData.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_updateData.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_updateData.UseSelectable = true;
            this.btn_updateData.Click += new System.EventHandler(this.btn_updateData_Click);
            // 
            // txt_secondName
            // 
            this.txt_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secondName.Location = new System.Drawing.Point(259, 92);
            this.txt_secondName.Name = "txt_secondName";
            this.txt_secondName.Size = new System.Drawing.Size(406, 31);
            this.txt_secondName.TabIndex = 1;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(259, 31);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(406, 31);
            this.txt_firstName.TabIndex = 1;
            // 
            // lbl_tele
            // 
            this.lbl_tele.AutoSize = true;
            this.lbl_tele.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tele.Location = new System.Drawing.Point(30, 329);
            this.lbl_tele.Name = "lbl_tele";
            this.lbl_tele.Size = new System.Drawing.Size(213, 25);
            this.lbl_tele.TabIndex = 0;
            this.lbl_tele.Text = "TelePhone Number";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(30, 270);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(53, 25);
            this.lbl_age.TabIndex = 0;
            this.lbl_age.Text = "Age";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(30, 212);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(144, 25);
            this.lbl_dob.TabIndex = 0;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(30, 152);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(98, 25);
            this.lbl_address.TabIndex = 0;
            this.lbl_address.Text = "Address";
            // 
            // lbl_SecondName
            // 
            this.lbl_SecondName.AutoSize = true;
            this.lbl_SecondName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecondName.Location = new System.Drawing.Point(30, 93);
            this.lbl_SecondName.Name = "lbl_SecondName";
            this.lbl_SecondName.Size = new System.Drawing.Size(158, 25);
            this.lbl_SecondName.TabIndex = 0;
            this.lbl_SecondName.Text = "Second Name";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(30, 32);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(126, 25);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name";
            // 
            // btn_clearpassword
            // 
            this.btn_clearpassword.ActiveControl = null;
            this.btn_clearpassword.Location = new System.Drawing.Point(395, 283);
            this.btn_clearpassword.Name = "btn_clearpassword";
            this.btn_clearpassword.Size = new System.Drawing.Size(176, 50);
            this.btn_clearpassword.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_clearpassword.TabIndex = 2;
            this.btn_clearpassword.Text = "CLEAR";
            this.btn_clearpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clearpassword.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_clearpassword.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_clearpassword.UseSelectable = true;
            this.btn_clearpassword.Click += new System.EventHandler(this.btn_clearpassword_Click);
            // 
            // btn_updatepassword
            // 
            this.btn_updatepassword.ActiveControl = null;
            this.btn_updatepassword.Location = new System.Drawing.Point(137, 283);
            this.btn_updatepassword.Name = "btn_updatepassword";
            this.btn_updatepassword.Size = new System.Drawing.Size(176, 50);
            this.btn_updatepassword.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_updatepassword.TabIndex = 2;
            this.btn_updatepassword.Text = "UPDATE";
            this.btn_updatepassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_updatepassword.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_updatepassword.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_updatepassword.UseSelectable = true;
            this.btn_updatepassword.Click += new System.EventHandler(this.btn_updatepassword_Click);
            // 
            // txt_confirmPassWord
            // 
            this.txt_confirmPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPassWord.Location = new System.Drawing.Point(309, 134);
            this.txt_confirmPassWord.Name = "txt_confirmPassWord";
            this.txt_confirmPassWord.Size = new System.Drawing.Size(355, 31);
            this.txt_confirmPassWord.TabIndex = 1;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPassword.Location = new System.Drawing.Point(309, 56);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(355, 31);
            this.txt_newPassword.TabIndex = 1;
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_password.Location = new System.Drawing.Point(72, 139);
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(207, 25);
            this.lbl_confirm_password.TabIndex = 0;
            this.lbl_confirm_password.Text = "Confirm PassWord";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.Location = new System.Drawing.Point(72, 57);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(166, 25);
            this.lbl_newPassword.TabIndex = 0;
            this.lbl_newPassword.Text = "New Password";
            // 
            // profile_setting_control
            // 
            this.profile_setting_control.GetForm = this;
            this.profile_setting_control.TargetControl = this.settings_pb;
            // 
            // SellerProfile_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_changeDetails);
            this.Controls.Add(this.panel_privacy);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_privacy);
            this.Controls.Add(this.btn_changeUserSettings);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.settings_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerProfile_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerProfile_settings";
            this.Load += new System.EventHandler(this.SellerProfile_settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settings_pb)).EndInit();
            this.panel_privacy.ResumeLayout(false);
            this.panel_privacy.PerformLayout();
            this.panel_changeDetails.ResumeLayout(false);
            this.panel_changeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox settings_pb;
        private System.Windows.Forms.Label lbl_settings;
        private MetroFramework.Controls.MetroTile btn_changeUserSettings;
        private MetroFramework.Controls.MetroTile btn_privacy;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel_privacy;
        private MetroFramework.Controls.MetroTile btn_clearpassword;
        private MetroFramework.Controls.MetroTile btn_updatepassword;
        private System.Windows.Forms.TextBox txt_confirmPassWord;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Label lbl_confirm_password;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.Panel panel_changeDetails;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_address;
        private MetroFramework.Controls.MetroTile btn_ClearData;
        private MetroFramework.Controls.MetroTile btn_updateData;
        private System.Windows.Forms.TextBox txt_secondName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label lbl_tele;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_SecondName;
        private System.Windows.Forms.Label lbl_firstname;
        private JDragControl.JDragControl profile_setting_control;
    }
}