namespace ProjectA
{
    partial class Advisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.comboBoxdesignation = new System.Windows.Forms.ComboBox();
            this.dataGridViewAdvisors = new System.Windows.Forms.DataGridView();
            this.display = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updateId = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvisors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desgination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(82, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(185, 327);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(173, 22);
            this.salary.TabIndex = 3;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(403, 171);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 37);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // comboBoxdesignation
            // 
            this.comboBoxdesignation.FormattingEnabled = true;
            this.comboBoxdesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.comboBoxdesignation.Location = new System.Drawing.Point(185, 285);
            this.comboBoxdesignation.Name = "comboBoxdesignation";
            this.comboBoxdesignation.Size = new System.Drawing.Size(173, 24);
            this.comboBoxdesignation.TabIndex = 5;
            // 
            // dataGridViewAdvisors
            // 
            this.dataGridViewAdvisors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAdvisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdvisors.Location = new System.Drawing.Point(563, 21);
            this.dataGridViewAdvisors.Name = "dataGridViewAdvisors";
            this.dataGridViewAdvisors.RowHeadersWidth = 51;
            this.dataGridViewAdvisors.RowTemplate.Height = 24;
            this.dataGridViewAdvisors.Size = new System.Drawing.Size(850, 461);
            this.dataGridViewAdvisors.TabIndex = 8;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.display.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(937, 519);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(93, 33);
            this.display.TabIndex = 9;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Advisor\'s Id To Update";
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(104, 451);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(173, 22);
            this.updateId.TabIndex = 11;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(299, 442);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 31);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(75, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Advisor\'s Id To Search";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(104, 530);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(173, 22);
            this.searchbox.TabIndex = 14;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(299, 522);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 36);
            this.search.TabIndex = 15;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(69, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(69, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(75, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(82, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(60, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Date Of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(75, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gender";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(185, 40);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(173, 22);
            this.first.TabIndex = 22;
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(185, 82);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(173, 22);
            this.last.TabIndex = 23;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(185, 127);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(173, 22);
            this.contact.TabIndex = 24;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(185, 171);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(173, 22);
            this.email.TabIndex = 25;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(185, 212);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(173, 22);
            this.DOB.TabIndex = 26;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(185, 249);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(173, 24);
            this.comboBoxGender.TabIndex = 27;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(665, 626);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 37);
            this.exit.TabIndex = 28;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::ProjectA.Properties.Resources.istockphoto_1294598267_612x612;
            this.ClientSize = new System.Drawing.Size(1518, 718);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridViewAdvisors);
            this.Controls.Add(this.comboBoxdesignation);
            this.Controls.Add(this.add);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.Load += new System.EventHandler(this.Advisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvisors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox comboBoxdesignation;
        private System.Windows.Forms.DataGridView dataGridViewAdvisors;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox DOB;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button exit;
    }
}