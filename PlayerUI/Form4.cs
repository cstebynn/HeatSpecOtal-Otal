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
    public partial class Form4 : Form
    {
        private Form2 form2;
        public DataGridView form2Grid;
        public Form4(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
          
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int ID = 0;
            if (int.TryParse(textBox5.Text, out int idValue))
            {
                ID = idValue;
            }
            else
            {
                MessageBox.Show("ID must be a valid integer.");
                return;
            }
            string Brand = textBox1.Text;
            string Model = textBox2.Text;
            string Price = textBox3.Text;
            int Quantity = 0;
            if (int.TryParse(textBox4.Text, out int quanValue))
            {
                Quantity = quanValue;
            }
            else
            {
                MessageBox.Show("ID must be a valid integer.");
                return;
            }

            form2.AddRowToDataGridView(ID, Brand, Model, Price, Quantity);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            UPDATE.Parent = pictureBox1;
            UPDATE.BackColor = Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

        }
    }
}
