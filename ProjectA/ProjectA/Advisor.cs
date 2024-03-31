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




namespace ProjectA
{
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }

        private void Advisor_Load(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            first.Text = string.Empty;
            last.Text = string.Empty;
            contact.Text = string.Empty;
            email.Text = string.Empty;
            DOB.Text = string.Empty;
            comboBoxGender.SelectedIndex = -1;
            salary.Text = string.Empty;
            comboBoxdesignation.SelectedIndex = -1;
        }


        private void add_Click(object sender, EventArgs e)
        {

            try
            {
                if (!validation.Validation.ValidateContact(contact.Text))
                {
                    MessageBox.Show("Please enter a valid contact number in the format 03xx-xxxxxxx.");
                    return;
                }

                if (!validation.Validation.ValidateEmail(email.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }
                if (!validation.Validation.ValidateFirstName(first.Text))
                {
                    MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                    return;
                }
                if (!validation.Validation.ValidateLastName(last.Text))
                {
                    MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                    return;
                }
                var con = Configuration.getInstance().getConnection();
                string getGenderIdQuery = "SELECT Id FROM Lookup WHERE Value = @Gender AND Category = 'GENDER'";
                SqlCommand cmdGetGenderId = new SqlCommand(getGenderIdQuery, con);
                cmdGetGenderId.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
                int GenderId = Convert.ToInt32(cmdGetGenderId.ExecuteScalar());



                string getDesignationIdQuery = "SELECT Id FROM Lookup WHERE Value = @Designation AND Category = 'DESIGNATION'";
                SqlCommand cmdGetDesignationId = new SqlCommand(getDesignationIdQuery, con);
                cmdGetDesignationId.Parameters.AddWithValue("@Designation", comboBoxdesignation.Text);
                int DesignationId = Convert.ToInt32(cmdGetDesignationId.ExecuteScalar());





                // int genderId = Convert.ToInt32(cmdGetGenderId.ExecuteScalar());

                string insertPersonQuery = @"INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)
                                     VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender);
                                     SELECT SCOPE_IDENTITY();";
                SqlCommand cmdInsertPerson = new SqlCommand(insertPersonQuery, con);
                cmdInsertPerson.Parameters.AddWithValue("@FirstName", first.Text);
                cmdInsertPerson.Parameters.AddWithValue("@LastName", last.Text);
                cmdInsertPerson.Parameters.AddWithValue("@Contact", contact.Text);
                cmdInsertPerson.Parameters.AddWithValue("@Email", email.Text);
                cmdInsertPerson.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(DOB.Text));
                cmdInsertPerson.Parameters.AddWithValue("@Gender", GenderId);

                int newPersonId = Convert.ToInt32(cmdInsertPerson.ExecuteScalar());

                string insertAdvisorQuery = "INSERT INTO Advisor (Id, Salary, Designation) VALUES (@Id, @Salary, @Designation)";
                SqlCommand cmdInsertAdvisor = new SqlCommand(insertAdvisorQuery, con);
                cmdInsertAdvisor.Parameters.AddWithValue("@Id", newPersonId);
                cmdInsertAdvisor.Parameters.AddWithValue("@Salary", decimal.Parse(salary.Text));
                cmdInsertAdvisor.Parameters.AddWithValue("@Designation", DesignationId);

                cmdInsertAdvisor.ExecuteNonQuery();

                MessageBox.Show("Advisor added successfully.");
                DisplayAdvisorsData();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private void DisplayAdvisorsData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT P.Id, P.FirstName, P.LastName, P.Contact, P.Email, P.DateOfBirth, " +
                                                 "GL.Value AS Gender, AL.Value AS Designation, A.Salary " +
                                                 "FROM Person P " +
                                                 "INNER JOIN Advisor A ON P.Id = A.Id " +
                                                 "INNER JOIN Lookup GL ON P.Gender = GL.Id AND GL.Category = 'GENDER' " +
                                                 "INNER JOIN Lookup AL ON A.Designation = AL.Id AND AL.Category = 'DESIGNATION'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAdvisors.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while displaying advisors: " + ex.Message);
            }
        }




        private void display_Click_1(object sender, EventArgs e)
        {
            DisplayAdvisorsData();

        }

        private void update_Click(object sender, EventArgs e)
        {

            if (!validation.Validation.ValidateContact(contact.Text))
            {
                MessageBox.Show("Please enter a valid contact number in the format 03xx-xxxxxxx.");
                return;
            }

            if (!validation.Validation.ValidateEmail(email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (!validation.Validation.ValidateFirstName(first.Text))
            {
                MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                return;
            }
            if (!validation.Validation.ValidateLastName(last.Text))
            {
                MessageBox.Show("Please enter a validfirst name that contains alphabets only.");
                return;
            }
            var con = Configuration.getInstance().getConnection();

            // Get Gender ID
            string getGenderIdQuery = "SELECT Id FROM Lookup WHERE Value = @Gender AND Category = 'GENDER'";
            SqlCommand cmdGetGenderId = new SqlCommand(getGenderIdQuery, con);
            cmdGetGenderId.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
            int GenderId = Convert.ToInt32(cmdGetGenderId.ExecuteScalar());

            // Get Designation ID
            string getDesignationIdQuery = "SELECT Id FROM Lookup WHERE Value = @Designation AND Category = 'DESIGNATION'";
            SqlCommand cmdGetDesignationId = new SqlCommand(getDesignationIdQuery, con);
            cmdGetDesignationId.Parameters.AddWithValue("@Designation", comboBoxdesignation.Text);
            int DesignationId = Convert.ToInt32(cmdGetDesignationId.ExecuteScalar());

            // Step 1: Update data in the Person table
            string updatePersonQuery = @"UPDATE Person 
                         SET FirstName = @FirstName, 
                             LastName = @LastName, 
                             Contact = @Contact, 
                             Email = @Email, 
                             DateOfBirth = @DateOfBirth, 
                             Gender = @Gender 
                         WHERE Id = @Id";
            SqlCommand cmdUpdatePerson = new SqlCommand(updatePersonQuery, con);
            cmdUpdatePerson.Parameters.AddWithValue("@FirstName", first.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@LastName", last.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@Contact", contact.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@Email", email.Text);
            cmdUpdatePerson.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(DOB.Text));
            cmdUpdatePerson.Parameters.AddWithValue("@Gender", GenderId);
            cmdUpdatePerson.Parameters.AddWithValue("@Id", int.Parse(updateId.Text));

            cmdUpdatePerson.ExecuteNonQuery();

            // Step 2: Update data in the Advisor table
            string updateAdvisorQuery = "UPDATE Advisor SET Salary = @Salary, Designation = @Designation WHERE Id = @Id";
            SqlCommand cmdUpdateAdvisor = new SqlCommand(updateAdvisorQuery, con);
            cmdUpdateAdvisor.Parameters.AddWithValue("@Salary", decimal.Parse(salary.Text));
            cmdUpdateAdvisor.Parameters.AddWithValue("@Designation", DesignationId);
            cmdUpdateAdvisor.Parameters.AddWithValue("@Id", int.Parse(updateId.Text));

            cmdUpdateAdvisor.ExecuteNonQuery();

            MessageBox.Show("Advisor updated successfully.");
            DisplayAdvisorsData();
            ClearTextBoxes();

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                int advisorId = int.Parse(searchbox.Text); // Assuming searchId is the name of the TextBox for entering advisor ID

                // Search for the advisor based on the entered ID
                SqlCommand cmd = new SqlCommand("SELECT P.Id, P.FirstName, P.LastName, P.Contact, P.Email, P.DateOfBirth, " +
                                                 "GL.Value AS Gender, AL.Value AS Designation, A.Salary " +
                                                 "FROM Person P " +
                                                 "INNER JOIN Advisor A ON P.Id = A.Id " +
                                                 "INNER JOIN Lookup GL ON P.Gender = GL.Id AND GL.Category = 'GENDER' " +
                                                 "INNER JOIN Lookup AL ON A.Designation = AL.Id AND AL.Category = 'DESIGNATION' " +
                                                 "WHERE P.Id = @AdvisorId", con);
                cmd.Parameters.AddWithValue("@AdvisorId", advisorId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Advisor Found");
                    dataGridViewAdvisors.DataSource = dt; // Display the search result in the DataGridView
                }
                else
                {
                    MessageBox.Show("Advisor doesn't Exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while searching for advisor: " + ex.Message);
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
    
        
    
