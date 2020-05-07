namespace DBFinalProj.Forms
{
    partial class CreateRoomForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChoreSetTextBox = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MeetingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HouseSectionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomLeaderSSNComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Create Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chore Set";
            // 
            // ChoreSetTextBox
            // 
            this.ChoreSetTextBox.Location = new System.Drawing.Point(100, 59);
            this.ChoreSetTextBox.Name = "ChoreSetTextBox";
            this.ChoreSetTextBox.Size = new System.Drawing.Size(197, 20);
            this.ChoreSetTextBox.TabIndex = 17;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(139, 180);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 30;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(224, 180);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Room Number";
            // 
            // RoomNumTextBox
            // 
            this.RoomNumTextBox.Location = new System.Drawing.Point(100, 33);
            this.RoomNumTextBox.Name = "RoomNumTextBox";
            this.RoomNumTextBox.Size = new System.Drawing.Size(128, 20);
            this.RoomNumTextBox.TabIndex = 13;
            this.RoomNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextboxKeypress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Meeting Time";
            // 
            // MeetingTimeTextBox
            // 
            this.MeetingTimeTextBox.Location = new System.Drawing.Point(100, 85);
            this.MeetingTimeTextBox.Name = "MeetingTimeTextBox";
            this.MeetingTimeTextBox.Size = new System.Drawing.Size(197, 20);
            this.MeetingTimeTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Room Leader SSN";
            // 
            // HouseSectionComboBox
            // 
            this.HouseSectionComboBox.FormattingEnabled = true;
            this.HouseSectionComboBox.Location = new System.Drawing.Point(119, 137);
            this.HouseSectionComboBox.Name = "HouseSectionComboBox";
            this.HouseSectionComboBox.Size = new System.Drawing.Size(178, 21);
            this.HouseSectionComboBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "House Section";
            // 
            // RoomLeaderSSNComboBox
            // 
            this.RoomLeaderSSNComboBox.FormattingEnabled = true;
            this.RoomLeaderSSNComboBox.Location = new System.Drawing.Point(119, 111);
            this.RoomLeaderSSNComboBox.Name = "RoomLeaderSSNComboBox";
            this.RoomLeaderSSNComboBox.Size = new System.Drawing.Size(178, 21);
            this.RoomLeaderSSNComboBox.TabIndex = 34;
            // 
            // CreateRoomForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(311, 215);
            this.Controls.Add(this.RoomLeaderSSNComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HouseSectionComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeetingTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoreSetTextBox);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomNumTextBox);
            this.Name = "CreateRoomForm";
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChoreSetTextBox;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomNumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MeetingTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HouseSectionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoomLeaderSSNComboBox;
    }
}