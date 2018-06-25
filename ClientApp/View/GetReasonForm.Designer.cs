namespace ClientApp.View
{
    partial class GetReasonForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cmbReasons = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Indigo;
            this.btnCancel.Location = new System.Drawing.Point(156, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.ForeColor = System.Drawing.Color.Indigo;
            this.lblReason.Location = new System.Drawing.Point(85, 102);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 17;
            this.lblReason.Text = "Reason";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(69, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Choose Reason";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.Indigo;
            this.btnEnter.Location = new System.Drawing.Point(54, 214);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cmbReasons
            // 
            this.cmbReasons.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbReasons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbReasons.ForeColor = System.Drawing.Color.Indigo;
            this.cmbReasons.FormattingEnabled = true;
            this.cmbReasons.Location = new System.Drawing.Point(69, 122);
            this.cmbReasons.Name = "cmbReasons";
            this.cmbReasons.Size = new System.Drawing.Size(148, 21);
            this.cmbReasons.TabIndex = 20;
            // 
            // GetReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbReasons);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEnter);
            this.Name = "GetReasonForm";
            this.Text = "GetReasonForm";
            this.Load += new System.EventHandler(this.GetReasonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cmbReasons;
    }
}