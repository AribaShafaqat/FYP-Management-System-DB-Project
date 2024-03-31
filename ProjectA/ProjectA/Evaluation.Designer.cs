namespace ProjectA
{
    partial class Evaluation
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
            this.name = new System.Windows.Forms.TextBox();
            this.marks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightage = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.display = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.TextBox();
            this.UpdateID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(115, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Marks";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(266, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 22);
            this.name.TabIndex = 2;
            // 
            // marks
            // 
            this.marks.Location = new System.Drawing.Point(266, 96);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(147, 22);
            this.marks.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(96, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Weightage";
            // 
            // weightage
            // 
            this.weightage.Location = new System.Drawing.Point(266, 131);
            this.weightage.Name = "weightage";
            this.weightage.Size = new System.Drawing.Size(147, 22);
            this.weightage.TabIndex = 5;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(209, 174);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 28);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 320);
            this.dataGridView1.TabIndex = 7;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.display.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(657, 404);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(117, 33);
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
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(106, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Id to Update";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(114, 274);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(147, 22);
            this.update.TabIndex = 10;
            // 
            // UpdateID
            // 
            this.UpdateID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UpdateID.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateID.Location = new System.Drawing.Point(305, 267);
            this.UpdateID.Name = "UpdateID";
            this.UpdateID.Size = new System.Drawing.Size(91, 29);
            this.UpdateID.TabIndex = 11;
            this.UpdateID.Text = "Update";
            this.UpdateID.UseVisualStyleBackColor = false;
            this.UpdateID.Click += new System.EventHandler(this.UpdateID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(106, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Id to Search";
            // 
            // idSearch
            // 
            this.idSearch.Location = new System.Drawing.Point(110, 361);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(147, 22);
            this.idSearch.TabIndex = 13;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(305, 361);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(91, 31);
            this.search.TabIndex = 14;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(472, 521);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 31);
            this.exit.TabIndex = 15;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectA.Properties.Resources.istockphoto_1294598267_612x612;
            this.ClientSize = new System.Drawing.Size(1075, 642);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.idSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.weightage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox marks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightage;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox update;
        private System.Windows.Forms.Button UpdateID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button exit;
    }
}