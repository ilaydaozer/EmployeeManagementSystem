using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace EmployeeManagementSystem
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEVPC01;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(sqlConnection.State != ConnectionState.Open)
                {
                    try
                    {
                        sqlConnection.Open();
                        string select_username = "SELECT COUNT(id) FROM users WHERE username = @username";
                        using(SqlCommand check_user = new SqlCommand(select_username,sqlConnection))
                        {
                            check_user.Parameters.AddWithValue("@username", register_username.Text.Trim());
                            int count = (int)check_user.ExecuteScalar();
                            if(count>=1)
                            {
                                MessageBox.Show(register_username.Text.Trim()+"is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users" +
                                    "(username, password, registration_date)" +
                                    "VALUES(@username,@password,@registration_date)";
                                using (SqlCommand command = new SqlCommand(insertData, sqlConnection))
                                {
                                    command.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    command.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    command.Parameters.AddWithValue("@registration_date", today);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("User is registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 login_form = new Form1();
                                    login_form.Show();
                                    this.Hide();
                                }
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_show_password_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_show_password.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void register_login_btn_Click(object sender, EventArgs e)
        {
            Form1 login_form = new Form1();
            login_form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
