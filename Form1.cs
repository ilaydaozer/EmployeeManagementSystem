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
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEVPC01;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(sqlConnection.State== ConnectionState.Closed)
                {
                    try
                    {
                        sqlConnection.Open();
                        string select_data = "SELECT * FROM users WHERE username = @username" +
                            " AND password = @password";
                        using(SqlCommand command = new SqlCommand(select_data, sqlConnection))
                        {
                            command.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            command.Parameters.AddWithValue("@password",login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable data_table = new DataTable();
                            adapter.Fill(data_table);
                            if(data_table.Rows.Count >= 1) 
                            {
                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                Form3 form3 = new Form3();
                                form3.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                

            }
        }
    }
}
