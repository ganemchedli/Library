﻿namespace Library
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
            this.SuspendLayout();
            // 
            // subscribers
            // 
            this.subscribers.BackColor = System.Drawing.Color.RoyalBlue;
            this.subscribers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscribers.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subscribers.ForeColor = System.Drawing.Color.White;
            this.subscribers.Location = new System.Drawing.Point(185, 168);
            this.subscribers.Name = "subscribers";
            this.subscribers.Size = new System.Drawing.Size(266, 43);
            this.subscribers.TabIndex = 0;
            this.subscribers.Text = "Subscriber management";
            this.subscribers.UseVisualStyleBackColor = false;
            this.subscribers.Paint += new System.Windows.Forms.PaintEventHandler(this.subscribers_paint);
            // 
            // books
            // 
            this.books.BackColor = System.Drawing.Color.RoyalBlue;
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books.ForeColor = System.Drawing.Color.White;
            this.books.Location = new System.Drawing.Point(185, 245);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(266, 43);
            this.books.TabIndex = 1;
            this.books.Text = "Book management";
            this.books.UseVisualStyleBackColor = false;
            this.books.Paint += new System.Windows.Forms.PaintEventHandler(this.books_paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administration";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 450);
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
    }
}