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
    public partial class SellReport : MetroForm
    {
        private Admin admin { get; set; }
        private Manager manager { get; set; }
        private DataAccess Da { get; set; }
        public SellReport()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateSellReport();
            this.PerDaySellReport();
        }
        public SellReport(Admin admin) : this()
        {
            this.admin = admin;
        }
        public SellReport(Manager manager) : this()
        {
            this.manager = manager;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (admin != null)
                admin.Show();
            else
                manager.Show();
            this.Hide();
        }
        public void PopulateSellReport(string sql = "select * from Receipt")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvSellReport.DataSource = ds.Tables[0];
            this.PerDaySellReport();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvSellReport.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var id = this.dgvSellReport.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "delete from Receipt where InvoiceNumber = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateSellReport();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Receipt where InvoiceNumber like '___" + this.txtSearch.Text + "%';";
            this.PopulateSellReport(sql);
        }

        private void PerDaySellReport()
        {
            var sql = "select date from Receipt order by date desc";
            var dt = this.Da.ExecuteQuery(sql);
            var date = dt.Tables[0].Rows[0][0].ToString();
            string[] s = date.Split('/');
            string day = s[1];
            string month = s[0];
            var sql1 = "select sum(totalamount) from receipt where date like '__" + day + "%'";
            var ds = this.Da.ExecuteScalarQuery(sql1);
            this.txtPerDay.Text = ds;
            int previousDay = Convert.ToInt32(s[1]);
            previousDay--;
            var sql2 = "select sum(totalamount) from receipt where date like '__" + previousDay.ToString() + "%'";
            var ds1 = this.Da.ExecuteScalarQuery(sql2);
            this.txtPrevDay.Text = ds1;
            var sql3 = "select sum(totalamount) from receipt where date like '" + month + "%'";
            var ds3 = this.Da.ExecuteScalarQuery(sql3);
            this.txtMonth.Text = ds3;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}
