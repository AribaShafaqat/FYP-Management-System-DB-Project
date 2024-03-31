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
    public partial class group : Form
    {
        public group()
        {
            InitializeComponent();
        }
        private int lastDisplayedGroupId = -1;



        private void create_Click(object sender, EventArgs e)
        {
            string createdOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            InsertNewGroup(createdOn);
        }
        private void InsertNewGroup(string createdOn)
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                {
                    string insertGroupQuery = "INSERT INTO [Group] (Created_On) VALUES (@CreatedOn); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdInsertGroup = new SqlCommand(insertGroupQuery, connection);
                    cmdInsertGroup.Parameters.AddWithValue("@CreatedOn", createdOn);
                    int newGroupId = Convert.ToInt32(cmdInsertGroup.ExecuteScalar());

                    MessageBox.Show("Group created successfully!");
                    DisplayGroups();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            DisplayGroups();
        }
        private void DisplayGroups()
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                {
                    string selectGroupsQuery = "SELECT * FROM [Group]";
                    SqlCommand cmdSelectGroups = new SqlCommand(selectGroupsQuery, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectGroups);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private int GetSelectedGroupId()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            }
            else
            {
                MessageBox.Show("Please select a group.");
                return -1;
            }
        }
        private List<int> GetSelectedStudentIdsFromCheckedListBox()
        {
            // Parse the selected list of student IDs from the CheckedListBox
            List<int> selectedStudentIds = new List<int>();

            // Loop through the checked items in the CheckedListBox
            foreach (var item in STUDENTIDS.CheckedItems)
            {
                // Add the checked student ID to the list
                selectedStudentIds.Add((int)item);
            }

            return selectedStudentIds;
        }

        //private List<int> GetSelectedStudentIds()
        //{
        //    List<int> studentIds = new List<int>();

        //    string[] studentIdsString = studentid.Text.Split(',');

        //    foreach (string idString in studentIdsString)
        //    {
        //        if (int.TryParse(idString.Trim(), out int id))
        //        {
        //            studentIds.Add(id);
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Invalid student ID: {idString}");
        //            return new List<int>(); 
        //        }
        //    }

        //    return studentIds;
        //}
        private void AddStudentsToGroup(int groupId, List<int> studentIds, int statusId)
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                foreach (int studentId in studentIds)
                {
                    string insertGroupStudentQuery = "INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@GroupId, @StudentId, @Status, @AssignmentDate)";
                    SqlCommand cmdInsertGroupStudent = new SqlCommand(insertGroupStudentQuery, connection);
                    cmdInsertGroupStudent.Parameters.AddWithValue("@GroupId", groupId);
                    cmdInsertGroupStudent.Parameters.AddWithValue("@StudentId", studentId);
                    cmdInsertGroupStudent.Parameters.AddWithValue("@Status", statusId);
                    cmdInsertGroupStudent.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                    cmdInsertGroupStudent.ExecuteNonQuery();
                }

                MessageBox.Show("Students added to group successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void PopulateStatusComboBox()
        {
            comboBoxStatus.Items.Clear();
            string query = "SELECT Value FROM Lookup WHERE Category = 'STATUS'";

            using (SqlConnection connection = Configuration.getInstance().getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxStatus.Items.Add(reader["Value"].ToString());
                }
            }
        }

        private int GetStatusId(string statusValue)
        {
            try
            {
                string query = "SELECT Id FROM Lookup WHERE Value = @StatusValue AND Category = 'STATUS'";

                SqlConnection connection = Configuration.getInstance().getConnection();
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StatusValue", statusValue);
                    int statusId = (int)command.ExecuteScalar();

                    return statusId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while retrieving status ID: " + ex.Message);
                return -1;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            int selectedGroupId = GetSelectedGroupId();

            if (selectedGroupId != -1)
            {
                List<int> selectedStudentIds = GetSelectedStudentIdsFromCheckedListBox();
                int currentGroupStudentCount = GetGroupStudentCount(selectedGroupId);
                int maxGroupSize = 10; // Set the maximum group size
                int remainingCapacity = maxGroupSize - currentGroupStudentCount;

                if (selectedStudentIds.Count > remainingCapacity)
                {
                    MessageBox.Show($"Cannot add. The maximum number of students allowed in a group is 10");
                    return;
                }
                string selectedStatus = comboBoxStatus.SelectedItem.ToString();
                int statusId = GetStatusId(selectedStatus);
                AddStudentsToGroup(selectedGroupId, selectedStudentIds, statusId);
                // studentid.Clear();
            }
            else
            {
                MessageBox.Show("Please select a group.");
            }

            //int selectedGroupId = GetSelectedGroupId();

            //if (selectedGroupId != -1)
            //{
            //    List<int> selectedStudentIds = GetSelectedStudentIds();
            //    int currentGroupStudentCount = GetGroupStudentCount(selectedGroupId);
            //    int maxGroupSize = 10; // Set the maximum group size
            //    int remainingCapacity = maxGroupSize - currentGroupStudentCount;

            //    if (selectedStudentIds.Count > remainingCapacity)
            //    {
            //        MessageBox.Show($"Cannot add.The maximum number of students allowed in a group is 10");
            //        return;
            //    }
            //    string selectedStatus = comboBoxStatus.SelectedItem.ToString();
            //    int statusId = GetStatusId(selectedStatus);
            //    AddStudentsToGroup(selectedGroupId, selectedStudentIds, statusId);
            //    studentid.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("Please select a group.");
            //}
        }

        private int GetGroupStudentCount(int groupId)
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                string countQuery = "SELECT COUNT(*) FROM GroupStudent WHERE GroupId = @GroupId";
                SqlCommand cmdCount = new SqlCommand(countQuery, connection);
                cmdCount.Parameters.AddWithValue("@GroupId", groupId);

                int count = (int)cmdCount.ExecuteScalar();

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while retrieving group student count: " + ex.Message);
                return -1;
            }
        }
        private void DisplayGroupStudents(int groupId)
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                {
                    string selectGroupStudentsQuery = "SELECT GroupStudent.GroupId, GroupStudent.StudentId, Lookup.Value AS Status, GroupStudent.AssignmentDate " +
                                                      "FROM GroupStudent " +
                                                      "INNER JOIN Lookup ON GroupStudent.Status = Lookup.Id " +
                                                      "WHERE GroupStudent.GroupId = @GroupId";
                    SqlCommand cmdSelectGroupStudents = new SqlCommand(selectGroupStudentsQuery, connection);
                    cmdSelectGroupStudents.Parameters.AddWithValue("@GroupId", groupId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectGroupStudents);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    // Display the group students in a DataGridView
                    dataGridView1.DataSource = dt;

                    // Optionally, set the column header for the Group ID
                    dataGridView1.Columns["GroupId"].HeaderText = "Group ID";
                    lastDisplayedGroupId = groupId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while retrieving group students: " + ex.Message);
            }
            //try
            //{
            //    SqlConnection connection = Configuration.getInstance().getConnection();
            //    {
            //        string selectGroupStudentsQuery = "SELECT GroupStudent.GroupId, Student.Id AS StudentId, Lookup.Value AS Status, GroupStudent.AssignmentDate " +
            //                                          "FROM Student " +
            //                                          "INNER JOIN GroupStudent ON Student.Id = GroupStudent.StudentId " +
            //                                          "INNER JOIN Lookup ON GroupStudent.Status = Lookup.Id " +
            //                                          "WHERE GroupStudent.GroupId = @GroupId";
            //        SqlCommand cmdSelectGroupStudents = new SqlCommand(selectGroupStudentsQuery, connection);
            //        cmdSelectGroupStudents.Parameters.AddWithValue("@GroupId", groupId);

            //        SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectGroupStudents);
            //        DataTable dt = new DataTable();

            //        adapter.Fill(dt);

            //        // Display the group students in a DataGridView
            //        dataGridView1.DataSource = dt;

            //        // Optionally, set the column header for the Group ID
            //        dataGridView1.Columns["GroupId"].HeaderText = "Group ID";
            //        lastDisplayedGroupId = groupId;

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error occurred while retrieving group students: " + ex.Message);
            //}



        }

       

        private void group_Load(object sender, EventArgs e)
        {
            AddStudentIdsToCheckedListBox();
        }

        private void groupStudents_Click(object sender, EventArgs e)
        {

            int selectedGroupId = GetSelectedGroupId();

            if (selectedGroupId != -1)
            {
                DisplayGroupStudents(selectedGroupId);
            }
            else
            {
                MessageBox.Show("Please select a group first.");
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxStatus.SelectedItem.ToString();
            int statusId = GetStatusId(selectedStatus);
        }
        private void AddStudentIdsToCheckedListBox()
        {
            try
            {

                SqlConnection connection = Configuration.getInstance().getConnection();
                string selectQuery = "SELECT Id FROM Student";

                SqlCommand cmdSelectStudentIds = new SqlCommand(selectQuery, connection);

                SqlDataReader reader = cmdSelectStudentIds.ExecuteReader();

                STUDENTIDS.Items.Clear();

                while (reader.Read())
                {
                    STUDENTIDS.Items.Add(reader["Id"], isChecked: false);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding student IDs to CheckedListBox: " + ex.Message);
            }
        }
        private void updateGrp_Click(object sender, EventArgs e)
        {
            int currentStudentId = GetSelectedStudentId();

            if (currentStudentId != -1)
            {
                // Get the new student ID entered by the user
                if (int.TryParse(newID.Text.Trim(), out int newStudentId))
                {
                    // Get the selected status from the ComboBox
                    string selectedStatus = comboBoxStatus.SelectedItem.ToString();

                    // Update the student ID and status
                    UpdateStudentId(currentStudentId, newStudentId, selectedStatus);

                    // Refresh the DataGridView with the last displayed group ID
                    if (lastDisplayedGroupId != -1)
                    {
                        DisplayGroupStudents(lastDisplayedGroupId);
                    }
                    else
                    {
                        MessageBox.Show("Error: No group ID available to refresh the DataGridView.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid new student ID.");
                }
            }

            //int currentStudentId = GetSelectedStudentId();

            //if (currentStudentId != -1)
            //{
            //    // Get the new student ID entered by the user
            //    if (int.TryParse(newID.Text.Trim(), out int newStudentId))
            //    {
            //        // Update the student ID
            //        UpdateStudentId(currentStudentId, newStudentId);

            //        // Refresh the DataGridView with the last displayed group ID
            //        if (lastDisplayedGroupId != -1)
            //        {
            //            DisplayGroupStudents(lastDisplayedGroupId);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error: No group ID available to refresh the DataGridView.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter a valid new student ID.");
            //    }
            //}
        }

        private int GetSelectedStudentId()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return (int)dataGridView1.SelectedRows[0].Cells["StudentId"].Value;
            }
            else
            {
                MessageBox.Show("Please select a student.");
                return -1;
            }
        }

        //private void UpdateStudentId(int currentStudentId, int newStudentId)
        //{
        //    try
        //    {
        //        // Create a new connection
        //        SqlConnection connection = Configuration.getInstance().getConnection();

        //        // Define the update query
        //        string updateQuery = "UPDATE GroupStudent SET StudentId = @NewStudentId WHERE StudentId = @StudentId";

        //        // Create a new command
        //        SqlCommand cmdUpdateStudentId = new SqlCommand(updateQuery, connection);

        //        // Add parameters
        //        cmdUpdateStudentId.Parameters.AddWithValue("@NewStudentId", newStudentId);
        //        cmdUpdateStudentId.Parameters.AddWithValue("@StudentId", currentStudentId);



        //        // Execute the command
        //        int rowsAffected = cmdUpdateStudentId.ExecuteNonQuery();

        //        // Close the connection


        //        if (rowsAffected > 0)
        //        {
        //            // Display success message
        //            MessageBox.Show("Student ID updated successfully.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("No records were updated.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any exceptions
        //        MessageBox.Show("Error occurred: " + ex.Message);
        //    }
        //}
        private void UpdateStudentId(int currentStudentId, int newStudentId, string selectedStatus)
        {
            try
            {
                // Get the status ID corresponding to the selected status value
                int newStatusId = GetStatusId(selectedStatus);

                // Create a new connection
                SqlConnection connection = Configuration.getInstance().getConnection();

                // Define the update query
                string updateQuery = "UPDATE GroupStudent SET StudentId = @NewStudentId, Status = @NewStatusId WHERE StudentId = @StudentId";

                // Create a new command
                SqlCommand cmdUpdateStudentId = new SqlCommand(updateQuery, connection);

                // Add parameters
                cmdUpdateStudentId.Parameters.AddWithValue("@NewStudentId", newStudentId);
                cmdUpdateStudentId.Parameters.AddWithValue("@NewStatusId", newStatusId); // Add status parameter
                cmdUpdateStudentId.Parameters.AddWithValue("@StudentId", currentStudentId);

                // Execute the command
                int rowsAffected = cmdUpdateStudentId.ExecuteNonQuery();

                // Close the connection

                if (rowsAffected > 0)
                {
                    // Display success message
                    MessageBox.Show("Student ID and status updated successfully.");
                }
                else
                {
                    MessageBox.Show("No records were updated.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }




        private void searchgrp_Click(object sender, EventArgs e)
        {
            {
                // Get the group ID entered by the user
                if (int.TryParse(searchGroup.Text, out int groupId))
                {
                    try
                    {
                        // Retrieve the group information based on the entered ID
                        SqlConnection connection = Configuration.getInstance().getConnection();
                        string selectGroupByIdQuery = "SELECT * FROM [Group] WHERE Id = @GroupId";
                        SqlCommand cmdSelectGroupById = new SqlCommand(selectGroupByIdQuery, connection);
                        cmdSelectGroupById.Parameters.AddWithValue("@GroupId", groupId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectGroupById);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Display the group information in the DataGridView
                            MessageBox.Show("Group Found");
                            dataGridView1.DataSource = dt;

                        }
                        else
                        {
                            MessageBox.Show("Group not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred while searching for group: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid group ID.");
                }

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



