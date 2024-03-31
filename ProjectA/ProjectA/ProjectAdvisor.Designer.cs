namespace ProjectA
{
    partial class ProjectAdvisor
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
            this.comboBoxproject = new System.Windows.Forms.ComboBox();
            this.comboBoxadvisor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxrole = new System.Windows.Forms.ComboBox();
            this.assign = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.display = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Project Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Advisor Id";
            // 
            // comboBoxproject
            // 
            this.comboBoxproject.FormattingEnabled = true;
            this.comboBoxproject.Location = new System.Drawing.Point(192, 54);
            this.comboBoxproject.Name = "comboBoxproject";
            this.comboBoxproject.Size = new System.Drawing.Size(121, 24);
            this.comboBoxproject.TabIndex = 2;
            // 
            // comboBoxadvisor
            // 
            this.comboBoxadvisor.FormattingEnabled = true;
            this.comboBoxadvisor.Location = new System.Drawing.Point(192, 97);
            this.comboBoxadvisor.Name = "comboBoxadvisor";
            this.comboBoxadvisor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxadvisor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Advisor Role";
            // 
            // comboBoxrole
            // 
            this.comboBoxrole.FormattingEnabled = true;
            this.comboBoxrole.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.comboBoxrole.Location = new System.Drawing.Point(192, 135);
            this.comboBoxrole.Name = "comboBoxrole";
            this.comboBoxrole.Size = new System.Drawing.Size(121, 24);
            this.comboBoxrole.TabIndex = 5;
            // 
            // assign
            // 
            this.assign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.assign.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign.Location = new System.Drawing.Point(127, 179);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(99, 35);
            this.assign.TabIndex = 6;
            this.assign.Text = "Assign";
            this.assign.UseVisualStyleBackColor = false;
            this.assign.Click += new System.EventHandler(this.assign_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(497, 305);
            this.dataGridView1.TabIndex = 7;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.display.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(532, 350);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(134, 32);
            this.display.TabIndex = 8;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Project Id";
            // 
            // searchbox
            // 
            this.searchbox.FormattingEnabled = true;
            this.searchbox.Location = new System.Drawing.Point(192, 236);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(121, 24);
            this.searchbox.TabIndex = 10;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(127, 275);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 34);
            this.search.TabIndex = 11;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(354, 421);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 31);
            this.exit.TabIndex = 28;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Select Record From Grid View To Update";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(127, 371);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 34);
            this.update.TabIndex = 30;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ProjectAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectA.Properties.Resources.istockphoto_1294598267_612x612;
            this.ClientSize = new System.Drawing.Size(905, 511);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.assign);
            this.Controls.Add(this.comboBoxrole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxadvisor);
            this.Controls.Add(this.comboBoxproject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjectAdvisor";
            this.Text = "ProjectAdvisor";
            this.Load += new System.EventHandler(this.ProjectAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxproject;
        private System.Windows.Forms.ComboBox comboBoxadvisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxrole;
        private System.Windows.Forms.Button assign;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchbox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update;
    }
}