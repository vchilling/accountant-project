namespace ServerApp
{
    partial class ServerUI
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
            this.rtbServer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbServer
            // 
            this.rtbServer.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbServer.Location = new System.Drawing.Point(0, 0);
            this.rtbServer.Name = "rtbServer";
            this.rtbServer.Size = new System.Drawing.Size(621, 281);
            this.rtbServer.TabIndex = 1;
            this.rtbServer.Text = "";
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 281);
            this.Controls.Add(this.rtbServer);
            this.Name = "ServerUI";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbServer;
    }
}

