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
using DispensaryManagementSystem;
using MetroFramework.Forms;


namespace WF1BillingSystem
{
    public partial class Access : MetroForm
    {
        private DataAccess Da { get; set; }
        public Access()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateAccess();
        }
        private void PopulateAccess(string sql = "select userid,name, [contact no] ,position from login where position not in ('admin')")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvAccess.DataSource = ds.Tables[0];
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAccess.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a employee first to remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var id = this.dgvAccess.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to remove", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "delete from login where userID = '" + id + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data remove failed");
                this.PopulateAccess();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "select userid,name, [contact no] , position from login where UserID = '" + this.txtSearch.Text.Trim() + "';";
                var dt = this.Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    this.PopulateAccess(sql);
                }
                else
                {
                    string sqlS = "select userid,name, [contact no] , position from login where userId like '__" + this.txtSearch.Text.Trim() + "%';";
                    this.PopulateAccess(sqlS);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.txtPosition.Text) || String.IsNullOrEmpty(this.txtPassword.Text))

                return false;
            else
                return true;
        }
        private void ClearContent()
        {
            this.txtUserID.Clear();
            this.txtName.Clear();
            this.txtPosition.Clear();
            this.txtContactNo.Clear();
            this.txtPassword.Clear();
            this.txtSearch.Clear();
            this.dgvAccess.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill up all the values");
                    return;
                }

                var query = "select * from login where UserID = '" + this.txtUserID.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    return;
                }
                else if (dt.Rows.Count == 0)
                {
                    var sql = "insert into Login values('" + this.txtUserID.Text + "','" + this.txtName.Text + "','" + this.txtPosition.Text + "','" + this.txtContactNo.Text + "','" + this.txtPassword.Text + "')";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Added Properly");
                    else
                        MessageBox.Show("Data insertion failure");
                }

                this.PopulateAccess();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void dgvAccess_DoubleClick(object sender, EventArgs e)
        {

            var id = this.dgvAccess.CurrentRow.Cells[0].Value.ToString();
            var name = this.dgvAccess.CurrentRow.Cells["Name"].Value.ToString();
            var position = this.dgvAccess.CurrentRow.Cells["position"].Value.ToString();
            this.txtContactNo.Text = this.dgvAccess.CurrentRow.Cells["Contact No"].Value.ToString();


            this.txtPosition.Text = position;
            this.txtUserID.Text = id;
            this.txtName.Text = name;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.dgvAccess.SelectedRows.Count < 1)
            {
                var query = "select * from login where UserId = '" + this.txtUserID.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = "update Login set Position = '" + this.txtPosition.Text + "', [Contact No] ='" + this.txtContactNo.Text + "'  where UserID = '" + this.txtUserID.Text + "'";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                this.PopulateAccess();

                this.ClearContent();
                return;
            }

            try
            {
                var id = this.dgvAccess.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvAccess.CurrentRow.Cells["Name"].Value.ToString();
                var position = this.dgvAccess.CurrentRow.Cells["position"].Value.ToString();
                //this.txtContactNo.Text = this.dgvAccess.CurrentRow.Cells["Contact No"].Value.ToString();
               // this.txtPosition.Text = position;
                this.txtUserID.Text = id;
                this.txtName.Text = name;

                DialogResult dr = MessageBox.Show("Are you sure you want to edit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "update Login set Position = '" + this.txtPosition.Text + "', [Contact No] ='" + this.txtContactNo.Text + "'  where UserID = '" + this.txtUserID.Text + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been edited from the list.");
                else
                    MessageBox.Show("Employeee data edit failed");

                this.PopulateAccess();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

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
    }
}

