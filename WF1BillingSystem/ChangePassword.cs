using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DispensaryManagementSystem;
using MetroFramework.Forms;
namespace WF1BillingSystem
{
    public partial class ChangePassword : MetroForm
    {
        private string id;
        private string password;

        private Admin admin { get; set; }
        private Manager manager { get; set; }
        private DataAccess Da { get; set; }
        public ChangePassword()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            pnlPaasword.Visible = true;
        }

        public ChangePassword(string id, string password)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            pnlPaasword.Visible = true;
            this.id = id;
            this.password = password;
        }
        public ChangePassword(string id, string password, Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.Da = new DataAccess();
            pnlPaasword.Visible = true;
            this.id = id;
            this.password = password;
        }
        public ChangePassword(string id, string password, Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            this.Da = new DataAccess();
            pnlPaasword.Visible = true;
            this.id = id;
            this.password = password;
        }

        
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {


                if (this.txtNew.Text == this.txtConfirm.Text && this.txtNew.Text != "" && this.txtConfirm.Text != "")
                {
                    string sql = "update Login set Password = '" + txtNew.Text + "' where UserID = '" + this.id + "' and password='" + this.password + "'";
                    this.password = txtNew.Text;
                    var dt = this.Da.ExecuteDMLQuery(sql);
                    string sql1 = "select * from Login where UserID= '" + this.id + "' and Password = '" + txtNew.Text + "'";
                    var dt1 = this.Da.ExecuteQuery(sql1);
                    if (dt1.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Password changed!");
                    }
                    else
                    {
                        MessageBox.Show("Not changed!");
                    }

                }

                else
                {
                    MessageBox.Show("Not match!");
                }
                this.txtNew.Clear();
                this.txtConfirm.Clear();
                this.txtOldPass.Clear();
            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (admin != null)
                admin.Show();
            else
                manager.Show();
        }
    }
}
