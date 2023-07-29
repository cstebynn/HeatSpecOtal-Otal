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
    public partial class Form3CS : Form
    {
     
        public Form3CS()
        {
            InitializeComponent();   
        }

        private void Form3CS_Load(object sender, EventArgs e)
        {
            lenovo21.Hide();
            asus21.Hide();
            acer21.Hide();
            msI21.Hide();
            hP21.Hide();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            //hide other user controls
            lenovo21.Hide();
            asus21.Hide();
            acer21.Hide();
            msI21.Hide();
            hP21.Hide();
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
            asus21.Hide();
            acer21.Hide();
            msI21.Hide();
            hP21.Hide();
            //show current user control
            lenovo21.Show();
            lenovo21.BringToFront();



        }

        private void buttonAsus_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo21.Hide();
            acer21.Hide();
            msI21.Hide();
            hP21.Hide();
            //show current user control
            asus21.Show();
            asus21.BringToFront();
        }

        private void buttonAcer_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo21.Hide();
            asus21.Hide();
            msI21.Hide();
            hP21.Hide();
            //show current user control
            acer21.Show();
            acer21.BringToFront();
        }

        private void buttonMSI_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo21.Hide();
            asus21.Hide();
            acer21.Hide();
            hP21.Hide();
            //show current user control
            msI21.Show();
            msI21.BringToFront();
        }

        private void buttonHP_Click(object sender, EventArgs e)
        {
            //hide other user controls
            pictureBox2.Hide();
            lenovo21.Hide();
            asus21.Hide();
            acer21.Hide();
            msI21.Hide();
            //show current user control
            hP21.Show();
            hP21.BringToFront();
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
            string price = "₱36,995";

            Image laptopImage = Properties.Resources.msi1;

            Final_Billing formFB = this.ParentForm as Final_Billing;

            SpecificationCS formSpecCS = new SpecificationCS(formFB, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();


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

            Image laptopImage = Properties.Resources.hp3;


            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

        private void buttonMSIBuyNow5_Click(object sender, EventArgs e)
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
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

            Image laptopImage = Properties.Resources.asus5; // Replace with the actual laptop image

            SpecificationCS formSpecCS = new SpecificationCS(this.ParentForm as Final_Billing, model, processor, memory, storage, graphics, display, price, laptopImage);
            formSpecCS.Show();
        }

      
    }
}
