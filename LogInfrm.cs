using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BIGBREWdaw
{
    public partial class LogInfrm : Form
    {
        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BIGB.mdb";

        public LogInfrm()
        {
            InitializeComponent();
        }

     
        private void btnLOGIN_Click(object sender, EventArgs e)
        {

            string username = tbUN.Text;
            string password = tbPASS.Text;

          
            string query = "SELECT * FROM Useracc WHERE Username = ? AND [Password] = ?";
            using (OleDbConnection con = new OleDbConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("?", username);
                            adapter.SelectCommand.Parameters.AddWithValue("?", password);
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];

                                Auth.user = row;

                                string role = row["Role"].ToString();
                                ModelSelectedUser.username = username;
                                ModelSelectedUser.role = role;
                                if (role == "Admin")
                                {
                                    MessageBox.Show("Welcome Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ADMINfrm ADMIN = new ADMINfrm();
                                    this.Hide();
                                    ADMIN.ShowDialog();
                                    this.Show();

                                }

                                else if (role == "Staff")
                                {
                                    MessageBox.Show("Welcome Staff!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    STAFFfrm staff = new STAFFfrm();
                                    this.Hide();
                                    staff.ShowDialog();
                                    this.Show();
                                }
                                else if (role == "Customer")
                                {
                                    MessageBox.Show("Customize Order", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    TAPTOORDER custo = new TAPTOORDER();
                                    this.Hide();
                                    custo.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid role", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cbSP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSP.Checked)
            {
                tbPASS.UseSystemPasswordChar = false;
            }
            else
            {
                tbPASS.UseSystemPasswordChar = true;
            }
        }

        private void LogInfrm_Load(object sender, EventArgs e)
        {

        }
    }
}