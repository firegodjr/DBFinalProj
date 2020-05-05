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
    public partial class ErrorDispForm : Form
    {
        public string ErrorNotif;
        public string ErrorName;
        public string ErrorMessage;
        public string Stacktrace;

        public ErrorDispForm()
        {
            InitializeComponent();
        }

        private void ErrorDispForm_Load(object sender, EventArgs e)
        {
            ErrorNotifLabel.Text = ErrorNotif;
            ErrorNameLabel.Text = ErrorName;
            ErrorMsgTextBox.Text = $"\"{ErrorMessage}\"";
            StackTraceTextBox.Text = Stacktrace;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
