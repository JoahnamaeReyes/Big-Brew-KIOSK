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
    public partial class OrderItems : Form
    {
        public int orderId { get; set; }
        public double total_amount { get; set; }

        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DbConnectionString);
        OleDbDataAdapter adapter;
        DataTable dt;

        public OrderItems()
        {
            InitializeComponent();
        }

        private void getOrderLines()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM (((([OrderLine] "+
                    "LEFT JOIN [Orders] ON [OrderLine].[order_id]=[Orders].[ID]) " +
                    "LEFT JOIN [tbl_AddProduct] ON [OrderLine].[product_id]=[tbl_AddProduct].[ProductID]) " +
                    "LEFT JOIN [ProductSugarLevels] ON [OrderLine].[sugarlvl_id]=[ProductSugarLevels].[ID]) " +
                    "LEFT JOIN [ProductAddOns] ON [OrderLine].[addon_id]=[ProductAddOns].[ID]) " +
                    "WHERE [order_id]=?";
                adapter = new OleDbDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", orderId);
                dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dgvOrderLine.Rows.Add(row["ProductName"].ToString(), row["percentage"].ToString() != "" ? row["percentage"].ToString() + "%" : "0%", row["addon_name"].ToString() != "" ? row["addon_name"].ToString() : "None", "P " + Convert.ToDouble(row["tbl_AddProduct.Price"].ToString()).ToString("N2"), row["quantity"].ToString(), "P " + Convert.ToDouble(row["OrderLine.total_amount"]).ToString("N2"));
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

        private void OrderItems_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "P " + Convert.ToDouble(total_amount).ToString("N2");
            getOrderLines();
        }
    }
}
