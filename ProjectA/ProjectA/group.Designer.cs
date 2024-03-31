namespace ProjectA
{
    partial class group
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
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupStudents = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.updateGrp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.STUDENTIDS = new System.Windows.Forms.CheckedListBox();
            this.newID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGroup = new System.Windows.Forms.TextBox();
            this.searchgrp = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.LimeGreen;
            this.create.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.create.Location = new System.Drawing.Point(167, 32);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(177, 36);
            this.create.TabIndex = 0;
            this.create.Text = "Create New Group";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(97, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Student ID\'s";
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.display.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(801, 97);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(151, 33);
            this.display.TabIndex = 4;
            this.display.Text = "Display Group";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(186, 354);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 34);
            this.add.TabIndex = 7;
            this.add.Text = "Add Student";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupStudents
            // 
            this.groupStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupStudents.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStudents.Location = new System.Drawing.Point(770, 523);
            this.groupStudents.Name = "groupStudents";
            this.groupStudents.Size = new System.Drawing.Size(224, 34);
            this.groupStudents.TabIndex = 9;
            this.groupStudents.Text = "Display Group Students";
            this.groupStudents.UseVisualStyleBackColor = false;
            this.groupStudents.Click += new System.EventHandler(this.groupStudents_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(97, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status Student";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(281, 307);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 14;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // updateGrp
            // 
            this.updateGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.updateGrp.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGrp.Location = new System.Drawing.Point(204, 523);
            this.updateGrp.Name = "updateGrp";
            this.updateGrp.Size = new System.Drawing.Size(92, 32);
            this.updateGrp.TabIndex = 17;
            this.updateGrp.Text = "Update";
            this.updateGrp.UseVisualStyleBackColor = false;
            this.updateGrp.Click += new System.EventHandler(this.updateGrp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(168, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter new Student ID";
            // 
            // STUDENTIDS
            // 
            this.STUDENTIDS.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUDENTIDS.FormattingEnabled = true;
            this.STUDENTIDS.Location = new System.Drawing.Point(304, 196);
            this.STUDENTIDS.Name = "STUDENTIDS";
            this.STUDENTIDS.Size = new System.Drawing.Size(133, 46);
            this.STUDENTIDS.TabIndex = 19;
            // 
            // newID
            // 
            this.newID.Location = new System.Drawing.Point(184, 481);
            this.newID.Name = "newID";
            this.newID.Size = new System.Drawing.Size(146, 22);
            this.newID.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(545, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 362);
            this.dataGridView1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter Group id to Search:\r\n";
            // 
            // searchGroup
            // 
            this.searchGroup.Location = new System.Drawing.Point(304, 97);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(146, 22);
            this.searchGroup.TabIndex = 23;
            // 
            // searchgrp
            // 
            this.searchgrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchgrp.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgrp.Location = new System.Drawing.Point(188, 138);
            this.searchgrp.Name = "searchgrp";
            this.searchgrp.Size = new System.Drawing.Size(92, 32);
            this.searchgrp.TabIndex = 24;
            this.searchgrp.Text = "Search Group";
            this.searchgrp.UseVisualStyleBackColor = false;
            this.searchgrp.Click += new System.EventHandler(this.searchgrp_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(678, 675);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 31);
            this.exit.TabIndex = 25;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectA.Properties.Resources.istockphoto_1294598267_612x612;
            this.ClientSize = new System.Drawing.Size(1514, 785);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchgrp);
            this.Controls.Add(this.searchGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newID);
            this.Controls.Add(this.STUDENTIDS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateGrp);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupStudents);
            this.Controls.Add(this.add);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create);
            this.Name = "group";
            this.Text = "\\lo";
            this.Load += new System.EventHandler(this.group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button groupStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button updateGrp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox STUDENTIDS;
        private System.Windows.Forms.TextBox newID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchGroup;
        private System.Windows.Forms.Button searchgrp;
        private System.Windows.Forms.Button exit;
    }
}