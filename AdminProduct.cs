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
using System.IO;

namespace BIGBREWdaw
{
    public partial class AdminProduct : Form
    {

        OleDbConnection con = new OleDbConnection(Properties.Settings.Default.DbConnectionString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        private bool isImageUploaded = false;

        public AdminProduct()
        {
            InitializeComponent();
        }

        private void getCategories()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [Categories]";
                adapter = new OleDbDataAdapter(query, con);
                dt = new DataTable();
                adapter.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "name";
                cmbCategory.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void getProducts()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [tbl_AddProduct] " +
                    "INNER JOIN [Categories] ON [tbl_AddProduct].[category_id]=[Categories].[ID] " +
                    "WHERE [tbl_AddProduct].[ProductName] LIKE ?";
                adapter = new OleDbDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("?", $"%{tbSearch.Text}%");
                dt = new DataTable();
                adapter.Fill(dt);

                dgvProduct.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvProduct.Rows.Add(
                        row["ProductID"].ToString(),
                        row["ProductName"].ToString(),
                        row["Photo"],
                        row["category_id"].ToString(),
                        row["name"].ToString(),
                        row["Size"].ToString(),
                        "P " + Convert.ToDouble(row["Price"].ToString()).ToString("N2"),
                        row["status"].ToString(),
                        DateTime.Parse(row["DateInsert"].ToString()).ToString("MMM. dd, yyyy")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void GetUsers(string searchQuery = "")
        {
            try
            {
                dt = new DataTable();
                string query = "SELECT * FROM tbl_AddProduct";
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE tbl_AddProduct LIKE @search OR Role LIKE @search";
                }

                adapter = new OleDbDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
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

        private void btnADD_admin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(cmbCategory.Text) || string.IsNullOrWhiteSpace(txtProductSize.Text) || nudProductPrice.Value <= 0 || string.IsNullOrWhiteSpace(cmbStatus.Text) || pbInsert.Image == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string query = "INSERT INTO [tbl_AddProduct] ([ProductName], [category_id], [Size], [price], [Status], [Photo]) VALUES (?, ?, ?, ?, ?, ?)";
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", txtProductName.Text);
                cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("?", txtProductSize.Text);
                cmd.Parameters.AddWithValue("?", nudProductPrice.Value);
                cmd.Parameters.AddWithValue("?", cmbStatus.Text);

                using (MemoryStream ms = new MemoryStream())
                {
                    pbInsert.Image.Save(ms, pbInsert.Image.RawFormat);
                    cmd.Parameters.AddWithValue("?", ms.ToArray());
                }
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Inserted Successfully");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
                getProducts();
            }
        

        private void btnUPDATE_admin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(cmbCategory.Text) || string.IsNullOrWhiteSpace(txtProductSize.Text) || nudProductPrice.Value <= 0 || string.IsNullOrWhiteSpace(cmbStatus.Text) || pbInsert.Image == null)

            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            string query = "UPDATE [tbl_AddProduct] SET [ProductName]=?, [category_id]=?, [Size]=?, [Price]=?, [Status]=?, [Photo]=?, [DateUpdate]=? WHERE ProductID=@id";
            DateTime today = DateTime.Today;

            try
            {
                con.Open();
                cmd = new OleDbCommand(query, con);
                
                cmd.Parameters.AddWithValue("?", txtProductName.Text);
                cmd.Parameters.AddWithValue("?", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("?", txtProductSize.Text);
                cmd.Parameters.AddWithValue("?", nudProductPrice.Value);
                cmd.Parameters.AddWithValue("?", cmbStatus.Text);
                using (MemoryStream ms = new MemoryStream())
                {
                    pbInsert.Image.Save(ms, pbInsert.Image.RawFormat);
                    cmd.Parameters.AddWithValue("?", ms.ToArray());
                }
                cmd.Parameters.AddWithValue("?", today);
                cmd.Parameters.AddWithValue("?", txtProductID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User updated successfully.", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            getProducts();
        }

        private void btnDELETE_admin_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedProductId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string selectQuery = "SELECT * FROM [tbl_AddProduct] WHERE [ProductID] = @id";
                string insertArchiveQuery = @"
        INSERT INTO [Archive] 
        ([ProductName], [CategoryID], [Size], [Price], [Status], [DateInserted], [DateDeleted]) 
        VALUES (?, ?, ?, ?, ?, ?, ?)";
                string deleteQuery = "DELETE FROM [tbl_AddProduct] WHERE [ProductID] = @id";

                try
                {
                    con.Open();

                    
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@id", selectedProductId);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        string productName = reader["ProductName"].ToString();
                        int categoryId = Convert.ToInt32(reader["category_id"]);
                        string size = reader["Size"].ToString();
                        int price = Convert.ToInt32(reader["Price"]);
                        string status = reader["Status"].ToString();
                        DateTime dateInserted = Convert.ToDateTime(reader["DateInsert"]);
                        
                        cmd = new OleDbCommand(insertArchiveQuery, con);
                        cmd.Parameters.AddWithValue("?", productName);
                        cmd.Parameters.AddWithValue("?", categoryId);
                        cmd.Parameters.AddWithValue("?", size);
                        cmd.Parameters.AddWithValue("?", price);
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", dateInserted);
                        cmd.Parameters.AddWithValue("?", DateTime.Today);

                        cmd.ExecuteNonQuery();

                        
                        cmd = new OleDbCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@id", selectedProductId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product archived and deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product not found. Unable to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"An error occurred while deleting the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                getProducts();
            }
        }

        private void btnCLEAR_admin_Click(object sender, EventArgs e)
        {
            txtProductID.Clear();
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtProductSize.Clear();
            nudProductPrice.Value = 0;
            cmbStatus.SelectedIndex = -1;
            tbSearch.Clear();
            dgvProduct.ClearSelection();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            getProducts();
        }

        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtProductID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                txtProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                cmbCategory.SelectedValue = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                txtProductSize.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
                nudProductPrice.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[6].Value.ToString().Replace("P ", ""));
                cmbStatus.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();


                if (dgvProduct.CurrentRow.Cells["Photo"].Value != DBNull.Value)
                {
                    try
                    {
                        byte[] imgData = (byte[])dgvProduct.CurrentRow.Cells["Photo"].Value;
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            pbInsert.Image = Image.FromStream(ms);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                        pbInsert.Image = null;
                    }
                }
                else
                {
                    pbInsert.Image = null;
                }


            }
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            getCategories();
            getProducts();
        }

        private void AdminProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbInsert.Image = new Bitmap(openFileDialog.FileName);
            }
               isImageUploaded = true;
        }

        private void pbInsert_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            Archive_Form archive_Form = new Archive_Form();
            this.Hide();
            archive_Form.ShowDialog();
            this.Show();
        }
    }
    }

