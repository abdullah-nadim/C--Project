namespace WF1BillingSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pnlAdmin = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccess = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.BtnSellReport = new MetroFramework.Controls.MetroButton();
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.pnlChangePass = new MetroFramework.Controls.MetroPanel();
            this.btnChangePass = new MetroFramework.Controls.MetroButton();
            this.btnSetting = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.pnlAdmin.SuspendLayout();
            this.pnlChangePass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.btnAccess);
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.BtnSellReport);
            this.pnlAdmin.Controls.Add(this.btnMenu);
            this.pnlAdmin.Controls.Add(this.pnlChangePass);
            this.pnlAdmin.Controls.Add(this.btnExit);
            this.pnlAdmin.Controls.Add(this.picAdmin);
            this.pnlAdmin.CustomBackground = true;
            this.pnlAdmin.HorizontalScrollbarBarColor = true;
            this.pnlAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdmin.HorizontalScrollbarSize = 10;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1043, 600);
            this.pnlAdmin.TabIndex = 0;
            this.pnlAdmin.VerticalScrollbarBarColor = true;
            this.pnlAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdmin.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "WELCOME TO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(352, 299);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(339, 50);
            this.btnAccess.TabIndex = 8;
            this.btnAccess.Text = "Access";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(940, 554);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(78, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BtnSellReport
            // 
            this.BtnSellReport.Location = new System.Drawing.Point(351, 386);
            this.BtnSellReport.Name = "BtnSellReport";
            this.BtnSellReport.Size = new System.Drawing.Size(341, 50);
            this.BtnSellReport.TabIndex = 7;
            this.BtnSellReport.Text = "Sell Report";
            this.BtnSellReport.Click += new System.EventHandler(this.BtnSellReport_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(352, 212);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(339, 50);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.Controls.Add(this.btnChangePass);
            this.pnlChangePass.Controls.Add(this.btnSetting);
            this.pnlChangePass.HorizontalScrollbarBarColor = true;
            this.pnlChangePass.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlChangePass.HorizontalScrollbarSize = 10;
            this.pnlChangePass.Location = new System.Drawing.Point(915, 60);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(106, 25);
            this.pnlChangePass.TabIndex = 4;
            this.pnlChangePass.VerticalScrollbarBarColor = true;
            this.pnlChangePass.VerticalScrollbarHighlightOnWheel = false;
            this.pnlChangePass.VerticalScrollbarSize = 10;
            this.pnlChangePass.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(0, 29);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(103, 23);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(106, 25);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Setting";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(-16, -18);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(1096, 656);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 10;
            this.picAdmin.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlChangePass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlAdmin;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnSetting;
        private MetroFramework.Controls.MetroButton btnMenu;
        private MetroFramework.Controls.MetroButton BtnSellReport;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnAccess;
        private MetroFramework.Controls.MetroPanel pnlChangePass;
        private MetroFramework.Controls.MetroButton btnChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAdmin;
    }
}