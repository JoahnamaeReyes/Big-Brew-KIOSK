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
    public partial class StaffOrder : Form
    {
        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DbConnectionString);
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;

        public StaffOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderMenu frm = new OrderMenu();
            frm.ShowDialog();
            getOrders();
        }

        private void getOrders()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM [Orders] WHERE [status]='pending'";
                adapter = new OleDbDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);

                dgvOrders.Rows.Clear();
                
                foreach (DataRow row in dt.Rows)
                {
                    DateTime dt = DateTime.Parse(row["date_ordered"].ToString());
                    string date = dt.ToString("MMM. dd, yyyy");
                    string time = dt.ToString("HH:mm tt");
                    dgvOrders.Rows.Add(row["id"].ToString(), "P " + Convert.ToDouble(row["total_amount"].ToString()).ToString("N2"), date, time);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int selectedRowCount = dgvOrders.SelectedRows.Count;
                if (selectedRowCount > 0)
                {
                    for (int i = selectedRowCount - 1; i >= 0; i--)
                    {
                        int selectedRowIndex = dgvOrders.SelectedRows[i].Index;
                        int orderId = Convert.ToInt32(dgvOrders.Rows[selectedRowIndex].Cells["orderID"].Value.ToString());
                        string query = "DELETE FROM [Orders] WHERE [ID]=?";
                        using (cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", orderId);
                            cmd.ExecuteNonQuery();
                        }

                        dgvOrders.Rows.RemoveAt(selectedRowIndex);

                        query = "DELETE FROM [OrderLine] WHERE [order_id]=?";
                        using (cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", orderId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPLACEORDER_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int selectedRowCount = dgvOrders.SelectedRows.Count;
                if (selectedRowCount > 0)
                {
                    for (int i = selectedRowCount - 1; i >= 0; i--)
                    {
                        int selectedRowIndex = dgvOrders.SelectedRows[i].Index;
                        int orderId = Convert.ToInt32(dgvOrders.Rows[selectedRowIndex].Cells["orderID"].Value.ToString());
                        string query = "UPDATE [Orders] SET [status]='done' WHERE [ID]=?";
                        using(cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", orderId);
                            cmd.ExecuteNonQuery();
                        }

                        dgvOrders.Rows.RemoveAt(selectedRowIndex);

                        query = "INSERT INTO [Sales] ([order_id], [user_id]) VALUES (?, ?)";
                        using (cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", orderId);
                            cmd.Parameters.AddWithValue("?", Auth.user["ID"].ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Placed Order Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void StaffOrder_Load(object sender, EventArgs e)
        {
            getOrders();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnViewItems.Visible = dgvOrders.SelectedRows.Count == 1;
            btnPLACEORDER.Visible = dgvOrders.SelectedRows.Count > 0;
            btnREMOVE.Visible = dgvOrders.SelectedRows.Count > 0;
        }

        private void dgvOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnViewItems.Visible = dgvOrders.SelectedRows.Count == 1;
            btnPLACEORDER.Visible = dgvOrders.SelectedRows.Count > 0;
            btnREMOVE.Visible = dgvOrders.SelectedRows.Count > 0;
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            OrderItems f = new OrderItems();
            int selectedRowIndex = dgvOrders.SelectedRows[0].Index;
            int orderId = Convert.ToInt32(dgvOrders.Rows[selectedRowIndex].Cells["orderID"].Value.ToString());
            double total_amount = Convert.ToDouble(dgvOrders.Rows[selectedRowIndex].Cells["total"].Value.ToString().Replace("P ", ""));
            f.orderId = orderId;
            f.total_amount = total_amount;
            f.ShowDialog();
        }
    }
}
