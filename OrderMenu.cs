using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace BIGBREWdaw
{
    public partial class OrderMenu : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BIGB.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        private object[] ToAdd =
        {
            //"Product ID", "Product Name", "Sugar Level ID", "Sugar Level", "Addon ID", "Addon", "Price", "Quantity", "Total"
            0, "", 0, "0%", 0, "None", 0, 1, 0
        };

        private double total_amount = 0;

        public int activeMenu = 0;

        public OrderMenu()
        {
            InitializeComponent();
        }

        private void getProducts()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [tbl_AddProduct] WHERE [category_id]=? AND [Status]='Available' AND [ProductName] LIKE ?";
                adapter = new OleDbDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("?", activeMenu);
                adapter.SelectCommand.Parameters.AddWithValue("?", $"%{txtSearch.Text}%");
                dt = new DataTable();
                adapter.Fill(dt);

                fpnlMenuItems.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductID"].ToString());
                    byte[] productImg = (byte[])row["Photo"];
                    string productName = row["ProductName"].ToString() + " - " + row["Size"].ToString();
                    double productPrice = Convert.ToDouble(row["Price"]);

                    MemoryStream ms = new MemoryStream();
                    ms.Write(productImg, 0, productImg.Length);

                    ProductCard pc = new ProductCard();

                    pc.ProductImg.Image = Image.FromStream(ms);
                    pc.productId = productId;
                    pc.ProductName.Text = productName;
                    pc.Price.Text = "P " + productPrice.ToString("N2");

                    pc.Click += ProductCard_Click;

                    fpnlMenuItems.Controls.Add(pc);
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

        private void ProductCard_Click(object sender, EventArgs e)
        {
            try
            {
                ProductCard pc = (ProductCard)sender;
                panOrderProduct.Visible = true;
                picProductImg.Image = pc.ProductImg.Image;

                con.Open();
                string query = "SELECT * FROM [tbl_AddProduct] WHERE [ProductID]=?";
                adapter = new OleDbDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("?", pc.productId);
                dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.Rows[0];

                ToAdd[0] = Convert.ToInt32(row["ProductID"].ToString());
                ToAdd[1] = row["ProductName"].ToString();
                ToAdd[6] = Convert.ToDouble(row["Price"].ToString());
                ToAdd[8] = Convert.ToDouble(row["Price"].ToString());

                lblPrice.Text = "P " + Convert.ToDouble(ToAdd[6]).ToString("N2");
                lblTotal.Text = "P " + Convert.ToDouble(ToAdd[8]).ToString("N2");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Add(ToAdd[0], ToAdd[1], ToAdd[2], ToAdd[3], ToAdd[4], ToAdd[5], "P " + Convert.ToDouble(ToAdd[6]).ToString("N2"), ToAdd[7], "P " + Convert.ToDouble(ToAdd[8]).ToString("N2"));
            total_amount += Convert.ToDouble(ToAdd[8]);
            lblTotalAmount.Text = "P " + total_amount.ToString("N2");
            btnCloseOrder.PerformClick();
            MessageBox.Show("Added to Cart!");
        }

        private void getCategoryOptions()
        {
            try
            {
                con.Open();
                var query = "SELECT * FROM [Categories]";
                adapter = new OleDbDataAdapter(query, con);
                dt = new DataTable();
                adapter.Fill(dt);
                activeMenu = Convert.ToInt32(dt.Rows[0][0].ToString());
                foreach (DataRow row in dt.Rows)
                {

                    MenuButton btnCategory = new MenuButton();
                    btnCategory.Text = row["name"].ToString();
                    btnCategory.MenuID = Convert.ToInt32(row["ID"].ToString());
                    if (btnCategory.MenuID == activeMenu)
                    {
                        btnCategory.BackColor = Color.DarkRed;
                        btnCategory.ForeColor = Color.White;
                    }
                    btnCategory.Click += setActiveMenu;
                    fpnlCategories.Controls.Add(btnCategory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void getSugarLevels()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [ProductSugarLevels]";
                adapter = new OleDbDataAdapter(query, con);
                dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    MyButton btn = new MyButton();
                    btn.id = Convert.ToInt32(row["id"].ToString());
                    btn.Text = row["percentage"].ToString() + "%";
                    btn.Click += btnSugarLevel_Click;
                    fpnlSugarLevel.Controls.Add(btn);
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

        private void btnSugarLevel_Click(object sender, EventArgs e)
        {
            MyButton btn = (MyButton)sender;
            btn.BackColor = Color.DarkRed;
            btn.ForeColor = Color.White;
            ToAdd[2] = Convert.ToInt32(btn.id);
            ToAdd[3] = btn.Text;

            Control parent = btn.Parent;
            foreach (Control ctrl in parent.Controls)
            {
                MyButton myBtn = (MyButton)ctrl;
                if (Convert.ToInt32(ToAdd[2]) != myBtn.id)
                {
                    myBtn.BackColor = Color.White;
                    myBtn.ForeColor = Color.Black;
                }
            }
        }

        private void getProductAddons()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [ProductAddOns]";
                adapter = new OleDbDataAdapter(query, con);
                dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    MyButton btn = new MyButton();
                    btn.id = Convert.ToInt32(row["id"].ToString());
                    btn.Text = row["addon_name"].ToString();
                    btn.Click += btnAddon_Click;
                    fpnlAddons.Controls.Add(btn);
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

        private void btnAddon_Click(object sender, EventArgs e)
        {
            MyButton btn = (MyButton)sender;
            btn.BackColor = Color.DarkRed;
            btn.ForeColor = Color.White;
            ToAdd[4] = Convert.ToInt32(btn.id);
            ToAdd[5] = btn.Text;

            Control parent = btn.Parent;
            foreach (Control ctrl in parent.Controls)
            {
                MyButton myBtn = (MyButton)ctrl;
                if (Convert.ToInt32(ToAdd[4]) != myBtn.id)
                {
                    myBtn.BackColor = Color.White;
                    myBtn.ForeColor = Color.Black;
                }
            }
        }

        private void OrderMenu_Load(object sender, EventArgs e)
        {
            getSugarLevels();
            getProductAddons();
            getCategoryOptions();
            getProducts();
        }

        private void setActiveMenu(object sender, EventArgs e)
        {
            MenuButton btn = sender as MenuButton;
            activeMenu = btn.MenuID;

            foreach(Control ctrl in fpnlCategories.Controls)
            {
                MenuButton btnCtrl = ctrl as MenuButton;

                btnCtrl.BackColor = btnCtrl.MenuID != activeMenu ? Color.White : Color.DarkRed;
                btnCtrl.ForeColor = btnCtrl.MenuID != activeMenu ? Color.Black : Color.White;
            }
            getProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getProducts();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            ToAdd[7] = nudQuantity.Value;
            ToAdd[8] = Convert.ToDouble(ToAdd[6]) * Convert.ToDouble(ToAdd[7]);
            lblTotal.Text = "P " + Convert.ToDouble(ToAdd[8]).ToString("N2");
        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            ToAdd = new object[] { 0, "", 0, "0%", 0, "None", 0, 1, 0 };
            nudQuantity.Value = 1;

            foreach (Control ctrl in fpnlAddons.Controls)
            {
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
            }

            foreach (Control ctrl in fpnlSugarLevel.Controls)
            {
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
            }

            panOrderProduct.Visible = false;
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            total_amount = 0;
            lblTotalAmount.Text = "P " + total_amount.ToString("N2");
        }

        private void btnOrderCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.Rows.Count <= 0)
                {
                    MessageBox.Show("No cart items detected!");
                    return;
                }
                con.Open();

                int orderId;
                string query = "INSERT INTO [Orders] ([total_amount]) VALUES (?)";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", total_amount);
                cmd.ExecuteNonQuery();

                string getLastIdQuery = "SELECT @@IDENTITY";
                using (OleDbCommand cmd = new OleDbCommand(getLastIdQuery, con))
                {
                    orderId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    query = "INSERT INTO [OrderLine] ([order_id], [product_id], [sugarlvl_id], [addon_id], [price], [quantity], [total_amount]) " +
                            "VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmdLine = new OleDbCommand(query, con))
                    {
                        cmdLine.Parameters.AddWithValue("?", orderId);
                        cmdLine.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells["productId"].Value.ToString()));
                        cmdLine.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells["sugarLvlId"].Value.ToString()));
                        cmdLine.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells["addonId"].Value.ToString()));
                        cmdLine.Parameters.AddWithValue("?", Convert.ToDouble(row.Cells["price"].Value.ToString().Replace("P ", "")));
                        cmdLine.Parameters.AddWithValue("?", Convert.ToInt32(row.Cells["quantity"].Value.ToString()));
                        cmdLine.Parameters.AddWithValue("?", Convert.ToDouble(row.Cells["total"].Value.ToString().Replace("P ", "")));
                        cmdLine.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ordered Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClearCart.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
