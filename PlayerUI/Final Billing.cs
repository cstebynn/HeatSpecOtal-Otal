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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace PlayerUI
{
    public partial class Final_Billing : Form
    {

        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\current new one 25-7-23\\edit_connection\\LaptopStore.accdb");

        int indexRow;


        private string name;
        private string street;
        private string province;
        private string city;
        private string postal;

        private string laptop;
        private string quantity;
        private string price;

        public Final_Billing(string name, string street, string province, string city, string postal, string laptop, string quantity, string price)
        {
            InitializeComponent();
           

            this.name = name;
            this.street = street;
            this.province = province;
            this.city = city;
            this.postal = postal;

            this.laptop = laptop;
            this.quantity = quantity;
            this.price = price;


            DisplayBillingDetails();

          
           dataGridViewOrder.Rows.Add(laptop,quantity,price);

        }

        public void DisplayBillingDetails()
        {
            // Display the billing details
            labelName.Text = name;
            labelStreet.Text = street;
            labelProvince.Text = province;
            labelCity.Text = city;
            labelPostal.Text = postal;

            labelLTModel.Text = laptop;
            labelQuantity.Text = quantity.ToString();
            labelPrice.Text = price;
      
        }


        public void AddOrderToDataGridView(string model, int quantity, string price)
        {
            dataGridViewOrder.Rows.Add(model, quantity, price);
        }



        private void buttonSubmit_Click(object sender, EventArgs e)
        {
                conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CustomerDetails([Name], [Street], [Province], [City], [Postal Code], [Cardholder Name], [Cardholder Number], [Expiration Date], [CVV]) values('" + labelName.Text + "', '" + labelStreet.Text + "', '" + labelProvince.Text + "', '" + labelCity.Text + "', '" + labelPostal.Text + "','" + textBoxCardholderName.Text + "', '" + textBoxCardNumber.Text + "', '" + textBoxExpire.Text + "','" + textBoxCVV.Text + "',)";
            cmd.ExecuteNonQuery();

            string paymentType = GetPaymentType();
            string cardholderName = textBoxCardholderName.Text;
            string cardNumber = textBoxCardNumber.Text;
            string expirationDate = textBoxExpire.Text;
            string cvv = textBoxCVV.Text;


            if (string.IsNullOrEmpty(paymentType))
            {
                MessageBox.Show("Please select a payment type.");
                return;
            }

            if (paymentType == "Credit/Debit Card")
            {
                if (string.IsNullOrEmpty(cardholderName) || string.IsNullOrEmpty(cardNumber)
                    || string.IsNullOrEmpty(expirationDate) || string.IsNullOrEmpty(cvv))
                {
                    MessageBox.Show("Please fill in all the required card details.");
                    return;
                }
            }


            // Display the billing details
            string billingDetails = $"Billing Details:\n" +
                                    $"Name: {name}\n" +
                                    $"Street: {street}\n" +
                                    $"Province: {province}\n" +
                                    $"City: {city}\n" +
                                    $"Postal: {postal}\n" +
                                    $"Payment Type: {paymentType}\n" +
                                    $"Cardholder's Name: {cardholderName}\n" +
                                    $"Card Number: {cardNumber}\n" +
                                    $"Expiration Date: {expirationDate}\n" +
                                    $"CVV: {cvv}";
            
            // Display the collected data or perform further actions
            string orderSummary = $"YOUR ORDER\n\n" +
                                  $"PRODUCT\t\t\t\t\t\t\t {laptop}" +
                                  $"\n\nTOTAL\t\t\t\t\t\t\t{price:C}\n" +
                                  //$"Subtotal\t\t\t\t\t\t\t{lblSubtotal.Text}//\n" +
                                  $"Total\t\t\t\t\t\t\t{labelPrice.Text}";
            

            MessageBox.Show(billingDetails + "\n\n" + orderSummary);
          

            // Reset the text boxes after submission
            textBoxCardholderName.Text = "";
            textBoxCardNumber.Text = "";
            textBoxExpire.Text = "";
            textBoxCVV.Text = "";

            string GetPaymentType()
            {
                if (rbCreditDebitCard.Checked)
                {
                    return "Credit/Debit Card";
                }
                else if (rbCodOnSitePayment.Checked)
                {
                    return "COD/On-Site Payment";
                }
                else
                {
                    return "";
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult Cancel;
            Cancel = MessageBox.Show("Do you want to cancel the order?", "HEAT SPEC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Cancel == DialogResult.Yes)
            {         
                this.Hide();
            }
        }

        private void BuyMoreItems_Click(object sender, EventArgs e)
        {
            Form3CS homepage = new Form3CS();
            homepage.Show();
        }

        private void Final_Billing_Load(object sender, EventArgs e)
        {
            label6.Parent = pictureBox2;
            label6.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
