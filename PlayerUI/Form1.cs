using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\current new one 25-7-23\\edit_connection\\LaptopStore.accdb");

        public Form1()
        {
            InitializeComponent();
          
        }
        private int ImageNumber = 1;
        private void LoadNextImage()
        {
            if(ImageNumber==4)
            {
                ImageNumber = 1;
            }
            slidepictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
        public bool ValidateLogin(string username, string password)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM CustomerAccount WHERE Username = '" + username + "' AND Password = '" + password + "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                int ctr = 0;
                while (reader.Read())
                {
                    ctr++;
                }
                if (ctr == 1)
                {
                    return true;
                }
                else if (ctr > 1)
                {
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //customer
            conn.Close();
            return false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                // Open Form2 (Admin Form)
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                //customer
                if(txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(ValidateLogin(txtUsername.Text, txtPassword.Text) == true)
                    {
                        MessageBox.Show("Logging In", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username/Password", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createAccount cr = new createAccount();
            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
    public class RoundTextBox : TextBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw a rounded border
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                int borderRadius = 10; // Adjust the radius as needed
                Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
                e.Graphics.DrawArc(borderPen, borderRect, 180, 90); // Top-left corner
                e.Graphics.DrawArc(borderPen, borderRect, 270, 90); // Top-right corner
                e.Graphics.DrawArc(borderPen, borderRect, 0, 90);   // Bottom-right corner
                e.Graphics.DrawArc(borderPen, borderRect, 90, 90);  // Bottom-left corner
                e.Graphics.DrawLine(borderPen, borderRadius, 0, Width - borderRadius, 0); // Top line
                e.Graphics.DrawLine(borderPen, Width - 1, borderRadius, Width - 1, Height - borderRadius); // Right line
                e.Graphics.DrawLine(borderPen, borderRadius, Height - 1, Width - borderRadius, Height - 1); // Bottom line
                e.Graphics.DrawLine(borderPen, 0, borderRadius, 0, Height - borderRadius); // Left line
            }
        }
    }
}
