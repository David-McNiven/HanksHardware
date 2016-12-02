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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            StartForm StartForm = new StartForm();
            StartForm.Show();
            SplashTimer.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
