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
            var stringSSNs = Resident.GetAllResidents(dataWrapper).Select(ssn => ssn.ToString("000000000"));
            var stringRoomNums = Room.GetAllRooms(dataWrapper).Select(rn => rn.ToString());
            var stringSectionNames = Section.GetAllSections(dataWrapper);

            ResidentListBox.Items.Clear();
            RoomListBox.Items.Clear();
            SectionListBox.Items.Clear();

            ResidentListBox.Items.AddRange(stringSSNs.ToArray());
            RoomListBox.Items.AddRange(stringRoomNums.ToArray());
            SectionListBox.Items.AddRange(stringSectionNames);
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

        // Filters keypress events based on whether or not the pressed key was numeric
        private void NumericTextboxKeypress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ResidentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ResidentListBox.SelectedItem != null)
            {
                int ssn;
                bool success = int.TryParse(ResidentListBox.SelectedItem.ToString(), out ssn);
                if(success)
                {
                    Dictionary<string, object> resident = Resident.GetResident(ssn, dataWrapper);
                    UpdateResidentUI(resident);
                }
            }
        }

        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomListBox.SelectedItem != null)
            {
                int roomNum;
                bool success = int.TryParse(RoomListBox.SelectedItem.ToString(), out roomNum);
                if (success)
                {
                    Dictionary<string, object> room = Room.GetRoom(roomNum, dataWrapper);
                    UpdateRoomUI(room);
                }
            }
        }

        private void SectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionListBox.SelectedItem != null)
            {
                string sectionName = SectionListBox.SelectedItem.ToString();
                Dictionary<string, object> section = Section.GetSection(sectionName, dataWrapper);
                UpdateSectionUI(section);
            }
        }

        private void UpdateResidentUI(Dictionary<string, object> residentAttribs)
        {
            ResidentSSNTextBox.Text                     = residentAttribs["SSN"].ToString();
            ResidentPhoneNumTextBox.Text                = residentAttribs["PhoneN"].ToString();
            ResidentNameTextBox.Text                    = residentAttribs["Name"].ToString();
            ResidentOutstandingBalanceNUD.Value         = int.Parse(residentAttribs["OutstandingBalance"].ToString());
            ResidentChoresMissedNUD.Value               = int.Parse(residentAttribs["MissedChores"].ToString());
            ResidentSmallGroupTextBox.Text              = residentAttribs["SmallGroup"].ToString();
            ResidentNextSemesterTextBox.Text            = residentAttribs["NextSemesterPlan"].ToString();
            ResidentGraduationDatetimePicker.Text       = residentAttribs["GradDate"].ToString();
            ResidentContractStartDatetimePicker.Text    = residentAttribs["ContractStartDate"].ToString();
            ResidentContractEndDatetimePicker.Text      = residentAttribs["ContractEndDate"].ToString();
            ResidentMealPlanTextBox.Text                = residentAttribs["ContractMealPlan"].ToString();
            ResidentIsKPCheckbox.Checked                = (bool)residentAttribs["KP"];
            ResidentIsFMCheckbox.Checked                = (bool)residentAttribs["FM"];

            ResidentAssignedRoomNumTextBox.Text = Resident.GetAssignedRoom((int)residentAttribs["SSN"], dataWrapper).ToString();
        }

        private void UpdateRoomUI(Dictionary<string, object> roomAttribs)
        {
            RoomNumberNUD.Value = int.Parse(roomAttribs["RoomNumber"].ToString());
            RoomChoreSetTextBox.Text = roomAttribs["ChoreSet"].ToString();
            RoomWorkOrdersTextBox.Text = roomAttribs["WorkOrders"].ToString();
            RoomMeetingTimeTextBox.Text = roomAttribs["RoomMeetingTime"].ToString();
            RoomLeaderSSNTextBox.Text = (int.Parse(roomAttribs["RLSSN"].ToString())).ToString("000000000");

            RoomSectionTextBox.Text = Room.GetSection((int)RoomNumberNUD.Value, dataWrapper);
        }

        private void UpdateSectionUI(Dictionary<string, object> sectionAttribs)
        {
            SectionNameTextBox.Text = sectionAttribs["Name"].ToString();
            SectionPointsNUD.Value = int.Parse(sectionAttribs["Points"].ToString());
            SectionRASSNNUD.Value = int.Parse(sectionAttribs["RASSN"].ToString());
        }
    }
}
