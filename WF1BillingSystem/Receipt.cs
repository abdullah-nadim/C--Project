using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DispensaryManagementSystem;
using MetroFramework.Forms;

namespace WF1BillingSystem
{

    public partial class Receipt : MetroForm
    {
        private DataAccess Da { get; set; }
        public Receipt()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateTBill();
        }

        private void PopulateTBill(string sql = "select * from TBill")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvReceipt.DataSource = ds.Tables[0];
        }
        public Receipt(string invoiceNumber, string customerInfo, string totalAmount)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateTBill();
            this.txtCustomerInfo.Text = customerInfo;
            this.txtInvoice.Text = invoiceNumber;
            this.txtTotalAmount.Text = totalAmount;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            string sql = "insert into Receipt values('" + this.txtInvoice.Text + "','" + this.txtCustomerInfo.Text + "','" + DateTime.Now + "'," + this.txtTotalAmount.Text + ")";
            this.Da.ExecuteDMLQuery(sql);
            Billing billing = new Billing();
            billing.Show();
            billing.ClearContant();
            this.Close();

        }
        
    }
}

