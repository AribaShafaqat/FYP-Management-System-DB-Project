using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void advisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Advisor a = new Advisor();
            a.Show();
        }

        private void group_Click(object sender, EventArgs e)
        {
            this.Hide();
            group g = new group();
            g.Show();
        }

        private void project_Click(object sender, EventArgs e)
        {
            this.Hide();
            project p = new project();
            p.Show();
        }

        private void groupProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            groupProject gp = new groupProject();
            gp.Show();
        }

        private void evaluation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluation ev= new Evaluation();
            ev.Show();
        }

        private void grpevaluation_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupEvaluation ge = new GroupEvaluation();
            ge.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r = new Report();
            r.Show();
        }

        private void projadvisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectAdvisor p = new ProjectAdvisor();
            p.Show();
        }
    }
}
