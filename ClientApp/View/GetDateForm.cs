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
    public partial class GetDateForm : Form
    {
        public GetDateForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public DateTime GetDateValue() 
        { 
            return date.Value; 
        }
    }
}
