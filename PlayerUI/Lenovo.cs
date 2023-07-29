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
    public partial class Lenovo : UserControl
    {
    
        public Lenovo()
        {
            InitializeComponent();

        }

        private void buttonLenovoBuyNow1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources.lenovo1;

            string model = "LENOVO IDEAPAD SLIM 3I 14ITL6 82H700HNPH";
            string processor = "Intel Core i5-1135G7";
            string memory = "4GB DDR4-3200 + 4GB SO-DIMM DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "NVIDIA GEFORCE MX450 2GB GDDR6";
            string display = "14 FHD (1920x1080)";
            string price = "₱36,995";

            Image laptopImage = Properties.Resources.lenovo1; // Replace with the actual laptop image


            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 36995);
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


        private void buttonLenovoBuyNow2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.lenovo2;

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


        private void buttonLenovoBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.lenovo3;

            string model = "LENOVO ThinkPad E14 Gen 4 21E3S01900";
            string processor = "Intel Core i5-1235U";
            string memory = "8GB DDR5-4800";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Intel Iris Xe Graphics";
            string display = "14\" FHD (1920x1080) IPS 300nits Anti-glare";
            string price = "₱72,945";

            Image laptopImage = Properties.Resources.lenovo3;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 72945);
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

        private void buttonLenovoBuyNow4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.lenovo4;

            string model = "LENOVO ThinkPad E14 Gen 4 21E3S01900";
            string processor = "AMD Ryzen 5 5500U";
            string memory = "8GB Soldered DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Radeon RX VEGA 8";
            string display = "13.3\" FHD (1920x1080) IPS 300nits Anti-glare";
            string price = "₱45,295";

            Image laptopImage = Properties.Resources.lenovo4;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 45295);
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

        private void buttonLenovoBuyNow5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.lenovo5;

            string model = "LENOVO G50-70 CORE I7 15INCH";
            string processor = "Intel Core i7-4210U";
            string memory = "8GB DDR3L-1600";
            string storage = "1TB 5400RPM HDD";
            string graphics = "AMD Radeon R5 M230";
            string display = "15.6-inch HD (1366x768) LED backlit display";
            string price = "₱21,950";

            Image laptopImage = Properties.Resources.lenovo5;

            Specification formSpec = new Specification(model, processor, memory, storage, graphics, display, price, laptopImage, 21950);
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

        private void Lenovo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
