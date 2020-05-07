using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFinalProj.Forms
{
    public partial class CreateResidentForm : Form
    {
        public int SSN;
        public string ResidentName;
        public string StartDate;
        public string EndDate;

        public CreateResidentForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SSN = int.Parse(SSNTextBox.Text);
                ResidentName = ResidentNameTextBox.Text;
                StartDate = DataWrapper.GetSqlDateString(ContractStartDatetime.Value);
                EndDate = DataWrapper.GetSqlDateString(ContractEndDatetime.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Unable to create resident. Please ensure that all fields were filled out, and that the resident's SSN is unique.");
            }
        }

        // Filters keypress events based on whether or not the pressed key was numeric
        private void NumericTextboxKeypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
