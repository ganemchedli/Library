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
    }
}
