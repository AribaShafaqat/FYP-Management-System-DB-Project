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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            LoadGroupIDs();
            LoadEvaluationIDs();
        }
        private void LoadGroupIDs()
        {
            var con = Configuration.getInstance().getConnection();
            string selectGroupIDsQuery = "SELECT Id FROM [Group]";
            SqlCommand cmdSelectGroupIDs = new SqlCommand(selectGroupIDsQuery, con);

            SqlDataReader reader = cmdSelectGroupIDs.ExecuteReader();
            comboBoxgroup.Items.Clear();
            //updateID.Items.Clear();
            while (reader.Read())
            {
                comboBoxgroup.Items.Add(reader["Id"].ToString());
                //updateID.Items.Add(reader["Id"].ToString());
            }
            reader.Close();
        }
        private void LoadEvaluationIDs()
        {
            var con = Configuration.getInstance().getConnection();

            using (SqlCommand command = new SqlCommand("SELECT Id FROM Evaluation", con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    comboBoxEvaluation.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxEvaluation.Items.Add(reader["Id"].ToString());
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (comboBoxgroup.SelectedItem == null ||
                comboBoxEvaluation.SelectedItem == null ||
                 string.IsNullOrWhiteSpace(obtmarks.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var con = Configuration.getInstance().getConnection();

            // Parse selected combo box values
            int groupID = int.Parse(comboBoxgroup.SelectedItem.ToString());
            int evaluationID = int.Parse(comboBoxEvaluation.SelectedItem.ToString());
            int obtainedMarks = int.Parse(obtmarks.Text);
            DateTime evaluationDate = DateTime.Now;

            // Insert into GroupEvaluation table
            string insertQuery = "INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@GroupId", groupID);
                cmd.Parameters.AddWithValue("@EvaluationId", evaluationID);
                cmd.Parameters.AddWithValue("@ObtainedMarks", obtainedMarks);
                cmd.Parameters.AddWithValue("@EvaluationDate", evaluationDate);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Group evaluation added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add group evaluation.");
                }
            }
        }
        private void DisplayData()
        {
            var con = Configuration.getInstance().getConnection();
            string selectQuery = "SELECT GroupId, EvaluationId, ObtainedMarks, EvaluationDate FROM GroupEvaluation";

            using (SqlCommand command = new SqlCommand(selectQuery, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void display_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchID.Text))
            {
                // Search for group evaluation based on Group ID
                int groupID = Convert.ToInt32(SearchID.Text);

                var con = Configuration.getInstance().getConnection();
                string selectQuery = "SELECT GroupId, EvaluationId, ObtainedMarks, EvaluationDate FROM GroupEvaluation WHERE GroupId = @GroupId";

                using (SqlCommand command = new SqlCommand(selectQuery, con))
                {
                    command.Parameters.AddWithValue("@GroupId", groupID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the search results
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        MessageBox.Show("Found!!");
                        dataGridView1.DataSource = dataTable;


                    }
                }

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(updatebox.Text))
            {
                int groupID = Convert.ToInt32(updatebox.Text);
                int newObtainedMarks = Convert.ToInt32(newobt.Text);

                var con = Configuration.getInstance().getConnection();
                string updateQuery = "UPDATE GroupEvaluation SET ObtainedMarks = @NewObtainedMarks WHERE GroupId = @GroupId";

                using (SqlCommand command = new SqlCommand(updateQuery, con))
                {
                    command.Parameters.AddWithValue("@NewObtainedMarks", newObtainedMarks);
                    command.Parameters.AddWithValue("@GroupId", groupID);

                  
                    int rowsAffected = command.ExecuteNonQuery();
                  

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Obtained marks updated successfully!");
                        DisplayData(); // Refresh the displayed data after update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update obtained marks.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Group ID to update.");
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


