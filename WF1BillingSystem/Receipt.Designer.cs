namespace WF1BillingSystem
{
    partial class Receipt
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
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.txtInvoice = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerInfo = new MetroFramework.Controls.MetroTextBox();
            this.pnlReceipt = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.pnlReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Location = new System.Drawing.Point(138, 141);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(765, 381);
            this.dgvReceipt.TabIndex = 4;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(138, 101);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(89, 25);
            this.txtInvoice.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(634, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(335, 101);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(229, 25);
            this.txtCustomerInfo.TabIndex = 8;
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlReceipt.Controls.Add(this.label3);
            this.pnlReceipt.Controls.Add(this.label2);
            this.pnlReceipt.Controls.Add(this.label4);
            this.pnlReceipt.Controls.Add(this.label1);
            this.pnlReceipt.Controls.Add(this.metroTextBox1);
            this.pnlReceipt.Controls.Add(this.txtTotalAmount);
            this.pnlReceipt.Controls.Add(this.txtCustomerInfo);
            this.pnlReceipt.Controls.Add(this.dateTimePicker1);
            this.pnlReceipt.Controls.Add(this.btnExit);
            this.pnlReceipt.Controls.Add(this.txtInvoice);
            this.pnlReceipt.Controls.Add(this.dgvReceipt);
            this.pnlReceipt.CustomBackground = true;
            this.pnlReceipt.HorizontalScrollbarBarColor = true;
            this.pnlReceipt.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlReceipt.HorizontalScrollbarSize = 10;
            this.pnlReceipt.Location = new System.Drawing.Point(0, 0);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.Size = new System.Drawing.Size(1040, 600);
            this.pnlReceipt.TabIndex = 9;
            this.pnlReceipt.VerticalScrollbarBarColor = true;
            this.pnlReceipt.VerticalScrollbarHighlightOnWheel = false;
            this.pnlReceipt.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fat Chef restaurant";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Invoice";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(1191, 952);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.Size = new System.Drawing.Size(116, 25);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.Text = "Total";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(787, 528);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(116, 25);
            this.txtTotalAmount.TabIndex = 9;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlReceipt);
            this.Name = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private MetroFramework.Controls.MetroTextBox txtInvoice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox txtCustomerInfo;
        private MetroFramework.Controls.MetroPanel pnlReceipt;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label3;
    }
}