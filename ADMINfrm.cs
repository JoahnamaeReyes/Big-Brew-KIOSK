using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIGBREWdaw
{
    public partial class ADMINfrm : Form
    {
        public ADMINfrm()
        {
            InitializeComponent();
        }

      

        private void btnADDUSER_Click(object sender, EventArgs e)
        {
            AddStaff frm2 = new AddStaff();
            frm2.TopLevel = false;
            mainpanel.Controls.Add(frm2);
            frm2.BringToFront();
            frm2.Show();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            AdminProduct frm = new AdminProduct();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LogInfrm F1 = new LogInfrm();
                F1.Show();
                this.Hide();
            }
        }

        private void ADMINfrm_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = ModelSelectedUser.username;
            SALES_UI frm = new SALES_UI();
            mainpanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnSALES_Admin_Click(object sender, EventArgs e)
        {
            SALES_UI frm = new SALES_UI();
            mainpanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
