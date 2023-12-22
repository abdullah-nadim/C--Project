using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WF1BillingSystem
{
    public partial class Manager : MetroForm
    {
        private string id;
        private string password;
        public Manager()
        {
            InitializeComponent();
            pnlManager.Visible = true;
        }
        public Manager(string id, string password)
        {
            InitializeComponent();
            pnlManager.Visible = true;
            this.id = id;
            this.password = password;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            pnlChnagePass.Height = 25;
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

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            if (pnlChnagePass.Height == 54)
            {
                pnlChnagePass.Height = 25;
            }
            else
            {
                pnlChnagePass.Height = 54;
            }
        }

        private void BtnChnagePass_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(this.id, this.password, this);
            change.Show();
            this.Hide();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(this);
            menu.Show();
            this.Hide();
        }

        private void BtnBilling_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void BtnSellReport_Click(object sender, EventArgs e)
        {
            SellReport sellReport = new SellReport(this);
            sellReport.Show();
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
