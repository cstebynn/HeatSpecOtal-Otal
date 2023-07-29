using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class addtocartv2 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb;Persist Security Info=False;";


        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
        public addtocartv2()
        {
            InitializeComponent();      
        }

        public void AddLaptopToCart(string model, int quantity, decimal totalPrice)
        {
            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");
            UpdateGrandTotal();
        }

        private void buttonLenovo_Click(object sender, EventArgs e)
        {  
            panel1.BringToFront();//levono
        }

        private void buttonAsus_Click(object sender, EventArgs e)
        {
            panel9.BringToFront();//asus
        }

        private void buttonAcer_Click(object sender, EventArgs e)
        {
            panel15.BringToFront();//acer

        }

        private void buttonMSI_Click(object sender, EventArgs e)
        {
            panel22.BringToFront();//mis
        }

        private void buttonHP_Click(object sender, EventArgs e)
        {
            panel28.BringToFront();//hp
        }

        private void buttonLenovoBuyNow1_Click(object sender, EventArgs e)
        {
         
            string model = "LENOVO IDEAPAD SLIM 3I 14ITL6 82H700HNPH";
            string processor = "Intel Core i5-1135G7";
            string memory = "4GB DDR4-3200 + 4GB SO-DIMM DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "NVIDIA GEFORCE MX450 2GB GDDR6";
            string display = "14 FHD (1920x1080)";
            decimal price = 36995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();

        }

        private void buttonLenovoBuyNow2_Click(object sender, EventArgs e)
        {
            string model = "LENOVO Legion Slim 5 16IRH8 82YA008EPH";
            string processor = "Intel Core i7-13700H";
            string memory = "8GB SO-DIMM DDR5-5200";
            string storage = "1TB SSD M.2 2280 PCIe® 4.0x4 NVMe";
            string graphics = "NVIDIA GeForce RTX 4070 8GB GDDR6";
            string display = "16\" WQXGA (2560x1600) IPS 300nits Anti-glare";
            decimal price = 124995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";
        
            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return; 

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonLenovoBuyNow3_Click(object sender, EventArgs e)
        {
            string model = "LENOVO ThinkPad E14 Gen 4 21E3S01900";
            string processor = "Intel Core i5-1235U";
            string memory = "8GB DDR5-4800";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Intel Iris Xe Graphics";
            string display = "14\" FHD (1920x1080) IPS 300nits Anti-glare"; 
            decimal price = 72945;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();

        }

        private void buttonLenovoBuyNow4_Click(object sender, EventArgs e)
        {
            string model = "LENOVO YOGA 6 13ALC6 82ND00AQPH";
            string processor = "AMD Ryzen 5 5500U";
            string memory = "8GB Soldered DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Radeon RX VEGA 8";
            string display = "13.3\" FHD (1920x1080) IPS 300nits Anti-glare";
            decimal price= 45295;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }


        private void buttonLenovoBuyNow5_Click(object sender, EventArgs e)
        {
            string model = "LENOVO G50-70 CORE I7 15INCH";
            string processor = "Intel Core i5-4210U";
            string memory = "8GB DDR3L-1600";
            string storage = "1TB 5400RPM HDD";
            string graphics = "AMD Radeon R5 M230";
            string display = "15.6-inch HD (1366x768) LED backlit display";
            decimal price = 21950;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        
        public void UpdateGrandTotal()
        {
            decimal grandTotal = CalculateGrandTotal();

            // Display the grand total in the label with the Philippine peso sign (₱)
            labeltextGrandTotal.Text = $"Grand Total: ₱{grandTotal:N}";
        }

        private void buttonAsusBuyNow1_Click(object sender, EventArgs e)
        {
            string model = "ASUS TUF Gaming F15 FX506HC-HN083W";
            string processor = "AMD Ryzen 7 5800H";
            string memory = "16GB DDR4-3200";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe + 1TB HDD 2.5\" SATA III";
            string graphics = "NVIDIA GeForce RTX 3050 Ti 4GB GDDR6";
            string display = "15.6\" FHD (1920x1080) IPS 240Hz Anti-glare";       
            decimal price = 53995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();


        }

        private void buttonAsusBuyNow2_Click(object sender, EventArgs e)
        {
            string model = "ASUS Zephyrus G14 AW SE GA401QEC 14”\r\n";
            string processor = "AMD Ryzen™ 9 5900HS";
            string memory = "16GB DDR4 3200MHz";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX™ 3050 Ti Laptop GPU";
            string display = "14\" QHD (2560 x 1440) IPS-Type, 120Hz, Adaptive-Sync, Pantone® Validated, DCI-P3 100%, DisplayHDR™ 400";
            decimal price = 79900;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonAsusBuyNow3_Click(object sender, EventArgs e)
        {
            string model = "ASUS Vivobook 15 X1502ZA-BQ247WS";
            string processor = "Intel Core i5-12500H";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "15.6\" FHD (1920 x 1080) IPS 60Hz Anti-glare";
            decimal price = 34995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonAsusBuyNow4_Click(object sender, EventArgs e)
        {
            string model = "ASUS Zenbook 14 UX3402ZA-KM136WS";
            string processor = "Intel Core i5-12450H";
            string memory = "8GB LPDDR4X-4266";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "14\" WUXGA (1920 x 1200) OLED 500 nits Non-Touch";
            decimal price = 65995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonAsusBuyNow5_Click(object sender, EventArgs e)
        {

            string model = "ASUS ROG Strix G15";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "1TB PCIe® 3.0 x4 SSD + 512GB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3070 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 300Hz Anti-glare";    
            decimal price = 54995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();

        }

        private void buttonAcerBuyNow1_Click(object sender, EventArgs e)
        {
            string model = "ACER ASPIRE 5 A515-56G-34QK";
            string processor = "Intel Core i3-1115G4";
            string memory = "8GB DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Integrated Intel Iris Xe Graphics";
            string display = "15.6\" FHD (1920x1080) IPS 300nits Anti-glare";    
            decimal price = 29995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonAcerBuyNow2_Click(object sender, EventArgs e)
        {
            string model = "ACER Nitro 5 AN515-58-78A6";
            string processor = "Intel Core i7-12700H";
            string memory = "8GB DDR5-4800";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe";
            string graphics = "NVIDIA GeForce RTX 3060 6GB GDDR6";
            string display = "15.6\" FHD (1920x1080) IPS 144Hz Anti-glare";
            decimal price = 73995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        
        private void buttonAcerBuyNow3_Click(object sender, EventArgs e)
        {
            string model = "ACER Helios Neo 16 PHN16-71-59F1";
            string processor = "Intel Core i5-13500HX";
            string memory = "8GB DDR5-5200";
            string storage = "512GB SSD M.2 2280 PCIe® 4.0x4 NVMe";
            string graphics = "NVIDIA GeForce RTX 4050 6GB GDDR6";
            string display = "16\" WQXGA (2560x1600) IPS 300nits Anti-glare";
            decimal price = 67495;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonAcerBuyNow4_Click(object sender, EventArgs e)
        {
            string model = "ACER Swift 3 SF314-43-R4CP";
            string processor = "AMD Ryzen 5 5500U";
            string memory = "8GB DDR5-5200";
            string storage = "512GB SSD M.2 2280 PCIe 3.0x4 NVMe";
            string graphics = "AMD Radeon RX Vega 7";
            string display = "14\" FHD (1920x1080) IPS 300nits Anti-glare";
            decimal price = 41999;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonAcerBuyNow5_Click(object sender, EventArgs e)
        {
            string model = "ACER TravelMate P214-53-54TU I5-1135G7";
            string processor = "Intel Core i5-1135G7";
            string memory = "8GB DDR4-3200";
            string storage = "512GB SSD M.2 2242 PCIe 3.0x4 NVMe";
            string graphics = "Integrated Intel Iris Xe Graphics";
            string display = "14\" FHD (1920x1080) IPS 300nits Anti-glare";
            decimal price = 36999;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonMSIBuyNow1_Click(object sender, EventArgs e)
        {
            string model = "MSI Raider GE78 HX 13VH-258PH";
            string processor = "Intel Core i9-12900HX";
            string memory = "32GB DDR5-5200";
            string storage = "1TB PCIe® 4.0 x4 SSD + 1TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3080 Ti Laptop GPU";
            string display = "17.3\" WQXGA (2560 x 1440) IPS 240Hz Anti-glare";
            decimal price = 23000;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonMSIBuyNow2_Click(object sender, EventArgs e)
        {
            string model = "MSI Pulse GL66 12UEK-028PH";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "1TB PCIe® 3.0 x4 SSD + 512GB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3060 Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 165Hz Anti-glare";
            decimal price = 114995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonMSIBuyNow3_Click(object sender, EventArgs e)
        {
            string model = "MSI Titan GT77 12UHS-055PH";
            string processor = "Intel Core i9-12900HX";
            string memory = "64GB DDR5-5200";
            string storage = "2TB PCIe® 4.0 x4 SSD + 2TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3080 Ti Laptop GPU";
            string display = "17.3\" UHD (3840 x 2160) IPS 120Hz Anti-glare";
            decimal price = 50000;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonMSIBuyNow4_Click(object sender, EventArgs e)
        {
            string model = "MSI GF63 THIN";
            string processor = "Intel Core i7-11800H";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® 3.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3050 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 144Hz Anti-glare";
            decimal price = 44995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonMSIBuyNow5_Click(object sender, EventArgs e)
        {
            string model = "MSI Katana GF66 12UC-841PH";
            string processor = "Intel Core i7-12700H";
            string memory = "16GB DDR5-4800";
            string storage = "512GB PCIe® 3.0 x4 SSD + 1TB PCIe® 4.0 x4 SSD";
            string graphics = "NVIDIA GeForce RTX 3050 Ti Laptop GPU";
            string display = "15.6\" FHD (1920 x 1080) IPS 144Hz Anti-glare";
            decimal price = 62950;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonHPBuyNow1_Click(object sender, EventArgs e)
        {
            string model = "HP Pavilion 14-DV1020TU";
            string processor = "Intel Core i5-1155G7";
            string memory = "8 GB DDR4-3200 MHz RAM (2 x 4 GB)";
            string storage = "512GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "35.6 cm (14\") diagonal, FHD (1920 x 1080)";
            decimal price = 44495;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonHPBuyNow2_Click(object sender, EventArgs e)
        {
            string model = "HP Envy 13-BA1521TX";
            string processor = "Intel Core i5-1135G7";
            string memory = "8GB DDR4-3200";
            string storage = "512GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "Intel Iris Xe Graphics";
            string display = "13.3\" diagonal, FHD (1920 x 1080), IPS, edge-to-edge glass, micro-edge, 400 nits, 100% sRGB";
            decimal price = 52995;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonHPBuyNow3_Click(object sender, EventArgs e)
        {
            string model = "Omen 16-B0174TX";
            string processor = "Intel Core i5-11400H";
            string memory = "16GB DDR4-3200 MHz RAM";
            string storage = "512GB SSD";
            string graphics = "NVIDIA GeForce RTX 3060 6GB";
            string display = "16.1\" FHD IPS (300 nits, 144Hz)";
            decimal price = 78859;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonHPBuyNow4_Click(object sender, EventArgs e)
        {
            string model = "HP Spectre X360 13-AP0044TU";
            string processor = "Intel Core i5-8265U";
            string memory = "8GB DDR4-2400 MHz RAM";
            string storage = "256GB PCIe® NVMe™ TLC M.2 SSD";
            string graphics = "Intel UHD Graphics 620";
            string display = "13.3\" diagonal, FHD (1920 x 1080), IPS, micro-edge, multi-touch, edge-to-edge glass, anti-glare, 400 nits, 72% NTSC";
            decimal price = 79990;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }

        private void buttonHPBuyNow5_Click(object sender, EventArgs e)
        {
            string model = "HP Chromebook 14 G7 Notebook Laptop";
            string processor = "Intel Celeron N4020";
            string memory = "4GB LPDDR4-2400 RAM";
            string storage = "32GB eMMC";
            string graphics = "Intel UHD Graphics 600";
            string display = "14\" diagonal, HD (1366 x 768), micro-edge, anti-glare, 220 nits, 45% NTSC";
            decimal price = 13495;

            string message = $"Model: {model}\nProcessor: {processor}\nMemory: {memory}\nStorage: {storage}\nGraphics: {graphics}\nDisplay: {display}\nPrice: ₱{price:N}";

            MessageBox.Show(message, "Laptop Specifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int quantity = InputBox.GetNumericInput("Enter quantity:", "Quantity", defaultValue: 1);
            if (quantity == -1) return;

            decimal totalPrice = price * quantity;

            int rowIndex = dataGridViewOrder.Rows.Add(model, quantity, $"₱{totalPrice:N}");

            UpdateGrandTotal();
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridViewOrder.SelectedRows[0].Index;

                // Remove the selected row from the DataGridView
                dataGridViewOrder.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateGrandTotal();
        }


        public decimal CalculateGrandTotal()
        {
            decimal grandTotal = 0;

            // Iterate through the rows of the DataGridView and sum up the total prices
            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                if (row.Cells["Price"].Value != null && decimal.TryParse(row.Cells["Price"].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-PH"), out decimal totalPrice))
                {
                    grandTotal += totalPrice;
                }
            }

            return grandTotal;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {


            // Get the billing details from the textboxes
            string date = dateTimePicker1.Text;
            string fullName = textBoxFullName.Text;
            string street = textBoxStreet.Text;
            string province = textBoxProvince.Text;
            string city = textBoxCity.Text;
            string postalCode = textBoxPostalCode.Text;

            // Check if any of the billing details fields are empty
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(street) ||
                string.IsNullOrWhiteSpace(province) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(postalCode))
            {
                MessageBox.Show("Please fill in all the billing details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the credit card details
            string cardholderName = textBoxCardholderName.Text;
            string cardNumber = textBoxCardNumber.Text;
            string expirationDate = textBoxExpire.Text;
            string cvv = textBoxCVV.Text;

            // Check if any of the credit card details fields are empty
            if (string.IsNullOrWhiteSpace(cardholderName) ||
                string.IsNullOrWhiteSpace(cardNumber) ||
                string.IsNullOrWhiteSpace(expirationDate) ||
                string.IsNullOrWhiteSpace(cvv))
            {
                MessageBox.Show("Please fill in all the credit card details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show a message box with the submitted billing details and payment method, including credit card details
            string message = $"Billing Details:\nDate: {date}\nFull Name: {fullName}\nStreet: {street}\nProvince: {province}\nCity: {city}\nPostal Code: {postalCode}\n\n" +
                             $"Payment: \nCardholder's Name: {cardholderName}\nCard Number: {cardNumber}\nExpiration Date: {expirationDate}\nCVV: {cvv}";

            // Show the billing details and credit card information in a message box
            MessageBox.Show(message, "Billing Details and Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);



            decimal grandTotal = 0; // Variable to store the grand total
            string ordersMessage = "Orders:\n";

            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                if (!row.IsNewRow)
                {
                    var modelCell = row.Cells["Model"];
                    var quantityCell = row.Cells["Quantity"];
                    var priceCell = row.Cells["Price"];

                    if (modelCell.Value != null && quantityCell.Value != null && priceCell.Value != null)
                    {
                        string model = modelCell.Value.ToString();
                        int quantity = Convert.ToInt32(quantityCell.Value);
                        string priceString = priceCell.Value.ToString();

                        // Remove currency symbol (₱) and comma from the price string
                        decimal totalPrice;
                        if (!decimal.TryParse(priceString.Replace("₱", "").Replace(",", ""), out totalPrice))
                        {
                            MessageBox.Show($"Invalid price format for {model}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Update the grand total with the total price of each item
                        grandTotal += totalPrice;

                        ordersMessage += $"\n{model} - Quantity: {quantity}, Total Price: ₱{totalPrice:N}\n";
                    }
                    else
                    {
                        // Handle the case where the cell value is null (optional)
                        // You can display an error message or perform other actions here if needed.
                        MessageBox.Show("Error: Missing or invalid data in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

            // Show the grand total in the message box
            ordersMessage += $"\nGrand Total: ₱{grandTotal:N}\n";

            // Show the orders in the message box
            MessageBox.Show(ordersMessage, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show a thank you message box
            MessageBox.Show("Thank you for your purchase!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ////

            ////
            ///


            //reduing the inventory to the inventory
           
        
            

            // Insert data into the tables (CustomerDetails, CustomerOrders, CustomerDate)
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Insert data into the CustomerDetails table
                    string customerQuery = "INSERT INTO CustomerDetails ([Name], [Street], [Province], [City], [Postal Code], [Cardholder Name], [Cardholder Number], [Expiration Date], [CVV]) " +
                                          "VALUES (@Name, @Street, @Province, @City, @PostalCode, @CardholderName, @CardNumber, @ExpirationDate, @CVV)";
                    using (OleDbCommand customerCmd = new OleDbCommand(customerQuery, conn))
                    {
                        customerCmd.Parameters.AddWithValue("@Name", fullName);
                        customerCmd.Parameters.AddWithValue("@Street", street);
                        customerCmd.Parameters.AddWithValue("@Province", province);
                        customerCmd.Parameters.AddWithValue("@City", city);
                        customerCmd.Parameters.AddWithValue("@PostalCode", postalCode);
                        customerCmd.Parameters.AddWithValue("@CardholderName", textBoxCardholderName.Text);
                        customerCmd.Parameters.AddWithValue("@CardNumber", textBoxCardNumber.Text);
                        customerCmd.Parameters.AddWithValue("@ExpirationDate", textBoxExpire.Text);
                        customerCmd.Parameters.AddWithValue("@CVV", textBoxCVV.Text);

                        customerCmd.ExecuteNonQuery();
                    }

                    // Retrieve the customer ID for that user
                    int customerID;
                    using (OleDbCommand getCustomerIDCmd = new OleDbCommand("SELECT ID FROM CustomerDetails WHERE [Name] = @Name", conn))
                    {
                        getCustomerIDCmd.Parameters.AddWithValue("@Name", fullName);
                        object result = getCustomerIDCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out customerID))
                        {
                            // Insert data into the CustomerOrders table for each laptop purchased by that user
                            string orderQuery = "INSERT INTO CustomerOrders (ID, LaptopModel, Quantity, Price) VALUES (@ID, @LaptopModel, @Quantity, @Price)";
                            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string model = row.Cells["Model"].Value.ToString();
                                    string quantityString = row.Cells["Quantity"].Value.ToString();
                                    string priceString = row.Cells["Price"].Value.ToString();

                                    if (int.TryParse(quantityString, out int quantity) && decimal.TryParse(priceString.Replace("₱", "").Replace(",", ""), out decimal price))
                                    {
                                        using (OleDbCommand orderCmd = new OleDbCommand(orderQuery, conn))
                                        {
                                            orderCmd.Parameters.AddWithValue("@ID", customerID);
                                            orderCmd.Parameters.AddWithValue("@LaptopModel", model);
                                            orderCmd.Parameters.AddWithValue("@Quantity", quantity);
                                            orderCmd.Parameters.AddWithValue("@Price", price);

                                            orderCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        // Display the problematic data for debugging
                                        MessageBox.Show($"Error: Invalid quantity or price format for the laptop:\nModel: {model}\nQuantity: {quantityString}\nPrice: {priceString}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        // You might want to return or exit the loop here if needed.
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Customer ID not found for {fullName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Insert data into the CustomerDate table
                    string dateQuery = "INSERT INTO CustomerDate (Date_) VALUES (@Date_)";
                    using (OleDbCommand dateCmd = new OleDbCommand(dateQuery, conn))
                    {
                        dateCmd.Parameters.AddWithValue("@Date_", date);
                        dateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();

            // Clear the form after submission
            ClearForm();
        }


        private void ClearForm()
        {
            // Clear all the textboxes
            textBoxFullName.Text = "";
            textBoxStreet.Text = "";
            textBoxProvince.Text = "";
            textBoxCity.Text = "";
            textBoxPostalCode.Text = "";
            textBoxCardholderName.Text = "";
            textBoxCardNumber.Text = "";
            textBoxExpire.Text = "";
            textBoxCVV.Text = "";

            // Uncheck the payment method radio buttons
            rbCreditDebitCard.Checked = false;
            rbCodOnSitePayment.Checked = false;
        }

        private void buttonProceed_Click_1(object sender, EventArgs e)
        {
            panel34.BringToFront();
            panel34.Show();
            dataGridViewOrder.BringToFront();
            labeltextGrandTotal.BringToFront();

            
        }

            private void buttonBack_Click(object sender, EventArgs e)
        {  
           panel34.Hide();
        }

        private void addtocartv2_Load(object sender, EventArgs e)
        {
         
       
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLenovo_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();//levono
        }
    }
}
