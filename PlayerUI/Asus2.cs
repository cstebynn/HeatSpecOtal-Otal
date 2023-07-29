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
    public partial class Asus2 : UserControl
    {
        public Asus2()
        {
            InitializeComponent();
        }

        private void buttonAsusBuyNow1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.asus1;

            string model = "ASUS TUF Gaming F15 FX506HC-HN083W";
            string processor = "AMD Ryzen 7 5800H";
            string memory = "16GB DDR4-3200";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe + 1TB HDD 2.5\" SATA III";
            string graphics = "NVIDIA GeForce RTX 3050 Ti 4GB GDDR6";
            string display = "15.6\" FHD (1920x1080) IPS 240Hz Anti-glare";
            string price = "₱53,995";

            Image laptopImage = Properties.Resources.asus1; // Replace with the actual laptop image

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

        private void buttonAsusBuyNow2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.asus2;

            string model = "ASUS Zephyrus G14 AW SE GA401QEC 14”\r\n";
            string processor = "AMD Ryzen™ 9 5900HS";
            string memory = "16GB DDR4 3200MHz";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX™ 3050 Ti Laptop GPU";
            string display = "14\" QHD (2560 x 1440) IPS-Type, 120Hz, Adaptive-Sync, Pantone® Validated, DCI-P3 100%, DisplayHDR™ 400";
            string price = "₱79,900";

            Image laptopImage = Properties.Resources.asus2; // Replace with the actual laptop image

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

        private void buttonAsusBuyNow3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.asus3;

            string model = "ASUS Vivobook 15 X1502ZA-BQ247WS";
            string processor = "Intel Core i5-12500H";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "15.6\" FHD (1920 x 1080) IPS 60Hz Anti-glare";
            string price = "₱34,995";

            Image laptopImage = Properties.Resources.asus3; // Replace with the actual laptop image

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

        private void buttonAsusBuyNow4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.asus4;

            string model = "ASUS Zenbook 14 UX3402ZA-KM136WS";
            string processor = "Intel Core i5-12450H";
            string memory = "8GB LPDDR4X-4266";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "14\" WUXGA (1920 x 1200) OLED 500 nits Non-Touch";
            string price = "₱65,995";

            Image laptopImage = Properties.Resources.asus4; // Replace with the actual laptop image

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

        private void buttonAsusBuyNow5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.asus5;

            string model = "ASUS ROG Strix G15";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "1TB PCIe® 3.0 x4 SSD + 512GB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3070 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 300Hz Anti-glare";
            string price = "₱54,995";

            Image laptopImage = Properties.Resources.asus5; // Replace with the actual laptop image

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }
    }
}

