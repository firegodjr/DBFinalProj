using DBFinalProj;
using DBFinalProj.Forms;
using DBFinalProj.IO;
using DBFinalProj.Data;
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
    /// <summary>
    /// The main form of the program, orchestrates all functionality through the use of UI events.
    /// 
    /// Calls DataWrapper.cs, along with other forms as needed.
    /// </summary>
    public partial class MainMenuForm : Form
    {
        DataWrapper dataWrapper;
        Database database;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void InitUI()
        {
            var SSNs = Resident.GetAllResidents(dataWrapper);
            var StringSSNs = SSNs.Select(ssn => ssn.ToString("000000000"));
            ResidentListBox.Items.AddRange(StringSSNs.ToArray());
        }

        private void PickDatabase()
        {
            var form = new PickDatabaseForm();
            var result = form.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                Close();
            }
            else
            {
                database = form.SelectedDatabase;
            }
        }

        private void InitDataWrapper(string user, string pwd)
        {
            dataWrapper = new DataWrapper(database, user, pwd);
            dataWrapper.Open();
        }

        /// <summary>
        /// Prompt for credentials until the user manages to login to a database.
        /// </summary>
        private void TryLogin()
        {
            bool cont = true;
            while (cont)
            {
                cont = false;

                try
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
                            PickDatabase();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    var result = MessageBox.Show(this, $"Error trying to connect to database: {ex.Message}", "Database Connection Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Cancel)
                    {
                        PickDatabase();
                    }
                    else
                    {
                        cont = true;
                    }
                }
            }
        }

        // Runs when form is shown
        private void MainMenuForm_Show(object sender, EventArgs e)
        {
            PickDatabase();
            TryLogin();
            InitUI();
        }

        // Runs when form is closing
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataWrapper != null)
            {
                dataWrapper.Close();
            }
        }

        private void NumericTextboxKeypress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
