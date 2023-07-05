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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\project_FYT_inv\project_FYT_inv\UsersDB.mdf;Integrated Security=True";

            string enteredEmail = email_textbox.Text;
            string enteredPassword = password_textbox.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM User_Info WHERE u_Email = @EnteredEmail AND u_Password = @EnteredPassword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EnteredEmail", enteredEmail);
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        // Authentication successful
                        MessageBox.Show("Authentication successful. Welcome, " + enteredEmail);
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        // Invalid email or password
                        MessageBox.Show("Invalid email or password. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions during the authentication process
                MessageBox.Show("An error occurred during authentication: " + ex.Message);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
