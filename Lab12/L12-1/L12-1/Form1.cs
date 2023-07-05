using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L12_1
{
    public partial class Login_Forn : Form
    {
        public Login_Forn()
        {
            InitializeComponent();
        }

        private void Login_Forn_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {   
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.ShowDialog();
            this.Close();

        }
    }
}
