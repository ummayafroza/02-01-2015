using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryAndSearchApp
{
    public partial class StudentSearchUI : Form
    {
        public StudentSearchUI()
        {
            InitializeComponent();
        }

        private void searchDeptIdButton_Click(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>();
            string inputId = searchDeptIdTextBox.Text;
            string connectionString = @"Data Source=(local)\SQLEXPRESS; Database=universityDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM tb_Students JOIN tb_Department ON tb_Students.Dept_Id = tb_Department.Dept_Id";

            if (!string.IsNullOrEmpty(searchDeptIdTextBox.Text))
            {
               
                query = "SELECT * FROM tb_Students JOIN tb_Department ON tb_Students.Dept_Id = tb_Department.Dept_Id WHERE tb_Students.Dept_Id='"  + inputId+ "'";
                
            }

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new Student();
                student.id = (int)reader["StudentId"];
                student.name = reader["StudentName"].ToString();
                student.phone = reader["Phone"].ToString();
                student.email = reader["Email"].ToString();
                student.deptId =(int) reader["Dept_Id"];

                studentList.Add(student);
            }

            showAllListBox.Items.Clear();

            foreach (var aStudent in studentList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aStudent.id.ToString();
                aListViewItem.SubItems.Add(aStudent.name);
                aListViewItem.SubItems.Add(aStudent.phone);
                aListViewItem.SubItems.Add(aStudent.email);
                aListViewItem.SubItems.Add(aStudent.deptId.ToString());

                aListViewItem.Tag = aStudent;

                showAllListBox.Items.Add(aListViewItem);
            }
            connection.Close();
        }
    }
}
