namespace ClientApp.View
{
    partial class AddRecordForm
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
            this.components = new System.ComponentModel.Container();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.Indigo;
            this.btnEnter.Location = new System.Drawing.Point(75, 244);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Indigo;
            this.btnCancel.Location = new System.Drawing.Point(161, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Indigo;
            this.lblPrice.Location = new System.Drawing.Point(210, 96);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(83, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Enter Record Data";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.ForeColor = System.Drawing.Color.Indigo;
            this.lblReason.Location = new System.Drawing.Point(51, 96);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 8;
            this.lblReason.Text = "Reason";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.ForeColor = System.Drawing.Color.Indigo;
            this.lblDateTime.Location = new System.Drawing.Point(102, 150);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(30, 13);
            this.lblDateTime.TabIndex = 9;
            this.lblDateTime.Text = "Date";
            // 
            // date
            // 
            this.date.CalendarForeColor = System.Drawing.Color.Indigo;
            this.date.CalendarMonthBackground = System.Drawing.Color.SteelBlue;
            this.date.CalendarTitleForeColor = System.Drawing.Color.Indigo;
            this.date.Location = new System.Drawing.Point(97, 166);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(131, 20);
            this.date.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.numPrice.DecimalPlaces = 1;
            this.numPrice.ForeColor = System.Drawing.Color.Indigo;
            this.numPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrice.Location = new System.Drawing.Point(213, 113);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(75, 20);
            this.numPrice.TabIndex = 11;
            // 
            // cmbReason
            // 
            this.cmbReason.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReason.ForeColor = System.Drawing.Color.Indigo;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(54, 112);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(121, 21);
            this.cmbReason.TabIndex = 13;
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(331, 276);
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Name = "AddRecordForm";
            this.Text = "AddRecord";
            this.Load += new System.EventHandler(this.AddRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cmbReason;
    }
}