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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmployeeManagementSystem
{
    public partial class UserControl2 : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEVPC01;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
        public UserControl2()
        {
            InitializeComponent();
        }
        public void DisplayEmployeeData()
        {
            EmployeeData employeeData = new EmployeeData();
            List<EmployeeData> listData = employeeData.employeeListData();
            dataGridView1.DataSource = listData;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void add_emp_add_btn_Click(object sender, EventArgs e)
        {
            
            if (add_emp_id.Text == "" || add_emp_fullName.Text == "" || add_emp_gender.Text == "" || add_emp_phoneNumber.Text == "" || add_emp_position.Text == "" || add_emp_status.Text == "" || add_emp_image.Image == null)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    try
                    {
                        sqlConnection.Open(); 
                        string checkEmployeeID = "SELECT COUNT(*) FROM employees WHERE employee_id = @employeeID AND delete_date IS NOT NULL";
                        using (SqlCommand command = new SqlCommand(checkEmployeeID, sqlConnection))
                        {
                            
                            command.Parameters.AddWithValue("@employeeID", add_emp_id.Text.Trim());

                            
                            int count = (int)command.ExecuteScalar();

                            
                            if (count >= 1)
                            {
                                MessageBox.Show(add_emp_id.Text.Trim() + " is already.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                
                                DateTime today = DateTime.Today;

                                
                                string insert_data = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, phone_number, position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @full_name, @gender, @phone_number, @position, @image, @salary, @insert_date, @status)";

                               
                                string path = Path.Combine(@"C:\Users\ilayda.ozer\source\repos\EmployeeManagementSystem\Directory\" + add_emp_id.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(add_emp_image.ImageLocation, path, true); 

                                using (SqlCommand cmd = new SqlCommand(insert_data, sqlConnection))
                                {
                                   
                                    cmd.Parameters.AddWithValue("@employeeID", add_emp_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@full_name", add_emp_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", add_emp_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone_number", add_emp_phoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", add_emp_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary",  0); 
                                    cmd.Parameters.AddWithValue("@insert_date", today);
                                    cmd.Parameters.AddWithValue("@status", add_emp_status.Text.Trim());

                                    
                                    cmd.ExecuteNonQuery();

                                    DisplayEmployeeData(); 
                                    MessageBox.Show("Added succsessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close(); 
                    }
                }
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void add_emp_import_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg,*.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    add_emp_image.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex, "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                add_emp_id.Text = row.Cells[1].Value.ToString();
                add_emp_fullName.Text = row.Cells[2].Value.ToString();
                add_emp_gender.Text = row.Cells[3].Value.ToString();
                add_emp_phoneNumber.Text = row.Cells[4].Value.ToString();
                add_emp_position.Text = row.Cells[5].Value.ToString();
                string imagePath = row.Cells[6].Value.ToString();
                if(imagePath != null)
                {
                    add_emp_image.Image = Image.FromFile(imagePath);
                }
                else
                {
                    add_emp_image.Image = null;
                }
                add_emp_status.Text = row.Cells[8].Value.ToString();
            }
        }
        public void ClearFields()
        {
            add_emp_id.Text = "";
            add_emp_fullName.Text = "";
            add_emp_gender.SelectedIndex = -1;
            add_emp_phoneNumber.Text = "";
            add_emp_position.SelectedIndex = -1;
            add_emp_status.SelectedIndex = -1;
            add_emp_image.Image = null;
        }

        private void add_emp_update_btn_Click(object sender, EventArgs e)
        {
            if (add_emp_id.Text == "" || add_emp_fullName.Text == "" || add_emp_gender.Text == "" || add_emp_phoneNumber.Text == "" || add_emp_position.Text == "" || add_emp_status.Text == "" || add_emp_image.Image == null)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update " + "Employee ID: "+ add_emp_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(check == DialogResult.Yes)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        sqlConnection.Open();
                        string update_data = "UPDATE employees SET full_name = @full_name, gender=@gender, phone_number=@phone_number, position=@position,update_date=@update_date,status=@status"+
                            " WHERE employee_id=@employeeID";
                        using (SqlCommand cmd = new SqlCommand(update_data, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", add_emp_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@full_name", add_emp_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", add_emp_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone_number", add_emp_phoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", add_emp_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@update_date", today);
                            cmd.Parameters.AddWithValue("@status", add_emp_status.Text.Trim());
                            cmd.ExecuteNonQuery();
                            DisplayEmployeeData();
                            MessageBox.Show("Updated succsessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_emp_clearr_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void add_emp_delete_btn_Click(object sender, EventArgs e)
        {
            if (add_emp_id.Text == "" || add_emp_fullName.Text == "" || add_emp_gender.Text == "" || add_emp_phoneNumber.Text == "" || add_emp_position.Text == "" || add_emp_status.Text == "" || add_emp_image.Image == null)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete " + "Employee ID: " + add_emp_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        sqlConnection.Open();
                        string update_data = "UPDATE employees SET delete_date=@delete_date" +
                            " WHERE employee_id=@employeeID";
                        using (SqlCommand cmd = new SqlCommand(update_data, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", add_emp_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@delete_date", today);
                            cmd.ExecuteNonQuery();
                            DisplayEmployeeData();
                            MessageBox.Show("Updated succsessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
