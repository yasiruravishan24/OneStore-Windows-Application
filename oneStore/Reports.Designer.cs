
namespace oneStore
{
    partial class Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sales_recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerSell = new oneStore.sellerSell();
            this.report_pb = new System.Windows.Forms.PictureBox();
            this.btn_sell_report = new MetroFramework.Controls.MetroTile();
            this.btn_employe_report = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.lbl_reports = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.report_control = new JDragControl.JDragControl(this.components);
            this.btn_databasereport = new MetroFramework.Controls.MetroTile();
            this.panel_database = new System.Windows.Forms.Panel();
            this.lbl_database_Operation = new System.Windows.Forms.Label();
            this.lbl_emp_id = new System.Windows.Forms.Label();
            this.txt_database_EID = new System.Windows.Forms.TextBox();
            this.cmb_search_operation = new MetroFramework.Controls.MetroComboBox();
            this.DatabaseReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_database_search = new MetroFramework.Controls.MetroTile();
            this.panel_login_report = new System.Windows.Forms.Panel();
            this.LogingReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbl_login_operation = new System.Windows.Forms.Label();
            this.lbl_login_EID = new System.Windows.Forms.Label();
            this.txt_login_EID = new System.Windows.Forms.TextBox();
            this.cmb_login_operation = new MetroFramework.Controls.MetroComboBox();
            this.btn_login_search = new MetroFramework.Controls.MetroTile();
            this.panel_sell_report = new System.Windows.Forms.Panel();
            this.lbl_sells_brands = new System.Windows.Forms.Label();
            this.lbl_sells_EID = new System.Windows.Forms.Label();
            this.SellesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_selles_EID = new System.Windows.Forms.TextBox();
            this.btn_sells_search = new MetroFramework.Controls.MetroTile();
            this.Sales_recordsTableAdapter = new oneStore.sellerSellTableAdapters.Sales_recordsTableAdapter();
            this.Employee_recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginReport = new oneStore.LoginReport();
            this.Employee_recordsTableAdapter = new oneStore.LoginReportTableAdapters.Employee_recordsTableAdapter();
            this.DataBaseReport = new oneStore.DataBaseReport();
            this.Database_recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database_recordsTableAdapter = new oneStore.DataBaseReportTableAdapters.Database_recordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sales_recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_pb)).BeginInit();
            this.panel_database.SuspendLayout();
            this.panel_login_report.SuspendLayout();
            this.panel_sell_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database_recordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Sales_recordsBindingSource
            // 
            this.Sales_recordsBindingSource.DataMember = "Sales_records";
            this.Sales_recordsBindingSource.DataSource = this.sellerSell;
            // 
            // sellerSell
            // 
            this.sellerSell.DataSetName = "sellerSell";
            this.sellerSell.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_pb
            // 
            this.report_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.report_pb.Location = new System.Drawing.Point(0, 0);
            this.report_pb.Margin = new System.Windows.Forms.Padding(4);
            this.report_pb.Name = "report_pb";
            this.report_pb.Size = new System.Drawing.Size(1231, 679);
            this.report_pb.TabIndex = 0;
            this.report_pb.TabStop = false;
            // 
            // btn_sell_report
            // 
            this.btn_sell_report.ActiveControl = null;
            this.btn_sell_report.Location = new System.Drawing.Point(16, 89);
            this.btn_sell_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sell_report.Name = "btn_sell_report";
            this.btn_sell_report.Size = new System.Drawing.Size(271, 62);
            this.btn_sell_report.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sell_report.TabIndex = 1;
            this.btn_sell_report.Text = "Sells Report";
            this.btn_sell_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sell_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sell_report.UseSelectable = true;
            this.btn_sell_report.Click += new System.EventHandler(this.btn_sell_report_Click);
            // 
            // btn_employe_report
            // 
            this.btn_employe_report.ActiveControl = null;
            this.btn_employe_report.Location = new System.Drawing.Point(16, 158);
            this.btn_employe_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_employe_report.Name = "btn_employe_report";
            this.btn_employe_report.Size = new System.Drawing.Size(271, 62);
            this.btn_employe_report.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_employe_report.TabIndex = 1;
            this.btn_employe_report.Text = "Login Report";
            this.btn_employe_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_employe_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_employe_report.UseSelectable = true;
            this.btn_employe_report.Click += new System.EventHandler(this.btn_employe_report_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(35, 530);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(235, 62);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_reports
            // 
            this.lbl_reports.AutoSize = true;
            this.lbl_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reports.Location = new System.Drawing.Point(313, 17);
            this.lbl_reports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reports.Name = "lbl_reports";
            this.lbl_reports.Size = new System.Drawing.Size(167, 46);
            this.lbl_reports.TabIndex = 3;
            this.lbl_reports.Text = "Reports";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = global::oneStore.Properties.Resources.minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(1129, 2);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(43, 39);
            this.btn_minimize.TabIndex = 4;
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
            this.btn_exit.Location = new System.Drawing.Point(1177, 2);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(43, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // report_control
            // 
            this.report_control.GetForm = this;
            this.report_control.TargetControl = this.report_pb;
            // 
            // btn_databasereport
            // 
            this.btn_databasereport.ActiveControl = null;
            this.btn_databasereport.Location = new System.Drawing.Point(16, 226);
            this.btn_databasereport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_databasereport.Name = "btn_databasereport";
            this.btn_databasereport.Size = new System.Drawing.Size(271, 62);
            this.btn_databasereport.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_databasereport.TabIndex = 1;
            this.btn_databasereport.Text = "Database Report";
            this.btn_databasereport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_databasereport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_databasereport.UseSelectable = true;
            this.btn_databasereport.Click += new System.EventHandler(this.btn_databasereport_Click);
            // 
            // panel_database
            // 
            this.panel_database.BackColor = System.Drawing.Color.Red;
            this.panel_database.Controls.Add(this.lbl_database_Operation);
            this.panel_database.Controls.Add(this.lbl_emp_id);
            this.panel_database.Controls.Add(this.txt_database_EID);
            this.panel_database.Controls.Add(this.cmb_search_operation);
            this.panel_database.Controls.Add(this.DatabaseReportView);
            this.panel_database.Controls.Add(this.btn_database_search);
            this.panel_database.Location = new System.Drawing.Point(313, 89);
            this.panel_database.Margin = new System.Windows.Forms.Padding(4);
            this.panel_database.Name = "panel_database";
            this.panel_database.Size = new System.Drawing.Size(907, 576);
            this.panel_database.TabIndex = 6;
            // 
            // lbl_database_Operation
            // 
            this.lbl_database_Operation.AutoSize = true;
            this.lbl_database_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_database_Operation.Location = new System.Drawing.Point(456, 4);
            this.lbl_database_Operation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_database_Operation.Name = "lbl_database_Operation";
            this.lbl_database_Operation.Size = new System.Drawing.Size(142, 31);
            this.lbl_database_Operation.TabIndex = 5;
            this.lbl_database_Operation.Text = "Operation";
            // 
            // lbl_emp_id
            // 
            this.lbl_emp_id.AutoSize = true;
            this.lbl_emp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_id.Location = new System.Drawing.Point(91, 5);
            this.lbl_emp_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emp_id.Name = "lbl_emp_id";
            this.lbl_emp_id.Size = new System.Drawing.Size(180, 31);
            this.lbl_emp_id.TabIndex = 5;
            this.lbl_emp_id.Text = "Employee ID";
            // 
            // txt_database_EID
            // 
            this.txt_database_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_database_EID.Location = new System.Drawing.Point(71, 39);
            this.txt_database_EID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_database_EID.Name = "txt_database_EID";
            this.txt_database_EID.Size = new System.Drawing.Size(228, 37);
            this.txt_database_EID.TabIndex = 4;
            // 
            // cmb_search_operation
            // 
            this.cmb_search_operation.FormattingEnabled = true;
            this.cmb_search_operation.ItemHeight = 23;
            this.cmb_search_operation.Items.AddRange(new object[] {
            "Insert ",
            "Delete",
            "Update"});
            this.cmb_search_operation.Location = new System.Drawing.Point(420, 39);
            this.cmb_search_operation.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_search_operation.Name = "cmb_search_operation";
            this.cmb_search_operation.Size = new System.Drawing.Size(228, 29);
            this.cmb_search_operation.TabIndex = 3;
            this.cmb_search_operation.UseSelectable = true;
            // 
            // DatabaseReportView
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.Database_recordsBindingSource;
            this.DatabaseReportView.LocalReport.DataSources.Add(reportDataSource4);
            this.DatabaseReportView.LocalReport.ReportEmbeddedResource = "oneStore.Yasiru.rdlc";
            this.DatabaseReportView.Location = new System.Drawing.Point(4, 96);
            this.DatabaseReportView.Margin = new System.Windows.Forms.Padding(4);
            this.DatabaseReportView.Name = "DatabaseReportView";
            this.DatabaseReportView.ServerReport.BearerToken = null;
            this.DatabaseReportView.Size = new System.Drawing.Size(898, 472);
            this.DatabaseReportView.TabIndex = 0;
            // 
            // btn_database_search
            // 
            this.btn_database_search.ActiveControl = null;
            this.btn_database_search.Location = new System.Drawing.Point(703, 20);
            this.btn_database_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_database_search.Name = "btn_database_search";
            this.btn_database_search.Size = new System.Drawing.Size(177, 58);
            this.btn_database_search.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_database_search.TabIndex = 2;
            this.btn_database_search.Text = "SEARCH";
            this.btn_database_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_database_search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_database_search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_database_search.UseSelectable = true;
            this.btn_database_search.Click += new System.EventHandler(this.btn_database_search_Click);
            // 
            // panel_login_report
            // 
            this.panel_login_report.BackColor = System.Drawing.Color.Red;
            this.panel_login_report.Controls.Add(this.LogingReportViewer);
            this.panel_login_report.Controls.Add(this.lbl_login_operation);
            this.panel_login_report.Controls.Add(this.lbl_login_EID);
            this.panel_login_report.Controls.Add(this.txt_login_EID);
            this.panel_login_report.Controls.Add(this.cmb_login_operation);
            this.panel_login_report.Controls.Add(this.btn_login_search);
            this.panel_login_report.Location = new System.Drawing.Point(313, 89);
            this.panel_login_report.Margin = new System.Windows.Forms.Padding(4);
            this.panel_login_report.Name = "panel_login_report";
            this.panel_login_report.Size = new System.Drawing.Size(907, 576);
            this.panel_login_report.TabIndex = 7;
            // 
            // LogingReportViewer
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.Employee_recordsBindingSource;
            this.LogingReportViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.LogingReportViewer.LocalReport.ReportEmbeddedResource = "oneStore.Pasan.rdlc";
            this.LogingReportViewer.Location = new System.Drawing.Point(4, 96);
            this.LogingReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.LogingReportViewer.Name = "LogingReportViewer";
            this.LogingReportViewer.ServerReport.BearerToken = null;
            this.LogingReportViewer.Size = new System.Drawing.Size(898, 472);
            this.LogingReportViewer.TabIndex = 12;
            // 
            // lbl_login_operation
            // 
            this.lbl_login_operation.AutoSize = true;
            this.lbl_login_operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_operation.Location = new System.Drawing.Point(456, 4);
            this.lbl_login_operation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login_operation.Name = "lbl_login_operation";
            this.lbl_login_operation.Size = new System.Drawing.Size(142, 31);
            this.lbl_login_operation.TabIndex = 10;
            this.lbl_login_operation.Text = "Operation";
            // 
            // lbl_login_EID
            // 
            this.lbl_login_EID.AutoSize = true;
            this.lbl_login_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_EID.Location = new System.Drawing.Point(91, 5);
            this.lbl_login_EID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login_EID.Name = "lbl_login_EID";
            this.lbl_login_EID.Size = new System.Drawing.Size(180, 31);
            this.lbl_login_EID.TabIndex = 11;
            this.lbl_login_EID.Text = "Employee ID";
            // 
            // txt_login_EID
            // 
            this.txt_login_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_EID.Location = new System.Drawing.Point(71, 39);
            this.txt_login_EID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_login_EID.Name = "txt_login_EID";
            this.txt_login_EID.Size = new System.Drawing.Size(228, 37);
            this.txt_login_EID.TabIndex = 9;
            // 
            // cmb_login_operation
            // 
            this.cmb_login_operation.FormattingEnabled = true;
            this.cmb_login_operation.ItemHeight = 24;
            this.cmb_login_operation.Items.AddRange(new object[] {
            "Login",
            "Logout"});
            this.cmb_login_operation.Location = new System.Drawing.Point(420, 39);
            this.cmb_login_operation.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_login_operation.Name = "cmb_login_operation";
            this.cmb_login_operation.Size = new System.Drawing.Size(228, 30);
            this.cmb_login_operation.TabIndex = 8;
            this.cmb_login_operation.UseSelectable = true;
            // 
            // btn_login_search
            // 
            this.btn_login_search.ActiveControl = null;
            this.btn_login_search.Location = new System.Drawing.Point(703, 20);
            this.btn_login_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login_search.Name = "btn_login_search";
            this.btn_login_search.Size = new System.Drawing.Size(177, 58);
            this.btn_login_search.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_login_search.TabIndex = 7;
            this.btn_login_search.Text = "SEARCH";
            this.btn_login_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login_search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_login_search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_login_search.UseSelectable = true;
            this.btn_login_search.Click += new System.EventHandler(this.btn_login_search_Click);
            // 
            // panel_sell_report
            // 
            this.panel_sell_report.BackColor = System.Drawing.Color.Red;
            this.panel_sell_report.Controls.Add(this.lbl_sells_brands);
            this.panel_sell_report.Controls.Add(this.lbl_sells_EID);
            this.panel_sell_report.Controls.Add(this.SellesReportViewer);
            this.panel_sell_report.Controls.Add(this.txt_ProductID);
            this.panel_sell_report.Controls.Add(this.txt_selles_EID);
            this.panel_sell_report.Controls.Add(this.btn_sells_search);
            this.panel_sell_report.Location = new System.Drawing.Point(313, 89);
            this.panel_sell_report.Margin = new System.Windows.Forms.Padding(4);
            this.panel_sell_report.Name = "panel_sell_report";
            this.panel_sell_report.Size = new System.Drawing.Size(907, 576);
            this.panel_sell_report.TabIndex = 8;
            // 
            // lbl_sells_brands
            // 
            this.lbl_sells_brands.AutoSize = true;
            this.lbl_sells_brands.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sells_brands.Location = new System.Drawing.Point(436, 5);
            this.lbl_sells_brands.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sells_brands.Name = "lbl_sells_brands";
            this.lbl_sells_brands.Size = new System.Drawing.Size(153, 31);
            this.lbl_sells_brands.TabIndex = 4;
            this.lbl_sells_brands.Text = "Product ID";
            // 
            // lbl_sells_EID
            // 
            this.lbl_sells_EID.AutoSize = true;
            this.lbl_sells_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sells_EID.Location = new System.Drawing.Point(91, 5);
            this.lbl_sells_EID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sells_EID.Name = "lbl_sells_EID";
            this.lbl_sells_EID.Size = new System.Drawing.Size(180, 31);
            this.lbl_sells_EID.TabIndex = 4;
            this.lbl_sells_EID.Text = "Employee ID";
            // 
            // SellesReportViewer
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.Sales_recordsBindingSource;
            this.SellesReportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.SellesReportViewer.LocalReport.ReportEmbeddedResource = "oneStore.Chamith.rdlc";
            this.SellesReportViewer.Location = new System.Drawing.Point(4, 96);
            this.SellesReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.SellesReportViewer.Name = "SellesReportViewer";
            this.SellesReportViewer.ServerReport.BearerToken = null;
            this.SellesReportViewer.Size = new System.Drawing.Size(898, 472);
            this.SellesReportViewer.TabIndex = 3;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductID.Location = new System.Drawing.Point(404, 39);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(228, 37);
            this.txt_ProductID.TabIndex = 1;
            // 
            // txt_selles_EID
            // 
            this.txt_selles_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selles_EID.Location = new System.Drawing.Point(71, 39);
            this.txt_selles_EID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selles_EID.Name = "txt_selles_EID";
            this.txt_selles_EID.Size = new System.Drawing.Size(228, 37);
            this.txt_selles_EID.TabIndex = 1;
            // 
            // btn_sells_search
            // 
            this.btn_sells_search.ActiveControl = null;
            this.btn_sells_search.Location = new System.Drawing.Point(703, 20);
            this.btn_sells_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sells_search.Name = "btn_sells_search";
            this.btn_sells_search.Size = new System.Drawing.Size(177, 52);
            this.btn_sells_search.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sells_search.TabIndex = 2;
            this.btn_sells_search.Text = "SEARCH";
            this.btn_sells_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sells_search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sells_search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sells_search.UseSelectable = true;
            this.btn_sells_search.Click += new System.EventHandler(this.btn_sells_search_Click);
            // 
            // Sales_recordsTableAdapter
            // 
            this.Sales_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_recordsBindingSource
            // 
            this.Employee_recordsBindingSource.DataMember = "Employee_records";
            this.Employee_recordsBindingSource.DataSource = this.LoginReport;
            // 
            // LoginReport
            // 
            this.LoginReport.DataSetName = "LoginReport";
            this.LoginReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employee_recordsTableAdapter
            // 
            this.Employee_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // DataBaseReport
            // 
            this.DataBaseReport.DataSetName = "DataBaseReport";
            this.DataBaseReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Database_recordsBindingSource
            // 
            this.Database_recordsBindingSource.DataMember = "Database_records";
            this.Database_recordsBindingSource.DataSource = this.DataBaseReport;
            // 
            // Database_recordsTableAdapter
            // 
            this.Database_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 679);
            this.Controls.Add(this.panel_sell_report);
            this.Controls.Add(this.panel_login_report);
            this.Controls.Add(this.panel_database);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_reports);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_databasereport);
            this.Controls.Add(this.btn_employe_report);
            this.Controls.Add(this.btn_sell_report);
            this.Controls.Add(this.report_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sales_recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_pb)).EndInit();
            this.panel_database.ResumeLayout(false);
            this.panel_database.PerformLayout();
            this.panel_login_report.ResumeLayout(false);
            this.panel_login_report.PerformLayout();
            this.panel_sell_report.ResumeLayout(false);
            this.panel_sell_report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database_recordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox report_pb;
        private MetroFramework.Controls.MetroTile btn_sell_report;
        private MetroFramework.Controls.MetroTile btn_employe_report;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Label lbl_reports;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl report_control;
        private System.Windows.Forms.Panel panel_database;
        private MetroFramework.Controls.MetroTile btn_databasereport;
        private Microsoft.Reporting.WinForms.ReportViewer DatabaseReportView;
        private System.Windows.Forms.Label lbl_database_Operation;
        private System.Windows.Forms.Label lbl_emp_id;
        private System.Windows.Forms.TextBox txt_database_EID;
        private MetroFramework.Controls.MetroComboBox cmb_search_operation;
        private MetroFramework.Controls.MetroTile btn_database_search;
        private System.Windows.Forms.Panel panel_login_report;
        private System.Windows.Forms.Label lbl_login_operation;
        private System.Windows.Forms.Label lbl_login_EID;
        private System.Windows.Forms.TextBox txt_login_EID;
        private MetroFramework.Controls.MetroComboBox cmb_login_operation;
        private MetroFramework.Controls.MetroTile btn_login_search;
        private System.Windows.Forms.Panel panel_sell_report;
        private Microsoft.Reporting.WinForms.ReportViewer SellesReportViewer;
        private System.Windows.Forms.TextBox txt_selles_EID;
        private MetroFramework.Controls.MetroTile btn_sells_search;
        private System.Windows.Forms.Label lbl_sells_brands;
        private System.Windows.Forms.Label lbl_sells_EID;
        private Microsoft.Reporting.WinForms.ReportViewer LogingReportViewer;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.BindingSource Sales_recordsBindingSource;
        private sellerSell sellerSell;
        private sellerSellTableAdapters.Sales_recordsTableAdapter Sales_recordsTableAdapter;
        private System.Windows.Forms.BindingSource Employee_recordsBindingSource;
        private LoginReport LoginReport;
        private LoginReportTableAdapters.Employee_recordsTableAdapter Employee_recordsTableAdapter;
        private System.Windows.Forms.BindingSource Database_recordsBindingSource;
        private DataBaseReport DataBaseReport;
        private DataBaseReportTableAdapters.Database_recordsTableAdapter Database_recordsTableAdapter;
    }
}