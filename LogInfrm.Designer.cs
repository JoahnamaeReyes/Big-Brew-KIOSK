namespace BIGBREWdaw
{
    partial class LogInfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSP = new System.Windows.Forms.CheckBox();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.tbPASS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(69, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // cbSP
            // 
            this.cbSP.AutoSize = true;
            this.cbSP.BackColor = System.Drawing.Color.Transparent;
            this.cbSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSP.Location = new System.Drawing.Point(254, 439);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(129, 21);
            this.cbSP.TabIndex = 62;
            this.cbSP.Text = "Show Password";
            this.cbSP.UseVisualStyleBackColor = false;
            this.cbSP.CheckedChanged += new System.EventHandler(this.cbSP_CheckedChanged);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.Tan;
            this.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGIN.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLOGIN.Location = new System.Drawing.Point(112, 528);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(229, 42);
            this.btnLOGIN.TabIndex = 61;
            this.btnLOGIN.Text = "LOG IN";
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(112, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(229, 43);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(69, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Password";
            // 
            // tbUN
            // 
            this.tbUN.Location = new System.Drawing.Point(73, 355);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(310, 22);
            this.tbUN.TabIndex = 57;
            // 
            // tbPASS
            // 
            this.tbPASS.Location = new System.Drawing.Point(73, 411);
            this.tbPASS.Name = "tbPASS";
            this.tbPASS.Size = new System.Drawing.Size(310, 22);
            this.tbPASS.TabIndex = 60;
            this.tbPASS.UseSystemPasswordChar = true;
            // 
            // LogInfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(450, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbSP);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUN);
            this.Controls.Add(this.tbPASS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Brew";
            this.Load += new System.EventHandler(this.LogInfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbSP;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.TextBox tbPASS;
    }
}

