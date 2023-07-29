using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using System.Text.RegularExpressions;

namespace PlayerUI
{
    public partial class createAccount : Form
    {
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\MSAD\combination\edit_connection\\LaptopStore.accdb");


        private string Username;
        private string Email;
        private string Password;
        public createAccount()
        {
            InitializeComponent();
            txtUsername.GotFocus += txtUsername_GotFocus;
            txtPassword.GotFocus += txtPassword_GotFocus;
        }
        public createAccount(string Username, string Email, string Password)
        {
            InitializeComponent();
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }
        public static bool ValidateEmail(string Email) 
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(Email);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Username = txtUsername.Text;
                Email = txtEmail.Text;
                Password = txtPassword.Text;

                if(ValidateEmail(Email) == false) 
                {
                    MessageBox.Show("EMAIL IS NOT IN CORRECT FORMAT!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Clear();
                }
                else
                {
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
                    new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO CustomerAccount([Username], [Email], [Password]) values('" + txtUsername.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account was created\nSigning In", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 form3 = new Form3();
                    this.Hide();
                    form3.ShowDialog();
                    this.Close();


                }
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

        }
        private void txtUsername_GotFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.SelectionStart = 0;
                txtUsername.SelectionLength = txtUsername.TextLength;
            }
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.SelectionStart = 0;
                txtPassword.SelectionLength = txtPassword.TextLength;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtUsername.SelectionLength = 0;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.SelectionLength = 0;
        }

        private void createAccount_Load(object sender, EventArgs e)
        {

        }
    }
 }
