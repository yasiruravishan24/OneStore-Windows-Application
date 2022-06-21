
namespace oneStore
{
    partial class Splash
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
            this.splash_timer = new System.Windows.Forms.Timer(this.components);
            this.sp_bar_panel = new System.Windows.Forms.Panel();
            this.sp_pro_bar = new MetroFramework.Controls.MetroProgressBar();
            this.pic_splash = new System.Windows.Forms.PictureBox();
            this.ArduioUnoPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_timer
            // 
            this.splash_timer.Enabled = true;
            this.splash_timer.Tick += new System.EventHandler(this.splash_timer_Tick);
            // 
            // sp_bar_panel
            // 
            this.sp_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sp_bar_panel.Location = new System.Drawing.Point(229, 420);
            this.sp_bar_panel.Name = "sp_bar_panel";
            this.sp_bar_panel.Size = new System.Drawing.Size(540, 15);
            this.sp_bar_panel.TabIndex = 2;
            // 
            // sp_pro_bar
            // 
            this.sp_pro_bar.Location = new System.Drawing.Point(229, 421);
            this.sp_pro_bar.Name = "sp_pro_bar";
            this.sp_pro_bar.Size = new System.Drawing.Size(540, 15);
            this.sp_pro_bar.TabIndex = 0;
            this.sp_pro_bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sp_pro_bar.UseCustomBackColor = true;
            // 
            // pic_splash
            // 
            this.pic_splash.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_splash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_splash.Image = global::oneStore.Properties.Resources.sp;
            this.pic_splash.Location = new System.Drawing.Point(0, 0);
            this.pic_splash.Name = "pic_splash";
            this.pic_splash.Size = new System.Drawing.Size(784, 461);
            this.pic_splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_splash.TabIndex = 0;
            this.pic_splash.TabStop = false;
            // 
            // ArduioUnoPort
            // 
            this.ArduioUnoPort.PortName = "COM4";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.sp_pro_bar);
            this.Controls.Add(this.sp_bar_panel);
            this.Controls.Add(this.pic_splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_splash;
        private System.Windows.Forms.Timer splash_timer;
        private System.Windows.Forms.Panel sp_bar_panel;
        private MetroFramework.Controls.MetroProgressBar sp_pro_bar;
        private System.IO.Ports.SerialPort ArduioUnoPort;
    }
}

