using DBFinalProj.IO;
using DBFinalProj.Objects;
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
    public partial class AddDatabaseForm : Form
    {
        Database db;

        public AddDatabaseForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            db = new Database(NameTextBox.Text, ServerTextBox.Text, (int)PortNUD.Value, SchemaTextBox.Text);
            JsonMgr.SaveDatabase(db);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PortNUD_Enter(object sender, EventArgs e)
        {
            PortNUD.Select(0, 5);
        }
    }
}
