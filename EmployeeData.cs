using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class EmployeeData
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEVPC01;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listData = new List<EmployeeData>();
            if(sqlConnection.State != ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Open();
                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";
                    using(SqlCommand command = new SqlCommand(selectData, sqlConnection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeData employeeData = new EmployeeData();
                            employeeData.ID = (int)reader["id"];
                            employeeData.EmployeeID = reader["employee_id"].ToString();
                            employeeData.FullName = reader["full_name"].ToString();
                            employeeData.Gender = reader["gender"].ToString();
                            employeeData.PhoneNumber = reader["phone_number"].ToString();
                            employeeData.Position = reader["position"].ToString();
                            employeeData.Image = reader["image"].ToString();
                            employeeData.Salary = (int)reader["salary"];
                            employeeData.Status = reader["employee_id"].ToString();
                            listData.Add(employeeData);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    sqlConnection.Close();
                }

            }
            return listData;
        }
    }
}
