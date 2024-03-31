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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectA
{
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            if (string.IsNullOrWhiteSpace(name.Text) ||
        string.IsNullOrWhiteSpace(marks.Text) ||
        string.IsNullOrWhiteSpace(weightage.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse textbox values
            string Name = name.Text;
            int totalMarks = int.Parse(marks.Text);
            int totalWeightage = int.Parse(weightage.Text);
                string insertQuery = "INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) VALUES (@Name, @TotalMarks, @TotalWeightage)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    // Add parameters

                    cmd.Parameters.AddWithValue("@Name", name.Text); // Use name.Text instead of name
                    cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
                    cmd.Parameters.AddWithValue("@TotalWeightage", totalWeightage);

                    // Execute query
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Evaluation added successfully!");
                    displayEvaluation();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add evaluation.");
                    }
                }
            }
            
        

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void displayEvaluation()
        {
            var con = Configuration.getInstance().getConnection();
            string selectQuery = "SELECT Id, Name, TotalMarks, TotalWeightage FROM Evaluation";

            using (SqlCommand cmd = new SqlCommand(selectQuery, con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            displayEvaluation();
        }
        private void SearchEvaluationById(int evaluationId)
        {
            
                var con = Configuration.getInstance().getConnection();

                // Select query to fetch evaluation data based on ID
                string selectQuery = "SELECT Id, Name, TotalMarks, TotalWeightage FROM Evaluation WHERE Id = @EvaluationId";

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    // Add parameter for evaluation ID
                    cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Check if any rows are returned
                    if (dt.Rows.Count > 0)
                    {
                    MessageBox.Show("Evaluation Id Found!!");
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No evaluation found with the specified ID.");
                    }
                }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idSearch.Text))
            {
                MessageBox.Show("Please enter an evaluation ID to search.");
                return;
            }

            // Parse the evaluation ID from the textbox
            if (!int.TryParse(idSearch.Text, out int evaluationId))
            {
                MessageBox.Show("Invalid evaluation ID. Please enter a valid integer ID.");
                return;
            }

            // Call the SearchEvaluationById function with the evaluation ID
            SearchEvaluationById(evaluationId);
        }

        private void UpdateID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(update.Text))
            {
                MessageBox.Show("Please enter an evaluation ID to update.");
                return;
            }

            // Parse the evaluation ID from the textbox
            if (!int.TryParse(update.Text, out int evaluationId))
            {
                MessageBox.Show("Invalid evaluation ID. Please enter a valid integer ID.");
                return;
            }

            // Check if all textboxes are filled
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(marks.Text) ||
                string.IsNullOrWhiteSpace(weightage.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse textbox values
            string Name = name.Text;
            int totalMarks;
            int totalWeightage;

            if (!int.TryParse(marks.Text, out totalMarks))
            {
                MessageBox.Show("Invalid total marks. Please enter a valid integer value.");
                return;
            }

            if (!int.TryParse(weightage.Text, out totalWeightage))
            {
                MessageBox.Show("Invalid total weightage. Please enter a valid integer value.");
                return;
            }
                var con = Configuration.getInstance().getConnection();

                // Update query
                string updateQuery = "UPDATE Evaluation SET Name = @Name, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @EvaluationId";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
                    cmd.Parameters.AddWithValue("@TotalWeightage", totalWeightage);
                    cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);

                    // Execute query
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Evaluation updated successfully!");
                        displayEvaluation();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update evaluation. Please check the provided ID.");
                    }
                }
            }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m=new Main();
            m.Show();
        }
    }
    }

