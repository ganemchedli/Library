namespace Library
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.subscribers = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subscribers
            // 
            this.subscribers.BackColor = System.Drawing.Color.RoyalBlue;
            this.subscribers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscribers.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subscribers.ForeColor = System.Drawing.Color.White;
            this.subscribers.Location = new System.Drawing.Point(185, 213);
            this.subscribers.Name = "subscribers";
            this.subscribers.Size = new System.Drawing.Size(266, 43);
            this.subscribers.TabIndex = 0;
            this.subscribers.Text = "Subscriber management";
            this.subscribers.UseVisualStyleBackColor = false;
            this.subscribers.Click += new System.EventHandler(this.subscribers_Click);
            this.subscribers.Paint += new System.Windows.Forms.PaintEventHandler(this.subscribers_paint);
            // 
            // books
            // 
            this.books.BackColor = System.Drawing.Color.RoyalBlue;
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books.ForeColor = System.Drawing.Color.White;
            this.books.Location = new System.Drawing.Point(185, 144);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(266, 43);
            this.books.TabIndex = 1;
            this.books.Text = "Book management";
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            this.books.Paint += new System.Windows.Forms.PaintEventHandler(this.books_paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administration";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(274, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.logout_button_paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(185, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Borrowing managment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.books);
            this.Controls.Add(this.subscribers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private Button subscribers;
        private Button books;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}