namespace ProjectA
{
    partial class GroupEvaluation
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
            this.comboBoxgroup = new System.Windows.Forms.ComboBox();
            this.comboBoxEvaluation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.obtmarks = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.display = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.updatebox = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newobt = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(98, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(85, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evaluation Id";
            // 
            // comboBoxgroup
            // 
            this.comboBoxgroup.FormattingEnabled = true;
            this.comboBoxgroup.Location = new System.Drawing.Point(224, 58);
            this.comboBoxgroup.Name = "comboBoxgroup";
            this.comboBoxgroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxgroup.TabIndex = 2;
            // 
            // comboBoxEvaluation
            // 
            this.comboBoxEvaluation.FormattingEnabled = true;
            this.comboBoxEvaluation.Location = new System.Drawing.Point(224, 103);
            this.comboBoxEvaluation.Name = "comboBoxEvaluation";
            this.comboBoxEvaluation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEvaluation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(76, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obtained Marks";
            // 
            // obtmarks
            // 
            this.obtmarks.Location = new System.Drawing.Point(224, 145);
            this.obtmarks.Name = "obtmarks";
            this.obtmarks.Size = new System.Drawing.Size(121, 22);
            this.obtmarks.TabIndex = 5;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(156, 189);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 28);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.display.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(698, 365);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(106, 32);
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
            this.label4.Location = new System.Drawing.Point(98, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Group Id To Search ";
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(129, 269);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(154, 22);
            this.SearchID.TabIndex = 10;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(156, 307);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 31);
            this.search.TabIndex = 11;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Group Id To Update\r\n";
            // 
            // updatebox
            // 
            this.updatebox.Location = new System.Drawing.Point(27, 414);
            this.updatebox.Name = "updatebox";
            this.updatebox.Size = new System.Drawing.Size(164, 22);
            this.updatebox.TabIndex = 13;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(200, 457);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(113, 32);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(274, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter Updated Otained Marks\r\n\r\n";
            // 
            // newobt
            // 
            this.newobt.Location = new System.Drawing.Point(313, 414);
            this.newobt.Name = "newobt";
            this.newobt.Size = new System.Drawing.Size(152, 22);
            this.newobt.TabIndex = 16;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exit.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(520, 598);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 31);
            this.exit.TabIndex = 26;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectA.Properties.Resources.istockphoto_1294598267_612x612;
            this.ClientSize = new System.Drawing.Size(1196, 690);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.newobt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.update);
            this.Controls.Add(this.updatebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.SearchID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.obtmarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEvaluation);
            this.Controls.Add(this.comboBoxgroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupEvaluation";
            this.Text = "                ";
            this.Load += new System.EventHandler(this.GroupEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxgroup;
        private System.Windows.Forms.ComboBox comboBoxEvaluation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox obtmarks;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updatebox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newobt;
        private System.Windows.Forms.Button exit;
    }
}