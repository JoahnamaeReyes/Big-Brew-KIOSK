using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BIGBREWdaw
{
    public partial class SALES_UI : UserControl
    {
        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DbConnectionString);
        DataTable dt;
        OleDbDataAdapter adapter;

        public SALES_UI()
        {
            InitializeComponent();
        }

        private void getSales()
        {
            try
            {
                conn.Open();
                string query;

               
                if (ModelSelectedUser.role == "Admin")
                {
                   
                    query = "SELECT * FROM (((((([Sales] " +
                        "LEFT JOIN [Orders] ON [Sales].[order_id]=[Orders].[ID]) " +
                        "LEFT JOIN [OrderLine] ON [OrderLine].[order_id]=[Orders].[ID]) " +
                        "LEFT JOIN [tbl_AddProduct] ON [OrderLine].[product_id]=[tbl_AddProduct].[ProductID]) " +
                        "LEFT JOIN [ProductSugarLevels] ON [OrderLine].[sugarlvl_id]=[ProductSugarLevels].[ID]) " +
                        "LEFT JOIN [ProductAddOns] ON [OrderLine].[addon_id]=[ProductAddOns].[ID]) " +
                        "LEFT JOIN [Useracc] ON [Sales].[user_id]=[Useracc].[ID]) " +
                        "WHERE ([tbl_AddProduct].[ProductName] & [Useracc].[Username]) LIKE ?";
                    adapter = new OleDbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("?", $"%{txtSearch.Text}%");
                }
                else
                {
                    
                    query = "SELECT * FROM (((((([Sales] " +
                        "LEFT JOIN [Orders] ON [Sales].[order_id]=[Orders].[ID]) " +
                        "LEFT JOIN [OrderLine] ON [OrderLine].[order_id]=[Orders].[ID]) " +
                        "LEFT JOIN [tbl_AddProduct] ON [OrderLine].[product_id]=[tbl_AddProduct].[ProductID]) " +
                        "LEFT JOIN [ProductSugarLevels] ON [OrderLine].[sugarlvl_id]=[ProductSugarLevels].[ID]) " +
                        "LEFT JOIN [ProductAddOns] ON [OrderLine].[addon_id]=[ProductAddOns].[ID]) " +
                        "LEFT JOIN [Useracc] ON [Sales].[user_id]=[Useracc].[ID]) " +
                        "WHERE ([Useracc].[Username] = ?) AND " +
                        "([tbl_AddProduct].[ProductName] & [Useracc].[Username]) LIKE ?";
                    adapter = new OleDbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("?",ModelSelectedUser.username);
                    adapter.SelectCommand.Parameters.AddWithValue("?", $"%{txtSearch.Text}%");
                }

                dt = new DataTable();
                adapter.Fill(dt);

                dgvSales.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvSales.Rows.Add(
                        row["OrderLine.ID"].ToString(),
                        row["Orders.ID"].ToString(),
                        row["ProductName"].ToString(),
                        row["percentage"].ToString() != "" ? row["percentage"].ToString() + "%" : "0%",
                        row["addon_name"].ToString() != "" ? row["addon_name"].ToString() : "None",
                        "P " + Convert.ToDouble(row["OrderLine.price"].ToString()).ToString("N2"),
                        row["quantity"].ToString(),
                        "P " + Convert.ToDouble(row["OrderLine.total_amount"].ToString()).ToString("N2"),
                        row["Username"].ToString()
                    );
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

        private void SALES_staff_Load(object sender, EventArgs e)
        {
            getSales();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getSales();
        }
    }
}
