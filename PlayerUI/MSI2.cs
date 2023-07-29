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
    public partial class MSI2 : UserControl
    {
        public MSI2()
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();

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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

        private void buttonMSIBuyNow4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.msi4;

            string model = "MSI GF63 THIN";
            string processor = "Intel Core i7-11800H";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3050 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 144Hz Anti-glare";
            string price = "₱44,995";

            Image laptopImage = Properties.Resources.msi4;

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }
    }
}
