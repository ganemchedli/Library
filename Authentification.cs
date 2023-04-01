using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class Authentification : Form
    {
        // variables
        MySqlConnection con ;
        MySqlCommand cmd ;

        // userid and pwd
        public static int userid ;
        public static string password;


        public Authentification()
        {
            InitializeComponent();
           
        }
        public void clear()
        {
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();  
            admin.Show();
            this.Visible = false; 
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd = new MySqlCommand("select * from users where Username = @user_id and Password = @password", con);
            cmd.Parameters.AddWithValue("@user_id", usernameBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordBox.Text);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("The entered USER ID or PASSWORD is WRONG.\nPlease check and try again.");
                clear();
            }
        }
        private void button1_Paint(object sender, PaintEventArgs e)
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

        private void Authentification_Load(object sender, EventArgs e)
        {
            // initialise connection to db
            string connectionString = "server=localhost;port=3306;uid=root;pwd=root;database=library";
            con = new MySqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}