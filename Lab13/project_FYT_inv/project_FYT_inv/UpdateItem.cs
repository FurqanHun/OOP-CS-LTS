using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_FYT_inv
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void mm_update_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void update_item_btn_Click(object sender, EventArgs e)
        {
            string productName = pname_txt.Text;
            decimal price = decimal.Parse(pprice_txt.Text);
            int quantity = int.Parse(pqty_txt.Text);
            string productCode = pcode_txt.Text;
            int productId = int.Parse(pid_txt.Text);
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\project_FYT_inv\project_FYT_inv\Product_Info_DB.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Product_Info SET p_Name = @ProductName, p_Qty = @Quantity, p_Price = @Price, p_Code = @ProductCode WHERE p_Id = @ProductId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@ProductCode", productCode);
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.ExecuteNonQuery();
                }

                // Show a success message
                MessageBox.Show("Product updated successfully.");

                dataGridView.DataSource = null; // Clear the existing data source
                LoadData(); // Reload the data from the database

            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show("Failed to update the product. Error: " + ex.Message);
            }
        }
        private void LoadData()
        {
            // Retrieve the data from the database and assign it to the DataGridView
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\project_FYT_inv\project_FYT_inv\Product_Info_DB.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Product_Info";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
               dataGridView.DataSource = dataTable;
            }
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Info_DBDataSet.Product_Info' table. You can move, or remove it, as needed.
            this.product_InfoTableAdapter.Fill(this.product_Info_DBDataSet.Product_Info);
            LoadData();
        }
    }

}
