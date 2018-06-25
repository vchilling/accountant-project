using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientApp.View
{
    public partial class GetReasonForm : Form
    {
        public GetReasonForm()
        {
            InitializeComponent();
        }

        public int Reason
        {
            get
            {
                return cmbReasons.SelectedIndex;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void GetReasonForm_Load(object sender, EventArgs e)
        {
            MainForm owner = Owner as MainForm;
            cmbReasons.DataSource = owner.GetReasonsForRecords();
        }

    }
}
