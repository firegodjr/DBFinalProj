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
    public partial class CreateRoomForm : Form
    {
        public int RoomNumber;
        public string ChoreSet;
        public string RoomMeetingTime;
        public int RoomLeaderSSN;
        public string SectionName;

        public CreateRoomForm(int[] residentSSNs, string[] houseSections)
        {
            InitializeComponent();
            RoomLeaderSSNComboBox.Items.AddRange(residentSSNs.Select(ssn => ssn.ToString("000000000")).ToArray());
            HouseSectionComboBox.Items.AddRange(houseSections);
        }

        // Filters keypress events based on whether or not the pressed key was numeric
        private void NumericTextboxKeypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RoomNumber = int.Parse(RoomNumTextBox.Text);
                ChoreSet = ChoreSetTextBox.Text;
                RoomMeetingTime = MeetingTimeTextBox.Text;
                RoomLeaderSSN = int.Parse(RoomLeaderSSNComboBox.SelectedItem.ToString());
                SectionName = HouseSectionComboBox.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Unable to create room. Please ensure that all fields were filled out, and that the room number is unique.");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
