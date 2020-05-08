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
    public partial class CreateSectionForm : Form
    {
        public string SectionName;
        public int RASSN;

        public CreateSectionForm(int[] SSNs)
        {
            InitializeComponent();
            var SSNStrings = SSNs.Select(ssn => ssn.ToString("000000000"));
            RASSNComboBox.Items.AddRange(SSNStrings.ToArray());
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SectionName = NameTextBox.Text;
                RASSN = int.Parse(RASSNComboBox.SelectedItem.ToString());
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Unable to create section. Please ensure that all fields were filled out, and that the section name is unique.");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
