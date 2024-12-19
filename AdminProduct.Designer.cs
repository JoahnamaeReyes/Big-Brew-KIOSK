namespace BIGBREWdaw
{
    partial class AdminProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUPDATE_admin = new System.Windows.Forms.Button();
            this.btnDELETE_admin = new System.Windows.Forms.Button();
            this.btnCLEAR_admin = new System.Windows.Forms.Button();
            this.btnADD_admin = new System.Windows.Forms.Button();
            this.txtProductSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.pbInsert = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 380);
            this.panel1.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.photo,
            this.category_id,
            this.category,
            this.size,
            this.price,
            this.status,
            this.date});
            this.dgvProduct.Location = new System.Drawing.Point(8, 28);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1131, 335);
            this.dgvProduct.TabIndex = 33;
            this.dgvProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEnter);
            // 
            // productId
            // 
            this.productId.HeaderText = "Product ID";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // photo
            // 
            this.photo.HeaderText = "Photo";
            this.photo.MinimumWidth = 6;
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // category_id
            // 
            this.category_id.HeaderText = "Category ID";
            this.category_id.MinimumWidth = 6;
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            this.category_id.Visible = false;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date Created";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tan;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.nudProductPrice);
            this.panel2.Controls.Add(this.txtProductID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.pbInsert);
            this.panel2.Controls.Add(this.btnUPDATE_admin);
            this.panel2.Controls.Add(this.btnDELETE_admin);
            this.panel2.Controls.Add(this.btnCLEAR_admin);
            this.panel2.Controls.Add(this.btnADD_admin);
            this.panel2.Controls.Add(this.txtProductSize);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 441);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 257);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nudProductPrice
            // 
            this.nudProductPrice.DecimalPlaces = 2;
            this.nudProductPrice.Location = new System.Drawing.Point(451, 66);
            this.nudProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudProductPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudProductPrice.Name = "nudProductPrice";
            this.nudProductPrice.Size = new System.Drawing.Size(193, 22);
            this.nudProductPrice.TabIndex = 35;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(135, 38);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(192, 22);
            this.txtProductID.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Product ID";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Tan;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1039, 130);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Upload";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUPDATE_admin
            // 
            this.btnUPDATE_admin.BackColor = System.Drawing.Color.Tan;
            this.btnUPDATE_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUPDATE_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE_admin.Location = new System.Drawing.Point(79, 218);
            this.btnUPDATE_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUPDATE_admin.Name = "btnUPDATE_admin";
            this.btnUPDATE_admin.Size = new System.Drawing.Size(120, 30);
            this.btnUPDATE_admin.TabIndex = 29;
            this.btnUPDATE_admin.Text = "Update";
            this.btnUPDATE_admin.UseVisualStyleBackColor = false;
            this.btnUPDATE_admin.Click += new System.EventHandler(this.btnUPDATE_admin_Click);
            // 
            // btnDELETE_admin
            // 
            this.btnDELETE_admin.BackColor = System.Drawing.Color.Tan;
            this.btnDELETE_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE_admin.Location = new System.Drawing.Point(215, 218);
            this.btnDELETE_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDELETE_admin.Name = "btnDELETE_admin";
            this.btnDELETE_admin.Size = new System.Drawing.Size(121, 30);
            this.btnDELETE_admin.TabIndex = 28;
            this.btnDELETE_admin.Text = "Delete";
            this.btnDELETE_admin.UseVisualStyleBackColor = false;
            this.btnDELETE_admin.Click += new System.EventHandler(this.btnDELETE_admin_Click);
            // 
            // btnCLEAR_admin
            // 
            this.btnCLEAR_admin.BackColor = System.Drawing.Color.Tan;
            this.btnCLEAR_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLEAR_admin.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR_admin.Location = new System.Drawing.Point(355, 218);
            this.btnCLEAR_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCLEAR_admin.Name = "btnCLEAR_admin";
            this.btnCLEAR_admin.Size = new System.Drawing.Size(120, 30);
            this.btnCLEAR_admin.TabIndex = 27;
            this.btnCLEAR_admin.Text = "Clear";
            this.btnCLEAR_admin.UseVisualStyleBackColor = false;
            this.btnCLEAR_admin.Click += new System.EventHandler(this.btnCLEAR_admin_Click);
            // 
            // btnADD_admin
            // 
            this.btnADD_admin.BackColor = System.Drawing.Color.Tan;
            this.btnADD_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD_admin.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD_admin.Location = new System.Drawing.Point(1028, 212);
            this.btnADD_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD_admin.Name = "btnADD_admin";
            this.btnADD_admin.Size = new System.Drawing.Size(121, 30);
            this.btnADD_admin.TabIndex = 26;
            this.btnADD_admin.Text = "+ Add Product";
            this.btnADD_admin.UseVisualStyleBackColor = false;
            this.btnADD_admin.Click += new System.EventHandler(this.btnADD_admin_Click);
            // 
            // txtProductSize
            // 
            this.txtProductSize.Location = new System.Drawing.Point(451, 39);
            this.txtProductSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.Size = new System.Drawing.Size(192, 22);
            this.txtProductSize.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(135, 68);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(192, 22);
            this.txtProductName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Name";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbStatus.Location = new System.Drawing.Point(451, 103);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(192, 28);
            this.cmbStatus.TabIndex = 18;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_admin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Status";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(135, 103);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(192, 28);
            this.cmbCategory.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Category";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(979, 26);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(192, 22);
            this.tbSearch.TabIndex = 32;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(917, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Search";
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(12, 12);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(158, 37);
            this.buttonArchive.TabIndex = 34;
            this.buttonArchive.Text = "View Archive";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // pbInsert
            // 
            this.pbInsert.BackColor = System.Drawing.Color.Sienna;
            this.pbInsert.Location = new System.Drawing.Point(1039, 5);
            this.pbInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbInsert.Name = "pbInsert";
            this.pbInsert.Size = new System.Drawing.Size(100, 121);
            this.pbInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsert.TabIndex = 30;
            this.pbInsert.TabStop = false;
            this.pbInsert.Click += new System.EventHandler(this.pbInsert_Click);
            // 
            // AdminProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 709);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminProduct";
            this.Text = "AdminProduct";
            this.Load += new System.EventHandler(this.AdminProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInsert;
        private System.Windows.Forms.Button btnUPDATE_admin;
        private System.Windows.Forms.Button btnDELETE_admin;
        private System.Windows.Forms.Button btnCLEAR_admin;
        private System.Windows.Forms.Button btnADD_admin;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudProductPrice;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button buttonArchive;
    }
}