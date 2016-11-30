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
    public partial class SelectForm : Form
    {
        private int _selectedRow;
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
                _selectedRow = Program.selectedProduct.productID;
                SelectDataGridView.CurrentCell = SelectDataGridView.Rows[_selectedRow].Cells[0];
                DisplaySelected();
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
                _selectedRow = e.RowIndex;
                SelectDataGridView.Rows[_selectedRow].Selected = true;
                DisplaySelected();
                NextButton.Enabled = true;
            }
        }

        /// <summary>
        /// creates string to display as current selection
        /// </summary>
        private void DisplaySelected()
        {
            SelectedTextBox.Text = String.Concat(SelectDataGridView.Rows[_selectedRow].Cells["manufacturerColumn"].Value.ToString(),
                " ", SelectDataGridView.Rows[_selectedRow].Cells["modelColumn"].Value.ToString(),
                " Priced at: ", SelectDataGridView.Rows[_selectedRow].Cells["costColumn"].FormattedValue.ToString());
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
    }
}
