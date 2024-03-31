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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            title.Text = string.Empty;
            description.Text = string.Empty;
            updateid.Text = string.Empty;
            //  textBox3.Text = string.Empty;

        }

        private void add_Click(object sender, EventArgs e)
        {
            string Title = title.Text;
            string Description = description.Text;

            InsertProject(Title, Description);
            DisplayProjects();
            ClearTextBoxes();
        }
        private void InsertProject(string title, string description)
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                {
                    string insertQuery = "INSERT INTO Project (Title, Description) VALUES (@Title, @Description)";
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, connection);
                    cmdInsert.Parameters.AddWithValue("@Title", title);
                    cmdInsert.Parameters.AddWithValue("@Description", description);


                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Project added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private void DisplayProjects()
        {
            try
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                {
                    string selectQuery = "SELECT * FROM Project";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
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

        private void display_Click(object sender, EventArgs e)
        {
            DisplayProjects();
        }
        
        

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(updateid.Text, out int projectId))
                {
                    string newTitle = title.Text;
                    string newDescription = description.Text;

                    UpdateProject(projectId, newTitle, newDescription);
                    DisplayProjects(); 
                    ClearTextBoxes(); 
                }
                else
                {
                    MessageBox.Show("Please enter a valid project ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private void UpdateProject(int projectId, string newTitle, string newDescription)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string updateProjectQuery = @"UPDATE Project 
                                      SET Title = @Title, 
                                          Description = @Description
                                      WHERE Id = @Id";
                SqlCommand cmdUpdateProject = new SqlCommand(updateProjectQuery, con);
                cmdUpdateProject.Parameters.AddWithValue("@Title", newTitle);
                cmdUpdateProject.Parameters.AddWithValue("@Description", newDescription);
                cmdUpdateProject.Parameters.AddWithValue("@Id", projectId);

                cmdUpdateProject.ExecuteNonQuery();

                MessageBox.Show("Project updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(searchbox.Text, out int projectId))
                {
                    SearchProjectById(projectId);
                }
                else
                {
                    MessageBox.Show("Please enter a valid project ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private void SearchProjectById(int projectId)
        {
            if (int.TryParse(searchbox.Text, out int projectID))
            {
                SqlConnection connection = Configuration.getInstance().getConnection();
                string selectQuery = "SELECT * FROM Project WHERE Id = @ProjectId";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MessageBox.Show(" Project Found");
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please enter a valid project ID.");
            }
           
        }
       


        private void project_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m=new Main();
            m.Show();
        }
    }
}

