using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PlayerUI
{

    public partial class Form3 : Form
    {

        private addtocartv2 atcv2Form;

        public Form3()
        {
            InitializeComponent();
            atcv2Form = new addtocartv2();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //colour button transparent
            buttonAsus.Parent = pictureBox1;
            buttonAsus.BackColor = Color.Transparent;

            buttonAcer.Parent = pictureBox1;
            buttonAcer.BackColor = Color.Transparent;

            buttonLenovo.Parent = pictureBox1;
            buttonLenovo.BackColor = Color.Transparent;

            buttonHP.Parent = pictureBox1;
            buttonHP.BackColor = Color.Transparent;

            buttonMSI.Parent = pictureBox1;
            buttonMSI.BackColor = Color.Transparent;

            string videoUrl = " \"D:\\\\Videos\\\\laptopad.mp4\";"; // Replace with your video URL or file path.
            axWindowsMediaPlayer1.URL = videoUrl;

            // Set the Windows Media Player control properties to stretch the video.
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;

            lenovo1.Hide();
            asus1.Hide();
            acer1.Hide();
            acer1.Hide();
            msi1.Hide();
            hp1.Hide();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            
            //hide other user controls
            lenovo1.Hide();
            asus1.Hide();
            acer1.Hide();
            acer1.Hide();
            msi1.Hide();
           hp1.Hide();
            //show current user control
            pictureBox2.Show();
            pictureBox2.BringToFront();
            label5.Show();
            label5.BringToFront();
            panel1.Show();
            panel1.BringToFront();
            panel2.Show();
            panel2.BringToFront();
            panel3.Show();
            panel3.BringToFront();
            panel4.Show();
            panel4.BringToFront();
            panel6.Show();
            panel6.BringToFront();
            panel7.Show();
            panel7.BringToFront();
            panel8.Show();
            panel8.BringToFront();
            panel9.Show();
            panel9.BringToFront();

        }

        private void buttonLenovo_Click(object sender, EventArgs e)
        {

            //hide other user controls
            pictureBox2.Hide();
            asus1.Hide();
            acer1.Hide();
            acer1.Hide();
            msi1.Hide();
            hp1.Hide();
            //show current user control
            lenovo1.Show();
            lenovo1.BringToFront();


        }

        private void buttonAsus_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo1.Hide();
            acer1.Hide();
            msi1.Hide();
            hp1.Hide();
            //show current user control
            asus1.Show();
            asus1.BringToFront();
        }

        private void buttonAcer_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo1.Hide();
            asus1.Hide();
            msi1.Hide();
           hp1.Hide();
            //show current user control
            acer1.Show();
            acer1.BringToFront();
        }

        private void buttonMSI_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo1.Hide();
            asus1.Hide();
            acer1.Hide();
           hp1.Hide();
            //show current user control
            msi1.Show();
            msi1.BringToFront();
        }

        private void buttonHP_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo1.Hide();
            asus1.Hide();
            acer1.Hide();
            msi1.Hide();
            //show current user control
            hp1.Show();
            hp1.BringToFront();
        }


        private void buttonMSIBuyNow1_Click(object sender, EventArgs e)
        {
            
            pictureBoxRaider.Image = Properties.Resources.msi1;

            string model = "MSI Raider GE78 HX 13VH-258PH";
            string processor = "Intel Core i9-12900HX";
            string memory = "32GB DDR5-5200";
            string storage = "1TB PCIe® 4.0 x4 SSD + 1TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3080 Ti Laptop GPU";
            string display = "17.3\" WQXGA (2560 x 1440) IPS 240Hz Anti-glare";
            string price = "₱23,000";
       
            // Load the image from the resources
            Image image = Properties.Resources.msi1;

            // Show the laptop specifications in the Specification form and pass the image and pricePerUnit as parameters
            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, image, 23000); // Replace 36995 with the actual pricePerUnit
            var dialogResult = formSpec.ShowDialog();

            // Check if the user clicked the "Add to Cart" button in the Specification form
            if (dialogResult == DialogResult.OK)
            {
                // Retrieve the laptop details from the Specification form properties
                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;

                // Create an instance of the adtocartv2 form
                addtocartv2 adtocartForm = new addtocartv2();

                // Call the AddLaptopToCart method on the instance of adtocartv2 to add the laptop details to the cart
                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                // Show the adtocartv2 form if it is not already visible
                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            // Dispose of the Specification form after usage
            formSpec.Dispose();


        }

        private void buttonHPBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBoxOmen.Image = Properties.Resources.hp3;

            string model = "HP Envy 13-BA1521TX";
            string processor = "Intel Core i5-11400H";
            string memory = "16GB DDR4-3200 MHz RAM";
            string storage = "512GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "NVIDIA GeForce RTX 3060 Laptop GPU";
            string display = "16.1\" diagonal, FHD (1920 x 1080), IPS, micro-edge, anti-glare, 250 nits, 45% NTSC";
            string price = "₱52,995";

            Image image = Properties.Resources.hp3;
         
            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, image, 52995);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
          
                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();
      
                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }

        private void buttonAsusBuyNow1_Click(object sender, EventArgs e)
        {
            pictureBoxTuf.Image = Properties.Resources.asus1;

            string model = "ASUS TUF Gaming F15 FX506HC-HN083W";
            string processor = "AMD Ryzen 7 5800H";
            string memory = "16GB DDR4-3200";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe + 1TB HDD 2.5\" SATA III";
            string graphics = "NVIDIA GeForce RTX 3050 Ti 4GB GDDR6";
            string display = "15.6\" FHD (1920x1080) IPS 240Hz Anti-glare";
            string price = "₱53,995";

            Image laptopImage = Properties.Resources.asus1; // Replace with the actual laptop image

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 53995);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();

                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }

        private void buttonMSIBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBoxTitan.Image = Properties.Resources.msi3;

            string model = "MSI Titan GT77 12UHS-055PH";
            string processor = "Intel Core i9-12900HX";
            string memory = "64GB DDR5-5200";
            string storage = "2TB PCIe® 4.0 x4 SSD + 2TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3080 Ti Laptop GPU";
            string display = "17.3\" UHD (3840 x 2160) IPS 120Hz Anti-glare";
            string price = "₱50,000";

            Image laptopImage = Properties.Resources.msi3;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 50000);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();

                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBoxLegion.Image = Properties.Resources.lenovo2;

            string model = "LENOVO Legion Slim 5 16IRH8 82YA008EPH";
            string processor = "Intel Core i7-13700H";
            string memory = "8GB SO-DIMM DDR5-5200";
            string storage = "1TB SSD M.2 2280 PCIe® 4.0x4 NVMe";
            string graphics = "NVIDIA GeForce RTX 4070 8GB GDDR6";
            string display = "16\" WQXGA (2560x1600) IPS 300nits Anti-glare";
            string price = "₱124,995";

            Image laptopImage = Properties.Resources.lenovo2;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 124995);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();

                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }

        private void buttonMSIBuyNow5_Click_1(object sender, EventArgs e)
        {
            pictureBoxKatana.Image = Properties.Resources.msi5;

            string model = "MSI Katana GF66 12UC-841PH";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "512GB PCIe® 3.0 x4 SSD + 1TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3050 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 144Hz Anti-glare";
            string price = "₱62,950";

            Image laptopImage = Properties.Resources.msi5;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 62950);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();

                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }


        private void buttonMSIBuyNow2_Click_1(object sender, EventArgs e)
        {
            pictureBoxPulse.Image = Properties.Resources.msi2;

            string model = "MSI Pulse GL66 12UEK-028PH";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "1TB PCIe® 3.0 x4 SSD + 512GB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3060 Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 165Hz Anti-glare";
            string price = "₱114,995";

            Image laptopImage = Properties.Resources.msi2;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 114995);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();

                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }

        private void buttonAsusBuyNow5_Click(object sender, EventArgs e)
        {
            pictureBoxROG.Image = Properties.Resources.asus5;

            string model = "ASUS ROG Strix G15";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "1TB PCIe® 3.0 x4 SSD + 512GB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3070 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 300Hz Anti-glare";
            string price = "₱54,995";

            Image laptopImage = Properties.Resources.asus5;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 54995);
            var dialogResult = formSpec.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                string laptopModel = formSpec.LaptopModel;
                int quantity = formSpec.Quantity;
                decimal totalPrice = formSpec.TotalPrice;
                addtocartv2 adtocartForm = new addtocartv2();

                adtocartForm.AddLaptopToCart(laptopModel, quantity, totalPrice);

                if (!adtocartForm.Visible)
                {
                    adtocartForm.Show();
                }
            }

            formSpec.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void AxWindowsMediaPlayer1_SizeChanged(object sender, EventArgs e)
        {
            // Get the aspect ratio of the video.
            int videoWidth = axWindowsMediaPlayer1.currentMedia.imageSourceWidth;
            int videoHeight = axWindowsMediaPlayer1.currentMedia.imageSourceHeight;
            double aspectRatio = (double)videoWidth / videoHeight;

            // Adjust the size of the control to match the video's aspect ratio.
            int newWidth = axWindowsMediaPlayer1.Width;
            int newHeight = (int)(newWidth / aspectRatio);
            axWindowsMediaPlayer1.Height = newHeight;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string videoUrl = "D:\\MSAD\\current new one 25-7-23\\edit_connection\\laptopad.mp4"; // Replace with your video URL or file path.
            axWindowsMediaPlayer1.URL = videoUrl;

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}

