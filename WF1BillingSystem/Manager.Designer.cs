namespace WF1BillingSystem
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pnlManager = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.BtnMenu = new MetroFramework.Controls.MetroButton();
            this.BtnSellReport = new MetroFramework.Controls.MetroButton();
            this.BtnBilling = new MetroFramework.Controls.MetroButton();
            this.pnlChnagePass = new MetroFramework.Controls.MetroPanel();
            this.BtnSetting = new MetroFramework.Controls.MetroButton();
            this.BtnChnagePass = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.pnlManager.SuspendLayout();
            this.pnlChnagePass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManager
            // 
            this.pnlManager.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlManager.Controls.Add(this.label2);
            this.pnlManager.Controls.Add(this.label1);
            this.pnlManager.Controls.Add(this.btnLogout);
            this.pnlManager.Controls.Add(this.BtnMenu);
            this.pnlManager.Controls.Add(this.BtnSellReport);
            this.pnlManager.Controls.Add(this.BtnBilling);
            this.pnlManager.Controls.Add(this.pnlChnagePass);
            this.pnlManager.Controls.Add(this.btnExit);
            this.pnlManager.Controls.Add(this.picManager);
            this.pnlManager.CustomBackground = true;
            this.pnlManager.HorizontalScrollbarBarColor = true;
            this.pnlManager.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlManager.HorizontalScrollbarSize = 10;
            this.pnlManager.Location = new System.Drawing.Point(0, 0);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(1040, 600);
            this.pnlManager.TabIndex = 0;
            this.pnlManager.VerticalScrollbarBarColor = true;
            this.pnlManager.VerticalScrollbarHighlightOnWheel = false;
            this.pnlManager.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manager Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME TO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(931, 555);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 25);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(370, 217);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(300, 50);
            this.BtnMenu.TabIndex = 5;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnSellReport
            // 
            this.BtnSellReport.Location = new System.Drawing.Point(370, 405);
            this.BtnSellReport.Name = "BtnSellReport";
            this.BtnSellReport.Size = new System.Drawing.Size(300, 50);
            this.BtnSellReport.TabIndex = 6;
            this.BtnSellReport.Text = "Sell Report";
            this.BtnSellReport.Click += new System.EventHandler(this.BtnSellReport_Click);
            // 
            // BtnBilling
            // 
            this.BtnBilling.Location = new System.Drawing.Point(370, 311);
            this.BtnBilling.Name = "BtnBilling";
            this.BtnBilling.Size = new System.Drawing.Size(300, 50);
            this.BtnBilling.TabIndex = 7;
            this.BtnBilling.Text = "Billing";
            this.BtnBilling.Click += new System.EventHandler(this.BtnBilling_Click);
            // 
            // pnlChnagePass
            // 
            this.pnlChnagePass.Controls.Add(this.BtnSetting);
            this.pnlChnagePass.Controls.Add(this.BtnChnagePass);
            this.pnlChnagePass.HorizontalScrollbarBarColor = true;
            this.pnlChnagePass.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlChnagePass.HorizontalScrollbarSize = 10;
            this.pnlChnagePass.Location = new System.Drawing.Point(902, 74);
            this.pnlChnagePass.Name = "pnlChnagePass";
            this.pnlChnagePass.Size = new System.Drawing.Size(115, 25);
            this.pnlChnagePass.TabIndex = 4;
            this.pnlChnagePass.VerticalScrollbarBarColor = true;
            this.pnlChnagePass.VerticalScrollbarHighlightOnWheel = false;
            this.pnlChnagePass.VerticalScrollbarSize = 10;
            // 
            // BtnSetting
            // 
            this.BtnSetting.Location = new System.Drawing.Point(0, 0);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(115, 25);
            this.BtnSetting.TabIndex = 4;
            this.BtnSetting.Text = "Setting";
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // BtnChnagePass
            // 
            this.BtnChnagePass.Location = new System.Drawing.Point(0, 29);
            this.BtnChnagePass.Name = "BtnChnagePass";
            this.BtnChnagePass.Size = new System.Drawing.Size(113, 23);
            this.BtnChnagePass.TabIndex = 3;
            this.BtnChnagePass.Text = "Change Password";
            this.BtnChnagePass.Click += new System.EventHandler(this.BtnChnagePass_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picManager
            // 
            this.picManager.Image = ((System.Drawing.Image)(resources.GetObject("picManager.Image")));
            this.picManager.Location = new System.Drawing.Point(-17, -18);
            this.picManager.Name = "picManager";
            this.picManager.Size = new System.Drawing.Size(1074, 637);
            this.picManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManager.TabIndex = 12;
            this.picManager.TabStop = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlManager);
            this.Name = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.pnlManager.ResumeLayout(false);
            this.pnlManager.PerformLayout();
            this.pnlChnagePass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlManager;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroPanel pnlChnagePass;
        private MetroFramework.Controls.MetroButton BtnSetting;
        private MetroFramework.Controls.MetroButton BtnChnagePass;
        private MetroFramework.Controls.MetroButton BtnMenu;
        private MetroFramework.Controls.MetroButton BtnSellReport;
        private MetroFramework.Controls.MetroButton BtnBilling;
        private MetroFramework.Controls.MetroButton btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picManager;
    }
}