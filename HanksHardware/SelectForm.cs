using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Hanks Hardware	
/// Created By David McNiven
/// Student	# 200330143
/// Created On December 1st, 2016
/// A mock computer ordering application using a database and plaintext save files
/// </summary>
namespace HanksHardware
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// on load checks if a previous selection was made and if so defaults to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.cOMP1004DataSet.products);

            if (Program.selectedProduct != null)
            {
                NextButton.Enabled = true;
                findRow();
            }
            else
            {
                NextButton.Enabled = false;
                SelectDataGridView.ClearSelection();
            }
        }

        /// <summary>
        /// event handler that ensures entire row is selected when clicked and displays selection accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DisplaySelected();
                NextButton.Enabled = true;
            }
        }

        /// <summary>
        /// creates string to display as current selection
        /// </summary>
        private void DisplaySelected()
        {
            SelectedTextBox.Text = String.Concat(SelectDataGridView.CurrentRow.Cells["manufacturerColumn"].Value.ToString(),
                " ", SelectDataGridView.CurrentRow.Cells["modelColumn"].Value.ToString(),
                " Priced at: ", SelectDataGridView.CurrentRow.Cells["costColumn"].FormattedValue.ToString());
        }

        /// <summary>
        /// event handler for exiting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// event handler that sets program wide variable to the selected product when moving to other forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.selectedProduct = new product();
            foreach (var property in Program.selectedProduct.GetType().GetProperties())
            {
                if (property.Name.Equals("productID"))
                {
                    property.SetValue(Program.selectedProduct, Int32.Parse(SelectDataGridView.CurrentRow.Cells[property.Name + "Column"].Value.ToString()));
                }
                else if (property.Name.Equals("cost"))
                {
                    property.SetValue(Program.selectedProduct, Decimal.Parse(SelectDataGridView.CurrentRow.Cells[property.Name + "Column"].Value.ToString()));
                }
                else
                {
                    property.SetValue(Program.selectedProduct, SelectDataGridView.CurrentRow.Cells[property.Name + "Column"].Value.ToString());
                }

            }
            this.Hide();
            ProductInfoForm ProductInfoForm = new ProductInfoForm();
            ProductInfoForm.previousForm = this;
            ProductInfoForm.Show();
        }

        /// <summary>
        /// event handler for returning to this form from the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Activated(object sender, EventArgs e)
        {
            if (Program.selectedProduct != null)
            {
                NextButton.Enabled = true;
                findRow();
            }
            else
            {
                NextButton.Enabled = false;
                SelectDataGridView.ClearSelection();
            }
        }

        /// <summary>
        /// finds the row of the previously selected product
        /// </summary>
        private void findRow()
        {
            SelectDataGridView.ClearSelection();
            foreach (DataGridViewRow row in SelectDataGridView.Rows)
            {
                if (row.Cells["productIDColumn"].Value.ToString().Equals(Program.selectedProduct.productID.ToString()))
                {
                    row.Cells["costColumn"].Selected = true;
                }
            }
            DisplaySelected();
        }
    }
}
