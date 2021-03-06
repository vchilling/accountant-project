﻿namespace ClientApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.welcomeScreen = new System.Windows.Forms.GroupBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnGetDay = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnGetMonth = new System.Windows.Forms.Button();
            this.btnGetYear = new System.Windows.Forms.Button();
            this.btnGetReason = new System.Windows.Forms.Button();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.welcomeScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(47, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Expense";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmLogin
            // 
            this.tsmLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.tsmLogin.ForeColor = System.Drawing.Color.Indigo;
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(49, 20);
            this.tsmLogin.Text = "Login";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.BackColor = System.Drawing.Color.Gainsboro;
            this.tsmAbout.ForeColor = System.Drawing.Color.Indigo;
            this.tsmAbout.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmAbout.Text = "About";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(187, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Accountant System v1.0";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Indigo;
            this.lblWelcome.Location = new System.Drawing.Point(229, 74);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(218, 54);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.Indigo;
            this.lblLogin.Location = new System.Drawing.Point(269, 211);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(136, 13);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Please Login to continue....";
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.Controls.Add(this.lblWelcome);
            this.welcomeScreen.Controls.Add(this.lblLogin);
            this.welcomeScreen.Controls.Add(this.lblTitle);
            this.welcomeScreen.Controls.Add(this.shapeContainer1);
            this.welcomeScreen.Location = new System.Drawing.Point(0, 26);
            this.welcomeScreen.Name = "welcomeScreen";
            this.welcomeScreen.Size = new System.Drawing.Size(684, 337);
            this.welcomeScreen.TabIndex = 9;
            this.welcomeScreen.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(678, 318);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.Location = new System.Drawing.Point(33, 63);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(167, 140);
            // 
            // btnGetDay
            // 
            this.btnGetDay.BackColor = System.Drawing.Color.DimGray;
            this.btnGetDay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDay.ForeColor = System.Drawing.Color.Indigo;
            this.btnGetDay.Location = new System.Drawing.Point(162, 309);
            this.btnGetDay.Name = "btnGetDay";
            this.btnGetDay.Size = new System.Drawing.Size(109, 38);
            this.btnGetDay.TabIndex = 10;
            this.btnGetDay.Text = "Average For Day";
            this.btnGetDay.UseVisualStyleBackColor = false;
            this.btnGetDay.Click += new System.EventHandler(this.btnGetDay_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblSubTitle.Location = new System.Drawing.Point(253, 92);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(134, 24);
            this.lblSubTitle.TabIndex = 11;
            this.lblSubTitle.Text = "Choose Action";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblMainTitle.Location = new System.Drawing.Point(229, 46);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(91, 31);
            this.lblMainTitle.TabIndex = 12;
            this.lblMainTitle.Text = "Hello, ";
            // 
            // btnGetMonth
            // 
            this.btnGetMonth.BackColor = System.Drawing.Color.DimGray;
            this.btnGetMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetMonth.ForeColor = System.Drawing.Color.Indigo;
            this.btnGetMonth.Location = new System.Drawing.Point(277, 309);
            this.btnGetMonth.Name = "btnGetMonth";
            this.btnGetMonth.Size = new System.Drawing.Size(109, 38);
            this.btnGetMonth.TabIndex = 13;
            this.btnGetMonth.Text = "Total For Month";
            this.btnGetMonth.UseVisualStyleBackColor = false;
            this.btnGetMonth.Click += new System.EventHandler(this.btnGetMonth_Click);
            // 
            // btnGetYear
            // 
            this.btnGetYear.BackColor = System.Drawing.Color.DimGray;
            this.btnGetYear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetYear.ForeColor = System.Drawing.Color.Indigo;
            this.btnGetYear.Location = new System.Drawing.Point(392, 309);
            this.btnGetYear.Name = "btnGetYear";
            this.btnGetYear.Size = new System.Drawing.Size(109, 38);
            this.btnGetYear.TabIndex = 14;
            this.btnGetYear.Text = "Total For Year";
            this.btnGetYear.UseVisualStyleBackColor = false;
            this.btnGetYear.Click += new System.EventHandler(this.btnGetYear_Click);
            // 
            // btnGetReason
            // 
            this.btnGetReason.BackColor = System.Drawing.Color.DimGray;
            this.btnGetReason.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetReason.ForeColor = System.Drawing.Color.Indigo;
            this.btnGetReason.Location = new System.Drawing.Point(507, 309);
            this.btnGetReason.Name = "btnGetReason";
            this.btnGetReason.Size = new System.Drawing.Size(109, 38);
            this.btnGetReason.TabIndex = 15;
            this.btnGetReason.Text = "Get Costs For Reason";
            this.btnGetReason.UseVisualStyleBackColor = false;
            this.btnGetReason.Click += new System.EventHandler(this.btnGetReason_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Enabled = false;
            this.rtbConsole.ForeColor = System.Drawing.Color.Indigo;
            this.rtbConsole.Location = new System.Drawing.Point(67, 144);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(540, 147);
            this.rtbConsole.TabIndex = 10;
            this.rtbConsole.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.welcomeScreen);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.btnGetReason);
            this.Controls.Add(this.btnGetYear);
            this.Controls.Add(this.btnGetMonth);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.btnGetDay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.welcomeScreen.ResumeLayout(false);
            this.welcomeScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox welcomeScreen;
        private System.Windows.Forms.Button btnGetDay;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblMainTitle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnGetMonth;
        private System.Windows.Forms.Button btnGetYear;
        private System.Windows.Forms.Button btnGetReason;
        private System.Windows.Forms.RichTextBox rtbConsole;
    }
}

