using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientApp.View;
namespace ClientApp.View
{
    public partial class AddRecordForm : Form
    {
        public AddRecordForm()
        {
            InitializeComponent();
        }

        public decimal NumPrice
        {
            get
            {
                return numPrice.Value;
            }
        }

        public int Reason
        {
            get
            {
                return cmbReason.SelectedIndex;
            }
        }

        public DateTime Date
        {
            get
            {
                return date.Value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddRecordForm_Load(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            cmbReason.DataSource = owner.GetReasonsForRecords();
        }
    }
}
