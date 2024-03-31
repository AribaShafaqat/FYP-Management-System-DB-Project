//using iText.Layout;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void advisory_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT " +
                        "p.Title AS ProjectTitle, " +
                        "p.Description AS ProjectDescription, " +
                        "l.Value AS AdvisorRole, " +
                        "CONCAT(s.FirstName, ' ', s.LastName) AS StudentName " +
                        "FROM " +
                        "Project p " +
                        "LEFT JOIN " +
                        "ProjectAdvisor pa ON p.Id = pa.ProjectId " +
                        "LEFT JOIN " +
                        "Advisor a ON pa.AdvisorId = a.Id " +
                        "LEFT JOIN " +
                        "Lookup l ON pa.AdvisorRole = l.Id " +
                        "LEFT JOIN " +
                        "GroupProject gp ON p.Id = gp.ProjectId " +
                        "LEFT JOIN " +
                        "GroupStudent gs ON gp.GroupId = gs.GroupId " +
                        "LEFT JOIN " +
                        "Person s ON gs.StudentId = s.Id";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            // Create a new PDF document
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("Advisory_Board.pdf", FileMode.Create));

            // Open the document for writing
            document.Open();
            Paragraph heading = new Paragraph("List of projects along with advisory board and list of students");
            heading.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);

            heading.Alignment = Element.ALIGN_CENTER;
            document.Add(heading);

            // Create a table with 4 columns
            PdfPTable table = new PdfPTable(4);

            // Add table headers
            table.AddCell("Project Title");
            table.AddCell("Project Description");
            table.AddCell("Advisor Role");
            table.AddCell("Student Name");

            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.AddCell(reader["ProjectTitle"].ToString());
                    table.AddCell(reader["ProjectDescription"].ToString());
                    table.AddCell(reader["AdvisorRole"].ToString());
                    table.AddCell(reader["StudentName"].ToString());
                }
            }

            document.Add(table);

            document.Close();

            MessageBox.Show("PDF report generated successfully.");
        }

        private void evluation_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT " +
                        "Student.RegistrationNo AS RegistrationNo, " +
                        "Person.FirstName AS FirstName, " +
                        "GroupStudent.GroupId AS GroupId, " +
                        "GroupProject.ProjectId AS ProjectId, " +
                        "Project.Title AS ProjectTitle, " +
                        "Evaluation.Name AS EvaluationName, " +
                        "Evaluation.TotalMarks AS TotalMarks, " +
                        "GroupEvaluation.ObtainedMarks AS ObtainedMarks " +
                        "FROM " +
                        "Evaluation " +
                        "INNER JOIN GroupEvaluation ON Evaluation.Id = GroupEvaluation.EvaluationId " +
                        "INNER JOIN GroupProject ON GroupEvaluation.GroupId = GroupProject.GroupId " +
                        "INNER JOIN Project ON GroupProject.ProjectId = Project.Id " +
                        "INNER JOIN GroupStudent ON GroupEvaluation.GroupId = GroupStudent.GroupId " +
                        "INNER JOIN Student ON GroupStudent.StudentId = Student.Id " +
                        "INNER JOIN Person ON Person.Id = Student.Id";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            // Create a new PDF document
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("Evaluation.pdf", FileMode.Create));

            // Open the document for writing
            document.Open();

            // Add a heading to the document
            Paragraph heading = new Paragraph("Report: Student Evaluation Summary");
            heading.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
            heading.Alignment = Element.ALIGN_CENTER;
            document.Add(heading);

            // Create a table with 8 columns
            PdfPTable table = new PdfPTable(8);

            // Add table headers
            table.AddCell("Registration No");
            table.AddCell("First Name");
            table.AddCell("Group Id");
            table.AddCell("Project Id");
            table.AddCell("Project Title");
            table.AddCell("Evaluation Name");
            table.AddCell("Total Marks");
            table.AddCell("Obtained Marks");

            // Populate the table with data
            foreach (DataRow row in dataTable.Rows)
            {
                table.AddCell(row["RegistrationNo"].ToString());
                table.AddCell(row["FirstName"].ToString());
                table.AddCell(row["GroupId"].ToString());
                table.AddCell(row["ProjectId"].ToString());
                table.AddCell(row["ProjectTitle"].ToString());
                table.AddCell(row["EvaluationName"].ToString());
                table.AddCell(row["TotalMarks"].ToString());
                table.AddCell(row["ObtainedMarks"].ToString());
            }

            // Add the table to the document
            document.Add(table);

            // Close the document
            document.Close();

            MessageBox.Show("PDF report generated successfully.");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT " +
                           "P.Id AS PersonId, " +
                           "S.RegistrationNo AS RegistrationNo, " +
                           "P.FirstName AS FirstName, " +
                           "P.LastName AS LastName, " +
                           "P.Contact AS Contact, " +
                           "P.Email AS Email, " +
                           "P.DateOfBirth AS DateOfBirth, " +
                           "L.Value AS Gender " +
                           "FROM Person P " +
                           "INNER JOIN Student S ON P.Id = S.Id " +
                           "INNER JOIN Lookup L ON P.Gender = L.Id AND L.Category = 'GENDER'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("student_report.pdf", FileMode.Create));

            document.Open();

            Paragraph heading = new Paragraph("Report: Student Details");
            heading.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
            heading.Alignment = Element.ALIGN_CENTER;
            document.Add(heading);

            PdfPTable table = new PdfPTable(8);

            table.AddCell("Person ID");
            table.AddCell("Registration No");
            table.AddCell("First Name");
            table.AddCell("Last Name");
            table.AddCell("Contact");
            table.AddCell("Email");
            table.AddCell("Date of Birth");
            table.AddCell("Gender");

            foreach (DataRow row in dataTable.Rows)
            {
                table.AddCell(row["PersonId"].ToString());
                table.AddCell(row["RegistrationNo"].ToString());
                table.AddCell(row["FirstName"].ToString());
                table.AddCell(row["LastName"].ToString());
                table.AddCell(row["Contact"].ToString());
                table.AddCell(row["Email"].ToString());
                table.AddCell(row["DateOfBirth"].ToString());
                table.AddCell(row["Gender"].ToString());
            }

            document.Add(table);

            document.Close();

            MessageBox.Show("PDF report generated successfully.");
        }

        private void advisor_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT " +
                               "P.Id AS PersonId, " +
                               "P.FirstName AS FirstName, " +
                               "P.LastName AS LastName, " +
                               "P.Contact AS Contact, " +
                               "P.Email AS Email, " +
                               "P.DateOfBirth AS DateOfBirth, " +
                               "A.Salary AS Salary, " +
                               "L.Value AS Designation " +
                               "FROM Person P " +
                               "INNER JOIN Advisor A ON P.Id = A.Id " +
                               "INNER JOIN Lookup L ON A.Designation = L.Id AND L.Category = 'DESIGNATION'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("advisor_report.pdf", FileMode.Create));

                document.Open();

                Paragraph heading = new Paragraph("Report: Advisor Details");
                heading.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);

              
                PdfPTable table = new PdfPTable(8);

                table.AddCell("Person ID");
                table.AddCell("First Name");
                table.AddCell("Last Name");
                table.AddCell("Contact");
                table.AddCell("Email");
                table.AddCell("Date of Birth");
                table.AddCell("Salary");
                table.AddCell("Designation");

                foreach (DataRow row in dataTable.Rows)
                {
                    table.AddCell(row["PersonId"].ToString());
                    table.AddCell(row["FirstName"].ToString());
                    table.AddCell(row["LastName"].ToString());
                    table.AddCell(row["Contact"].ToString());
                    table.AddCell(row["Email"].ToString());
                    table.AddCell(row["DateOfBirth"].ToString());
                    table.AddCell(row["Salary"].ToString());
                    table.AddCell(row["Designation"].ToString());
                }

                document.Add(table);

                document.Close();

                MessageBox.Show("PDF report generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating advisor report: {ex.Message}");
            }
        }

        //private void group_Click(object sender, EventArgs e)
        //{
        //    SqlConnection connection = Configuration.getInstance().getConnection();
        //    if (connection != null)
        //    {
        //        string query = "SELECT [Group].Id AS GroupId, [Group].Created_On AS CreatedOn, " +
        //                       "STUFF((SELECT ', ' + Person.FirstName + ' ' + Person.LastName AS [text()] " +
        //                       "       FROM GroupStudent " +
        //                       "       INNER JOIN Person ON GroupStudent.StudentId = Person.Id " +
        //                       "       WHERE GroupStudent.GroupId = [Group].Id " +
        //                       "       FOR XML PATH('')), 1, 2, '') AS Students " +
        //                       "FROM [Group] " +
        //                       "WHERE EXISTS (SELECT 1 FROM GroupStudent WHERE GroupStudent.GroupId = [Group].Id)";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        DataTable dataTable = new DataTable();
        //        adapter.Fill(dataTable);
        //        dataGridView1.DataSource = dataTable;


        //        if (dataTable.Rows.Count > 0)
        //        {
        //            // Create a new PDF document
        //            Document document = new Document();
        //            PdfWriter.GetInstance(document, new FileStream("group_report.pdf", FileMode.Create));

        //            // Open the document for writing
        //            document.Open();

        //            // Add a heading to the document
        //            Paragraph heading = new Paragraph("Report: Group and Assigned Students Details");
        //            heading.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
        //            heading.Alignment = Element.ALIGN_CENTER;
        //            document.Add(heading);

        //            // Create a table with 3 columns
        //            PdfPTable table = new PdfPTable(3);

        //            // Add table headers
        //            table.AddCell("Group ID");
        //            table.AddCell("Created On");
        //            table.AddCell("Students");

        //            // Populate the table with data
        //            foreach (DataRow row in dataTable.Rows)
        //            {
        //                table.AddCell(row["GroupId"].ToString());
        //                table.AddCell(row["CreatedOn"].ToString());
        //                table.AddCell(row["Students"].ToString());
        //            }

        //            // Add the table to the document
        //            document.Add(table);

        //            // Close the document
        //            document.Close();

        //            MessageBox.Show("PDF report generated successfully.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("No data found to generate the report.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed to connect to the database.");
        //    }
        //}
    }
}

        


   
