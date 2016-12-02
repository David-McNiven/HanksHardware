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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for exiting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// event handler to load the selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm SelectForm = new SelectForm();
            SelectForm.Show();
        }

        /// <summary>
        /// event handler to load the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm ProductInfoForm = new ProductInfoForm();
            ProductInfoForm.previousForm = new SelectForm();
            ProductInfoForm.Show();
        }
    }
}
