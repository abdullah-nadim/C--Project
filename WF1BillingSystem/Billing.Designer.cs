namespace WF1BillingSystem
{
    partial class Billing
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
            this.pnlBilling = new MetroFramework.Controls.MetroPanel();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerInfo = new MetroFramework.Controls.MetroTextBox();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnModify = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.txtAdd = new MetroFramework.Controls.MetroButton();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtInvoice = new MetroFramework.Controls.MetroTextBox();
            this.DgvBill = new System.Windows.Forms.DataGridView();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.pnlBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBilling
            // 
            this.pnlBilling.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlBilling.Controls.Add(this.txtQuantity);
            this.pnlBilling.Controls.Add(this.label5);
            this.pnlBilling.Controls.Add(this.label4);
            this.pnlBilling.Controls.Add(this.label3);
            this.pnlBilling.Controls.Add(this.label2);
            this.pnlBilling.Controls.Add(this.label1);
            this.pnlBilling.Controls.Add(this.txtTotalAmount);
            this.pnlBilling.Controls.Add(this.txtCustomerInfo);
            this.pnlBilling.Controls.Add(this.btnPrint);
            this.pnlBilling.Controls.Add(this.btnClear);
            this.pnlBilling.Controls.Add(this.btnModify);
            this.pnlBilling.Controls.Add(this.btnDelete);
            this.pnlBilling.Controls.Add(this.dgvReceipt);
            this.pnlBilling.Controls.Add(this.txtAdd);
            this.pnlBilling.Controls.Add(this.dateTime);
            this.pnlBilling.Controls.Add(this.txtInvoice);
            this.pnlBilling.Controls.Add(this.DgvBill);
            this.pnlBilling.Controls.Add(this.txtSearch);
            this.pnlBilling.Controls.Add(this.btnSearch);
            this.pnlBilling.Controls.Add(this.btnExit);
            this.pnlBilling.Controls.Add(this.btnBack);
            this.pnlBilling.CustomBackground = true;
            this.pnlBilling.HorizontalScrollbarBarColor = true;
            this.pnlBilling.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBilling.HorizontalScrollbarSize = 10;
            this.pnlBilling.Location = new System.Drawing.Point(0, 0);
            this.pnlBilling.Name = "pnlBilling";
            this.pnlBilling.Size = new System.Drawing.Size(1040, 600);
            this.pnlBilling.TabIndex = 0;
            this.pnlBilling.VerticalScrollbarBarColor = true;
            this.pnlBilling.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBilling.VerticalScrollbarSize = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(823, 107);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 22);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Customer Info";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Invoice Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "*Search by Food Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(876, 487);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(83, 23);
            this.txtTotalAmount.TabIndex = 23;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(249, 64);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(180, 23);
            this.txtCustomerInfo.TabIndex = 22;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(823, 554);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(529, 511);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Location = new System.Drawing.Point(81, 236);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(878, 245);
            this.dgvReceipt.TabIndex = 16;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(884, 106);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(75, 23);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "Add";
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(709, 65);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(250, 22);
            this.dateTime.TabIndex = 15;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(81, 64);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(109, 23);
            this.txtInvoice.TabIndex = 14;
            // 
            // DgvBill
            // 
            this.DgvBill.AllowUserToAddRows = false;
            this.DgvBill.AllowUserToDeleteRows = false;
            this.DgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBill.BackgroundColor = System.Drawing.Color.OldLace;
            this.DgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBill.Location = new System.Drawing.Point(81, 174);
            this.DgvBill.Name = "DgvBill";
            this.DgvBill.ReadOnly = true;
            this.DgvBill.RowHeadersWidth = 51;
            this.DgvBill.RowTemplate.Height = 24;
            this.DgvBill.Size = new System.Drawing.Size(878, 62);
            this.DgvBill.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(81, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 23);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(940, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 554);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlBilling);
            this.Name = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.pnlBilling.ResumeLayout(false);
            this.pnlBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBilling;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.DataGridView DgvBill;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.DateTimePicker dateTime;
        private MetroFramework.Controls.MetroTextBox txtInvoice;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private MetroFramework.Controls.MetroButton txtAdd;
        private MetroFramework.Controls.MetroButton btnModify;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroTextBox txtCustomerInfo;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.NumericUpDown txtQuantity;
    }
}