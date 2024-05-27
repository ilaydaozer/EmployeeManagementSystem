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

namespace EmployeeManagementSystem
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEVPC01;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadEmployeeData()
        {
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM employees";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
