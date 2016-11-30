using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HanksHardware
{
    public partial class ProductInfoForm : Form
    {
        public SelectForm previousForm;

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// on load checks if a product has been selected and populates the form accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            if (Program.selectedProduct != null)
            {
                PopulateText();
                NextButton.Enabled = true;
            }
            else if (OpenProduct())
            {
                NextButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = false;
            }
        }

        /// <summary>
        ///  event handler for returning to the SelectForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        /// <summary>
        ///  event handler for exiting the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  event handler for moving to OrderForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm OrderForm = new OrderForm();
            OrderForm.previousForm = this;
            OrderForm.Show();
        }

        /// <summary>
        /// event handler for saving current product selection to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NextButton.Enabled && DialogResult.OK == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel))
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.InitialDirectory = Directory.GetCurrentDirectory();
                saver.Filter = "Text Files (*.txt)|*.txt";
                saver.FileName = "Product.txt";
                if (saver.ShowDialog() != DialogResult.Cancel)
                {
                    try
                    {
                        // iterates through every property of the product and saves it to its own line in the text document
                        StreamWriter writer = new StreamWriter(saver.FileName);
                        foreach (var property in Program.selectedProduct.GetType().GetProperties())
                        {
                            writer.WriteLine(property.GetValue(Program.selectedProduct));
                        }
                        writer.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// fill all textboxes with relevant information from product stored in program
        /// </summary>
        private void PopulateText()
        {
            CostTextBox.Text = Program.selectedProduct.cost.ToString("C2");
            ManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            ModelTextBox.Text = Program.selectedProduct.model;
            RAMTypeTextBox.Text = Program.selectedProduct.RAM_type;
            RAMSizeTextBox.Text = Program.selectedProduct.RAM_size;
            DisplayTypeTextBox.Text = Program.selectedProduct.displaytype;
            DisplaySizeTextBox.Text = Program.selectedProduct.screensize;
            DisplayResolutionTextBox.Text = Program.selectedProduct.resolution;
            CPUClassTextBox.Text = Program.selectedProduct.CPU_Class;
            CPUBrandTextBox.Text = Program.selectedProduct.CPU_brand;
            CPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            CPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            CPUNumberTextBox.Text = Program.selectedProduct.CPU_number;
            ConditionTextBox.Text = Program.selectedProduct.condition;
            OSTextBox.Text = Program.selectedProduct.OS;
            PlatformTextBox.Text = Program.selectedProduct.platform;
            HardDriveSizeTextBox.Text = Program.selectedProduct.HDD_size;
            HardDriveSpeedTextBox.Text = Program.selectedProduct.HDD_speed;
            GPUTypeTextBox.Text = Program.selectedProduct.GPU_Type;
            DiskDriveTextBox.Text = Program.selectedProduct.optical_drive;
            AudioTextBox.Text = Program.selectedProduct.Audio_type;
            LANTextBox.Text = Program.selectedProduct.LAN;
            WIFITextBox.Text = Program.selectedProduct.WIFI;
            DimensionsTextBox.Text = String.Concat(Program.selectedProduct.width, 
                " x ", Program.selectedProduct.depth, " x ", Program.selectedProduct.height);
            WeightTextBox.Text = Program.selectedProduct.weight;
            MouseTextBox.Text = Program.selectedProduct.moust_type;
            PowerTextBox.Text = Program.selectedProduct.power;
            WebCamTextBox.Text = Program.selectedProduct.webcam;
        }

        /// <summary>
        /// event handler for loading a new product save file and updating next button accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenProduct())
            {
                PopulateText();
                NextButton.Enabled = true;
            }
            else if (Program.selectedProduct != null)
            {
                NextButton.Enabled = false;
            }
        }

        /// <summary>
        /// attempts to load product from a save file and returns true if successful
        /// </summary>
        /// <returns></returns>
        private Boolean OpenProduct()
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.InitialDirectory = Directory.GetCurrentDirectory();
            opener.Filter = "Text Files (*.txt)|*.txt";
            if (opener.ShowDialog() == DialogResult.Cancel)
            {
                return false;
            }
            else
            {
                try
                {
                    StreamReader reader = new StreamReader(opener.FileName);
                    Program.selectedProduct = new product();
                    foreach (var property in Program.selectedProduct.GetType().GetProperties())
                    {
                        if (property.Name.Equals("productID"))
                        {
                            property.SetValue(Program.selectedProduct, Int32.Parse(reader.ReadLine()));
                        }
                        else if (property.Name.Equals("cost"))
                        {
                            property.SetValue(Program.selectedProduct, Decimal.Parse(reader.ReadLine()));
                        }
                        else
                        {
                            property.SetValue(Program.selectedProduct, reader.ReadLine());
                        }
                        
                    }
                    reader.Close();
                    PopulateText();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("A Problem Has Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
