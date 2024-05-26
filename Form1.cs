using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_signup_btn_Click(object sender, EventArgs e)
        {
            Form2 register_form = new Form2();
            register_form.Show();
            this.Hide();
        }

        private void login_show_password_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_show_password.Checked ? '\0' : '*';
        }
    }
}
