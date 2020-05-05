using DBFinalProj;
using DBFinalProj.Forms;
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
        }

        private void InitDataWrapper(string user, string pwd)
        {
            dataWrapper = new DataWrapper("localhost", "ccf", 3306, user, pwd);
            dataWrapper.Open();
        }

        // Runs when form is shown
        private void MainMenuForm_Show(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            var loginResult = login.ShowDialog();
            switch (loginResult)
            {
                case DialogResult.OK:
                    InitDataWrapper(login.Username, login.Password);
                    break;
                case DialogResult.Cancel:
                default:
                    Close();
                    break;
            }
        }

        // Runs when form is closing
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataWrapper != null)
            {
                dataWrapper.Close();
            }
        }
    }
}
