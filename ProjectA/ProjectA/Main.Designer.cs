namespace ProjectA
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.advisor = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Button();
            this.project = new System.Windows.Forms.Button();
            this.groupProject = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.evaluation = new System.Windows.Forms.Button();
            this.grpevaluation = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.projadvisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Student.Location = new System.Drawing.Point(256, 104);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(155, 42);
            this.Student.TabIndex = 0;
            this.Student.Text = "Manage Students";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "FYP MANAGEMENT SYSTEM";
            // 
            // advisor
            // 
            this.advisor.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.advisor.Location = new System.Drawing.Point(256, 152);
            this.advisor.Name = "advisor";
            this.advisor.Size = new System.Drawing.Size(155, 42);
            this.advisor.TabIndex = 3;
            this.advisor.Text = "Manage Advisors";
            this.advisor.UseVisualStyleBackColor = true;
            this.advisor.Click += new System.EventHandler(this.advisor_Click);
            // 
            // group
            // 
            this.group.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.group.Location = new System.Drawing.Point(256, 200);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(155, 42);
            this.group.TabIndex = 4;
            this.group.Text = "Manage Groups ";
            this.group.UseVisualStyleBackColor = true;
            this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // project
            // 
            this.project.BackColor = System.Drawing.Color.Transparent;
            this.project.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.project.Location = new System.Drawing.Point(256, 248);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(155, 42);
            this.project.TabIndex = 5;
            this.project.Text = "Manage Projects";
            this.project.UseVisualStyleBackColor = false;
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // groupProject
            // 
            this.groupProject.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupProject.Location = new System.Drawing.Point(256, 296);
            this.groupProject.Name = "groupProject";
            this.groupProject.Size = new System.Drawing.Size(155, 42);
            this.groupProject.TabIndex = 6;
            this.groupProject.Text = "Assign Projects";
            this.groupProject.UseVisualStyleBackColor = true;
            this.groupProject.Click += new System.EventHandler(this.groupProject_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(289, 536);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 33);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // evaluation
            // 
            this.evaluation.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.evaluation.Location = new System.Drawing.Point(256, 392);
            this.evaluation.Name = "evaluation";
            this.evaluation.Size = new System.Drawing.Size(155, 42);
            this.evaluation.TabIndex = 8;
            this.evaluation.Text = "Add Evaluation";
            this.evaluation.UseVisualStyleBackColor = true;
            this.evaluation.Click += new System.EventHandler(this.evaluation_Click);
            // 
            // grpevaluation
            // 
            this.grpevaluation.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpevaluation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpevaluation.Location = new System.Drawing.Point(256, 440);
            this.grpevaluation.Name = "grpevaluation";
            this.grpevaluation.Size = new System.Drawing.Size(155, 42);
            this.grpevaluation.TabIndex = 9;
            this.grpevaluation.Text = "Mark Evaluation";
            this.grpevaluation.UseVisualStyleBackColor = true;
            this.grpevaluation.Click += new System.EventHandler(this.grpevaluation_Click);
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.report.Location = new System.Drawing.Point(256, 488);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(155, 42);
            this.report.TabIndex = 10;
            this.report.Text = "Reports";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // projadvisor
            // 
            this.projadvisor.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projadvisor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.projadvisor.Location = new System.Drawing.Point(256, 344);
            this.projadvisor.Name = "projadvisor";
            this.projadvisor.Size = new System.Drawing.Size(155, 42);
            this.projadvisor.TabIndex = 11;
            this.projadvisor.Text = "Project Advisor";
            this.projadvisor.UseVisualStyleBackColor = true;
            this.projadvisor.Click += new System.EventHandler(this.projadvisor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::ProjectA.Properties.Resources.enlarge_images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 590);
            this.Controls.Add(this.projadvisor);
            this.Controls.Add(this.report);
            this.Controls.Add(this.grpevaluation);
            this.Controls.Add(this.evaluation);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupProject);
            this.Controls.Add(this.project);
            this.Controls.Add(this.group);
            this.Controls.Add(this.advisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Student);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button advisor;
        private System.Windows.Forms.Button group;
        private System.Windows.Forms.Button project;
        private System.Windows.Forms.Button groupProject;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button evaluation;
        private System.Windows.Forms.Button grpevaluation;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button projadvisor;
    }
}