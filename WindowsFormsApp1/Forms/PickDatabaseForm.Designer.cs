namespace DBFinalProj.Forms
{
    partial class PickDatabaseForm
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
            this.DatabaseListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PortNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SchemaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddDatabaseBtn = new System.Windows.Forms.Button();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PortNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseListBox
            // 
            this.DatabaseListBox.FormattingEnabled = true;
            this.DatabaseListBox.Location = new System.Drawing.Point(13, 13);
            this.DatabaseListBox.Name = "DatabaseListBox";
            this.DatabaseListBox.Size = new System.Drawing.Size(177, 290);
            this.DatabaseListBox.TabIndex = 0;
            this.DatabaseListBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameTextBox.Location = new System.Drawing.Point(249, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(116, 20);
            this.NameTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // PortNUD
            // 
            this.PortNUD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PortNUD.Location = new System.Drawing.Point(245, 91);
            this.PortNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNUD.Name = "PortNUD";
            this.PortNUD.ReadOnly = true;
            this.PortNUD.Size = new System.Drawing.Size(120, 20);
            this.PortNUD.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port";
            // 
            // SchemaTextBox
            // 
            this.SchemaTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SchemaTextBox.Location = new System.Drawing.Point(264, 65);
            this.SchemaTextBox.Name = "SchemaTextBox";
            this.SchemaTextBox.ReadOnly = true;
            this.SchemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.SchemaTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Schema";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ServerTextBox.Location = new System.Drawing.Point(249, 39);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.ReadOnly = true;
            this.ServerTextBox.Size = new System.Drawing.Size(116, 20);
            this.ServerTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Server";
            // 
            // OKBtn
            // 
            this.OKBtn.Enabled = false;
            this.OKBtn.Location = new System.Drawing.Point(214, 309);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 19;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(295, 309);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddDatabaseBtn
            // 
            this.AddDatabaseBtn.Location = new System.Drawing.Point(13, 309);
            this.AddDatabaseBtn.Name = "AddDatabaseBtn";
            this.AddDatabaseBtn.Size = new System.Drawing.Size(177, 23);
            this.AddDatabaseBtn.TabIndex = 21;
            this.AddDatabaseBtn.Text = "Add Database...";
            this.AddDatabaseBtn.UseVisualStyleBackColor = true;
            this.AddDatabaseBtn.Click += new System.EventHandler(this.AddDatabaseBtn_Click);
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Checked = true;
            this.RememberMeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(214, 286);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(130, 17);
            this.RememberMeCheckBox.TabIndex = 22;
            this.RememberMeCheckBox.Text = "Remember My Choice";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PickDatabaseForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(382, 345);
            this.Controls.Add(this.RememberMeCheckBox);
            this.Controls.Add(this.AddDatabaseBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PortNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SchemaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabaseListBox);
            this.Name = "PickDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick Database";
            this.Load += new System.EventHandler(this.PickDatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DatabaseListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PortNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SchemaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddDatabaseBtn;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
    }
}