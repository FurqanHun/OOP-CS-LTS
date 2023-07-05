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
    public partial class ViewItem : Form
    {
        public ViewItem()
        {
            InitializeComponent();
        }

        private void ViewItem_Load(object sender, EventArgs e)
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

        private void view_item_btn_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\project_FYT_inv\project_FYT_inv\Product_Info_DB.mdf;Integrated Security=True";
            string productCode = pcode_txt.Text; // Provide the product code

            string query = "SELECT p_Id, p_Name, p_Price, p_Qty, p_Code FROM Product_Info WHERE p_Code = @ProductCode";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductCode", productCode);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
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
    }
}
