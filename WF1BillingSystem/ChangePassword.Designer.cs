namespace WF1BillingSystem
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.pnlPaasword = new MetroFramework.Controls.MetroPanel();
            this.txtOldPass = new MetroFramework.Controls.MetroTextBox();
            this.lblOldPass = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnChange = new MetroFramework.Controls.MetroButton();
            this.txtConfirm = new MetroFramework.Controls.MetroTextBox();
            this.txtNew = new MetroFramework.Controls.MetroTextBox();
            this.lvlConfirmPass = new MetroFramework.Controls.MetroLabel();
            this.lvlNewPass = new MetroFramework.Controls.MetroLabel();
            this.picChangePass = new System.Windows.Forms.PictureBox();
            this.pnlPaasword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChangePass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaasword
            // 
            this.pnlPaasword.Controls.Add(this.txtOldPass);
            this.pnlPaasword.Controls.Add(this.lblOldPass);
            this.pnlPaasword.Controls.Add(this.btnBack);
            this.pnlPaasword.Controls.Add(this.btnChange);
            this.pnlPaasword.Controls.Add(this.txtConfirm);
            this.pnlPaasword.Controls.Add(this.txtNew);
            this.pnlPaasword.Controls.Add(this.lvlConfirmPass);
            this.pnlPaasword.Controls.Add(this.lvlNewPass);
            this.pnlPaasword.Controls.Add(this.picChangePass);
            this.pnlPaasword.HorizontalScrollbarBarColor = true;
            this.pnlPaasword.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPaasword.HorizontalScrollbarSize = 10;
            this.pnlPaasword.Location = new System.Drawing.Point(0, 0);
            this.pnlPaasword.Name = "pnlPaasword";
            this.pnlPaasword.Size = new System.Drawing.Size(1040, 600);
            this.pnlPaasword.TabIndex = 0;
            this.pnlPaasword.VerticalScrollbarBarColor = true;
            this.pnlPaasword.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPaasword.VerticalScrollbarSize = 10;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(751, 210);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '●';
            this.txtOldPass.Size = new System.Drawing.Size(221, 23);
            this.txtOldPass.TabIndex = 10;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOldPass.Location = new System.Drawing.Point(549, 213);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(104, 20);
            this.lblOldPass.TabIndex = 9;
            this.lblOldPass.Text = "Old Password";
            this.lblOldPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 554);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 25);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(700, 418);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(92, 25);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(751, 337);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '●';
            this.txtConfirm.Size = new System.Drawing.Size(221, 23);
            this.txtConfirm.TabIndex = 6;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(751, 275);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '●';
            this.txtNew.Size = new System.Drawing.Size(221, 23);
            this.txtNew.TabIndex = 5;
            this.txtNew.UseSystemPasswordChar = true;
//            this.txtNew.Click += new System.EventHandler(this.txtNew_Click);
            // 
            // lvlConfirmPass
            // 
            this.lvlConfirmPass.AutoSize = true;
            this.lvlConfirmPass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lvlConfirmPass.Location = new System.Drawing.Point(549, 340);
            this.lvlConfirmPass.Name = "lvlConfirmPass";
            this.lvlConfirmPass.Size = new System.Drawing.Size(137, 20);
            this.lvlConfirmPass.TabIndex = 4;
            this.lvlConfirmPass.Text = "Confirm Password";
            this.lvlConfirmPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvlNewPass
            // 
            this.lvlNewPass.AutoSize = true;
            this.lvlNewPass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lvlNewPass.Location = new System.Drawing.Point(549, 278);
            this.lvlNewPass.Name = "lvlNewPass";
            this.lvlNewPass.Size = new System.Drawing.Size(112, 20);
            this.lvlNewPass.TabIndex = 3;
            this.lvlNewPass.Text = "New Password";
            this.lvlNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picChangePass
            // 
            this.picChangePass.Image = ((System.Drawing.Image)(resources.GetObject("picChangePass.Image")));
            this.picChangePass.Location = new System.Drawing.Point(0, 0);
            this.picChangePass.Name = "picChangePass";
            this.picChangePass.Size = new System.Drawing.Size(1040, 600);
            this.picChangePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picChangePass.TabIndex = 11;
            this.picChangePass.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlPaasword);
            this.Name = "ChangePassword";
//            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.pnlPaasword.ResumeLayout(false);
            this.pnlPaasword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChangePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlPaasword;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnChange;
        private MetroFramework.Controls.MetroTextBox txtConfirm;
        private MetroFramework.Controls.MetroTextBox txtNew;
        private MetroFramework.Controls.MetroLabel lvlConfirmPass;
        private MetroFramework.Controls.MetroLabel lvlNewPass;
        private MetroFramework.Controls.MetroTextBox txtOldPass;
        private MetroFramework.Controls.MetroLabel lblOldPass;
        private System.Windows.Forms.PictureBox picChangePass;
    }
}