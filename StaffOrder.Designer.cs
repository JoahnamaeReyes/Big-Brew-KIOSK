namespace BIGBREWdaw
{
    partial class StaffOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPLACEORDER = new System.Windows.Forms.Button();
            this.btnREMOVE = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.dgvOrders);
            this.panel1.Location = new System.Drawing.Point(31, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 594);
            this.panel1.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.total,
            this.date,
            this.time});
            this.dgvOrders.Location = new System.Drawing.Point(16, 16);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1085, 564);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            this.dgvOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrders_RowHeaderMouseClick);
            // 
            // orderID
            // 
            this.orderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderID.HeaderText = "Order ID";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1021, 656);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPLACEORDER
            // 
            this.btnPLACEORDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPLACEORDER.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPLACEORDER.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLACEORDER.ForeColor = System.Drawing.Color.White;
            this.btnPLACEORDER.Location = new System.Drawing.Point(883, 656);
            this.btnPLACEORDER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPLACEORDER.Name = "btnPLACEORDER";
            this.btnPLACEORDER.Size = new System.Drawing.Size(132, 44);
            this.btnPLACEORDER.TabIndex = 2;
            this.btnPLACEORDER.Text = "Place Order";
            this.btnPLACEORDER.UseVisualStyleBackColor = false;
            this.btnPLACEORDER.Visible = false;
            this.btnPLACEORDER.Click += new System.EventHandler(this.btnPLACEORDER_Click);
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnREMOVE.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREMOVE.ForeColor = System.Drawing.Color.White;
            this.btnREMOVE.Location = new System.Drawing.Point(31, 656);
            this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.Size = new System.Drawing.Size(107, 44);
            this.btnREMOVE.TabIndex = 3;
            this.btnREMOVE.Text = "Remove";
            this.btnREMOVE.UseVisualStyleBackColor = false;
            this.btnREMOVE.Visible = false;
            this.btnREMOVE.Click += new System.EventHandler(this.btnREMOVE_Click);
            // 
            // btnViewItems
            // 
            this.btnViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewItems.BackColor = System.Drawing.Color.White;
            this.btnViewItems.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewItems.ForeColor = System.Drawing.Color.Black;
            this.btnViewItems.Location = new System.Drawing.Point(31, 11);
            this.btnViewItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(185, 38);
            this.btnViewItems.TabIndex = 4;
            this.btnViewItems.Text = "View Ordered Items";
            this.btnViewItems.UseVisualStyleBackColor = false;
            this.btnViewItems.Visible = false;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // StaffOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 711);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnREMOVE);
            this.Controls.Add(this.btnPLACEORDER);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffOrder";
            this.Text = "StaffOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPLACEORDER;
        private System.Windows.Forms.Button btnREMOVE;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}