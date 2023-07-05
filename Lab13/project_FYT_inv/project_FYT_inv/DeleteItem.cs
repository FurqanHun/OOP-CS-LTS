using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_FYT_inv
{
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {

            InitializeComponent();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Info_DBDataSet.Product_Info' table. You can move, or remove it, as needed.
            this.product_InfoTableAdapter.Fill(this.product_Info_DBDataSet.Product_Info);
            LoadData();

        }

        private void mm_delete_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void delete_item_btn_Click(object sender, EventArgs e)
        {
            int productId;

            if (int.TryParse(pid_txt.Text.Trim(), out productId))
            {
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\project_FYT_inv\project_FYT_inv\Product_Info_DB.mdf;Integrated Security=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Product_Info WHERE p_Id = @ProductId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ProductId", productId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show a success message
                            MessageBox.Show("Product deleted successfully.");

                            // Refresh the DataGridView with the updated data
                            if (dataGridView != null)
                            {
                                dataGridView.DataSource = null; // Clear the existing data source
                                LoadData(); // Reload the data from the database
                            }
                        }
                        else
                        {
                            // Show a message indicating no rows were affected (product with given ID not found)
                            MessageBox.Show("No product found with the given ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message
                    MessageBox.Show("Failed to delete the product. Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.");
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pid_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
