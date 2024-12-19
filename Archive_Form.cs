using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIGBREWdaw
{
    public partial class Archive_Form : Form
    {
        public Archive_Form()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Properties.Settings.Default.DbConnectionString);
        OleDbCommand cmd;
        
        DataTable dt;
        private void Archive_Form_Load(object sender, EventArgs e)
        {
            LoadDeletedProd();
        }
        void LoadDeletedProd()
        {
            string sql = "SELECT * FROM [Archive]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewProducts.DataSource = dt;

        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Are you sure you want to delete all records from the archive? This action cannot be undone.",
                 "Confirm Deletion",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
             );

            
            if (result == DialogResult.Yes)
            {
                string deleteSql = "DELETE FROM Archive";
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(deleteSql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("All records have been deleted from the archive.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                
                LoadDeletedProd();
            }
        }
    }
}
