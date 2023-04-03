using MySql.Data.MySqlClient;
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
    public partial class SubscriberMangement : Form
    {
        public SubscriberMangement()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlCommand cmd;
        public void displaySubscribers()
        {
            // establish connection to db
            string connectionString = "server=localhost;port=3306;uid=root;pwd=root;database=library";
            con = new MySqlConnection(connectionString);

            // on intialise display books table
            cmd = new MySqlCommand("select idSubscriber as 'Subscriber ID', name as 'Name', firstName as 'First name'from subscribers order by idSubscriber asc", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            // make read only
            dataGridView1.ReadOnly = true;
        }

        public void clearFields()
        {
            NameBox.Text = string.Empty;
            FirstNameBox.Text = string.Empty;
            

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Authentification authentification = new Authentification();
            authentification.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // variables 
            string connectionString = "server=localhost;port=3306;uid=root;pwd=root;database=library";
            con = new MySqlConnection(connectionString);

            string name;
            string firstName;
            

            // open connection
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                MessageBox.Show("Not connecting to database");
            }


            // copy values
            // copy value to variable even make sure correct format

            name = NameBox.Text;
            firstName = FirstNameBox.Text;

           
           
            // try to add book only if all pevious info is healthy
            
                try

                {
                    cmd = new MySqlCommand("insert into subscribers(name, firstName) values (@name, @firstName)", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    

                    int result = cmd.ExecuteNonQuery();


                    if (result == 1)
                    {
                        MessageBox.Show("Subscriber successfully added.");
                        clearFields();
                    }

                    // display updated books
                    displaySubscribers();
                }
                catch
                {
                    MessageBox.Show("There is already a Subscriber with this idSubscriber.\nidSubscriber's have to be distinct.");
                }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }


           
            string name = NameBox.Text;
            string firstName = FirstNameBox.Text;
            int id = Convert.ToInt32(IdBox.Text);
            
            try
            {
                cmd = new MySqlCommand("UPDATE subscribers SET name = @name, firstName = @firstName WHERE idSubscriber = @id", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@id", id);
                
                cmd.ExecuteNonQuery();
                clearFields();
                displaySubscribers();
            }
            catch
            {
                MessageBox.Show("Problem in updating the book ");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;uid=root;pwd=root;database=library";
            con = new MySqlConnection(connectionString);
            con.Open();

            int id = Convert.ToInt32(IdBox.Text);


            try
            {
                cmd = new MySqlCommand("Delete From subscribers where idSubscriber = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                clearFields();

                displaySubscribers();
            }
            catch
            {
                MessageBox.Show("Problem here");
            }

        }

        private void SubscriberMangement_Load(object sender, EventArgs e)
        {
            displaySubscribers();
        }

       
    }
}
