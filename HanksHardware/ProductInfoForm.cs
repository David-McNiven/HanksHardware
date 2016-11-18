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

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            if (Program.productID >= 0)
            {
                // show product details
            }
            else
            {
                OpenFileDialog opener = new OpenFileDialog();
                opener.InitialDirectory = Directory.GetCurrentDirectory();
                opener.Filter = "Text Files (*.txt)|*.txt|All Files|*.*";
                if (opener.ShowDialog() == DialogResult.Cancel)
                {

                } // elseif wrong filetype
                // elseif file == null
                // elseif other constraint
                else
                {
                    try
                    {
                        StreamReader reader = new StreamReader(opener.FileName);
                       // while (reader.Peek() != -1)
                        {
                            PriceTextBox.Text = reader.ReadLine();
                        }
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A Problem Has Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.productID = 0;
            this.Hide();
            previousForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productID = 0;
            this.Hide();
            OrderForm OrderForm = new OrderForm();
            OrderForm.previousForm = this;
            OrderForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel))
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.InitialDirectory = Directory.GetCurrentDirectory();
                saver.ShowDialog();
                // all the same stuff as the opener
                try
                {
                    StreamWriter writer = new StreamWriter("SaveFile.txt");
                    writer.WriteLine(PriceTextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);
                    //writer.WriteLine(TextBox.Text);

                    writer.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
