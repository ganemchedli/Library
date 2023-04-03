using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ReservedBooks : Form
    {
        public ReservedBooks()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlTransaction transaction;

        public void clearFields()
        {
            NameBox.Text = string.Empty;
            bookBox.Text = string.Empty;            
        }
        public void displayBorrows()
        {
            // establish connection to db
            string connectionString = "server=localhost;port=3306;uid=root;pwd=root;database=library";
            con = new MySqlConnection(connectionString);

            // on intialise display books table
            cmd = new MySqlCommand("select idBorrow as 'Borrow Id', idBookFK as 'Book ID', subscriber as 'Subscriber ID',  returnDate as 'Return Date'from borrowedbooks", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            // make read only
            dataGridView1.ReadOnly = true;
        }
        private void back_button_paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
            int curveSize = 20;
            btnPath.AddArc(0, 0, curveSize, curveSize, 180, 90);
            btnPath.AddArc(btn.Width - curveSize, 0, curveSize, curveSize, 270, 90);
            btnPath.AddArc(btn.Width - curveSize, btn.Height - curveSize, curveSize, curveSize, 0, 90);
            btnPath.AddArc(0, btn.Height - curveSize, curveSize, curveSize, 90, 90);
            btn.Region = new System.Drawing.Region(btnPath);
        }

        private void logout_button_paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
            int curveSize = 20;
            btnPath.AddArc(0, 0, curveSize, curveSize, 180, 90);
            btnPath.AddArc(btn.Width - curveSize, 0, curveSize, curveSize, 270, 90);
            btnPath.AddArc(btn.Width - curveSize, btn.Height - curveSize, curveSize, curveSize, 0, 90);
            btnPath.AddArc(0, btn.Height - curveSize, curveSize, curveSize, 90, 90);
            btn.Region = new System.Drawing.Region(btnPath);
        }
        private void borrow_button_paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
            int curveSize = 20;
            btnPath.AddArc(0, 0, curveSize, curveSize, 180, 90);
            btnPath.AddArc(btn.Width - curveSize, 0, curveSize, curveSize, 270, 90);
            btnPath.AddArc(btn.Width - curveSize, btn.Height - curveSize, curveSize, curveSize, 0, 90);
            btnPath.AddArc(0, btn.Height - curveSize, curveSize, curveSize, 90, 90);
            btn.Region = new System.Drawing.Region(btnPath);
        }

        private void return_button_paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
            int curveSize = 20;
            btnPath.AddArc(0, 0, curveSize, curveSize, 180, 90);
            btnPath.AddArc(btn.Width - curveSize, 0, curveSize, curveSize, 270, 90);
            btnPath.AddArc(btn.Width - curveSize, btn.Height - curveSize, curveSize, curveSize, 0, 90);
            btnPath.AddArc(0, btn.Height - curveSize, curveSize, curveSize, 90, 90);
            btn.Region = new System.Drawing.Region(btnPath);
        }

        private void ReservedBooks_Load(object sender, EventArgs e)
        {
            displayBorrows();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authentification authentification = new Authentification();
            authentification.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearFields();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void borrow_Click(object sender, EventArgs e)
        {
            // variables 
            
            
            int idSubscriber;
            int idBook;
            DateTime returnDate = dateTimePicker.Value.Date;

            // open connection
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                MessageBox.Show("Not connecting to database");
                return;
            }

            idSubscriber = Convert.ToInt32(NameBox.Text);
            idBook = Convert.ToInt32(bookBox.Text);

            try
            {
                // Start a transaction
                transaction = con.BeginTransaction();

                // Check if there are available copies of the book
                cmd = new MySqlCommand("SELECT No_of_copies FROM books WHERE IdBook = @idBook", con);
                cmd.Parameters.AddWithValue("@idBook", idBook);
                int noOfCopies = Convert.ToInt32(cmd.ExecuteScalar());

                if (noOfCopies > 0)
                {
                    // Update the No_of_copies column
                    cmd = new MySqlCommand("UPDATE books SET No_of_copies = No_of_copies - 1 WHERE IdBook = @idBook", con);
                    cmd.Parameters.AddWithValue("@idBook", idBook);
                    cmd.ExecuteNonQuery();

                    // Insert the borrowed book record
                    cmd = new MySqlCommand("INSERT INTO borrowedbooks(IdBookFK, Subscriber, ReturnDate) VALUES (@idBookFk, @subscriber, @returnDate)", con);
                    cmd.Parameters.AddWithValue("@idBookFk", idBook);
                    cmd.Parameters.AddWithValue("@subscriber", idSubscriber);
                    cmd.Parameters.AddWithValue("@returnDate", returnDate);
                    cmd.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Book borrowed successfully!");
                }
                else
                {
                    MessageBox.Show("No available copies of the book!");
                }

                clearFields();
                displayBorrows();
            }
            catch (Exception ex)
            {
                // Roll back the transaction if an error occurred
                transaction.Rollback();
                MessageBox.Show("An error occurred while borrowing the book: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void return_Click(object sender, EventArgs e)
        {
            int idBorrow;
            int idBook;
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            idBorrow = Convert.ToInt32(BorrowBox.Text);
            idBook = Convert.ToInt32(bookBox.Text);

            try
            {
                cmd = new MySqlCommand("Delete From borrowedbooks where idBorrow = @idBorrow", con);
                cmd.Parameters.AddWithValue("@idBorrow", idBorrow);
                cmd.ExecuteNonQuery();

                // Update the No_of_copies column
                cmd = new MySqlCommand("UPDATE books SET No_of_copies = No_of_copies + 1 WHERE IdBook = @idBook", con);
                cmd.Parameters.AddWithValue("@idBook", idBook);
                cmd.ExecuteNonQuery();
                displayBorrows();
            }
            catch
            {
                MessageBox.Show("The return of the book failed");
            }
        }
    }
}
