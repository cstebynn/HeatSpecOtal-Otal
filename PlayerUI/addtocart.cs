using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlayerUI
{
    public partial class addtocart : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
        int indexRow;

        public addtocart()
        {
            InitializeComponent();
        }

        public addtocart(string model, string processor, string memory, string storage, string graphics, string display, string price, Image image, int quantity)
        {
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            InitializeComponent();

            labelLTModel.Text = model;
            labelProcessor.Text = processor;
            labelMemory.Text = memory;
            labelStorage.Text = storage;
            labelGraphics.Text = graphics;
            labelDisplay.Text = display;
            labelPrice.Text = price;

            labelQuantity.Text = quantity.ToString();

            pictureBox1.Image = image;

            dataGridViewSpec.Rows.Add(model, quantity, price);

        }
        
        private void buttonProceed_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CustomerDetails([Name], [Street], [Province], [City], [Postal Code]) values('" + textBoxFullName.Text + "', '" + textBoxStreet.Text + "', '" + textBoxProvince.Text + "', '" + textBoxCity.Text + "', '" + textBoxPostalCode.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Saved");

            /*
            string name = textBoxFullName.Text;
            string street = textBoxStreet.Text;
            string province = textBoxProvince.Text;
            string city = textBoxCity.Text;
            string postal = textBoxPostalCode.Text;

            string laptop = labelLTModel.Text;
            string quantity = labelQuantity.Text;
            string price = labelPrice.Text;


            // Perform validation or further processing with the collected data
            // For example:
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(street) || string.IsNullOrEmpty(province) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(postal))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            this.Hide();

            // Create an instance of the FinalBillingForm and show it
            Final_Billing finalBillingForm = new Final_Billing(name, street, province, city, postal,laptop, quantity, price);
            finalBillingForm.ShowDialog();
            
            // Reset the text boxes after proceeding
            textBoxFullName.Text = "";
            textBoxStreet.Text = "";
            textBoxProvince.Text = "";
            textBoxCity.Text = "";
            textBoxPostalCode.Text = "";
            */

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void AddMoreItem_Click(object sender, EventArgs e)
        {

        }

        private void addtocart_Load(object sender, EventArgs e)
        {

        }
    }
}
