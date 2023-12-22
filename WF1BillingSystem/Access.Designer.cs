namespace WF1BillingSystem
{
    partial class Access
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
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.panelAccess = new MetroFramework.Controls.MetroPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.panelAccessLeft = new MetroFramework.Controls.MetroPanel();
            this.txtContactNo = new MetroFramework.Controls.MetroTextBox();
            this.lblContactNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnModify = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtPosition = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserID = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblPosition = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.panelAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.panelAccessLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(37, 546);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelAccess
            // 
            this.panelAccess.BackColor = System.Drawing.Color.DarkOrange;
            this.panelAccess.Controls.Add(this.label4);
            this.panelAccess.Controls.Add(this.btnLogout);
            this.panelAccess.Controls.Add(this.txtSearch);
            this.panelAccess.Controls.Add(this.btnRemove);
            this.panelAccess.Controls.Add(this.btnSearch);
            this.panelAccess.Controls.Add(this.dgvAccess);
            this.panelAccess.CustomBackground = true;
            this.panelAccess.HorizontalScrollbarBarColor = true;
            this.panelAccess.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAccess.HorizontalScrollbarSize = 6;
            this.panelAccess.Location = new System.Drawing.Point(320, -1);
            this.panelAccess.Margin = new System.Windows.Forms.Padding(2);
            this.panelAccess.Name = "panelAccess";
            this.panelAccess.Size = new System.Drawing.Size(721, 602);
            this.panelAccess.TabIndex = 3;
            this.panelAccess.VerticalScrollbarBarColor = true;
            this.panelAccess.VerticalScrollbarHighlightOnWheel = false;
            this.panelAccess.VerticalScrollbarSize = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(38, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "*Search by UserID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(612, 546);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(78, 33);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Wheat;
            this.txtSearch.CustomBackground = true;
            this.txtSearch.CustomForeColor = true;
            this.txtSearch.Location = new System.Drawing.Point(42, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 23);
            this.txtSearch.TabIndex = 14;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(593, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAccess
            // 
            this.dgvAccess.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Location = new System.Drawing.Point(42, 94);
            this.dgvAccess.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.RowHeadersWidth = 82;
            this.dgvAccess.RowTemplate.Height = 33;
            this.dgvAccess.Size = new System.Drawing.Size(648, 418);
            this.dgvAccess.TabIndex = 3;
            this.dgvAccess.DoubleClick += new System.EventHandler(this.dgvAccess_DoubleClick);
            // 
            // panelAccessLeft
            // 
            this.panelAccessLeft.BackColor = System.Drawing.Color.DarkOrange;
            this.panelAccessLeft.Controls.Add(this.btnExit);
            this.panelAccessLeft.Controls.Add(this.txtContactNo);
            this.panelAccessLeft.Controls.Add(this.lblContactNo);
            this.panelAccessLeft.Controls.Add(this.metroLabel1);
            this.panelAccessLeft.Controls.Add(this.dateTimePicker1);
            this.panelAccessLeft.Controls.Add(this.btnAdd);
            this.panelAccessLeft.Controls.Add(this.btnModify);
            this.panelAccessLeft.Controls.Add(this.txtName);
            this.panelAccessLeft.Controls.Add(this.txtPosition);
            this.panelAccessLeft.Controls.Add(this.btnBack);
            this.panelAccessLeft.Controls.Add(this.txtPassword);
            this.panelAccessLeft.Controls.Add(this.txtUserID);
            this.panelAccessLeft.Controls.Add(this.lblPassword);
            this.panelAccessLeft.Controls.Add(this.lblPosition);
            this.panelAccessLeft.Controls.Add(this.lblName);
            this.panelAccessLeft.Controls.Add(this.lblUserID);
            this.panelAccessLeft.CustomBackground = true;
            this.panelAccessLeft.HorizontalScrollbarBarColor = true;
            this.panelAccessLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAccessLeft.HorizontalScrollbarSize = 6;
            this.panelAccessLeft.Location = new System.Drawing.Point(-1, -1);
            this.panelAccessLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelAccessLeft.Name = "panelAccessLeft";
            this.panelAccessLeft.Size = new System.Drawing.Size(330, 602);
            this.panelAccessLeft.TabIndex = 5;
            this.panelAccessLeft.VerticalScrollbarBarColor = true;
            this.panelAccessLeft.VerticalScrollbarHighlightOnWheel = false;
            this.panelAccessLeft.VerticalScrollbarSize = 7;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.Wheat;
            this.txtContactNo.CustomBackground = true;
            this.txtContactNo.CustomForeColor = true;
            this.txtContactNo.Location = new System.Drawing.Point(154, 334);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(143, 25);
            this.txtContactNo.TabIndex = 15;
            // 
            // lblContactNo
            // 
            this.lblContactNo.BackColor = System.Drawing.Color.PeachPuff;
            this.lblContactNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContactNo.CustomBackground = true;
            this.lblContactNo.CustomForeColor = true;
            this.lblContactNo.Location = new System.Drawing.Point(37, 334);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(97, 25);
            this.lblContactNo.TabIndex = 14;
            this.lblContactNo.Text = "Contact No";
            this.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.PeachPuff;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(37, 59);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(260, 80);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Employee Access \r\nand Information";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 159);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(154, 435);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(143, 23);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Modify";
            this.btnModify.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Wheat;
            this.txtName.CustomBackground = true;
            this.txtName.CustomForeColor = true;
            this.txtName.Location = new System.Drawing.Point(154, 244);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 25);
            this.txtName.TabIndex = 9;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.Wheat;
            this.txtPosition.CustomBackground = true;
            this.txtPosition.CustomForeColor = true;
            this.txtPosition.Location = new System.Drawing.Point(154, 289);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(143, 25);
            this.txtPosition.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Wheat;
            this.txtPassword.CustomBackground = true;
            this.txtPassword.CustomForeColor = true;
            this.txtPassword.Location = new System.Drawing.Point(154, 379);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 25);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Wheat;
            this.txtUserID.CustomBackground = true;
            this.txtUserID.CustomForeColor = true;
            this.txtUserID.Location = new System.Drawing.Point(154, 199);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(143, 25);
            this.txtUserID.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.PeachPuff;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassword.CustomBackground = true;
            this.lblPassword.CustomForeColor = true;
            this.lblPassword.Location = new System.Drawing.Point(37, 379);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.PeachPuff;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosition.CustomBackground = true;
            this.lblPosition.CustomForeColor = true;
            this.lblPosition.Location = new System.Drawing.Point(37, 289);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(97, 25);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.PeachPuff;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.CustomBackground = true;
            this.lblName.CustomForeColor = true;
            this.lblName.Location = new System.Drawing.Point(37, 244);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.PeachPuff;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserID.CustomBackground = true;
            this.lblUserID.CustomForeColor = true;
            this.lblUserID.Location = new System.Drawing.Point(37, 199);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(97, 25);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "UserID";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(154, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.panelAccessLeft);
            this.Controls.Add(this.panelAccess);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Access";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.panelAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.panelAccessLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroPanel panelAccess;
        private System.Windows.Forms.DataGridView dgvAccess;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroPanel panelAccessLeft;
        private MetroFramework.Controls.MetroTextBox txtUserID;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblPosition;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtPosition;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnModify;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTextBox txtContactNo;
        private MetroFramework.Controls.MetroLabel lblContactNo;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}