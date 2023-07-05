using project_FYT_inv.Product_Info_DBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_FYT_inv
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            UpdateItem updateItem = new UpdateItem();
            updateItem.Show();
            this.Hide();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteItem deleteItem = new DeleteItem();
            deleteItem.Show();
            this.Hide();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewItem viewItem = new ViewItem();
            viewItem.Show();
            this.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
