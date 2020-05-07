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

        public CreateRoomForm()
        {
            InitializeComponent();
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
            RoomNumber = int.Parse(RoomNumTextBox.Text);
            ChoreSet = ChoreSetTextBox.Text;
            RoomMeetingTime = MeetingTimeTextBox.Text;
            RoomLeaderSSN = int.Parse(RoomLeaderSSNTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
