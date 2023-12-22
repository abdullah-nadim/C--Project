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
    public partial class Login : MetroForm
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide Both username And password.");
            }
            else
            {
                try
                {
                    string sql = "select * from Login where UserID = '" + this.txtUserID.Text + "' and Password = '" + this.txtPassword.Text + "'";
                    var dt = this.Da.ExecuteQuery(sql);
                    if (dt.Tables[0].Rows.Count == 1)
                    {
                        if (dt.Tables[0].Rows[0][2].ToString().Equals("Admin                                   "))
                        {
                            Admin admin = new Admin(this.txtUserID.Text, this.txtPassword.Text);
                            admin.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            Manager manager = new Manager(this.txtUserID.Text, this.txtPassword.Text);
                            manager.Visible = true;
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtUserID.Clear();
                        this.txtPassword.Clear();

                        this.txtUserID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();

            this.txtUserID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.UseSystemPasswordChar)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
