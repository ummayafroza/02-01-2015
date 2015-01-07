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

namespace StudentEntryAndSearchApp
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = studentNameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            int deptId = Convert.ToInt32(deptIdComboBox.Text);

            
            string connectionString =
               @"Data Source = (local)\SQLEXPRESS ; Database = universityDB; Integrated Security =true;";
            SqlConnection connection = new SqlConnection(connectionString);//object creation;
            connection.Open();//pipeline creation and open
            
            
            string query = "INSERT INTO tb_Students VALUES('" + name + "','" + phone + "','" +email + "','" + deptId +
                            "')";
            SqlCommand command = new SqlCommand(query, connection);

            int rowAffected = command.ExecuteNonQuery();


            connection.Close();


            if (rowAffected > 0)
            {
                MessageBox.Show("Successfully Saved data");
            }
            else
            {
                MessageBox.Show("Couldnot save the data");
            }
        }

    

        private void StudentEntryUI_Load(object sender, EventArgs e)
        {
            List<Department> aList = new List<Department>();
            string connectionString = @"Data Source=(local)\SQLEXPRESS;Database=universityDB;Integrated Security=true";
            SqlConnection aSqlConnection = new SqlConnection(connectionString);
            aSqlConnection.Open();

            string query = "SELECT * FROM tb_Department";

            SqlCommand command = new SqlCommand(query, aSqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Department aDept = new Department();
                aDept.Id = (int)reader["Dept_Id"];
                aDept.Name = reader["Dept_Name"].ToString();
                aList.Add(aDept);
            }

            reader.Close();
            aSqlConnection.Close();
            deptIdComboBox.ValueMember = "Id";//department Property
            deptIdComboBox.DisplayMember = "Name";
            deptIdComboBox.Items.Clear();
            foreach (var depart in aList)
            {
                deptIdComboBox.Items.Add(depart);
            }
        }
    }
}
