using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class SpecificationCS : Form
    {

        private Final_Billing formFB;

        public SpecificationCS()
        {
            InitializeComponent();
        }

        public SpecificationCS(Final_Billing formFB, string model, string processor, string memory, string storage, string graphics, string display, string price, Image image)
        {
            InitializeComponent();

            this.formFB = formFB; // Store the reference to the Final_Billing form

            labelLaptopModel.Text = model;
            labelProcessor.Text = processor;
            labelMemory.Text = memory;
            labelStorage.Text = storage;
            labelGraphics.Text = graphics;
            labelDisplay.Text = display;
            labelPrice.Text = price;

            pictureBox1.Image = image;
        }

        public SpecificationCS(string model, string quantity, string price)
        {
            InitializeComponent();

            labelLaptopModel.Text = model;
            numericUpDown1.Text = quantity;
            labelPrice.Text = price;

        }

        /*
        private void button_add_to_cart_Click(object sender, EventArgs e)
        {
            string model = labelLaptopModel.Text;
            string processor = labelProcessor.Text;
            string memory = labelMemory.Text;
            string storage = labelStorage.Text;
            string graphics = labelGraphics.Text;
            string display = labelDisplay.Text;p
            string price = labelPrice.Text;

            Image laptopImage = pictureBox1.Image;

            int Seclectquantity = (int)numericUpDown1.Value;

            if (Seclectquantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string quantity = Seclectquantity.ToString();




            this.Hide();


        }
        */

        private void button_add_to_cart_Click(object sender, EventArgs e)
        {
            //addtocartv2 addtocartv2 = new addtocartv2();    
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            formFB.DisplayBillingDetails(); // Display the billing details in the existing instance of Final_Billing
            formFB.Show(); // Show the existing instance of Final_Billing
            this.Close(); // Close the SpecificationCS form

        }

        
    }
}

