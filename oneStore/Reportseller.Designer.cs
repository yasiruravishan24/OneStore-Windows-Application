
namespace oneStore
{
    partial class Reportseller
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.report_pb = new System.Windows.Forms.PictureBox();
            this.lbl_reports = new System.Windows.Forms.Label();
            this.btn_sell_report = new MetroFramework.Controls.MetroTile();
            this.btn_employee_report = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.report_control = new JDragControl.JDragControl(this.components);
            this.panel_login = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.cmb_login = new MetroFramework.Controls.MetroComboBox();
            this.login_report_view = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_login_report = new MetroFramework.Controls.MetroTile();
            this.panel_sell = new System.Windows.Forms.Panel();
            this.selles_reportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.btn_sells_search = new MetroFramework.Controls.MetroTile();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.Sales_recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellsReport = new oneStore.SellsReport();
            this.Sales_recordsTableAdapter = new oneStore.SellsReportTableAdapters.Sales_recordsTableAdapter();
            this.sellerLogin = new oneStore.sellerLogin();
            this.Employee_recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Employee_recordsTableAdapter = new oneStore.sellerLoginTableAdapters.Employee_recordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.report_pb)).BeginInit();
            this.panel_login.SuspendLayout();
            this.panel_sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sales_recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_recordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report_pb
            // 
            this.report_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.report_pb.Location = new System.Drawing.Point(0, 0);
            this.report_pb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.report_pb.Name = "report_pb";
            this.report_pb.Size = new System.Drawing.Size(1231, 679);
            this.report_pb.TabIndex = 0;
            this.report_pb.TabStop = false;
            // 
            // lbl_reports
            // 
            this.lbl_reports.AutoSize = true;
            this.lbl_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reports.Location = new System.Drawing.Point(313, 17);
            this.lbl_reports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reports.Name = "lbl_reports";
            this.lbl_reports.Size = new System.Drawing.Size(167, 46);
            this.lbl_reports.TabIndex = 1;
            this.lbl_reports.Text = "Reports";
            // 
            // btn_sell_report
            // 
            this.btn_sell_report.ActiveControl = null;
            this.btn_sell_report.Location = new System.Drawing.Point(16, 89);
            this.btn_sell_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sell_report.Name = "btn_sell_report";
            this.btn_sell_report.Size = new System.Drawing.Size(271, 62);
            this.btn_sell_report.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sell_report.TabIndex = 2;
            this.btn_sell_report.Text = "Sells Report";
            this.btn_sell_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sell_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sell_report.UseSelectable = true;
            this.btn_sell_report.Click += new System.EventHandler(this.btn_sell_report_Click);
            // 
            // btn_employee_report
            // 
            this.btn_employee_report.ActiveControl = null;
            this.btn_employee_report.Location = new System.Drawing.Point(16, 158);
            this.btn_employee_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_employee_report.Name = "btn_employee_report";
            this.btn_employee_report.Size = new System.Drawing.Size(271, 62);
            this.btn_employee_report.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_employee_report.TabIndex = 2;
            this.btn_employee_report.Text = "Login Reports";
            this.btn_employee_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_employee_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_employee_report.UseSelectable = true;
            this.btn_employee_report.Click += new System.EventHandler(this.btn_employee_report_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(35, 530);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = global::oneStore.Properties.Resources.minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(1129, 2);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(43, 39);
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
            this.btn_exit.Location = new System.Drawing.Point(1177, 2);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(43, 39);
            this.btn_exit.TabIndex = 3;
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
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Red;
            this.panel_login.Controls.Add(this.lbl_login);
            this.panel_login.Controls.Add(this.cmb_login);
            this.panel_login.Controls.Add(this.login_report_view);
            this.panel_login.Controls.Add(this.btn_login_report);
            this.panel_login.Location = new System.Drawing.Point(313, 89);
            this.panel_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(907, 576);
            this.panel_login.TabIndex = 4;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(51, 23);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(142, 31);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Operation";
            // 
            // cmb_login
            // 
            this.cmb_login.FormattingEnabled = true;
            this.cmb_login.ItemHeight = 23;
            this.cmb_login.Items.AddRange(new object[] {
            "Login",
            "Logout"});
            this.cmb_login.Location = new System.Drawing.Point(233, 20);
            this.cmb_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_login.Name = "cmb_login";
            this.cmb_login.Size = new System.Drawing.Size(437, 29);
            this.cmb_login.TabIndex = 1;
            this.cmb_login.UseSelectable = true;
            // 
            // login_report_view
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Employee_recordsBindingSource;
            this.login_report_view.LocalReport.DataSources.Add(reportDataSource2);
            this.login_report_view.LocalReport.ReportEmbeddedResource = "oneStore.Charana.rdlc";
            this.login_report_view.Location = new System.Drawing.Point(4, 69);
            this.login_report_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_report_view.Name = "login_report_view";
            this.login_report_view.ServerReport.BearerToken = null;
            this.login_report_view.Size = new System.Drawing.Size(898, 499);
            this.login_report_view.TabIndex = 0;
            // 
            // btn_login_report
            // 
            this.btn_login_report.ActiveControl = null;
            this.btn_login_report.Location = new System.Drawing.Point(695, 10);
            this.btn_login_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login_report.Name = "btn_login_report";
            this.btn_login_report.Size = new System.Drawing.Size(177, 52);
            this.btn_login_report.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_login_report.TabIndex = 2;
            this.btn_login_report.Text = "SEARCH";
            this.btn_login_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_login_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_login_report.UseSelectable = true;
            this.btn_login_report.Click += new System.EventHandler(this.btn_login_report_Click);
            // 
            // panel_sell
            // 
            this.panel_sell.BackColor = System.Drawing.Color.Red;
            this.panel_sell.Controls.Add(this.txt_ProductID);
            this.panel_sell.Controls.Add(this.selles_reportView);
            this.panel_sell.Controls.Add(this.lbl_brand);
            this.panel_sell.Controls.Add(this.btn_sells_search);
            this.panel_sell.Location = new System.Drawing.Point(313, 89);
            this.panel_sell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_sell.Name = "panel_sell";
            this.panel_sell.Size = new System.Drawing.Size(907, 576);
            this.panel_sell.TabIndex = 5;
            // 
            // selles_reportView
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sales_recordsBindingSource;
            this.selles_reportView.LocalReport.DataSources.Add(reportDataSource1);
            this.selles_reportView.LocalReport.ReportEmbeddedResource = "oneStore.Oshan.rdlc";
            this.selles_reportView.Location = new System.Drawing.Point(4, 69);
            this.selles_reportView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selles_reportView.Name = "selles_reportView";
            this.selles_reportView.ServerReport.BearerToken = null;
            this.selles_reportView.Size = new System.Drawing.Size(898, 499);
            this.selles_reportView.TabIndex = 4;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.Location = new System.Drawing.Point(72, 16);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(153, 31);
            this.lbl_brand.TabIndex = 3;
            this.lbl_brand.Text = "Product ID";
            // 
            // btn_sells_search
            // 
            this.btn_sells_search.ActiveControl = null;
            this.btn_sells_search.Location = new System.Drawing.Point(695, 10);
            this.btn_sells_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // txt_ProductID
            // 
            this.txt_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductID.Location = new System.Drawing.Point(275, 16);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(359, 38);
            this.txt_ProductID.TabIndex = 5;
            // 
            // Sales_recordsBindingSource
            // 
            this.Sales_recordsBindingSource.DataMember = "Sales_records";
            this.Sales_recordsBindingSource.DataSource = this.SellsReport;
            // 
            // SellsReport
            // 
            this.SellsReport.DataSetName = "SellsReport";
            this.SellsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sales_recordsTableAdapter
            // 
            this.Sales_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // sellerLogin
            // 
            this.sellerLogin.DataSetName = "sellerLogin";
            this.sellerLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employee_recordsBindingSource
            // 
            this.Employee_recordsBindingSource.DataMember = "Employee_records";
            this.Employee_recordsBindingSource.DataSource = this.sellerLogin;
            // 
            // Employee_recordsTableAdapter
            // 
            this.Employee_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // Reportseller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 679);
            this.Controls.Add(this.panel_sell);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_employee_report);
            this.Controls.Add(this.btn_sell_report);
            this.Controls.Add(this.lbl_reports);
            this.Controls.Add(this.report_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reportseller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportseller";
            this.Load += new System.EventHandler(this.Reportseller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_pb)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_sell.ResumeLayout(false);
            this.panel_sell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sales_recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_recordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox report_pb;
        private System.Windows.Forms.Label lbl_reports;
        private MetroFramework.Controls.MetroTile btn_sell_report;
        private MetroFramework.Controls.MetroTile btn_employee_report;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl report_control;
        private System.Windows.Forms.Panel panel_login;
        private Microsoft.Reporting.WinForms.ReportViewer login_report_view;
        private MetroFramework.Controls.MetroComboBox cmb_login;
        private MetroFramework.Controls.MetroTile btn_login_report;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Panel panel_sell;
        private Microsoft.Reporting.WinForms.ReportViewer selles_reportView;
        private System.Windows.Forms.Label lbl_brand;
        private MetroFramework.Controls.MetroTile btn_sells_search;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.BindingSource Sales_recordsBindingSource;
        private SellsReport SellsReport;
        private SellsReportTableAdapters.Sales_recordsTableAdapter Sales_recordsTableAdapter;
        private System.Windows.Forms.BindingSource Employee_recordsBindingSource;
        private sellerLogin sellerLogin;
        private sellerLoginTableAdapters.Employee_recordsTableAdapter Employee_recordsTableAdapter;
    }
}