namespace WF1BillingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLogin = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.txtUserID = new MetroFramework.Controls.MetroTextBox();
            this.lvlPassword = new MetroFramework.Controls.MetroLabel();
            this.lvlUserID = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnView);
            this.pnlLogin.Controls.Add(this.txtUserID);
            this.pnlLogin.Controls.Add(this.lvlPassword);
            this.pnlLogin.Controls.Add(this.lvlUserID);
            this.pnlLogin.Controls.Add(this.btnClear);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.picLogin);
            this.pnlLogin.CustomBackground = true;
            this.pnlLogin.HorizontalScrollbarBarColor = true;
            this.pnlLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLogin.HorizontalScrollbarSize = 10;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1040, 600);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.VerticalScrollbarBarColor = true;
            this.pnlLogin.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLogin.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fat Chef restaurant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Wheat;
            this.txtPassword.Location = new System.Drawing.Point(441, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(706, 260);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Wheat;
            this.txtUserID.CustomBackground = true;
            this.txtUserID.Location = new System.Drawing.Point(441, 215);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(248, 23);
            this.txtUserID.TabIndex = 1;
            // 
            // lvlPassword
            // 
            this.lvlPassword.AutoSize = true;
            this.lvlPassword.BackColor = System.Drawing.Color.DarkOrange;
            this.lvlPassword.CustomBackground = true;
            this.lvlPassword.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lvlPassword.Location = new System.Drawing.Point(288, 260);
            this.lvlPassword.Name = "lvlPassword";
            this.lvlPassword.Size = new System.Drawing.Size(76, 20);
            this.lvlPassword.TabIndex = 5;
            this.lvlPassword.Text = "Password";
            // 
            // lvlUserID
            // 
            this.lvlUserID.AutoSize = true;
            this.lvlUserID.CustomBackground = true;
            this.lvlUserID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lvlUserID.Location = new System.Drawing.Point(288, 218);
            this.lvlUserID.Name = "lvlUserID";
            this.lvlUserID.Size = new System.Drawing.Size(57, 20);
            this.lvlUserID.TabIndex = 4;
            this.lvlUserID.Text = "UserID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(614, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(367, 403);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(0, 0);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(1074, 637);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 7;
            this.picLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Login";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlLogin;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtUserID;
        private MetroFramework.Controls.MetroLabel lvlPassword;
        private MetroFramework.Controls.MetroLabel lvlUserID;
        private MetroFramework.Controls.MetroButton btnView;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label label1;
    }
}

