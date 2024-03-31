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
    public partial class ProjectAdvisor : Form
    {
        public ProjectAdvisor()
        {
            InitializeComponent();
        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            LoadProjectIDs();
            LoadAdvisorIDs();
        }
        private void LoadProjectIDs()
        {
            var con = Configuration.getInstance().getConnection();
            string selectProjectIDsQuery = "SELECT Id FROM Project";
            SqlCommand cmdSelectProjectIDs = new SqlCommand(selectProjectIDsQuery, con);
            SqlDataReader reader = cmdSelectProjectIDs.ExecuteReader();

            // Clear existing items in the ComboBox
            comboBoxproject.Items.Clear();
            searchbox.Items.Clear();

            // Add each project ID to the ComboBox
            while (reader.Read())
            {
                comboBoxproject.Items.Add(reader["Id"].ToString());
                searchbox.Items.Add(reader["Id"].ToString());

            }

            // Close the reader
            reader.Close();
        }

        private void LoadAdvisorIDs()
        {
            var con = Configuration.getInstance().getConnection();
            string selectAdvisorIDsQuery = "SELECT Id FROM Advisor";
            SqlCommand cmdSelectAdvisorIDs = new SqlCommand(selectAdvisorIDsQuery, con);
            SqlDataReader reader = cmdSelectAdvisorIDs.ExecuteReader();

            // Clear existing items in the ComboBox
            comboBoxadvisor.Items.Clear();

            // Add each advisor ID to the ComboBox
            while (reader.Read())
            {
                comboBoxadvisor.Items.Add(reader["Id"].ToString());
            }

            // Close the reader
            reader.Close();
        }
        private int GetAdvisorRoleID(string advisorRole)
        {
            var con = Configuration.getInstance().getConnection();
            string selectAdvisorRoleIDQuery = "SELECT Id FROM Lookup WHERE Value = @AdvisorRole AND Category = 'ADVISOR_ROLE'";
            SqlCommand cmdSelectAdvisorRoleID = new SqlCommand(selectAdvisorRoleIDQuery, con);
            cmdSelectAdvisorRoleID.Parameters.AddWithValue("@AdvisorRole", advisorRole);
            int advisorRoleID = Convert.ToInt32(cmdSelectAdvisorRoleID.ExecuteScalar());
            return advisorRoleID;
        }

        private void assign_Click(object sender, EventArgs e)
        {
            if (comboBoxproject.SelectedItem == null || comboBoxadvisor.SelectedItem == null || comboBoxrole.SelectedItem == null)
            {
                MessageBox.Show("Please select ProjectID, AdvisorID, and AdvisorRole.");
                return;
            }

            var con = Configuration.getInstance().getConnection();

            // Retrieve selected values from ComboBoxes
            int projectID = Convert.ToInt32(comboBoxproject.SelectedItem);
            int advisorID = Convert.ToInt32(comboBoxadvisor.SelectedItem);
            string advisorRole = comboBoxrole.SelectedItem.ToString();

            // Get the AdvisorRole ID from the Lookup table
            int advisorRoleID = GetAdvisorRoleID(advisorRole);

            // Insert data into the ProjectAdvisor table
            string insertProjectAdvisorQuery = "INSERT INTO ProjectAdvisor (ProjectId, AdvisorId, AdvisorRole, AssignmentDate) VALUES (@ProjectId, @AdvisorId, @AdvisorRoleID, @AssignmentDate)";
            SqlCommand cmdInsertProjectAdvisor = new SqlCommand(insertProjectAdvisorQuery, con);
            cmdInsertProjectAdvisor.Parameters.AddWithValue("@ProjectId", projectID);
            cmdInsertProjectAdvisor.Parameters.AddWithValue("@AdvisorId", advisorID);
            cmdInsertProjectAdvisor.Parameters.AddWithValue("@AdvisorRoleID", advisorRoleID);
            cmdInsertProjectAdvisor.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);

            // Execute the query
            cmdInsertProjectAdvisor.ExecuteNonQuery();

            MessageBox.Show("Project Advisor added successfully!");
            displaydata();
        }

        private void display_Click(object sender, EventArgs e)
        {
            displaydata();

        }
        private void displaydata()
        {
            var con = Configuration.getInstance().getConnection();

            // Query to select data from the ProjectAdvisor table
            string selectProjectAdvisorDataQuery = "SELECT PA.ProjectId, PA.AdvisorId, L.Value AS AdvisorRole " +
                                                    "FROM ProjectAdvisor PA " +
                                                    "JOIN Lookup L ON PA.AdvisorRole = L.Id";
            SqlCommand cmdSelectProjectAdvisorData = new SqlCommand(selectProjectAdvisorDataQuery, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectProjectAdvisorData);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Project ID to search for.");
                return;
            }
            int selectedProjectID = Convert.ToInt32(searchbox.SelectedItem);


            SearchByProjectID(selectedProjectID);
        }
        private void SearchByProjectID(int projectID)
        {
            var con = Configuration.getInstance().getConnection();

            // Query to select data from the ProjectAdvisor table based on Project ID
            string selectProjectAdvisorDataQuery = "SELECT pa.ProjectId, pa.AdvisorId, lu.Value as AdvisorRole " +
                                                    "FROM ProjectAdvisor pa " +
                                                    "INNER JOIN Lookup lu ON pa.AdvisorRole = lu.Id " +
                                                    "WHERE pa.ProjectId = @ProjectId AND lu.Category = 'ADVISOR_ROLE'";
            SqlCommand cmdSelectProjectAdvisorData = new SqlCommand(selectProjectAdvisorDataQuery, con);
            cmdSelectProjectAdvisorData.Parameters.AddWithValue("@ProjectId", projectID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectProjectAdvisorData);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Project Advisors Found");
                dataGridView1.DataSource = dt;
            }
            else
            {
                // No data found for the given project ID
                MessageBox.Show("No project advisors found for the specified project ID.");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve data from the selected row
                string projectIdStr = selectedRow.Cells["ProjectId"].Value?.ToString();
                string advisorIdStr = selectedRow.Cells["AdvisorId"].Value?.ToString();
                string advisorRole = selectedRow.Cells["AdvisorRole"].Value?.ToString();

                // Check if any of the data is null
                if (projectIdStr == null || advisorIdStr == null || advisorRole == null)
                {
                    MessageBox.Show("Selected row does not contain complete data for update.");
                    return;
                }

                // Parse the IDs
                if (!int.TryParse(projectIdStr, out int projectId) || !int.TryParse(advisorIdStr, out int advisorId))
                {
                    MessageBox.Show("Invalid project or advisor ID.");
                    return;
                }

                // Get the AdvisorRole ID from the Lookup table
                int advisorRoleID = GetAdvisorRoleID(advisorRole);

                // Ensure AdvisorRole ID is valid
                if (advisorRoleID == -1)
                {
                    MessageBox.Show("Invalid advisor role.");
                    return;
                }

                // Perform the update
                UpdateProjectAdvisor(projectId, advisorId, advisorRoleID);
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }


        }

        private void UpdateProjectAdvisor(int projectId, int newAdvisorID, int newAdvisorRoleID)
        {
            using (var con = Configuration.getInstance().getConnection())
            {
                string updateProjectAdvisorQuery = @"UPDATE ProjectAdvisor 
                                            SET AdvisorId = @NewAdvisorId, 
                                                AdvisorRole = @NewAdvisorRoleID, 
                                                AssignmentDate = @AssignmentDate
                                            WHERE ProjectId = @ProjectId";

                using (SqlCommand cmdUpdateProjectAdvisor = new SqlCommand(updateProjectAdvisorQuery, con))
                {
                    cmdUpdateProjectAdvisor.Parameters.AddWithValue("@NewAdvisorId", newAdvisorID);
                    cmdUpdateProjectAdvisor.Parameters.AddWithValue("@NewAdvisorRoleID", newAdvisorRoleID);
                    cmdUpdateProjectAdvisor.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                    cmdUpdateProjectAdvisor.Parameters.AddWithValue("@ProjectId", projectId);

                    int rowsAffected = cmdUpdateProjectAdvisor.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Project Advisor updated successfully!");
                        displaydata();
                    }
                    else
                    {
                        MessageBox.Show("No project advisor found for the specified project ID.");
                    }
                }
            }
        }


    }
}
