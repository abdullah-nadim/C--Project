namespace WF1BillingSystem
{
    partial class Menu
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
            this.pnlMenuDGV = new MetroFramework.Controls.MetroPanel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.pnlCrud = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cmbFoodCategory = new MetroFramework.Controls.MetroComboBox();
            this.txtFoodID = new MetroFramework.Controls.MetroTextBox();
            this.txtFoodName = new MetroFramework.Controls.MetroTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtFoodPrice = new MetroFramework.Controls.MetroTextBox();
            this.lvlFoodPrice = new MetroFramework.Controls.MetroLabel();
            this.lvlFoodName = new MetroFramework.Controls.MetroLabel();
            this.lvlFoodCategory = new MetroFramework.Controls.MetroLabel();
            this.lvlFoodID = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnShowDetails = new MetroFramework.Controls.MetroButton();
            this.pnlMenuDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnlCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuDGV
            // 
            this.pnlMenuDGV.Controls.Add(this.dgvMenu);
            this.pnlMenuDGV.Controls.Add(this.pnlCrud);
            this.pnlMenuDGV.HorizontalScrollbarBarColor = true;
            this.pnlMenuDGV.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenuDGV.HorizontalScrollbarSize = 10;
            this.pnlMenuDGV.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuDGV.Name = "pnlMenuDGV";
            this.pnlMenuDGV.Size = new System.Drawing.Size(1040, 604);
            this.pnlMenuDGV.TabIndex = 0;
            this.pnlMenuDGV.VerticalScrollbarBarColor = true;
            this.pnlMenuDGV.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenuDGV.VerticalScrollbarSize = 10;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(515, 0);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(525, 601);
            this.dgvMenu.TabIndex = 11;
            this.dgvMenu.DoubleClick += new System.EventHandler(this.dgvMenu_DoubleClick);
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlCrud.Controls.Add(this.btnShowDetails);
            this.pnlCrud.Controls.Add(this.metroLabel1);
            this.pnlCrud.Controls.Add(this.btnClear);
            this.pnlCrud.Controls.Add(this.btnSave);
            this.pnlCrud.Controls.Add(this.cmbFoodCategory);
            this.pnlCrud.Controls.Add(this.txtFoodID);
            this.pnlCrud.Controls.Add(this.txtFoodName);
            this.pnlCrud.Controls.Add(this.btnEdit);
            this.pnlCrud.Controls.Add(this.txtSearch);
            this.pnlCrud.Controls.Add(this.btnDelete);
            this.pnlCrud.Controls.Add(this.btnSearch);
            this.pnlCrud.Controls.Add(this.txtFoodPrice);
            this.pnlCrud.Controls.Add(this.lvlFoodPrice);
            this.pnlCrud.Controls.Add(this.lvlFoodName);
            this.pnlCrud.Controls.Add(this.lvlFoodCategory);
            this.pnlCrud.Controls.Add(this.lvlFoodID);
            this.pnlCrud.Controls.Add(this.btnBack);
            this.pnlCrud.Controls.Add(this.btnExit);
            this.pnlCrud.CustomBackground = true;
            this.pnlCrud.HorizontalScrollbarBarColor = true;
            this.pnlCrud.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCrud.HorizontalScrollbarSize = 10;
            this.pnlCrud.Location = new System.Drawing.Point(0, 0);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(517, 604);
            this.pnlCrud.TabIndex = 11;
            this.pnlCrud.VerticalScrollbarBarColor = true;
            this.pnlCrud.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCrud.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 20);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "*Search by Food Name";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.ItemHeight = 24;
            this.cmbFoodCategory.Items.AddRange(new object[] {
            "Main Meal",
            "Drinks",
            "Dessert"});
            this.cmbFoodCategory.Location = new System.Drawing.Point(172, 323);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(175, 30);
            this.cmbFoodCategory.TabIndex = 24;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(173, 155);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(175, 25);
            this.txtFoodID.TabIndex = 23;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(173, 206);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(175, 25);
            this.txtFoodName.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(32, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(23, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 25);
            this.txtSearch.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 25);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(172, 267);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(175, 25);
            this.txtFoodPrice.TabIndex = 21;
            // 
            // lvlFoodPrice
            // 
            this.lvlFoodPrice.AutoSize = true;
            this.lvlFoodPrice.CustomBackground = true;
            this.lvlFoodPrice.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lvlFoodPrice.Location = new System.Drawing.Point(23, 267);
            this.lvlFoodPrice.Name = "lvlFoodPrice";
            this.lvlFoodPrice.Size = new System.Drawing.Size(79, 20);
            this.lvlFoodPrice.TabIndex = 19;
            this.lvlFoodPrice.Text = "Food Price";
            this.lvlFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvlFoodName
            // 
            this.lvlFoodName.AutoSize = true;
            this.lvlFoodName.CustomBackground = true;
            this.lvlFoodName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lvlFoodName.Location = new System.Drawing.Point(23, 211);
            this.lvlFoodName.Name = "lvlFoodName";
            this.lvlFoodName.Size = new System.Drawing.Size(87, 20);
            this.lvlFoodName.TabIndex = 18;
            this.lvlFoodName.Text = "Food Name";
            this.lvlFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvlFoodCategory
            // 
            this.lvlFoodCategory.AutoSize = true;
            this.lvlFoodCategory.CustomBackground = true;
            this.lvlFoodCategory.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lvlFoodCategory.Location = new System.Drawing.Point(23, 323);
            this.lvlFoodCategory.Name = "lvlFoodCategory";
            this.lvlFoodCategory.Size = new System.Drawing.Size(107, 20);
            this.lvlFoodCategory.TabIndex = 17;
            this.lvlFoodCategory.Text = "Food Category";
            this.lvlFoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvlFoodID
            // 
            this.lvlFoodID.AutoSize = true;
            this.lvlFoodID.CustomBackground = true;
            this.lvlFoodID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lvlFoodID.Location = new System.Drawing.Point(23, 155);
            this.lvlFoodID.Name = "lvlFoodID";
            this.lvlFoodID.Size = new System.Drawing.Size(62, 20);
            this.lvlFoodID.TabIndex = 15;
            this.lvlFoodID.Text = "Food ID";
            this.lvlFoodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 548);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(410, 548);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(393, 3);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(121, 23);
            this.btnShowDetails.TabIndex = 27;
            this.btnShowDetails.Text = "Sgow Details";
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlMenuDGV);
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenuDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMenuDGV;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMenu;
        private MetroFramework.Controls.MetroPanel pnlCrud;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel lvlFoodPrice;
        private MetroFramework.Controls.MetroLabel lvlFoodName;
        private MetroFramework.Controls.MetroLabel lvlFoodCategory;
        private MetroFramework.Controls.MetroLabel lvlFoodID;
        private MetroFramework.Controls.MetroComboBox cmbFoodCategory;
        private MetroFramework.Controls.MetroTextBox txtFoodID;
        private MetroFramework.Controls.MetroTextBox txtFoodName;
        private MetroFramework.Controls.MetroTextBox txtFoodPrice;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnShowDetails;
    }
}