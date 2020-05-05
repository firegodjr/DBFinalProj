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

namespace DBFinalProj.Forms
{
    public partial class PickDatabaseForm : Form
    {
        private Dictionary<string, Database> databases;
        public Database SelectedDatabase;

        public PickDatabaseForm()
        {
            InitializeComponent();
        }

        private void PickDatabaseForm_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            databases = JsonMgr.LoadDatabases();
            DatabaseListBox.Items.Clear();
            DatabaseListBox.Items.AddRange(databases.Keys.ToArray());
        }

        private void DatabaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DatabaseListBox.SelectedItem != null)
            {
                Database db = databases[(string)DatabaseListBox.SelectedItem];
                NameTextBox.Text = db.Name;
                ServerTextBox.Text = db.Server;
                SchemaTextBox.Text = db.Schema;
                PortNUD.Value = db.Port;
                OKBtn.Enabled = true;
            }
            else
            {
                NameTextBox.Text = "";
                ServerTextBox.Text = "";
                SchemaTextBox.Text = "";
                PortNUD.Value = 0;
                OKBtn.Enabled = false;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedDatabase = databases[(string)DatabaseListBox.SelectedItem];
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            SelectedDatabase = null;
            Close();
        }

        private void AddDatabaseBtn_Click(object sender, EventArgs e)
        {
            AddDatabaseForm form = new AddDatabaseForm();
            var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                InitControls();
            }
        }
    }
}
