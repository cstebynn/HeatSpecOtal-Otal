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
    public partial class MSI : UserControl
    {
        public MSI()
        {
            InitializeComponent();
        }

        private void buttonMSIBuyNow1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.msi1;

            string model = "MSI Raider GE78 HX 13VH-258PH";
            string processor = "Intel Core i9-12900HX";
            string memory = "32GB DDR5-5200";
            string storage = "1TB PCIe® 4.0 x4 SSD + 1TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3080 Ti Laptop GPU";
            string display = "17.3\" WQXGA (2560 x 1440) IPS 240Hz Anti-glare";
            string price = "₱23,000";

            Image laptopImage = Properties.Resources.msi1;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 23000);
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

        private void buttonMSIBuyNow2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.msi2;

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

        private void buttonMSIBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.msi3;

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

        private void buttonMSIBuyNow4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.msi4;

            string model = "MSI GF63 THIN 11UD-022PH";
            string processor = "Intel Core i7-11800H";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3050 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 144Hz Anti-glare";
            string price = "₱44,995";

            Image laptopImage = Properties.Resources.msi4;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 44995);
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

        private void buttonMSIBuyNow5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.msi5;

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

        private void MSI_Load(object sender, EventArgs e)
        {
         
        }
    }
}
