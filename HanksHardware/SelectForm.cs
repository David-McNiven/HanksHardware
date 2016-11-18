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
        //private Database db = new Database;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            if (Program.productID >= 0)
            {
                NextButton.Enabled = true;
                DisplaySelected();
            }
            else
            {
                NextButton.Enabled = false;
            }
            
        }

        private void SelectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                Program.productID = e.RowIndex;
                SelectDataGridView.Rows[Program.productID].Selected = true;
                DisplaySelected();
                NextButton.Enabled = true;
            }
        }

        private void DisplaySelected()
        {/*
            SelectedTextBox.Text = String.Concat(SelectDataGridView.Rows[Program.productID].Cells["Manufacturer"].Value.ToString(),
                " ", SelectDataGridView.Rows[Program.productID].Cells["Model"].Value.ToString(),
                "Priced at:", SelectDataGridView.Rows[Program.productID].Cells["Price"].Value.ToString());
        */}

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm ProductInfoForm = new ProductInfoForm();
            ProductInfoForm.previousForm = this;
            ProductInfoForm.Show();
        }
    }
}
