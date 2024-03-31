using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class groupProject : Form
    {
        public groupProject()
        {
            InitializeComponent();
        }
        private void LoadGroupIDs()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string selectGroupIDsQuery = "SELECT Id FROM [Group]";
                SqlCommand cmdSelectGroupIDs = new SqlCommand(selectGroupIDsQuery, con);

                SqlDataReader reader = cmdSelectGroupIDs.ExecuteReader();
                groupId.Items.Clear();
                updateID.Items.Clear();
                while (reader.Read())
                {
                    groupId.Items.Add(reader["Id"].ToString());
                    updateID.Items.Add(reader["Id"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while loading group IDs: " + ex.Message);
            }
        }
        private void LoadProjectIDs()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string selectProjectIDsQuery = "SELECT Id FROM Project";
                SqlCommand cmdSelectProjectIDs = new SqlCommand(selectProjectIDsQuery, con);

                SqlDataReader reader = cmdSelectProjectIDs.ExecuteReader();
                projectid.Items.Clear();
                while (reader.Read())
                {
                    projectid.Items.Add(reader["Id"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while loading project IDs: " + ex.Message);
            }
        }
        private void AddGroupProject()
        {
            
            var con = Configuration.getInstance().getConnection();
            int selectedGroupID = Convert.ToInt32(groupId.SelectedItem);
            int selectedProjectID = Convert.ToInt32(projectid.SelectedItem);
            if (IsProjectIDExists(selectedGroupID))
            {
                MessageBox.Show("Project ID cannot be the same as an existing Group ID.");
                return;
            }

            if (IsGroupAssigned(selectedProjectID))
            {
                MessageBox.Show("Group ID cannot be the same as an existing Project ID.");
                return;
            }

            DateTime currentDate = DateTime.Now;

            string insertGroupProjectQuery = "INSERT INTO GroupProject (GroupId, ProjectId, AssignmentDate) VALUES (@GroupId, @ProjectId, @AssignmentDate)";
            SqlCommand cmdInsertGroupProject = new SqlCommand(insertGroupProjectQuery, con);
            cmdInsertGroupProject.Parameters.AddWithValue("@GroupId", selectedGroupID);
            cmdInsertGroupProject.Parameters.AddWithValue("@ProjectId", selectedProjectID);
            cmdInsertGroupProject.Parameters.AddWithValue("@AssignmentDate", currentDate);
            cmdInsertGroupProject.ExecuteNonQuery();

            MessageBox.Show("Group Project added successfully!");
        }
        private bool IsProjectIDExists(int projectID)
        {
            var con = Configuration.getInstance().getConnection();
            string checkProjectIDQuery = "SELECT COUNT(*) FROM GroupProject WHERE ProjectId = @ProjectId";
            SqlCommand cmdCheckProjectID = new SqlCommand(checkProjectIDQuery, con);
            cmdCheckProjectID.Parameters.AddWithValue("@ProjectId", projectID);
            int projectCount = Convert.ToInt32(cmdCheckProjectID.ExecuteScalar());
            return projectCount > 0;
        }

        private bool IsGroupAssigned(int groupId)
        {
            var con = Configuration.getInstance().getConnection();

            // Query to check if the group already has a project assigned
            string checkAssignmentQuery = "SELECT COUNT(*) FROM GroupProject WHERE GroupId = @GroupId";
            SqlCommand cmdCheckAssignment = new SqlCommand(checkAssignmentQuery, con);
            cmdCheckAssignment.Parameters.AddWithValue("@GroupId", groupId);

            // Execute the query and get the count of assignments
            int assignmentCount = Convert.ToInt32(cmdCheckAssignment.ExecuteScalar());

            // If the count is greater than 0, the group already has a project assigned
            return assignmentCount > 0;
        }


        private void add_Click(object sender, EventArgs e)
        {
            AddGroupProject();
            DisplayGroupProjectData();

        }

        private void groupProject_Load(object sender, EventArgs e)
        {
            LoadGroupIDs();
            LoadProjectIDs();
        }
        private void DisplayGroupProjectData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string selectGroupProjectDataQuery = "SELECT * FROM GroupProject";
                SqlCommand cmdSelectGroupProjectData = new SqlCommand(selectGroupProjectDataQuery, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectGroupProjectData);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while loading Group Project data: " + ex.Message);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            DisplayGroupProjectData();
        }
        private void SearchByProjectID(int projectID)
        {
            var con = Configuration.getInstance().getConnection();
            string selectGroupProjectDataQuery = "SELECT * FROM GroupProject WHERE ProjectId = @ProjectId";
            SqlCommand cmdSelectGroupProjectData = new SqlCommand(selectGroupProjectDataQuery, con);
            cmdSelectGroupProjectData.Parameters.AddWithValue("@ProjectId", projectID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectGroupProjectData);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Project Id Found");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No group Id found for the specified project ID.");
            }


        }

        private void search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchbox.Text.ToString(), out int projectID))
            {
                SearchByProjectID(projectID);
            }
            else
            {
                MessageBox.Show("Please select a valid project ID.");
            }
        }
        private void UpdateGroupIDByProjectID(int projectID, int newGroupID)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                if (IsGroupAssigned(newGroupID))
                {
                    MessageBox.Show("The selected Group ID is already assigned to another project. Please select a different group.");
                    return;
                }

                string updateGroupIDQuery = "UPDATE GroupProject SET GroupId = @NewGroupID WHERE ProjectId = @ProjectID";
                SqlCommand cmdUpdateGroupID = new SqlCommand(updateGroupIDQuery, con);
                cmdUpdateGroupID.Parameters.AddWithValue("@NewGroupID", newGroupID);
                cmdUpdateGroupID.Parameters.AddWithValue("@ProjectID", projectID);

                cmdUpdateGroupID.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating Group ID: " + ex.Message);
            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Check if a new Group ID is selected
            if (updateID.SelectedItem == null)
            {
                MessageBox.Show("Please select a new Group ID.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get the Project ID of the selected row
            int projectID = Convert.ToInt32(selectedRow.Cells["ProjectId"].Value);

            // Retrieve the new Group ID from the ComboBox
            int newGroupID = Convert.ToInt32(updateID.SelectedItem);

            // Check if the new Group ID is already assigned to another Project ID
            if (IsGroupAssigned(newGroupID))
            {
                MessageBox.Show("This group is already assigned to another project. Please select a different group.");
                return;
            }

            // Update the Group ID for the selected Project ID
            UpdateGroupIDByProjectID(projectID, newGroupID);

            // Refresh the displayed data
            DisplayGroupProjectData();

            MessageBox.Show("Group ID updated successfully for Project ID: " + projectID);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}

