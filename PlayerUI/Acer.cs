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
    public partial class Acer : UserControl
    {
        public Acer()
        {
            InitializeComponent();
        }

        private void buttonAcerBuyNow1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.acer1;

            string model = "ACER ASPIRE 5 A515-56G-34QK";
            string processor = "Intel Core i3-1115G4";
            string memory = "8GB DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Integrated Intel Iris Xe Graphics";
            string display = "15.6\" FHD (1920x1080) IPS 300nits Anti-glare";
            string price = "₱29,995";

            Image laptopImage = Properties.Resources.acer1;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 29995);
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

        private void buttonAcerBuyNow2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.acer2;

            string model = "ACER Nitro 5 AN515-58-78A6";
            string processor = "Intel Core i7-12700H";
            string memory = "8GB DDR5-4800";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe";
            string graphics = "NVIDIA GeForce RTX 3060 6GB GDDR6";
            string display = "15.6\" FHD (1920x1080) IPS 144Hz Anti-glare";
            string price = "₱73,995";

            Image laptopImage = Properties.Resources.acer2;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 73995);
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

        private void buttonAcerBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.acer3;

            string model = "ACER Helios Neo 16 PHN16-71-59F1";
            string processor = "Intel Core i5-13500HX";
            string memory = "8GB DDR5-5200";
            string storage = "512GB SSD M.2 2280 PCIe® 4.0x4 NVMe";
            string graphics = "NVIDIA GeForce RTX 4050 6GB GDDR6";
            string display = "16\" WQXGA (2560x1600) IPS 300nits Anti-glare";
            string price = "₱67,495";

            Image laptopImage = Properties.Resources.acer3;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 67495);
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

        private void buttonAcerBuyNow4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.acer4;

            string model = "ACER Swift 3 SF314-43-R4CP";
            string processor = "AMD Ryzen 5 5500U";
            string memory = "8GB DDR5-5200";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe";
            string graphics = "AMD Radeon RX Vega 7";
            string display = "14\" FHD (1920x1080) IPS 300nits Anti-glare";
            string price = "₱41,999";

            Image laptopImage = Properties.Resources.acer4;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 41999);
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

        private void buttonAcerBuyNow5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.acer5;

            string model = "ACER TravelMate P214-53-54TU I5-1135G7";
            string processor = "Intel Core i5-1135G7";
            string memory = "8GB DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Integrated Intel Iris Xe Graphics";
            string display = "14\" FHD (1920x1080) IPS 300nits Anti-glare";
            string price = "₱36,999";

            Image laptopImage = Properties.Resources.acer5;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 36999);
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Acer_Load(object sender, EventArgs e)
        {
    
        }
    }
}
