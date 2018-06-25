namespace ClientApp.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lblError);
            this.gbUserInfo.Controls.Add(this.lblPassword);
            this.gbUserInfo.Controls.Add(this.lblUserName);
            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.txtUserName);
            this.gbUserInfo.ForeColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.gbUserInfo, "gbUserInfo");
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.TabStop = false;
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Name = "lblError";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.Color.Indigo;
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.ForeColor = System.Drawing.Color.Indigo;
            this.lblUserName.Name = "lblUserName";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.ForeColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.ForeColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.Indigo;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCancle, "btnCancle");
            this.btnCancle.ForeColor = System.Drawing.Color.Indigo;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancle;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gbUserInfo);
            this.Name = "LoginForm";
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblError;
    }
}