using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DispensaryManagementSystem;
using MetroFramework.Forms;

namespace WF1BillingSystem
{
    public partial class Billing : MetroForm
    {
        private string Amount { get; set; }
        private string invoiceNumber { get; set; }
        private DataAccess Da { get; set; }
        public Billing()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.AutoIdGenerate();
        }

        private void PopulateMenu(string sql = "select * from Menu")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.DgvBill.DataSource = ds.Tables[0];
        }
        private void PopulateTBill(string sql = "select * from TBill")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvReceipt.DataSource = ds.Tables[0];
        }
        private void Billing_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtCustomerInfo.Text) || String.IsNullOrEmpty(this.txtTotalAmount.Text) ||
                this.txtTotalAmount.Text == "0")

                return false;
            else
                return true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            this.ClearContant();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.ClearContant();
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "select FoodID, FoodName, FoodPrice from Menu where FoodName = '" + this.txtSearch.Text + "';";
                var dt = this.Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    this.PopulateMenu(sql);
                }
                else
                {
                    string sqlS = "select FoodID, FoodName, FoodPrice from Menu where FoodName like '" + this.txtSearch.Text + "%';";
                    this.PopulateMenu(sqlS);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }


        private void txtAdd_Click(object sender, EventArgs e)
        {
            if (this.DgvBill.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a Row first to Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string id = this.DgvBill.CurrentRow.Cells[0].Value.ToString();
                string name = this.DgvBill.CurrentRow.Cells["FoodName"].Value.ToString();
                Amount = this.DgvBill.CurrentRow.Cells["FoodPrice"].Value.ToString();
                string price = (Convert.ToInt32(Amount) * Convert.ToInt32(this.txtQuantity.Text)).ToString();

                var sql = "insert into TBill values('" + id + "','" + name + "','" + this.txtQuantity.Text + "'," + Amount + ",'" + price + "')";

                int count = this.Da.ExecuteDMLQuery(sql);
                this.totalAmount();

                this.PopulateTBill();
                this.txtQuantity.Text = "01";
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvReceipt.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var id = this.dgvReceipt.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "delete from TBill where FoodID = '" + id + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data remove failed");
                this.totalAmount();
                this.PopulateTBill();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.dgvReceipt.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a Row first to Modify", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var id = this.dgvReceipt.CurrentRow.Cells[0].Value.ToString();
                Amount = this.dgvReceipt.CurrentRow.Cells["FoodPrice"].Value.ToString();
                string price = (Convert.ToInt32(Amount) * Convert.ToInt32(this.txtQuantity.Text)).ToString();
                var name = this.dgvReceipt.CurrentRow.Cells["FoodName"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to Modify", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "update TBill set Quantity='" + this.txtQuantity.Text + "' , amount = '" + price + "'where FoodID = '" + id + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been modified from the list.");
                else
                    MessageBox.Show("Data modify failed");
                this.totalAmount();

                this.PopulateTBill();
                this.txtQuantity.Text = "01";
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void AutoIdGenerate()
        {
            var q = "select InvoiceNumber from Receipt order by InvoiceNumber desc;";
            var dt = this.Da.ExecuteQuery(q);
            var lastId = dt.Tables[0].Rows[0][0].ToString();
            string[] s = lastId.Split('#');
            int temp = Convert.ToInt32(s[1]);
            invoiceNumber = "IV#" + (++temp).ToString("d3");
            this.txtInvoice.Text = invoiceNumber;
        }

        internal void ClearContant()
        {
            var sql = "delete from TBill";
            var dml = this.Da.ExecuteDMLQuery(sql);
            this.PopulateTBill();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContant();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (IsValidToSave())
            {
                Receipt receipt = new Receipt(invoiceNumber, this.txtCustomerInfo.Text, this.txtTotalAmount.Text);
                receipt.Show();
                this.Close();
            }

            else if (String.IsNullOrEmpty(txtCustomerInfo.Text))
                MessageBox.Show("Add cutomer information to make a bill");
            else
                MessageBox.Show("Add Food to make a bill");

        }

        internal void totalAmount()
        {
            var cmd = "select sum(amount) from TBill ";
            var dt = this.Da.ExecuteScalarQuery(cmd);
            this.txtTotalAmount.Text = dt;

        }

    }
}

