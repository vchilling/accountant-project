﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ClientApp.View;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        private TcpClient client = new TcpClient();
        private IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.108"), 3000);
        private int userId;
        private String userName;
        private static String[] reasons;
        public MainForm()
        {
            InitializeComponent();
            client.Connect(serverEndPoint);
            _GetReasons();
        }

        private string SendMessage(string msg)
        {
            NetworkStream clientStream = client.GetStream();

            byte[] buffer = Encoding.GetEncoding(1252).GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();

            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            Byte[] data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = clientStream.Read(data, 0, data.Length);
            responseData = Encoding.GetEncoding(1252).GetString(data, 0, bytes);

            return responseData;
        }

        public String[] GetReasonsForRecords()
        {
            return reasons;
        }
        private void _GetReasons()
        {
            reasons = SendMessage(String.Format("reasons")).Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            DateTime date = new DateTime();
            int reason = 0;

            AddRecordForm addRecordForm = new AddRecordForm() { Owner = this };
            if (addRecordForm.ShowDialog() == DialogResult.OK)
            {
                price = addRecordForm.NumPrice;
                date = addRecordForm.Date;
                reason = addRecordForm.Reason;
                string response = SendMessage(String.Format("add {0} {1} {2} {3}", userId, price.ToString(), reason.ToString(), date.ToString()));
                MessageBox.Show(response);
            }
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            if (tsmLogin.Text.Equals("Login"))
            {
                HandleLogin();
            }
            else
            {
                tsmLogin.Text = "Login";
                lblMainTitle.Text = "Hello, ";
                userId = 0;
                welcomeScreen.Visible = true;
            }

        }

        public string UserExistingCheck(string username, string password)
        {
            string loginRequest = String.Format("login {0} {1}", username, password);
            string result = SendMessage(loginRequest);
            return result;
        }

        private void HandleLogin()
        {
            LoginForm loginForm = new LoginForm() { Owner = this };
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                String[] resultParams = loginForm.UserInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (int.TryParse(resultParams[1], out userId))
                {
                    userName = resultParams[0];
                    lblMainTitle.Text += userName;
                    tsmLogin.Text = "Logout";
                    welcomeScreen.Visible = false;
                }
            }
        }

        private void btnGetDay_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();

            GetDateForm getDateForm = new GetDateForm();
            if (getDateForm.ShowDialog() == DialogResult.OK)
            {
                date = getDateForm.GetDateValue();
                string response = SendMessage(String.Format("getday {0} {1}", userId, date));
                if (response.Equals("Wrong Input!"))
                {
                    rtbConsole.Text = response;
                }
                else
                {
                    rtbConsole.Text = String.Format("The average costs for: {0} is: {1}", date, response);
                }

            }
        }

        private void btnGetMonth_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();

            GetDateForm getDateForm = new GetDateForm();
            if (getDateForm.ShowDialog() == DialogResult.OK)
            {
                date = getDateForm.GetDateValue();
                string response = SendMessage(String.Format("getmonth {0} {1}", userId, date));
                if (response.Equals("Wrong Input!"))
                {
                    rtbConsole.Text = response;
                }
                else
                {
                    rtbConsole.Text = String.Format("The total costs for month: {0} is: {1}", date.Month, response);
                }
            }
        }

        private void btnGetYear_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();

            GetDateForm getDateForm = new GetDateForm();
            if (getDateForm.ShowDialog() == DialogResult.OK)
            {
                date = getDateForm.GetDateValue();
                string response = SendMessage(String.Format("getmonth {0} {1}", userId, date));
                if (response.Equals("Wrong Input!"))
                {
                    rtbConsole.Text = response;
                }
                else
                {
                    rtbConsole.Text = String.Format("The total costs for year: {0} is: {1}", date.Year, response);
                }
            }
        }

        private void btnGetReason_Click(object sender, EventArgs e)
        {
            int reasonIndex = 0;
            GetReasonForm getDateForm = new GetReasonForm() { Owner = this };
            if (getDateForm.ShowDialog() == DialogResult.OK)
            {
                reasonIndex = getDateForm.Reason;
                string response = SendMessage(String.Format("getreason {0} {1}", userId, reasonIndex));
                if (response.Equals("Wrong Input!"))
                {
                    rtbConsole.Text = response;
                }
                else
                {
                    if (!response.Equals("No data"))
                    {
                        String[] records = response.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                        rtbConsole.Text = "";
                        int counter = 1;
                        foreach (String current in records)
                        {
                            String[] currentParams = current.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                            rtbConsole.Text += String.Format("{0}. Value: {1}, Spend for: {2}, On: {3}{4}", counter++, currentParams[0], reasons[reasonIndex], currentParams[1], Environment.NewLine);
                        }
                    }
                    else
                    {
                        rtbConsole.Text = String.Format("{0} you dont have entered records for {1}.", userName, reasons[reasonIndex]);
                    }
                }
            }
        }
    }
}
