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
    /// Calls DataWrapper.cs for database access, Resident.cs Room.cs and Section.cs for help with retrieving entity-specific values, and calls other forms as needed.
    /// </summary>
    public partial class MainMenuForm : Form
    {
        DataWrapper dataWrapper;
        Database database;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves latest database data and refreshes all UI elements
        /// </summary>
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

            ResidentListBox.SelectedIndex = 0;
            RoomListBox.SelectedIndex = 0;
            SectionListBox.SelectedIndex = 0;
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

        private T ToValue<T>(object obj)
        {
            if (obj.GetType() == typeof(DBNull))
            {
                if (typeof(T) == typeof(DateTime))
                {
                    return (T)Convert.ChangeType(DateTime.Now, typeof(T));
                }
                else if (typeof(T) == typeof(string))
                {
                    return (T)Convert.ChangeType("", typeof(T));
                }
                else if(typeof(T) == typeof(bool))
                {
                    return (T)Convert.ChangeType(false, typeof(T));
                }
                else
                {
                    return (T)Convert.ChangeType(0, typeof(T));
                }
            }
            else return (T)Convert.ChangeType(obj, typeof(T));
        }

        private void UpdateResidentUI(Dictionary<string, object> dict)
        {
            ResidentSSNTextBox.Text                     = ToValue<int>(dict["SSN"]).ToString("000000000");
            ResidentPhoneNumTextBox.Text                = ToValue<string>(dict["PhoneN"]);
            ResidentNameTextBox.Text                    = ToValue<string>(dict["Name"]);
            ResidentOutstandingBalanceNUD.Value         = ToValue<int>(dict["OutstandingBalance"]);
            ResidentChoresMissedNUD.Value               = ToValue<int>(dict["MissedChores"]);
            ResidentSmallGroupTextBox.Text              = ToValue<string>(dict["SmallGroup"]);
            ResidentNextSemesterTextBox.Text            = ToValue<string>(dict["NextSemesterPlan"]);
            ResidentGraduationDatetimePicker.Value      = ToValue<DateTime>(dict["GradDate"]);
            ResidentContractStartDatetimePicker.Value   = ToValue<DateTime>(dict["ContractStartDate"]);
            ResidentContractEndDatetimePicker.Value     = ToValue<DateTime>(dict["ContractEndDate"]);
            ResidentMealPlanTextBox.Text                = ToValue<string>(dict["ContractMealPlan"]);
            ResidentIsKPCheckbox.Checked                = ToValue<bool>(dict["KP"]);
            ResidentIsFMCheckbox.Checked                = ToValue<bool>(dict["FM"]);

            ResidentAssignedRoomNumTextBox.Text = Resident.GetAssignedRoom((int)dict["SSN"], dataWrapper).ToString();
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

        private void AddResidentBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateResidentForm();
            var result = form.ShowDialog();
            var ssn = form.SSN;
            if (result == DialogResult.OK)
            {
                Resident.AddResident(ssn, form.ResidentName, form.StartDate, form.EndDate, dataWrapper);
                InitUI();
                ResidentListBox.SelectedItem = ssn.ToString();
            }
        }

        private void ResidentDeleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete this resident?", "Are you sure?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Resident.DeleteResident(int.Parse(ResidentListBox.SelectedItem.ToString()), dataWrapper);
                InitUI();
            }
        }
    }
}
