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
    public partial class AddStaff : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public AddStaff()
        {
            InitializeComponent();
        }
        private void InitializeConnection()
        {
            con = new OleDbConnection(Properties.Settings.Default.DbConnectionString);
        }

        void GetUsers(string searchQuery = "")
        {
            try
            {
                dt = new DataTable();
                string query = "SELECT * FROM Useracc";
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE tbl_AddProduct LIKE @search OR Role LIKE @search";
                }

                adapter = new OleDbDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                adapter.Fill(dt);
                dgview.DataSource = dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"An error occurred:" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    private void btnADD_admin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbUN_admin.Text) || string.IsNullOrWhiteSpace(tbPASS_admin.Text) || string.IsNullOrWhiteSpace(cbROLE_admin.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Useracc (Username, [Password], Role) VALUES (@u, @p, @r)";

            try
            {
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@u", tbUN_admin.Text);
                cmd.Parameters.AddWithValue("@p", tbPASS_admin.Text);
                cmd.Parameters.AddWithValue("@r", cbROLE_admin.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Inserted Successfully");

                GetUsers();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUPDATE_admin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUN_admin.Text) || string.IsNullOrWhiteSpace(tbPASS_admin.Text) || string.IsNullOrWhiteSpace(cbROLE_admin.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dgview.SelectedRows[0].Cells["ID"].Value);

            string query = "UPDATE Useracc SET Username=@un, [Password]=@p, Role=@r WHERE ID=@id";

            try
            {
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@un", tbUN_admin.Text);
                cmd.Parameters.AddWithValue("@p", tbPASS_admin.Text);
                cmd.Parameters.AddWithValue("@r", cbROLE_admin.Text);
                cmd.Parameters.AddWithValue("@id", selectedUserId);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("User updated successfully.", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUsers();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDELETE_admin_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgview.SelectedRows[0].Cells["ID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Useracc WHERE ID =?";
                cmd.Parameters.AddWithValue("?", selectedUserId);

                try
                {
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("?", selectedUserId);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUsers();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnCLEAR_admin_Click(object sender, EventArgs e)
        {
            tbID_admin.Clear();
            tbUN_admin.Clear();
            tbPASS_admin.Clear();
            cbROLE_admin.SelectedIndex = -1;
            tbSearch.Clear();
            dgview.ClearSelection();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string searchQuery = tbSearch.Text;
            GetUsers(searchQuery);

        }

        private void dgview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                tbID_admin.Text = dgview.CurrentRow.Cells[0].Value.ToString();
                tbUN_admin.Text = dgview.CurrentRow.Cells[1].Value.ToString();
                tbPASS_admin.Text = dgview.CurrentRow.Cells[2].Value.ToString();
                cbROLE_admin.Text = dgview.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {         
            InitializeConnection();
            con.Open();
            GetUsers();

        }
        private void AddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}