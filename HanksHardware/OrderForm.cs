using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanksHardware
{
    public partial class OrderForm : Form
    {
        public ProductInfoForm previousForm;

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// on load populates all fields based on the selected product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            ProductCostTextBox.Text = Program.selectedProduct.cost.ToString("C2");
            SalestaxTextBox.Text = (Program.selectedProduct.cost * (Decimal)0.13).ToString("C2");
            GrandTotalTextBox.Text = (Program.selectedProduct.cost * (Decimal)1.13).ToString("C2");
            ManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            ModelTextBox.Text = Program.selectedProduct.model;
            RAMTextBox.Text = String.Concat(Program.selectedProduct.RAM_size, " ", Program.selectedProduct.RAM_type);
            DisplayTextBox.Text = String.Concat(Program.selectedProduct.screensize, " ", Program.selectedProduct.displaytype, " ", Program.selectedProduct.resolution);
            CPUTextBox.Text = String.Concat(Program.selectedProduct.CPU_Class, " ", Program.selectedProduct.CPU_brand, " ", Program.selectedProduct.CPU_type, " ", Program.selectedProduct.CPU_speed, " ", Program.selectedProduct.CPU_number);
            ConditionTextBox.Text = Program.selectedProduct.condition;
            OSTextBox.Text = Program.selectedProduct.OS;
            PlatformTextBox.Text = Program.selectedProduct.platform;
            HardDriveTextBox.Text = String.Concat(Program.selectedProduct.HDD_size, " @", Program.selectedProduct.HDD_speed);
            GPUTextBox.Text = Program.selectedProduct.GPU_Type;
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
        /// event handler for returning to the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        /// <summary>
        /// event handler for exiting the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// event handler for finalizing order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Hanks Hardware!" + Environment.NewLine + 
                "Your order will take 7-10 business days to process." + Environment.NewLine);
            Application.Exit();
        }

        /// <summary>
        /// event handler for showing about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderAboutBox OrderAboutBox = new OrderAboutBox();
            OrderAboutBox.ShowDialog();
        }

        /// <summary>
        /// event handler for showing a message box saying that the order is printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is now printing.", "Printing");
        }
    }
}
