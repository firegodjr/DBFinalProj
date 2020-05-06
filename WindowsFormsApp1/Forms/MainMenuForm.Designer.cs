namespace WindowsFormsApp1
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassSelectorTabCtrl = new System.Windows.Forms.TabControl();
            this.tabResident = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResidentIsFMCheckbox = new System.Windows.Forms.CheckBox();
            this.ResidentContractEndDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.ResidentIsKPCheckbox = new System.Windows.Forms.CheckBox();
            this.ResidentSmallGroupTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ResidentOutstandingBalanceNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ResidentChoresMissedNUD = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResidentGraduationDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResidentContractStartDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ResidentPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResidentNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResidentSSNTextBox = new System.Windows.Forms.TextBox();
            this.ResidentListBox = new System.Windows.Forms.ListBox();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RoomLeaderSSNTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.RoomNumberNUD = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RoomWorkOrdersTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RoomChoreSetTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.tabSection = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SectionRASSNNUD = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SectionNameTextBox = new System.Windows.Forms.TextBox();
            this.SectionPointsNUD = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.SectionListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResidentMealPlanTextBox = new System.Windows.Forms.TextBox();
            this.ResidentAssignedRoomNumTextBox = new System.Windows.Forms.TextBox();
            this.ResidentNextSemesterTextBox = new System.Windows.Forms.TextBox();
            this.RoomMeetingTimeTextBox = new System.Windows.Forms.TextBox();
            this.RoomSectionTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ClassSelectorTabCtrl.SuspendLayout();
            this.tabResident.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentOutstandingBalanceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentChoresMissedNUD)).BeginInit();
            this.tabRoom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumberNUD)).BeginInit();
            this.tabSection.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionRASSNNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionPointsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassSelectorTabCtrl
            // 
            this.ClassSelectorTabCtrl.Controls.Add(this.tabResident);
            this.ClassSelectorTabCtrl.Controls.Add(this.tabRoom);
            this.ClassSelectorTabCtrl.Controls.Add(this.tabSection);
            this.ClassSelectorTabCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSelectorTabCtrl.HotTrack = true;
            this.ClassSelectorTabCtrl.Location = new System.Drawing.Point(13, 42);
            this.ClassSelectorTabCtrl.Multiline = true;
            this.ClassSelectorTabCtrl.Name = "ClassSelectorTabCtrl";
            this.ClassSelectorTabCtrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClassSelectorTabCtrl.SelectedIndex = 0;
            this.ClassSelectorTabCtrl.Size = new System.Drawing.Size(890, 601);
            this.ClassSelectorTabCtrl.TabIndex = 0;
            // 
            // tabResident
            // 
            this.tabResident.BackColor = System.Drawing.Color.Transparent;
            this.tabResident.Controls.Add(this.groupBox1);
            this.tabResident.Controls.Add(this.ResidentListBox);
            this.tabResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResident.Location = new System.Drawing.Point(4, 25);
            this.tabResident.Name = "tabResident";
            this.tabResident.Padding = new System.Windows.Forms.Padding(3);
            this.tabResident.Size = new System.Drawing.Size(882, 572);
            this.tabResident.TabIndex = 0;
            this.tabResident.Text = "Resident";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResidentNextSemesterTextBox);
            this.groupBox1.Controls.Add(this.ResidentAssignedRoomNumTextBox);
            this.groupBox1.Controls.Add(this.ResidentMealPlanTextBox);
            this.groupBox1.Controls.Add(this.ResidentIsFMCheckbox);
            this.groupBox1.Controls.Add(this.ResidentContractEndDatetimePicker);
            this.groupBox1.Controls.Add(this.ResidentIsKPCheckbox);
            this.groupBox1.Controls.Add(this.ResidentSmallGroupTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ResidentOutstandingBalanceNUD);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ResidentChoresMissedNUD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ResidentGraduationDatetimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ResidentContractStartDatetimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ResidentPhoneNumTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ResidentNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ResidentSSNTextBox);
            this.groupBox1.Location = new System.Drawing.Point(225, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 559);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident Attributes";
            // 
            // ResidentIsFMCheckbox
            // 
            this.ResidentIsFMCheckbox.AutoSize = true;
            this.ResidentIsFMCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentIsFMCheckbox.Location = new System.Drawing.Point(18, 359);
            this.ResidentIsFMCheckbox.Name = "ResidentIsFMCheckbox";
            this.ResidentIsFMCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResidentIsFMCheckbox.Size = new System.Drawing.Size(196, 20);
            this.ResidentIsFMCheckbox.TabIndex = 28;
            this.ResidentIsFMCheckbox.Text = "Resident is Facility Manager";
            this.ResidentIsFMCheckbox.UseVisualStyleBackColor = true;
            // 
            // ResidentContractEndDatetimePicker
            // 
            this.ResidentContractEndDatetimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentContractEndDatetimePicker.Location = new System.Drawing.Point(333, 85);
            this.ResidentContractEndDatetimePicker.Name = "ResidentContractEndDatetimePicker";
            this.ResidentContractEndDatetimePicker.Size = new System.Drawing.Size(222, 22);
            this.ResidentContractEndDatetimePicker.TabIndex = 27;
            // 
            // ResidentIsKPCheckbox
            // 
            this.ResidentIsKPCheckbox.AutoSize = true;
            this.ResidentIsKPCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentIsKPCheckbox.Location = new System.Drawing.Point(18, 333);
            this.ResidentIsKPCheckbox.Name = "ResidentIsKPCheckbox";
            this.ResidentIsKPCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResidentIsKPCheckbox.Size = new System.Drawing.Size(114, 20);
            this.ResidentIsKPCheckbox.TabIndex = 25;
            this.ResidentIsKPCheckbox.Text = "Resident is KP";
            this.ResidentIsKPCheckbox.UseVisualStyleBackColor = true;
            // 
            // ResidentSmallGroupTextBox
            // 
            this.ResidentSmallGroupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentSmallGroupTextBox.Location = new System.Drawing.Point(106, 305);
            this.ResidentSmallGroupTextBox.Name = "ResidentSmallGroupTextBox";
            this.ResidentSmallGroupTextBox.Size = new System.Drawing.Size(133, 22);
            this.ResidentSmallGroupTextBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Small Group:";
            // 
            // ResidentOutstandingBalanceNUD
            // 
            this.ResidentOutstandingBalanceNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentOutstandingBalanceNUD.Location = new System.Drawing.Point(156, 278);
            this.ResidentOutstandingBalanceNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ResidentOutstandingBalanceNUD.Name = "ResidentOutstandingBalanceNUD";
            this.ResidentOutstandingBalanceNUD.Size = new System.Drawing.Size(55, 22);
            this.ResidentOutstandingBalanceNUD.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Outstanding Balance:";
            // 
            // ResidentChoresMissedNUD
            // 
            this.ResidentChoresMissedNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentChoresMissedNUD.Location = new System.Drawing.Point(122, 251);
            this.ResidentChoresMissedNUD.Name = "ResidentChoresMissedNUD";
            this.ResidentChoresMissedNUD.Size = new System.Drawing.Size(55, 22);
            this.ResidentChoresMissedNUD.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Chores Missed:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Plan for Next Semester:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Graduation Date:";
            // 
            // ResidentGraduationDatetimePicker
            // 
            this.ResidentGraduationDatetimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentGraduationDatetimePicker.Location = new System.Drawing.Point(130, 183);
            this.ResidentGraduationDatetimePicker.Name = "ResidentGraduationDatetimePicker";
            this.ResidentGraduationDatetimePicker.Size = new System.Drawing.Size(226, 22);
            this.ResidentGraduationDatetimePicker.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Assigned Room:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Meal Plan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contract:";
            // 
            // ResidentContractStartDatetimePicker
            // 
            this.ResidentContractStartDatetimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentContractStartDatetimePicker.Location = new System.Drawing.Point(81, 84);
            this.ResidentContractStartDatetimePicker.Name = "ResidentContractStartDatetimePicker";
            this.ResidentContractStartDatetimePicker.Size = new System.Drawing.Size(222, 22);
            this.ResidentContractStartDatetimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone#:";
            // 
            // ResidentPhoneNumTextBox
            // 
            this.ResidentPhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentPhoneNumTextBox.Location = new System.Drawing.Point(74, 58);
            this.ResidentPhoneNumTextBox.MaxLength = 9;
            this.ResidentPhoneNumTextBox.Name = "ResidentPhoneNumTextBox";
            this.ResidentPhoneNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.ResidentPhoneNumTextBox.TabIndex = 4;
            this.ResidentPhoneNumTextBox.Tag = "";
            this.ResidentPhoneNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextboxKeypress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // ResidentNameTextBox
            // 
            this.ResidentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentNameTextBox.Location = new System.Drawing.Point(241, 31);
            this.ResidentNameTextBox.Name = "ResidentNameTextBox";
            this.ResidentNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.ResidentNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSN:";
            // 
            // ResidentSSNTextBox
            // 
            this.ResidentSSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentSSNTextBox.Location = new System.Drawing.Point(56, 31);
            this.ResidentSSNTextBox.MaxLength = 9;
            this.ResidentSSNTextBox.Name = "ResidentSSNTextBox";
            this.ResidentSSNTextBox.Size = new System.Drawing.Size(100, 22);
            this.ResidentSSNTextBox.TabIndex = 0;
            this.ResidentSSNTextBox.Tag = "";
            this.ResidentSSNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextboxKeypress);
            // 
            // ResidentListBox
            // 
            this.ResidentListBox.FormattingEnabled = true;
            this.ResidentListBox.ItemHeight = 15;
            this.ResidentListBox.Location = new System.Drawing.Point(7, 7);
            this.ResidentListBox.Name = "ResidentListBox";
            this.ResidentListBox.Size = new System.Drawing.Size(212, 559);
            this.ResidentListBox.TabIndex = 2;
            this.ResidentListBox.SelectedIndexChanged += new System.EventHandler(this.ResidentListBox_SelectedIndexChanged);
            // 
            // tabRoom
            // 
            this.tabRoom.BackColor = System.Drawing.Color.Transparent;
            this.tabRoom.Controls.Add(this.groupBox2);
            this.tabRoom.Controls.Add(this.RoomListBox);
            this.tabRoom.Location = new System.Drawing.Point(4, 25);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(882, 572);
            this.tabRoom.TabIndex = 1;
            this.tabRoom.Text = "Room";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RoomSectionTextBox);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.RoomMeetingTimeTextBox);
            this.groupBox2.Controls.Add(this.RoomLeaderSSNTextBox);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.RoomNumberNUD);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.RoomWorkOrdersTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.RoomChoreSetTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(225, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 559);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Attributes";
            // 
            // RoomLeaderSSNTextBox
            // 
            this.RoomLeaderSSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLeaderSSNTextBox.Location = new System.Drawing.Point(155, 93);
            this.RoomLeaderSSNTextBox.MaxLength = 10;
            this.RoomLeaderSSNTextBox.Name = "RoomLeaderSSNTextBox";
            this.RoomLeaderSSNTextBox.Size = new System.Drawing.Size(212, 22);
            this.RoomLeaderSSNTextBox.TabIndex = 14;
            this.RoomLeaderSSNTextBox.Tag = "";
            this.RoomLeaderSSNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextboxKeypress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Room Leader SSN:";
            // 
            // RoomNumberNUD
            // 
            this.RoomNumberNUD.Location = new System.Drawing.Point(121, 32);
            this.RoomNumberNUD.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.RoomNumberNUD.Name = "RoomNumberNUD";
            this.RoomNumberNUD.Size = new System.Drawing.Size(120, 21);
            this.RoomNumberNUD.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Room Meeting Time:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "Work Orders:";
            // 
            // RoomWorkOrdersTextBox
            // 
            this.RoomWorkOrdersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomWorkOrdersTextBox.Location = new System.Drawing.Point(121, 191);
            this.RoomWorkOrdersTextBox.MaxLength = 100;
            this.RoomWorkOrdersTextBox.Multiline = true;
            this.RoomWorkOrdersTextBox.Name = "RoomWorkOrdersTextBox";
            this.RoomWorkOrdersTextBox.Size = new System.Drawing.Size(514, 350);
            this.RoomWorkOrdersTextBox.TabIndex = 6;
            this.RoomWorkOrdersTextBox.Tag = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(297, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Chore Set:";
            // 
            // RoomChoreSetTextBox
            // 
            this.RoomChoreSetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomChoreSetTextBox.Location = new System.Drawing.Point(373, 31);
            this.RoomChoreSetTextBox.MaxLength = 10;
            this.RoomChoreSetTextBox.Name = "RoomChoreSetTextBox";
            this.RoomChoreSetTextBox.Size = new System.Drawing.Size(100, 22);
            this.RoomChoreSetTextBox.TabIndex = 4;
            this.RoomChoreSetTextBox.Tag = "";
            this.RoomChoreSetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextboxKeypress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Room Number:";
            // 
            // RoomListBox
            // 
            this.RoomListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 15;
            this.RoomListBox.Location = new System.Drawing.Point(7, 7);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(212, 559);
            this.RoomListBox.TabIndex = 2;
            this.RoomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            // 
            // tabSection
            // 
            this.tabSection.BackColor = System.Drawing.Color.Transparent;
            this.tabSection.Controls.Add(this.groupBox3);
            this.tabSection.Controls.Add(this.SectionListBox);
            this.tabSection.Location = new System.Drawing.Point(4, 25);
            this.tabSection.Name = "tabSection";
            this.tabSection.Size = new System.Drawing.Size(882, 572);
            this.tabSection.TabIndex = 2;
            this.tabSection.Text = "Section";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SectionRASSNNUD);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.SectionNameTextBox);
            this.groupBox3.Controls.Add(this.SectionPointsNUD);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(225, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 559);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Section Attributes";
            // 
            // SectionRASSNNUD
            // 
            this.SectionRASSNNUD.Location = new System.Drawing.Point(208, 75);
            this.SectionRASSNNUD.Name = "SectionRASSNNUD";
            this.SectionRASSNNUD.Size = new System.Drawing.Size(120, 21);
            this.SectionRASSNNUD.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(189, 16);
            this.label20.TabIndex = 17;
            this.label20.Text = "Residential Advisor (RA) SSN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Name:";
            // 
            // SectionNameTextBox
            // 
            this.SectionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionNameTextBox.Location = new System.Drawing.Point(64, 20);
            this.SectionNameTextBox.Name = "SectionNameTextBox";
            this.SectionNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.SectionNameTextBox.TabIndex = 15;
            // 
            // SectionPointsNUD
            // 
            this.SectionPointsNUD.Location = new System.Drawing.Point(64, 48);
            this.SectionPointsNUD.Name = "SectionPointsNUD";
            this.SectionPointsNUD.Size = new System.Drawing.Size(192, 21);
            this.SectionPointsNUD.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "Points:";
            // 
            // SectionListBox
            // 
            this.SectionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionListBox.FormattingEnabled = true;
            this.SectionListBox.ItemHeight = 15;
            this.SectionListBox.Location = new System.Drawing.Point(7, 7);
            this.SectionListBox.Name = "SectionListBox";
            this.SectionListBox.Size = new System.Drawing.Size(212, 559);
            this.SectionListBox.TabIndex = 2;
            this.SectionListBox.SelectedIndexChanged += new System.EventHandler(this.SectionListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ResidentMealPlanTextBox
            // 
            this.ResidentMealPlanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentMealPlanTextBox.Location = new System.Drawing.Point(182, 116);
            this.ResidentMealPlanTextBox.Name = "ResidentMealPlanTextBox";
            this.ResidentMealPlanTextBox.Size = new System.Drawing.Size(121, 22);
            this.ResidentMealPlanTextBox.TabIndex = 29;
            // 
            // ResidentAssignedRoomNumTextBox
            // 
            this.ResidentAssignedRoomNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentAssignedRoomNumTextBox.Location = new System.Drawing.Point(182, 145);
            this.ResidentAssignedRoomNumTextBox.Name = "ResidentAssignedRoomNumTextBox";
            this.ResidentAssignedRoomNumTextBox.Size = new System.Drawing.Size(121, 22);
            this.ResidentAssignedRoomNumTextBox.TabIndex = 30;
            // 
            // ResidentNextSemesterTextBox
            // 
            this.ResidentNextSemesterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentNextSemesterTextBox.Location = new System.Drawing.Point(168, 219);
            this.ResidentNextSemesterTextBox.Name = "ResidentNextSemesterTextBox";
            this.ResidentNextSemesterTextBox.Size = new System.Drawing.Size(387, 22);
            this.ResidentNextSemesterTextBox.TabIndex = 31;
            // 
            // RoomMeetingTimeTextBox
            // 
            this.RoomMeetingTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomMeetingTimeTextBox.Location = new System.Drawing.Point(155, 63);
            this.RoomMeetingTimeTextBox.MaxLength = 10;
            this.RoomMeetingTimeTextBox.Name = "RoomMeetingTimeTextBox";
            this.RoomMeetingTimeTextBox.Size = new System.Drawing.Size(212, 22);
            this.RoomMeetingTimeTextBox.TabIndex = 15;
            this.RoomMeetingTimeTextBox.Tag = "";
            // 
            // RoomSectionTextBox
            // 
            this.RoomSectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSectionTextBox.Location = new System.Drawing.Point(155, 121);
            this.RoomSectionTextBox.MaxLength = 10;
            this.RoomSectionTextBox.Name = "RoomSectionTextBox";
            this.RoomSectionTextBox.Size = new System.Drawing.Size(212, 22);
            this.RoomSectionTextBox.TabIndex = 17;
            this.RoomSectionTextBox.Tag = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 16);
            this.label21.TabIndex = 16;
            this.label21.Text = "House Section";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClassSelectorTabCtrl);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainMenuForm_Show);
            this.ClassSelectorTabCtrl.ResumeLayout(false);
            this.tabResident.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentOutstandingBalanceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentChoresMissedNUD)).EndInit();
            this.tabRoom.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumberNUD)).EndInit();
            this.tabSection.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionRASSNNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionPointsNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ClassSelectorTabCtrl;
        private System.Windows.Forms.TabPage tabResident;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabSection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ResidentListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox SectionListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ResidentContractStartDatetimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResidentPhoneNumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResidentNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResidentSSNTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ResidentContractEndDatetimePicker;
        private System.Windows.Forms.CheckBox ResidentIsKPCheckbox;
        private System.Windows.Forms.TextBox ResidentSmallGroupTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ResidentOutstandingBalanceNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ResidentChoresMissedNUD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ResidentGraduationDatetimePicker;
        private System.Windows.Forms.TextBox RoomLeaderSSNTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown RoomNumberNUD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RoomWorkOrdersTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RoomChoreSetTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown SectionPointsNUD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ResidentIsFMCheckbox;
        private System.Windows.Forms.NumericUpDown SectionRASSNNUD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SectionNameTextBox;
        private System.Windows.Forms.TextBox ResidentAssignedRoomNumTextBox;
        private System.Windows.Forms.TextBox ResidentMealPlanTextBox;
        private System.Windows.Forms.TextBox ResidentNextSemesterTextBox;
        private System.Windows.Forms.TextBox RoomMeetingTimeTextBox;
        private System.Windows.Forms.TextBox RoomSectionTextBox;
        private System.Windows.Forms.Label label21;
    }
}

