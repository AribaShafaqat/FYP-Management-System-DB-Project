namespace ProjectA
{
    partial class Report
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
            this.advisory = new System.Windows.Forms.Button();
            this.evluation = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student = new System.Windows.Forms.Button();
            this.advisor = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // advisory
            // 
            this.advisory.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisory.Location = new System.Drawing.Point(67, 63);
            this.advisory.Name = "advisory";
            this.advisory.Size = new System.Drawing.Size(160, 35);
            this.advisory.TabIndex = 0;
            this.advisory.Text = "Advisory Board";
            this.advisory.UseVisualStyleBackColor = true;
            this.advisory.Click += new System.EventHandler(this.advisory_Click);
            // 
            // evluation
            // 
            this.evluation.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evluation.Location = new System.Drawing.Point(67, 112);
            this.evluation.Name = "evluation";
            this.evluation.Size = new System.Drawing.Size(160, 35);
            this.evluation.TabIndex = 1;
            this.evluation.Text = "Evaluation";
            this.evluation.UseVisualStyleBackColor = true;
            this.evluation.Click += new System.EventHandler(this.evluation_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(144, 375);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 31);
            this.exit.TabIndex = 29;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 436);
            this.dataGridView1.TabIndex = 30;
            // 
            // student
            // 
            this.student.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(67, 162);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(160, 35);
            this.student.TabIndex = 31;
            this.student.Text = "Students";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // advisor
            // 
            this.advisor.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor.Location = new System.Drawing.Point(67, 212);
            this.advisor.Name = "advisor";
            this.advisor.Size = new System.Drawing.Size(160, 35);
            this.advisor.TabIndex = 32;
            this.advisor.Text = "Advisors";
            this.advisor.UseVisualStyleBackColor = true;
            this.advisor.Click += new System.EventHandler(this.advisor_Click);
            // 
            // group
            // 
            this.group.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(67, 262);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(160, 35);
            this.group.TabIndex = 33;
            this.group.Text = "Groups";
            this.group.UseVisualStyleBackColor = true;
          //  this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectA.Properties.Resources.istockphoto_1294598267_612x612;
            this.ClientSize = new System.Drawing.Size(1262, 708);
            this.Controls.Add(this.group);
            this.Controls.Add(this.advisor);
            this.Controls.Add(this.student);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.evluation);
            this.Controls.Add(this.advisory);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button advisory;
        private System.Windows.Forms.Button evluation;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button advisor;
        private System.Windows.Forms.Button group;
    }
}