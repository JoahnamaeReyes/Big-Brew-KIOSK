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
    public partial class STAFFfrm : Form
    {
        public STAFFfrm()
        {
            InitializeComponent();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LogInfrm f = new LogInfrm();
                f.Show();
                this.Hide();
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            StaffOrder frm1 = new StaffOrder();
            frm1.TopLevel = false;
            mainpanelStaff.Controls.Add(frm1);
            frm1.BringToFront();
            frm1.Show();
        }

        private void btnSaleSTAFF_Click(object sender, EventArgs e)
        {
            SALES_UI frm = new SALES_UI();
            mainpanelStaff.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void saleS_staff1_Load(object sender, EventArgs e)
        {
            label4.Text = ModelSelectedUser.username;
        }
    }
}
