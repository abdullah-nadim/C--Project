namespace WF1BillingSystem
{
    partial class SellReport
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.pnlSellReport = new MetroFramework.Controls.MetroPanel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new MetroFramework.Controls.MetroTextBox();
            this.txtPerDay = new MetroFramework.Controls.MetroTextBox();
            this.txtPrevDay = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.dgvSellReport = new System.Windows.Forms.DataGridView();
            this.pnlSellReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(569, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSellReport
            // 
            this.pnlSellReport.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlSellReport.Controls.Add(this.btnExit);
            this.pnlSellReport.Controls.Add(this.btnLogout);
            this.pnlSellReport.Controls.Add(this.label3);
            this.pnlSellReport.Controls.Add(this.label2);
            this.pnlSellReport.Controls.Add(this.label4);
            this.pnlSellReport.Controls.Add(this.label1);
            this.pnlSellReport.Controls.Add(this.txtMonth);
            this.pnlSellReport.Controls.Add(this.txtPerDay);
            this.pnlSellReport.Controls.Add(this.txtPrevDay);
            this.pnlSellReport.Controls.Add(this.txtSearch);
            this.pnlSellReport.Controls.Add(this.btnBack);
            this.pnlSellReport.Controls.Add(this.dgvSellReport);
            this.pnlSellReport.Controls.Add(this.dateTimePicker1);
            this.pnlSellReport.Controls.Add(this.btnSearch);
            this.pnlSellReport.Controls.Add(this.btnDelete);
            this.pnlSellReport.CustomBackground = true;
            this.pnlSellReport.HorizontalScrollbarBarColor = true;
            this.pnlSellReport.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSellReport.HorizontalScrollbarSize = 10;
            this.pnlSellReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSellReport.Name = "pnlSellReport";
            this.pnlSellReport.Size = new System.Drawing.Size(1040, 600);
            this.pnlSellReport.TabIndex = 3;
            this.pnlSellReport.VerticalScrollbarBarColor = true;
            this.pnlSellReport.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSellReport.VerticalScrollbarSize = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(940, 546);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(78, 33);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 290);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monthly Sale Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(757, 211);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Previous Day\'s Sale Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(150, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Search by Invoice No.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(753, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Today\'s Sale Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(757, 330);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(200, 25);
            this.txtMonth.TabIndex = 5;
            // 
            // txtPerDay
            // 
            this.txtPerDay.Location = new System.Drawing.Point(757, 163);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(200, 25);
            this.txtPerDay.TabIndex = 5;
            // 
            // txtPrevDay
            // 
            this.txtPrevDay.Location = new System.Drawing.Point(757, 242);
            this.txtPrevDay.Name = "txtPrevDay";
            this.txtPrevDay.Size = new System.Drawing.Size(200, 25);
            this.txtPrevDay.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(154, 546);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvSellReport
            // 
            this.dgvSellReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellReport.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvSellReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellReport.Location = new System.Drawing.Point(154, 135);
            this.dgvSellReport.Name = "dgvSellReport";
            this.dgvSellReport.RowHeadersWidth = 51;
            this.dgvSellReport.RowTemplate.Height = 24;
            this.dgvSellReport.Size = new System.Drawing.Size(490, 384);
            this.dgvSellReport.TabIndex = 3;
            // 
            // SellReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlSellReport);
            this.Name = "SellReport";
//            this.Load += new System.EventHandler(this.SellReport_Load);
            this.pnlSellReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroPanel pnlSellReport;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.DataGridView dgvSellReport;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtMonth;
        private MetroFramework.Controls.MetroTextBox txtPerDay;
        private MetroFramework.Controls.MetroTextBox txtPrevDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.Label label4;
    }
}