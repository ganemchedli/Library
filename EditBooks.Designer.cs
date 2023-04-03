namespace Library
{
    partial class EditBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBooks));
            this.back_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.yearOfPubTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.SystemColors.Window;
            this.back_button.Location = new System.Drawing.Point(192, 142);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(109, 40);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            this.back_button.Paint += new System.Windows.Forms.PaintEventHandler(this.back_paint);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Red;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout_button.ForeColor = System.Drawing.SystemColors.Window;
            this.logout_button.Location = new System.Drawing.Point(677, 142);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(108, 40);
            this.logout_button.TabIndex = 1;
            this.logout_button.Text = "logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.button2_Click);
            this.logout_button.Paint += new System.Windows.Forms.PaintEventHandler(this.logout_paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 27);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(585, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.search_paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(192, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 160);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(590, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(278, 522);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(190, 27);
            this.titleTextBox.TabIndex = 7;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(647, 522);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(138, 27);
            this.authorTextBox.TabIndex = 7;
            // 
            // yearOfPubTextBox
            // 
            this.yearOfPubTextBox.Location = new System.Drawing.Point(647, 567);
            this.yearOfPubTextBox.Name = "yearOfPubTextBox";
            this.yearOfPubTextBox.Size = new System.Drawing.Size(138, 27);
            this.yearOfPubTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Copies : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Author :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year of publication :";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(691, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.clear_paint);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button.Location = new System.Drawing.Point(207, 675);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(134, 29);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Add to database";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            this.add_button.Paint += new System.Windows.Forms.PaintEventHandler(this.add_paint);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Red;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_button.Location = new System.Drawing.Point(585, 675);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 29);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_Click);
            this.delete_button.Paint += new System.Windows.Forms.PaintEventHandler(this.delete_paint);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_button.Location = new System.Drawing.Point(425, 675);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(94, 29);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Save edit";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            this.save_button.Paint += new System.Windows.Forms.PaintEventHandler(this.save_paint);
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(278, 567);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(94, 27);
            this.copiesTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Title :";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 31.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(258, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 87);
            this.label7.TabIndex = 10;
            this.label7.Text = "Books Managment";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(278, 625);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(125, 27);
            this.IdBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id book";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "(Used only to edit book)";
            // 
            // EditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 748);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yearOfPubTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBooks";
            this.Text = "Edit books";
            this.Load += new System.EventHandler(this.EditBooks_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back_button;
        private Button logout_button;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Panel panel1;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox yearOfPubTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button add_button;
        private Button delete_button;
        private Button save_button;
        private DataGridView dataGridView1;
        private TextBox copiesTextBox;
        private Label label6;
        private Label label7;
        private TextBox IdBox;
        private Label label2;
        private Label label8;
    }
}