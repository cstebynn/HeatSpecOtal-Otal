using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlayerUI
{
    public partial class Specification : Form
    {
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
        public string LaptopModel { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }

        private decimal pricePerUnit;


        public Specification()
        {
            InitializeComponent();
        }


        public Specification(string model, string processor, string memory, string storage, string graphics, string display, string price, Image laptopImage, decimal pricePerUnit)
        {
            InitializeComponent();

            labelLaptopModel.Text = model;
            labelProcessor.Text = processor;
            labelMemory.Text = memory;
            labelStorage.Text = storage;
            labelGraphics.Text = graphics;
            labelDisplay.Text = display;
            labelPrice.Text = price;

            pictureBox1.Image = laptopImage;

            this.pricePerUnit = pricePerUnit;
        }



        private void button_add_to_cart_Click(object sender, EventArgs e)
        {

            string model = labelLaptopModel.Text;
            string processor = labelProcessor.Text;
            string memory = labelMemory.Text;
            string storage = labelStorage.Text;
            string graphics = labelGraphics.Text;
            string display = labelDisplay.Text;
            string price = labelPrice.Text;

            Image laptopImage = pictureBox1.Image;

            /*
            int quantity = (int)numericUpDown1.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedQuantity = quantity;

            //addtocart formatc = new addtocart(model, processor, memory, storage, graphics, display, price, laptopImage, quantity);
            //formatc.Show();

            addtocartv2 formatcv2 = new addtocartv2();
            formatcv2.Show();


            this.Hide();
            */


            // Show the laptop details using a message box and get the quantity from the user
            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            // Calculate the total price
            decimal totalPrice = pricePerUnit * quantity;

            // Set the laptop details to the properties
            LaptopModel = model;
            Quantity = quantity;
            TotalPrice = totalPrice;

            // Close the Specification form with DialogResult OK
            this.DialogResult = DialogResult.OK;
            this.Close();


            //string brand1 = brand.SelectedItem.ToString();
            string modelname1 = labelLaptopModel.Text;
            quantity = Quantity;
            string price1 = labelPrice.Text;


            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb;"))
            {
                conn.Open();

                // Update Inventory table
                using (OleDbCommand cmd = new OleDbCommand("UPDATE Inventory SET Quantity = Quantity - ? WHERE [Model Name] = ?", conn))
                {
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@ModelName", modelname1);

                    cmd.ExecuteNonQuery();
                }

                // Insert into SalesRep table
                string query = "INSERT INTO SalesRep ([Model Name], Quantity, Price) VALUES (?, ?, ?)";
                using (OleDbCommand addCmd = new OleDbCommand(query, conn))
                {
                    addCmd.Parameters.AddWithValue("@ModelName", modelname1);
                    addCmd.Parameters.AddWithValue("@Quantity", quantity);
                    addCmd.Parameters.AddWithValue("@Price", price1);
                    addCmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            // Close the Specification form with DialogResult OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form back = new Form3();
            back.Show();
            this.Hide();
        }
    }
}
