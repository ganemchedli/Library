using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Library
{
    public partial class EditBooks : Form
    {
        // variables
        MySqlConnection con;
        MySqlCommand cmd;

        // userid and pwd
        public static int userid;
        public static string password;
       

        public EditBooks()
        {
            InitializeComponent();
            
            
        }
        public void clearFields()
        {
            bookNameTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
            authorTextBox.Text = string.Empty;
            yearOfPubTextBox.Text = string.Empty;
            copiesTextBox.Text = string.Empty;
            
        }
        public void displayBooks()
        {
            // establish connection to db
            string connectionString = "server=localhost;port=3306;uid=root;pwd=root;database=library";
            con = new MySqlConnection(connectionString);

            // on intialise display books table
            cmd = new MySqlCommand("select IdBook as 'Book ID', Title as 'Title', Author as 'Author',  Year_of_publication as 'Year_of_publication' from books order by IdBook asc", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            // make read only
            dataGridView1.ReadOnly = true;
        }
        private void back_paint(object sender, PaintEventArgs e)
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
        private void logout_paint(object sender, PaintEventArgs e)
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
        private void search_paint(object sender, PaintEventArgs e)
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
        private void add_paint(object sender, PaintEventArgs e)
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

        private void save_paint(object sender, PaintEventArgs e)
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

        private void delete_paint(object sender, PaintEventArgs e)
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

        private void clear_paint(object sender, PaintEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
        private void EditBooks_Load(object sender, EventArgs e)
        {
            // display table
            displayBooks();

            //.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // variables 
            int book_id = 0;
            string title;
            string author;
            int year_of_pub = 0000;
            int number_of_copies = 0 ;

           bool AcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                book_id = Convert.ToInt32(bookNameTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the BookID is an interger.");
               AcceptedState = false;
            }
            title = titleTextBox.Text;
            author = authorTextBox.Text;
            
            try
            {
                year_of_pub = Convert.ToInt32(yearOfPubTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Year of Publication is an interger.");
                AcceptedState = false;
            }
            number_of_copies = Convert.ToInt32(copiesTextBox.Text);

            // try to add book only if all pevious info is healthy
            if (AcceptedState == true)
            {
                try
                {
                    cmd = new MySqlCommand("insert into books values (@book_id, @title, @author,  @year_of_pub, @copies)", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@year_of_pub", year_of_pub);
                    cmd.Parameters.AddWithValue("@copies", number_of_copies);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully added.");
                        clearFields();
                    }

                    // display updated books
                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("There is already a book with this BookID.\nBookID's have to be distinct.");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
