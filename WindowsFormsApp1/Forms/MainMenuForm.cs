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

            if (ResidentListBox.Items.Count > 0)
                ResidentListBox.SelectedIndex = 0;
            if (RoomListBox.Items.Count > 0)
                RoomListBox.SelectedIndex = 0;
            if (SectionListBox.Items.Count > 0)
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

            if(dataWrapper != null)
            {
                InitUI();
            }
            else
            {
                Close();
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

        private T ToNonNull<T>(object obj)
        {
            if (obj.GetType() == typeof(DBNull) || obj == null)
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
            ResidentSSNTextBox.Text                     = ToNonNull<int>(dict["SSN"]).ToString("000000000");
            ResidentPhoneNumTextBox.Text                = ToNonNull<string>(dict["PhoneN"]);
            ResidentNameTextBox.Text                    = ToNonNull<string>(dict["Name"]);
            ResidentOutstandingBalanceNUD.Value         = ToNonNull<int>(dict["OutstandingBalance"]);
            ResidentChoresMissedNUD.Value               = ToNonNull<int>(dict["MissedChores"]);
            ResidentSmallGroupTextBox.Text              = ToNonNull<string>(dict["SmallGroup"]);
            ResidentNextSemesterTextBox.Text            = ToNonNull<string>(dict["NextSemesterPlan"]);
            ResidentGraduationDatetimePicker.Value      = ToNonNull<DateTime>(dict["GradDate"]);
            ResidentContractStartDatetimePicker.Value   = ToNonNull<DateTime>(dict["ContractStartDate"]);
            ResidentContractEndDatetimePicker.Value     = ToNonNull<DateTime>(dict["ContractEndDate"]);
            ResidentMealPlanTextBox.Text                = ToNonNull<string>(dict["ContractMealPlan"]);
            ResidentIsKPCheckbox.Checked                = ToNonNull<bool>(dict["KP"]);
            ResidentIsFMCheckbox.Checked                = ToNonNull<bool>(dict["FM"]);

            var rooms = Room.GetAllRooms(dataWrapper).Select(num => num.ToString());
            ResidentAssignedRoomComboBox.Items.Clear();
            ResidentAssignedRoomComboBox.Items.Add("N/A");
            ResidentAssignedRoomComboBox.Items.AddRange(rooms.ToArray());
            var assignedRoom = Resident.GetAssignedRoom((int)dict["SSN"], dataWrapper).ToString();
            if (assignedRoom == "0") assignedRoom = "N/A";
            ResidentAssignedRoomComboBox.SelectedItem = assignedRoom;
        }

        private void UpdateRoomUI(Dictionary<string, object> dict)
        {
            RoomLeaderSSNComboBox.Items.Clear();
            RoomLeaderSSNComboBox.Items.Add("N/A");
            RoomSectionComboBox.Items.Clear();

            var SSNStrings = Resident.GetAllResidents(dataWrapper).Select(ssn => ssn.ToString("000000000"));
            RoomLeaderSSNComboBox.Items.AddRange(SSNStrings.ToArray());
            RoomSectionComboBox.Items.AddRange(Section.GetAllSections(dataWrapper));

            RoomNumberTextBox.Text              = ToNonNull<int>(dict["RoomNumber"]).ToString();
            RoomChoreSetTextBox.Text            = ToNonNull<string>(dict["ChoreSet"]);
            RoomWorkOrdersTextBox.Text          = ToNonNull<string>(dict["WorkOrders"]);
            RoomMeetingTimeTextBox.Text         = ToNonNull<string>(dict["RoomMeetingTime"]);   
            RoomLeaderSSNComboBox.SelectedItem  = ToNonNull<int>(dict["RLSSN"]).ToString("000000000");

            RoomSectionComboBox.SelectedItem = Room.GetSection(int.Parse(RoomNumberTextBox.Text), dataWrapper);
        }

        private void UpdateSectionUI(Dictionary<string, object> dict)
        {
            RASSNComboBox.Items.Clear();
            RASSNComboBox.Items.Add("N/A");

            var SSNStrings = Resident.GetAllResidents(dataWrapper).Select(ssn => ssn.ToString("000000000"));
            RASSNComboBox.Items.AddRange(SSNStrings.ToArray());

            SectionNameTextBox.Text = ToNonNull<string>(dict["Name"]);
            SectionPointsNUD.Value  = ToNonNull<int>(dict["Points"]);
            RASSNComboBox.SelectedItem   = ToNonNull<int>(dict["RASSN"]).ToString("000000000");
        }

        private void AddResidentBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateResidentForm();
            var result = form.ShowDialog();
            var ssn = form.SSN;
            if (result == DialogResult.OK)
            {
                try
                {
                    Resident.AddResident(ssn, form.ResidentName, form.StartDate, form.EndDate, dataWrapper);
                }
                    catch (Exception ex)
                {
                    MessageBox.Show("An error occurred when adding a resident:\n\n" + ex.Message);
                }
                InitUI();
                ResidentListBox.SelectedItem = ssn.ToString();
            }
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateRoomForm(Resident.GetAllResidents(dataWrapper), Section.GetAllSections(dataWrapper));
            var result = form.ShowDialog();
            var roomNum = form.RoomNumber;
            if (result == DialogResult.OK)
            {
                try
                {
                    Room.AddRoom(roomNum, form.ChoreSet, form.RoomMeetingTime, form.RoomLeaderSSN, form.SectionName, dataWrapper);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred when adding a room:\n\n" + ex.Message);
                }
                InitUI();
                RoomListBox.SelectedItem = roomNum.ToString();
            }
        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            var form = new CreateSectionForm(Resident.GetAllResidents(dataWrapper));
            var result = form.ShowDialog();
            var name = form.SectionName;
            if (result == DialogResult.OK)
            {
                try
                {
                    Section.AddSection(name, form.RASSN, dataWrapper);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred when adding a section:\n\n" + ex.Message);
                }
                InitUI();
                SectionListBox.SelectedItem = name;
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

        private void RoomDeleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete this room?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Room.DeleteRoom(int.Parse(RoomListBox.SelectedItem.ToString()), dataWrapper);
                InitUI();
            }
        }

        private void SectionDeleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete this section?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Section.DeleteSection(SectionListBox.SelectedItem.ToString(), dataWrapper);
                InitUI();
            }
        }

        private void ResidentSaveBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();

            if (ResidentPhoneNumTextBox.Text != "")
            {
                values.Add("PhoneN", Int64.Parse(ResidentPhoneNumTextBox.Text));
            }
            values.Add("Name", ResidentNameTextBox.Text);
            values.Add("OutstandingBalance", ResidentOutstandingBalanceNUD.Value);
            values.Add("MissedChores", ResidentChoresMissedNUD.Value);
            values.Add("SmallGroup", ResidentSmallGroupTextBox.Text);
            values.Add("NextSemesterPlan", ResidentNextSemesterTextBox.Text);
            values.Add("GradDate", DataWrapper.GetSqlDateString(ResidentGraduationDatetimePicker.Value));
            values.Add("ContractStartDate", DataWrapper.GetSqlDateString(ResidentContractStartDatetimePicker.Value));
            values.Add("ContractEndDate", DataWrapper.GetSqlDateString(ResidentContractEndDatetimePicker.Value));
            values.Add("ContractMealPlan", ResidentMealPlanTextBox.Text);
            values.Add("KP", ResidentIsKPCheckbox.Checked);
            values.Add("FM", ResidentIsFMCheckbox.Checked);

            Resident.UpdateResident(int.Parse(ResidentListBox.SelectedItem.ToString()), values, dataWrapper);
            if(ResidentAssignedRoomComboBox.SelectedItem.ToString() != "N/A")
            {
                Resident.UpdateAssignedRoom(int.Parse(ResidentListBox.SelectedItem.ToString()), int.Parse(ResidentAssignedRoomComboBox.SelectedItem.ToString()), dataWrapper);
            }
        }

        private void RoomSaveBtn_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, object>();
            var roomNum = int.Parse(RoomListBox.SelectedItem.ToString());

            values.Add("ChoreSet", RoomChoreSetTextBox.Text);
            values.Add("WorkOrders", RoomWorkOrdersTextBox.Text);
            values.Add("RoomMeetingTime", RoomMeetingTimeTextBox.Text);
            values.Add("RLSSN", int.Parse(RoomLeaderSSNComboBox.SelectedItem.ToString()));

            Room.UpdateRoom(roomNum, values, dataWrapper);

            if(RoomSectionComboBox.SelectedItem.ToString() != "N/A")
            {
                var sectionName = RoomSectionComboBox.SelectedItem.ToString();
                Room.UpdateBelongingSection(roomNum, sectionName, dataWrapper);
            }
        }

        private void SectionSaveBtn_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, object>();
            var sectionName = SectionListBox.SelectedItem.ToString();

            values.Add("Points", SectionPointsNUD.Value);
            if(RASSNComboBox.SelectedItem.ToString() != "N/A")
            {
                values.Add("RASSN", int.Parse(RASSNComboBox.SelectedItem.ToString()));
            }

            Section.UpdateSection(sectionName, values, dataWrapper);
        }
    }
}
