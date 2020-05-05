using DBFinalProj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenuForm : Form
    {
        DataWrapper dataWrapper;

        public MainMenuForm()
        {
            InitializeComponent();

            //dataWrapper = new DataWrapper();
            //dataWrapper.Open();
        }

        // Runs when form is closed
        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //dataWrapper.Close();
        }
    }
}
