using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WF1BillingSystem
{
    public partial class Admin : MetroForm
    {
        private string id;
        private string password;
        public Admin()
        {
            InitializeComponent();
            pnlAdmin.Visible = true;
        }
        public Admin(string id, string password)
        {
            InitializeComponent();
            pnlAdmin.Visible = true;
            this.id = id;
            this.password = password;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            pnlChangePass.Height = 23;
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (pnlChangePass.Height == 53)
            {
                pnlChangePass.Height = 23;
            }
            else
            {
                pnlChangePass.Height = 53;
            }
            pnlChangePass.Visible = true;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(this.id, this.password, this);
            change.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(this);
            menu.Show();
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

        private void btnAccess_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            access.Show();
            this.Hide();
        }
    }
}
