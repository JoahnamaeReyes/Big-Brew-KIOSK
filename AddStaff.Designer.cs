namespace BIGBREWdaw
{
    partial class AddStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbID_admin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUPDATE_admin = new System.Windows.Forms.Button();
            this.btnDELETE_admin = new System.Windows.Forms.Button();
            this.btnCLEAR_admin = new System.Windows.Forms.Button();
            this.cbROLE_admin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPASS_admin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUN_admin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnADD_admin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(979, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(192, 22);
            this.tbSearch.TabIndex = 24;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(918, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.dgview);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(371, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 614);
            this.panel2.TabIndex = 23;
            // 
            // dgview
            // 
            this.dgview.AllowUserToDeleteRows = false;
            this.dgview.AllowUserToOrderColumns = true;
            this.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgview.Location = new System.Drawing.Point(6, 28);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 24;
            this.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview.Size = new System.Drawing.Size(791, 563);
            this.dgview.TabIndex = 1;
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.tbID_admin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnUPDATE_admin);
            this.panel1.Controls.Add(this.btnDELETE_admin);
            this.panel1.Controls.Add(this.btnCLEAR_admin);
            this.panel1.Controls.Add(this.cbROLE_admin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbPASS_admin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbUN_admin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 706);
            this.panel1.TabIndex = 22;
            // 
            // tbID_admin
            // 
            this.tbID_admin.Location = new System.Drawing.Point(104, 220);
            this.tbID_admin.Name = "tbID_admin";
            this.tbID_admin.Size = new System.Drawing.Size(192, 27);
            this.tbID_admin.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "User ID";
            // 
            // btnUPDATE_admin
            // 
            this.btnUPDATE_admin.BackColor = System.Drawing.Color.Tan;
            this.btnUPDATE_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUPDATE_admin.Location = new System.Drawing.Point(17, 627);
            this.btnUPDATE_admin.Name = "btnUPDATE_admin";
            this.btnUPDATE_admin.Size = new System.Drawing.Size(95, 34);
            this.btnUPDATE_admin.TabIndex = 11;
            this.btnUPDATE_admin.Text = "UPDATE";
            this.btnUPDATE_admin.UseVisualStyleBackColor = false;
            this.btnUPDATE_admin.Click += new System.EventHandler(this.btnUPDATE_admin_Click);
            // 
            // btnDELETE_admin
            // 
            this.btnDELETE_admin.BackColor = System.Drawing.Color.Tan;
            this.btnDELETE_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE_admin.Location = new System.Drawing.Point(229, 627);
            this.btnDELETE_admin.Name = "btnDELETE_admin";
            this.btnDELETE_admin.Size = new System.Drawing.Size(105, 34);
            this.btnDELETE_admin.TabIndex = 10;
            this.btnDELETE_admin.Text = "DELETE";
            this.btnDELETE_admin.UseVisualStyleBackColor = false;
            this.btnDELETE_admin.Click += new System.EventHandler(this.btnDELETE_admin_Click);
            // 
            // btnCLEAR_admin
            // 
            this.btnCLEAR_admin.BackColor = System.Drawing.Color.Tan;
            this.btnCLEAR_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLEAR_admin.Location = new System.Drawing.Point(118, 627);
            this.btnCLEAR_admin.Name = "btnCLEAR_admin";
            this.btnCLEAR_admin.Size = new System.Drawing.Size(105, 34);
            this.btnCLEAR_admin.TabIndex = 9;
            this.btnCLEAR_admin.Text = "CLEAR";
            this.btnCLEAR_admin.UseVisualStyleBackColor = false;
            this.btnCLEAR_admin.Click += new System.EventHandler(this.btnCLEAR_admin_Click);
            // 
            // cbROLE_admin
            // 
            this.cbROLE_admin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbROLE_admin.FormattingEnabled = true;
            this.cbROLE_admin.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbROLE_admin.Location = new System.Drawing.Point(104, 319);
            this.cbROLE_admin.Name = "cbROLE_admin";
            this.cbROLE_admin.Size = new System.Drawing.Size(192, 31);
            this.cbROLE_admin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role";
            // 
            // tbPASS_admin
            // 
            this.tbPASS_admin.Location = new System.Drawing.Point(104, 286);
            this.tbPASS_admin.Name = "tbPASS_admin";
            this.tbPASS_admin.Size = new System.Drawing.Size(192, 27);
            this.tbPASS_admin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // tbUN_admin
            // 
            this.tbUN_admin.Location = new System.Drawing.Point(104, 253);
            this.tbUN_admin.Name = "tbUN_admin";
            this.tbUN_admin.Size = new System.Drawing.Size(192, 27);
            this.tbUN_admin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // btnADD_admin
            // 
            this.btnADD_admin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnADD_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD_admin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD_admin.Location = new System.Drawing.Point(1037, 668);
            this.btnADD_admin.Name = "btnADD_admin";
            this.btnADD_admin.Size = new System.Drawing.Size(131, 31);
            this.btnADD_admin.TabIndex = 2;
            this.btnADD_admin.Text = "+ Add New ";
            this.btnADD_admin.UseVisualStyleBackColor = false;
            this.btnADD_admin.Click += new System.EventHandler(this.btnADD_admin_Click);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 709);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnADD_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbID_admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUPDATE_admin;
        private System.Windows.Forms.Button btnDELETE_admin;
        private System.Windows.Forms.Button btnCLEAR_admin;
        private System.Windows.Forms.ComboBox cbROLE_admin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPASS_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUN_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnADD_admin;
    }
}