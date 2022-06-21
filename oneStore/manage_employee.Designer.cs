
namespace oneStore
{
    partial class manage_employee
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
            this.manageEmployee_pb = new System.Windows.Forms.PictureBox();
            this.btn_add_employee = new MetroFramework.Controls.MetroTile();
            this.btn_delete_employee = new MetroFramework.Controls.MetroTile();
            this.btn_view_employee = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.lbl_manage_emp = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.manage_employee_control = new JDragControl.JDragControl(this.components);
            this.panel_employee_view = new System.Windows.Forms.Panel();
            this.rad_showAll = new System.Windows.Forms.RadioButton();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.txt_seach_EID = new System.Windows.Forms.TextBox();
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.lbl_serch_employee = new System.Windows.Forms.Label();
            this.rad_name = new System.Windows.Forms.RadioButton();
            this.rad_EID = new System.Windows.Forms.RadioButton();
            this.btn_serch = new MetroFramework.Controls.MetroTile();
            this.employee_grid = new System.Windows.Forms.DataGridView();
            this.panel_remove = new System.Windows.Forms.Panel();
            this.btn_emp_delete_clear = new MetroFramework.Controls.MetroTile();
            this.btn_emp_remove = new MetroFramework.Controls.MetroTile();
            this.txt_remove_employee = new System.Windows.Forms.TextBox();
            this.lbl_delete = new System.Windows.Forms.Label();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.panel_logout_second = new System.Windows.Forms.Panel();
            this.lbl_logout_second = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.ArduinoUno = new System.IO.Ports.SerialPort(this.components);
            this.panel_add_employee = new System.Windows.Forms.Panel();
            this.dob_picker = new System.Windows.Forms.DateTimePicker();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_secondName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_potition = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_SecondName = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.lbl_eid = new System.Windows.Forms.Label();
            this.txt_fid = new System.Windows.Forms.TextBox();
            this.lbl_fid = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cmb_poition = new MetroFramework.Controls.MetroComboBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.btn_Add = new MetroFramework.Controls.MetroTile();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.panelfinger_print = new System.Windows.Forms.Panel();
            this.lbl_arduino = new System.Windows.Forms.Label();
            this.txt_seral_moniter = new System.Windows.Forms.TextBox();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.btn_add_finger_print = new MetroFramework.Controls.MetroTile();
            this.ArduinoUno2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployee_pb)).BeginInit();
            this.panel_employee_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid)).BeginInit();
            this.panel_remove.SuspendLayout();
            this.panel_logout.SuspendLayout();
            this.panel_logout_second.SuspendLayout();
            this.panel_add_employee.SuspendLayout();
            this.panelfinger_print.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageEmployee_pb
            // 
            this.manageEmployee_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageEmployee_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.manageEmployee_pb.Location = new System.Drawing.Point(0, 0);
            this.manageEmployee_pb.Name = "manageEmployee_pb";
            this.manageEmployee_pb.Size = new System.Drawing.Size(923, 552);
            this.manageEmployee_pb.TabIndex = 0;
            this.manageEmployee_pb.TabStop = false;
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.ActiveControl = null;
            this.btn_add_employee.Location = new System.Drawing.Point(12, 72);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(203, 50);
            this.btn_add_employee.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_add_employee.TabIndex = 1;
            this.btn_add_employee.Text = "Add Employee";
            this.btn_add_employee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add_employee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_add_employee.UseSelectable = true;
            this.btn_add_employee.Click += new System.EventHandler(this.btn_add_employee_Click);
            // 
            // btn_delete_employee
            // 
            this.btn_delete_employee.ActiveControl = null;
            this.btn_delete_employee.Location = new System.Drawing.Point(12, 184);
            this.btn_delete_employee.Name = "btn_delete_employee";
            this.btn_delete_employee.Size = new System.Drawing.Size(203, 50);
            this.btn_delete_employee.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_delete_employee.TabIndex = 1;
            this.btn_delete_employee.Text = "Remove Employee";
            this.btn_delete_employee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_delete_employee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_delete_employee.UseSelectable = true;
            this.btn_delete_employee.Click += new System.EventHandler(this.btn_delete_employee_Click);
            // 
            // btn_view_employee
            // 
            this.btn_view_employee.ActiveControl = null;
            this.btn_view_employee.Location = new System.Drawing.Point(12, 128);
            this.btn_view_employee.Name = "btn_view_employee";
            this.btn_view_employee.Size = new System.Drawing.Size(203, 50);
            this.btn_view_employee.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_view_employee.TabIndex = 1;
            this.btn_view_employee.Text = "View Employee Details";
            this.btn_view_employee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_view_employee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_view_employee.UseSelectable = true;
            this.btn_view_employee.Click += new System.EventHandler(this.btn_view_employee_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(26, 431);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(176, 50);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_manage_emp
            // 
            this.lbl_manage_emp.AutoSize = true;
            this.lbl_manage_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manage_emp.Location = new System.Drawing.Point(235, 14);
            this.lbl_manage_emp.Name = "lbl_manage_emp";
            this.lbl_manage_emp.Size = new System.Drawing.Size(296, 37);
            this.lbl_manage_emp.TabIndex = 2;
            this.lbl_manage_emp.Text = "Manage Employee";
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
            // manage_employee_control
            // 
            this.manage_employee_control.GetForm = this;
            this.manage_employee_control.TargetControl = this.manageEmployee_pb;
            // 
            // panel_employee_view
            // 
            this.panel_employee_view.BackColor = System.Drawing.Color.Red;
            this.panel_employee_view.Controls.Add(this.rad_showAll);
            this.panel_employee_view.Controls.Add(this.txt_search_name);
            this.panel_employee_view.Controls.Add(this.txt_seach_EID);
            this.panel_employee_view.Controls.Add(this.lbl_search_name);
            this.panel_employee_view.Controls.Add(this.lbl_serch_employee);
            this.panel_employee_view.Controls.Add(this.rad_name);
            this.panel_employee_view.Controls.Add(this.rad_EID);
            this.panel_employee_view.Controls.Add(this.btn_serch);
            this.panel_employee_view.Controls.Add(this.employee_grid);
            this.panel_employee_view.Location = new System.Drawing.Point(235, 72);
            this.panel_employee_view.Name = "panel_employee_view";
            this.panel_employee_view.Size = new System.Drawing.Size(680, 468);
            this.panel_employee_view.TabIndex = 4;
            // 
            // rad_showAll
            // 
            this.rad_showAll.AutoSize = true;
            this.rad_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_showAll.Location = new System.Drawing.Point(434, 51);
            this.rad_showAll.Name = "rad_showAll";
            this.rad_showAll.Size = new System.Drawing.Size(77, 20);
            this.rad_showAll.TabIndex = 9;
            this.rad_showAll.TabStop = true;
            this.rad_showAll.Text = "Show All";
            this.rad_showAll.UseVisualStyleBackColor = true;
            this.rad_showAll.CheckedChanged += new System.EventHandler(this.rad_showAll_CheckedChanged);
            // 
            // txt_search_name
            // 
            this.txt_search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_name.Location = new System.Drawing.Point(251, 46);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(163, 31);
            this.txt_search_name.TabIndex = 8;
            // 
            // txt_seach_EID
            // 
            this.txt_seach_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seach_EID.Location = new System.Drawing.Point(35, 46);
            this.txt_seach_EID.Name = "txt_seach_EID";
            this.txt_seach_EID.Size = new System.Drawing.Size(163, 31);
            this.txt_seach_EID.TabIndex = 8;
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_name.Location = new System.Drawing.Point(249, 19);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(165, 24);
            this.lbl_search_name.TabIndex = 7;
            this.lbl_search_name.Text = "Employee Name";
            // 
            // lbl_serch_employee
            // 
            this.lbl_serch_employee.AutoSize = true;
            this.lbl_serch_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serch_employee.Location = new System.Drawing.Point(54, 19);
            this.lbl_serch_employee.Name = "lbl_serch_employee";
            this.lbl_serch_employee.Size = new System.Drawing.Size(129, 24);
            this.lbl_serch_employee.TabIndex = 7;
            this.lbl_serch_employee.Text = "Employee ID";
            // 
            // rad_name
            // 
            this.rad_name.AutoSize = true;
            this.rad_name.Location = new System.Drawing.Point(227, 55);
            this.rad_name.Name = "rad_name";
            this.rad_name.Size = new System.Drawing.Size(14, 13);
            this.rad_name.TabIndex = 6;
            this.rad_name.TabStop = true;
            this.rad_name.UseVisualStyleBackColor = true;
            this.rad_name.CheckedChanged += new System.EventHandler(this.rad_name_CheckedChanged);
            // 
            // rad_EID
            // 
            this.rad_EID.AutoSize = true;
            this.rad_EID.Location = new System.Drawing.Point(15, 55);
            this.rad_EID.Name = "rad_EID";
            this.rad_EID.Size = new System.Drawing.Size(14, 13);
            this.rad_EID.TabIndex = 6;
            this.rad_EID.TabStop = true;
            this.rad_EID.UseVisualStyleBackColor = true;
            this.rad_EID.CheckedChanged += new System.EventHandler(this.rad_EID_CheckedChanged);
            // 
            // btn_serch
            // 
            this.btn_serch.ActiveControl = null;
            this.btn_serch.Location = new System.Drawing.Point(528, 29);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(148, 55);
            this.btn_serch.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_serch.TabIndex = 5;
            this.btn_serch.Text = "SEARCH";
            this.btn_serch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_serch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_serch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_serch.UseSelectable = true;
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // employee_grid
            // 
            this.employee_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_grid.Location = new System.Drawing.Point(3, 90);
            this.employee_grid.Name = "employee_grid";
            this.employee_grid.Size = new System.Drawing.Size(673, 375);
            this.employee_grid.TabIndex = 0;
            // 
            // panel_remove
            // 
            this.panel_remove.BackColor = System.Drawing.Color.Red;
            this.panel_remove.Controls.Add(this.btn_emp_delete_clear);
            this.panel_remove.Controls.Add(this.btn_emp_remove);
            this.panel_remove.Controls.Add(this.txt_remove_employee);
            this.panel_remove.Controls.Add(this.lbl_delete);
            this.panel_remove.Location = new System.Drawing.Point(235, 72);
            this.panel_remove.Name = "panel_remove";
            this.panel_remove.Size = new System.Drawing.Size(680, 468);
            this.panel_remove.TabIndex = 5;
            // 
            // btn_emp_delete_clear
            // 
            this.btn_emp_delete_clear.ActiveControl = null;
            this.btn_emp_delete_clear.Location = new System.Drawing.Point(392, 267);
            this.btn_emp_delete_clear.Name = "btn_emp_delete_clear";
            this.btn_emp_delete_clear.Size = new System.Drawing.Size(148, 55);
            this.btn_emp_delete_clear.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_emp_delete_clear.TabIndex = 2;
            this.btn_emp_delete_clear.Text = "CLEAR";
            this.btn_emp_delete_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_emp_delete_clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_emp_delete_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_emp_delete_clear.UseSelectable = true;
            this.btn_emp_delete_clear.Click += new System.EventHandler(this.btn_emp_delete_clear_Click);
            // 
            // btn_emp_remove
            // 
            this.btn_emp_remove.ActiveControl = null;
            this.btn_emp_remove.Location = new System.Drawing.Point(148, 267);
            this.btn_emp_remove.Name = "btn_emp_remove";
            this.btn_emp_remove.Size = new System.Drawing.Size(148, 55);
            this.btn_emp_remove.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_emp_remove.TabIndex = 2;
            this.btn_emp_remove.Text = "REMOVE";
            this.btn_emp_remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_emp_remove.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_emp_remove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_emp_remove.UseSelectable = true;
            this.btn_emp_remove.Click += new System.EventHandler(this.btn_emp_remove_Click);
            // 
            // txt_remove_employee
            // 
            this.txt_remove_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remove_employee.Location = new System.Drawing.Point(253, 112);
            this.txt_remove_employee.Name = "txt_remove_employee";
            this.txt_remove_employee.Size = new System.Drawing.Size(287, 29);
            this.txt_remove_employee.TabIndex = 1;
            // 
            // lbl_delete
            // 
            this.lbl_delete.AutoSize = true;
            this.lbl_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete.Location = new System.Drawing.Point(55, 112);
            this.lbl_delete.Name = "lbl_delete";
            this.lbl_delete.Size = new System.Drawing.Size(162, 29);
            this.lbl_delete.TabIndex = 0;
            this.lbl_delete.Text = "Employee ID";
            // 
            // panel_logout
            // 
            this.panel_logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_logout.Controls.Add(this.panelfinger_print);
            this.panel_logout.Controls.Add(this.panel_logout_second);
            this.panel_logout.Location = new System.Drawing.Point(144, 172);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(651, 232);
            this.panel_logout.TabIndex = 12;
            // 
            // panel_logout_second
            // 
            this.panel_logout_second.BackColor = System.Drawing.Color.Red;
            this.panel_logout_second.Controls.Add(this.lbl_logout_second);
            this.panel_logout_second.Controls.Add(this.lbl_logout);
            this.panel_logout_second.Location = new System.Drawing.Point(3, 3);
            this.panel_logout_second.Name = "panel_logout_second";
            this.panel_logout_second.Size = new System.Drawing.Size(645, 226);
            this.panel_logout_second.TabIndex = 0;
            // 
            // lbl_logout_second
            // 
            this.lbl_logout_second.AutoSize = true;
            this.lbl_logout_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout_second.Location = new System.Drawing.Point(33, 109);
            this.lbl_logout_second.Name = "lbl_logout_second";
            this.lbl_logout_second.Size = new System.Drawing.Size(269, 25);
            this.lbl_logout_second.TabIndex = 0;
            this.lbl_logout_second.Text = " Arduino code uploading....";
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(33, 36);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(164, 31);
            this.lbl_logout.TabIndex = 0;
            this.lbl_logout.Text = "Please wait";
            // 
            // ArduinoUno
            // 
            this.ArduinoUno.PortName = "COM3";
            this.ArduinoUno.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ArduinoUno_DataReceived);
            // 
            // panel_add_employee
            // 
            this.panel_add_employee.BackColor = System.Drawing.Color.Red;
            this.panel_add_employee.Controls.Add(this.cmb_poition);
            this.panel_add_employee.Controls.Add(this.dob_picker);
            this.panel_add_employee.Controls.Add(this.txt_emp_id);
            this.panel_add_employee.Controls.Add(this.txt_firstName);
            this.panel_add_employee.Controls.Add(this.txt_password);
            this.panel_add_employee.Controls.Add(this.txt_username);
            this.panel_add_employee.Controls.Add(this.txt_fid);
            this.panel_add_employee.Controls.Add(this.btn_clear);
            this.panel_add_employee.Controls.Add(this.btn_Add);
            this.panel_add_employee.Controls.Add(this.lbl_eid);
            this.panel_add_employee.Controls.Add(this.lbl_firstname);
            this.panel_add_employee.Controls.Add(this.txt_tel);
            this.panel_add_employee.Controls.Add(this.txt_age);
            this.panel_add_employee.Controls.Add(this.lbl_SecondName);
            this.panel_add_employee.Controls.Add(this.txt_address);
            this.panel_add_employee.Controls.Add(this.lbl_address);
            this.panel_add_employee.Controls.Add(this.txt_secondName);
            this.panel_add_employee.Controls.Add(this.lbl_dob);
            this.panel_add_employee.Controls.Add(this.lbl_age);
            this.panel_add_employee.Controls.Add(this.lbl_password);
            this.panel_add_employee.Controls.Add(this.lbl_username);
            this.panel_add_employee.Controls.Add(this.lbl_fid);
            this.panel_add_employee.Controls.Add(this.lbl_tel);
            this.panel_add_employee.Controls.Add(this.lbl_potition);
            this.panel_add_employee.Location = new System.Drawing.Point(235, 72);
            this.panel_add_employee.Name = "panel_add_employee";
            this.panel_add_employee.Size = new System.Drawing.Size(680, 468);
            this.panel_add_employee.TabIndex = 13;
            // 
            // dob_picker
            // 
            this.dob_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_picker.Location = new System.Drawing.Point(251, 146);
            this.dob_picker.Name = "dob_picker";
            this.dob_picker.Size = new System.Drawing.Size(406, 31);
            this.dob_picker.TabIndex = 25;
            this.dob_picker.ValueChanged += new System.EventHandler(this.dob_picker_ValueChanged);
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(251, 181);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(406, 31);
            this.txt_age.TabIndex = 21;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(251, 111);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(406, 31);
            this.txt_address.TabIndex = 22;
            // 
            // txt_secondName
            // 
            this.txt_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secondName.Location = new System.Drawing.Point(251, 75);
            this.txt_secondName.Name = "txt_secondName";
            this.txt_secondName.Size = new System.Drawing.Size(406, 31);
            this.txt_secondName.TabIndex = 23;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(251, 40);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(406, 31);
            this.txt_firstName.TabIndex = 24;
            // 
            // lbl_potition
            // 
            this.lbl_potition.AutoSize = true;
            this.lbl_potition.BackColor = System.Drawing.Color.Transparent;
            this.lbl_potition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potition.Location = new System.Drawing.Point(24, 253);
            this.lbl_potition.Name = "lbl_potition";
            this.lbl_potition.Size = new System.Drawing.Size(97, 25);
            this.lbl_potition.TabIndex = 14;
            this.lbl_potition.Text = "Position";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(24, 187);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(53, 25);
            this.lbl_age.TabIndex = 15;
            this.lbl_age.Text = "Age";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(24, 151);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(144, 25);
            this.lbl_dob.TabIndex = 16;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(24, 117);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(98, 25);
            this.lbl_address.TabIndex = 17;
            this.lbl_address.Text = "Address";
            // 
            // lbl_SecondName
            // 
            this.lbl_SecondName.AutoSize = true;
            this.lbl_SecondName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecondName.Location = new System.Drawing.Point(24, 79);
            this.lbl_SecondName.Name = "lbl_SecondName";
            this.lbl_SecondName.Size = new System.Drawing.Size(158, 25);
            this.lbl_SecondName.TabIndex = 18;
            this.lbl_SecondName.Text = "Second Name";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(24, 43);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(126, 25);
            this.lbl_firstname.TabIndex = 19;
            this.lbl_firstname.Text = "First Name";
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_id.Location = new System.Drawing.Point(251, 5);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(406, 31);
            this.txt_emp_id.TabIndex = 24;
            // 
            // lbl_eid
            // 
            this.lbl_eid.AutoSize = true;
            this.lbl_eid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eid.Location = new System.Drawing.Point(24, 8);
            this.lbl_eid.Name = "lbl_eid";
            this.lbl_eid.Size = new System.Drawing.Size(144, 25);
            this.lbl_eid.TabIndex = 19;
            this.lbl_eid.Text = "Employee ID";
            // 
            // txt_fid
            // 
            this.txt_fid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fid.Location = new System.Drawing.Point(251, 286);
            this.txt_fid.Name = "txt_fid";
            this.txt_fid.Size = new System.Drawing.Size(406, 31);
            this.txt_fid.TabIndex = 20;
            // 
            // lbl_fid
            // 
            this.lbl_fid.AutoSize = true;
            this.lbl_fid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fid.Location = new System.Drawing.Point(24, 289);
            this.lbl_fid.Name = "lbl_fid";
            this.lbl_fid.Size = new System.Drawing.Size(164, 25);
            this.lbl_fid.TabIndex = 14;
            this.lbl_fid.Text = "Finger Print ID";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(251, 321);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(406, 31);
            this.txt_username.TabIndex = 20;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(24, 324);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(128, 25);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(24, 359);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(114, 25);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(251, 356);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(406, 31);
            this.txt_password.TabIndex = 20;
            // 
            // cmb_poition
            // 
            this.cmb_poition.FormattingEnabled = true;
            this.cmb_poition.ItemHeight = 23;
            this.cmb_poition.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.cmb_poition.Location = new System.Drawing.Point(251, 252);
            this.cmb_poition.Name = "cmb_poition";
            this.cmb_poition.Size = new System.Drawing.Size(406, 29);
            this.cmb_poition.TabIndex = 26;
            this.cmb_poition.UseSelectable = true;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(24, 222);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(155, 25);
            this.lbl_tel.TabIndex = 14;
            this.lbl_tel.Text = "Employee Tel";
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(251, 216);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(406, 31);
            this.txt_tel.TabIndex = 21;
            // 
            // btn_Add
            // 
            this.btn_Add.ActiveControl = null;
            this.btn_Add.Location = new System.Drawing.Point(120, 405);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(176, 50);
            this.btn_Add.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "ADD";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Add.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Add.UseSelectable = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(406, 405);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(176, 50);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panelfinger_print
            // 
            this.panelfinger_print.BackColor = System.Drawing.Color.Red;
            this.panelfinger_print.Controls.Add(this.btn_add_finger_print);
            this.panelfinger_print.Controls.Add(this.btn_save);
            this.panelfinger_print.Controls.Add(this.txt_seral_moniter);
            this.panelfinger_print.Controls.Add(this.lbl_arduino);
            this.panelfinger_print.Location = new System.Drawing.Point(3, 3);
            this.panelfinger_print.Name = "panelfinger_print";
            this.panelfinger_print.Size = new System.Drawing.Size(645, 226);
            this.panelfinger_print.TabIndex = 1;
            // 
            // lbl_arduino
            // 
            this.lbl_arduino.AutoSize = true;
            this.lbl_arduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arduino.Location = new System.Drawing.Point(34, 38);
            this.lbl_arduino.Name = "lbl_arduino";
            this.lbl_arduino.Size = new System.Drawing.Size(319, 25);
            this.lbl_arduino.TabIndex = 0;
            this.lbl_arduino.Text = "Finger Print Scanner working.....";
            // 
            // txt_seral_moniter
            // 
            this.txt_seral_moniter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seral_moniter.Location = new System.Drawing.Point(39, 71);
            this.txt_seral_moniter.Multiline = true;
            this.txt_seral_moniter.Name = "txt_seral_moniter";
            this.txt_seral_moniter.Size = new System.Drawing.Size(560, 72);
            this.txt_seral_moniter.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Location = new System.Drawing.Point(339, 161);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(226, 50);
            this.btn_save.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "SAVE";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_save.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add_finger_print
            // 
            this.btn_add_finger_print.ActiveControl = null;
            this.btn_add_finger_print.Location = new System.Drawing.Point(100, 161);
            this.btn_add_finger_print.Name = "btn_add_finger_print";
            this.btn_add_finger_print.Size = new System.Drawing.Size(205, 50);
            this.btn_add_finger_print.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_add_finger_print.TabIndex = 2;
            this.btn_add_finger_print.Text = "ADD FINGER PRINT";
            this.btn_add_finger_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_finger_print.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add_finger_print.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_add_finger_print.UseSelectable = true;
            this.btn_add_finger_print.Click += new System.EventHandler(this.btn_add_finger_print_Click);
            // 
            // ArduinoUno2
            // 
            this.ArduinoUno2.PortName = "COM4";
            // 
            // manage_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_logout);
            this.Controls.Add(this.panel_add_employee);
            this.Controls.Add(this.panel_remove);
            this.Controls.Add(this.panel_employee_view);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_manage_emp);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_view_employee);
            this.Controls.Add(this.btn_delete_employee);
            this.Controls.Add(this.btn_add_employee);
            this.Controls.Add(this.manageEmployee_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manage_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manage_employee";
            this.Load += new System.EventHandler(this.manage_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageEmployee_pb)).EndInit();
            this.panel_employee_view.ResumeLayout(false);
            this.panel_employee_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid)).EndInit();
            this.panel_remove.ResumeLayout(false);
            this.panel_remove.PerformLayout();
            this.panel_logout.ResumeLayout(false);
            this.panel_logout_second.ResumeLayout(false);
            this.panel_logout_second.PerformLayout();
            this.panel_add_employee.ResumeLayout(false);
            this.panel_add_employee.PerformLayout();
            this.panelfinger_print.ResumeLayout(false);
            this.panelfinger_print.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox manageEmployee_pb;
        private MetroFramework.Controls.MetroTile btn_add_employee;
        private MetroFramework.Controls.MetroTile btn_delete_employee;
        private MetroFramework.Controls.MetroTile btn_view_employee;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Label lbl_manage_emp;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl manage_employee_control;
        private System.Windows.Forms.Panel panel_employee_view;
        private System.Windows.Forms.DataGridView employee_grid;
        private System.Windows.Forms.Label lbl_serch_employee;
        private System.Windows.Forms.RadioButton rad_EID;
        private MetroFramework.Controls.MetroTile btn_serch;
        private System.Windows.Forms.TextBox txt_seach_EID;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.RadioButton rad_showAll;
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.RadioButton rad_name;
        private System.Windows.Forms.Panel panel_remove;
        private MetroFramework.Controls.MetroTile btn_emp_delete_clear;
        private MetroFramework.Controls.MetroTile btn_emp_remove;
        private System.Windows.Forms.TextBox txt_remove_employee;
        private System.Windows.Forms.Label lbl_delete;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.Panel panel_logout_second;
        private System.Windows.Forms.Label lbl_logout_second;
        private System.Windows.Forms.Label lbl_logout;
        private System.IO.Ports.SerialPort ArduinoUno;
        private System.Windows.Forms.Panel panel_add_employee;
        private MetroFramework.Controls.MetroComboBox cmb_poition;
        private System.Windows.Forms.DateTimePicker dob_picker;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_fid;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_Add;
        private System.Windows.Forms.Label lbl_eid;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label lbl_SecondName;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_secondName;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_fid;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_potition;
        private System.Windows.Forms.Panel panelfinger_print;
        private MetroFramework.Controls.MetroTile btn_save;
        private System.Windows.Forms.TextBox txt_seral_moniter;
        private System.Windows.Forms.Label lbl_arduino;
        private MetroFramework.Controls.MetroTile btn_add_finger_print;
        private System.IO.Ports.SerialPort ArduinoUno2;
    }
}