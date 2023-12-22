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
    public partial class Menu : MetroForm
    {
        private Admin admin { get; set; }
        private Manager manager { get; set; }
        private DataAccess Da { get; set; }
        public Menu()
        {

            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateMenu();
        }
        public Menu(Admin admin) : this()
        {
            this.admin = admin;
        }
        public Menu(Manager manager) : this()
        {
            this.manager = manager;
        }

        private void PopulateMenu(string sql = "select * from Menu")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvMenu.DataSource = ds.Tables[0];
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (admin != null)
                admin.Show();
            else
                manager.Show();
            this.Hide();
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
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtFoodID.Text) || String.IsNullOrEmpty(this.txtFoodName.Text) ||
                String.IsNullOrEmpty(this.txtFoodPrice.Text) || String.IsNullOrEmpty(this.cmbFoodCategory.Text))

                return false;
            else
                return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill up all the values");
                    return;
                }

                var query = "select * from Menu where FoodID = '" + this.txtFoodID.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update operation
                    var sql = @"update Menu
                                set FoodName = " + this.txtFoodName.Text + @",
                                FoodPrice = " + this.txtFoodPrice.Text + @",
                                FoodCategory = '" + this.cmbFoodCategory.Text + @"',
                                where FoodID = '" + this.txtFoodID.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else if (dt.Rows.Count == 0)
                {
                    //insert operation
                    var sql = "insert into Menu values('" + this.txtFoodID.Text + "','" + this.txtFoodName.Text + "','" + this.txtFoodPrice.Text + "','" + this.cmbFoodCategory.Text + "')";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Added Properly");
                    else
                        MessageBox.Show("Data insertion failure");
                }

                this.PopulateMenu();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void ClearContent()
        {
            this.txtFoodID.Clear();
            this.txtFoodName.Clear();
            this.txtFoodPrice.Clear();
            this.cmbFoodCategory.SelectedIndex = -1;

            this.txtSearch.Clear();

            this.dgvMenu.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMenu.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var id = this.dgvMenu.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvMenu.CurrentRow.Cells["FoodName"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "delete from Menu where FoodID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateMenu();
                this.ClearContent();
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

                string sql = "select * from Menu where FoodName = '" + this.txtSearch.Text + "';";
                var dt = this.Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    this.PopulateMenu(sql);
                }
                else
                {
                    string sqlS = "select * from Menu where FoodName like '" + this.txtSearch.Text + "%';";
                    this.PopulateMenu(sqlS);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (this.dgvMenu.SelectedRows.Count < 1)
            {
                var query = "select * from Menu where FoodID = '" + this.txtFoodID.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = "update Menu set FoodPrice = " + this.txtFoodPrice.Text + " where FoodID = '" + this.txtFoodID.Text + "'";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                this.PopulateMenu();
                return;
            }

            try
            {
                var id = this.dgvMenu.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvMenu.CurrentRow.Cells["FoodName"].Value.ToString();
                var price = this.dgvMenu.CurrentRow.Cells["FoodPrice"].Value.ToString();

                //this.txtFoodPrice.Text = price;
                this.txtFoodID.Text = id;
                this.txtFoodName.Text = name;

                DialogResult dr = MessageBox.Show("Are you sure you want to edit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }

                var query = "update Menu set FoodPrice = " + this.txtFoodPrice.Text + " where FoodID = '" + id + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been edited from the list.");
                else
                    MessageBox.Show("Data edit failed");

                this.PopulateMenu();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void dgvMenu_DoubleClick(object sender, EventArgs e)
        {
            var id = this.dgvMenu.CurrentRow.Cells[0].Value.ToString();
            var name = this.dgvMenu.CurrentRow.Cells["FoodName"].Value.ToString();
            var price = this.dgvMenu.CurrentRow.Cells["FoodPrice"].Value.ToString();

            this.txtFoodPrice.Text = price;
            this.txtFoodID.Text = id;
            this.txtFoodName.Text = name;
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateMenu();
        }
    }
}
