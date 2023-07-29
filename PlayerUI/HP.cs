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
    public partial class HP : UserControl
    {
        public HP()
        {
            InitializeComponent();

        }

        private void buttonHPBuyNow1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hp1;

            string model = "HP Pavilion 14-DV1020TU";
            string processor = "Intel Core i5-1155G7";
            string memory = "8 GB DDR4-3200 MHz RAM (2 x 4 GB)";
            string storage = "512GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "35.6 cm (14\") diagonal, FHD (1920 x 1080)";
            string price = "₱44,495";

            Image laptopImage = Properties.Resources.hp1;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 44495);
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

        private void buttonHPBuyNow2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hp2;

            string model = "HP Envy 13-BA1521TX";
            string processor = "Intel Core i5-1135G7";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "13.3\" diagonal, FHD (1920 x 1080), IPS, edge-to-edge glass, micro-edge, 400 nits, 100% sRGB";
            string price = "₱52,995";

            Image laptopImage = Properties.Resources.hp2;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 52995);
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

        private void buttonHPBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.hp3;

            string model = "Omen 16-B0174TX";
            string processor = "Intel Core i5-11400H";
            string memory = "16GB DDR4-3200 MHz RAM";
            string storage = "512GB SSD";
            string graphics = "NVIDIA GeForce RTX 3060 6GB";
            string display = "16.1\" FHD IPS (300 nits, 144Hz)";
            string price = "₱78,859";

            Image laptopImage = Properties.Resources.hp3;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 78859);
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

        private void buttonHPBuyNow4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.hp4;

            string model = "HP Spectre X360 13-AP0044TU";
            string processor = "Intel Core i5-8265U";
            string memory = "8GB DDR4-2400 MHz RAM";
            string storage = "256GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "Intel UHD Graphics 620";
            string display = "13.3\" diagonal, FHD (1920 x 1080), IPS, micro-edge, multi-touch, edge-to-edge glass, anti-glare, 400 nits, 72% NTSC";
            string price = "₱79,990";

            Image laptopImage = Properties.Resources.hp4;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 79990);
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

        private void buttonHPBuyNow5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.hp5;

            string model = "HP Chromebook 14 G7 Notebook Laptop";
            string processor = "Intel Celeron N4020";
            string memory = "4GB LPDDR4-2400 RAM";
            string storage = "32GB eMMC";
            string graphics = "Intel UHD Graphics 600";
            string display = "14\" diagonal, HD (1366 x 768), micro-edge, anti-glare, 220 nits, 45% NTSC";
            string price = "₱13,495";

            Image laptopImage = Properties.Resources.hp5;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 13495);
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
    }
}
