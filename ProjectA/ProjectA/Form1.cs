using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectA
{
    public partial class Form1 : Form

    {
        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con = Configuration.getInstance().getConnection();
        }
        private void ClearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            comboBoxGender.Text = string.Empty;
            //textBox7.Text = string.Empty;
            updateReg.Text = string.Empty;
            textBox9.Text = string.Empty;
            Searchh.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT P.Id, S.RegistrationNo,  P.FirstName, P.LastName, P.Contact, P.Email, P.DateOfBirth, " +
                                                 "L.Value AS Gender " +
                                                 "FROM Person P INNER JOIN Student S ON P.Id = S.Id " +
                                                 "INNER JOIN Lookup L ON P.Gender = L.Id AND L.Category = 'GENDER'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while displaying data: " + ex.Message);
            }
        }
        private void display_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validation.Validation.ValidateStudent(textBox9.Text, textBox4.Text, textBox5.Text))
                {
                    return; 
                }
                if (!validation.Validation.ValidateContact(textBox3.Text))
                {
                    MessageBox.Show("Please enter a valid contact number in the format 03xx-xxxxxxx.");
                    return; 
                }
                if (!validation.Validation.ValidateFirstName(textBox1.Text))
                {
                    MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                    return;
                }
                if (!validation.Validation.ValidateLastName(textBox2.Text))
                {
                    MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                    return;
                }
                var con = Configuration.getInstance().getConnection();
                string getGenderIdQuery = "SELECT Id  FROM Lookup WHERE Value = @Gender AND Category = 'GENDER'";
                SqlCommand cmdGetGenderId = new SqlCommand(getGenderIdQuery, con);
                cmdGetGenderId.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
                int GenderId = Convert.ToInt32(cmdGetGenderId.ExecuteScalar());
                string insertPersonQuery = @"INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)
                                  VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender);
                                  SELECT SCOPE_IDENTITY();";
                SqlCommand cmdInsertPerson = new SqlCommand(insertPersonQuery, con);
                cmdInsertPerson.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmdInsertPerson.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmdInsertPerson.Parameters.AddWithValue("@Contact", textBox3.Text);
                cmdInsertPerson.Parameters.AddWithValue("@Email", textBox4.Text);
                cmdInsertPerson.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(textBox5.Text));
                cmdInsertPerson.Parameters.AddWithValue("@Gender", GenderId);

                int newPersonId = Convert.ToInt32(cmdInsertPerson.ExecuteScalar());
                string insertStudentQuery = "INSERT INTO Student (Id, RegistrationNo) VALUES (@Id, @RegistrationNo)";
                SqlCommand cmdInsertStudent = new SqlCommand(insertStudentQuery, con);
                cmdInsertStudent.Parameters.AddWithValue("@Id", newPersonId);
                cmdInsertStudent.Parameters.AddWithValue("@RegistrationNo", textBox9.Text);

                cmdInsertStudent.ExecuteNonQuery();

                MessageBox.Show("Student added successfully.");
                DisplayData();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            if (!validation.Validation.ValidateStudent(textBox9.Text, textBox4.Text, textBox5.Text))
            {
                return;
            }
            if (!validation.Validation.ValidateContact(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid contact number in the format 03xx-xxxxxxx.");
                return;
            }
            if (!validation.Validation.ValidateFirstName(textBox1.Text))
            {
                MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                return;
            }
            if (!validation.Validation.ValidateLastName(textBox2.Text))
            {
                MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                return;
            }
            var con = Configuration.getInstance().getConnection();
            if (string.IsNullOrEmpty(updateReg.Text))
            {
                MessageBox.Show("Please enter Registration Number for the update.");
                return;
            }
            string getGenderIdQuery = "SELECT Id FROM Lookup WHERE Value = @Gender AND Category = 'GENDER'";
            SqlCommand cmdGetGenderId = new SqlCommand(getGenderIdQuery, con);
            cmdGetGenderId.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
            int GenderId = Convert.ToInt32(cmdGetGenderId.ExecuteScalar());
            string updatePersonQuery = @"UPDATE Person 
                             SET FirstName = @FirstName, 
                                 LastName = @LastName, 
                                 Contact = @Contact, 
                                 Email = @Email, 
                                 DateOfBirth = @DateOfBirth, 
                                 Gender = @Gender 
                             WHERE Id = (
                                 SELECT Id 
                                 FROM Student 
                                 WHERE RegistrationNo = @RegistrationNo
                             )";
            SqlCommand cmdUpdatePerson = new SqlCommand(updatePersonQuery, con);
            cmdUpdatePerson.Parameters.AddWithValue("@FirstName", textBox1.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@LastName", textBox2.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@Contact", textBox3.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@Email", textBox4.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(textBox5.Text));
            cmdUpdatePerson.Parameters.AddWithValue("@Gender", GenderId);
            cmdUpdatePerson.Parameters.AddWithValue("@RegistrationNo", updateReg.Text);

            int rowsAffected = cmdUpdatePerson.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Student information updated successfully");
            }
            else
            {
                MessageBox.Show("No student found with the given Registration Number for update");
            }

            DisplayData();
            ClearTextBoxes();

        }
        private void search_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Searchh.Text))
                {
                    MessageBox.Show("Please enter Registration Number for the search.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM Person INNER JOIN Student ON Person.Id = Student.Id WHERE Student.RegistrationNo = @RegistrationNo", con);
                cmd.Parameters.AddWithValue("@RegistrationNo", Searchh.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    textBox1.Text = reader["FirstName"].ToString();
                    textBox2.Text = reader["LastName"].ToString();
                    textBox3.Text = reader["Contact"].ToString();
                    textBox4.Text = reader["Email"].ToString();
                    textBox5.Text = reader["DateOfBirth"].ToString();
                    comboBoxGender.Text = reader["Gender"].ToString();
                    textBox9.Text = reader["RegistrationNo"].ToString();

                    MessageBox.Show("Student found!");
                }
                else
                {
                    MessageBox.Show("No student found with the given Registration Number");
                    ClearTextBoxes();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

    }
}



    
    



    


