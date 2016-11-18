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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm SelectForm = new SelectForm();
            SelectForm.Show();
        }

        private void SavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm ProductInfoForm = new ProductInfoForm();
            ProductInfoForm.previousForm = new SelectForm();
            ProductInfoForm.Show();
        }
    }
}
