namespace DBFinalProj.Forms
{
    partial class ErrorDispForm
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
            this.ErrorNotifLabel = new System.Windows.Forms.Label();
            this.StackTraceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorMsgTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrorNotifLabel
            // 
            this.ErrorNotifLabel.AutoSize = true;
            this.ErrorNotifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorNotifLabel.Location = new System.Drawing.Point(13, 13);
            this.ErrorNotifLabel.Name = "ErrorNotifLabel";
            this.ErrorNotifLabel.Size = new System.Drawing.Size(114, 16);
            this.ErrorNotifLabel.TabIndex = 0;
            this.ErrorNotifLabel.Text = "An Error Occurred";
            // 
            // StackTraceTextBox
            // 
            this.StackTraceTextBox.Location = new System.Drawing.Point(16, 88);
            this.StackTraceTextBox.Multiline = true;
            this.StackTraceTextBox.Name = "StackTraceTextBox";
            this.StackTraceTextBox.ReadOnly = true;
            this.StackTraceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StackTraceTextBox.Size = new System.Drawing.Size(541, 339);
            this.StackTraceTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stacktrace:";
            // 
            // ErrorNameLabel
            // 
            this.ErrorNameLabel.AutoSize = true;
            this.ErrorNameLabel.Location = new System.Drawing.Point(136, 15);
            this.ErrorNameLabel.Name = "ErrorNameLabel";
            this.ErrorNameLabel.Size = new System.Drawing.Size(57, 13);
            this.ErrorNameLabel.TabIndex = 3;
            this.ErrorNameLabel.Text = "ErrorName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorMsgTextBox
            // 
            this.ErrorMsgTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMsgTextBox.Location = new System.Drawing.Point(139, 31);
            this.ErrorMsgTextBox.Multiline = true;
            this.ErrorMsgTextBox.Name = "ErrorMsgTextBox";
            this.ErrorMsgTextBox.ReadOnly = true;
            this.ErrorMsgTextBox.Size = new System.Drawing.Size(418, 51);
            this.ErrorMsgTextBox.TabIndex = 5;
            this.ErrorMsgTextBox.Text = "ErrorMessage";
            // 
            // ErrorDispForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 465);
            this.Controls.Add(this.ErrorMsgTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StackTraceTextBox);
            this.Controls.Add(this.ErrorNotifLabel);
            this.Name = "ErrorDispForm";
            this.Text = "An Error Occurred";
            this.Load += new System.EventHandler(this.ErrorDispForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorNotifLabel;
        private System.Windows.Forms.TextBox StackTraceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ErrorMsgTextBox;
    }
}