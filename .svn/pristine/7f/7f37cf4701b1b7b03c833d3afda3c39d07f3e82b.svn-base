using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.View;

namespace ClientApp.View
{
    public partial class LoginForm : Form
    {
        private string userInfo;

        public string UserInfo
        {
            get
            {
                return userInfo;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUserName.Text.Equals(String.Empty) && !txtPassword.Text.Equals(String.Empty))
            {
                MainForm owner = Owner as MainForm; 
                String response = owner.UserExistingCheck(txtUserName.Text,txtPassword.Text);
                if (!response.Equals("no user"))
                {
                    this.userInfo = response;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lblError.Text = "Account is not existing! Check your data!";
                }
                
            }
            else 
            {
                lblError.Text = "All fields must be filled!";
            }
        }

    }
}
