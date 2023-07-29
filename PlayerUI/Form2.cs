using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace PlayerUI
{


    public partial class Form2 : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");

        DataSet ds;
        int indexRow;
        public Form2()
        {
            InitializeComponent();
            GemBox.Spreadsheet.SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();

            da = new OleDbDataAdapter("SELECT *FROM Inventory", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Inventory");
            dataGridView1.DataSource = ds.Tables["Inventory"];
            myConn.Close();

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb");
            ds = new DataSet();
            myConn.Open();
            myConn.Close();

            da = new OleDbDataAdapter("SELECT *FROM SalesReport", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "SalesReport");
            dataGridView2.DataSource = ds.Tables["SalesReport"];
            myConn.Close();

        }
        public void AddRowToDataGridView(int ID, string Brand, string Model, string Price, int Quantity)
        {
            // Add the new row to the DataGridView
            DataTable dt = (DataTable)dataGridView1.DataSource;

            // Create a new DataRow and populate it with values
            DataRow newRow = dt.NewRow();
            newRow["ID"]= ID;
            newRow["Brand"] = Brand;
            newRow["Model Name"] = Model;
            newRow["Price"] = Price;
            newRow["Quantity"] = Quantity;

            // Add the new row to the DataTable
            dt.Rows.Add(newRow);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
            "XLS (*.xls)|*.xls|" +
            "XLT (*.xlt)|*.xlt|" +
            "XLSX (*.xlsx)|*.xlsx|" +
            "XLSM (*.xlsm)|*.xlsm|" +
            "XLTX (*.xltx)|*.xltx|" +
            "XLTM (*.xltm)|*.xltm|" +
            "ODS (*.ods)|*.ods|" +
            "OTS (*.ots)|*.ots|" +
            "CSV (*.csv)|*.csv|" +
            "TSV (*.tsv)|*.tsv|" +
            "HTML (*.html)|*.html|" +
            "MHTML (.mhtml)|*.mhtml|" +
            "PDF (*.pdf)|*.pdf|" +
            "XPS (*.xps)|*.xps|" +
            "BMP (*.bmp)|*.bmp|" +
            "GIF (*.gif)|*.gif|" +
            "JPEG (*.jpg)|*.jpg|" +
            "PNG (*.png)|*.png|" +
            "TIFF (*.tif)|*.tif|" +
            "WMP (*.wdp)|*.wdp|" +
            "MD (*.mdb)|*.mdb|" +
            "ACCDB (*.accdb)|*.accdb";
            saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");
                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(
                worksheet,
                this.dataGridView1,
                new ImportFromDataGridViewOptions() { ColumnHeaders = true }); ;
                var saveOptions = GemBox.Spreadsheet.SaveOptions.XlsxDefault;
                workbook.Save(saveFileDialog.FileName, saveOptions);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the ID or unique identifier of the row to be deleted
                int rowId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);

                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);

                // Remove the row from the database
                RemoveRowFromDatabase(rowId);
            }

            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int rowIndex = dataGridView2.SelectedRows[0].Index;

                // Get the name of the row to be deleted
                string rowName = dataGridView2.Rows[rowIndex].Cells["Name"].Value.ToString();

                // Remove the row from the DataGridView
                dataGridView2.Rows.RemoveAt(rowIndex);

                // Remove the row from the database based on the name
                RemoveRowFromDatabase2(rowName);
            }

        }
        private void RemoveRowFromDatabase(int rowId)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb";
            string deleteQuery = "DELETE FROM Inventory WHERE ID = @RowID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    // Add parameter and its value
                    command.Parameters.AddWithValue("@RowID", rowId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row removed successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void RemoveRowFromDatabase2(string rowName)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\MSAD\\combination\\edit_connection\\LaptopStore.accdb";
            string deleteQuery = "DELETE FROM SalesReport WHERE Name = @RowID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    // Add parameter and its value
                    command.Parameters.AddWithValue("@RowName", rowName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row removed successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
