﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ServerApp.Logic;
using ServerApp.Data;

namespace ServerApp
{
    public partial class ServerUI : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private int connectedClients = 0;
        private delegate void WriteMessageDelegate(string msg, NetworkStream clientStream, string clientId);
        private delegate void SetTextCallback(TcpClient client);

        public ServerUI()
        {
            InitializeComponent();
            Server();
        }

        private void Server()
        {
            this.tcpListener = new TcpListener(IPAddress.Any, 3000); // Change to IPAddress.Any for internet wide Communication
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }

        private void ListenForClients()
        {
            this.tcpListener.Start();

            while (true) // Never ends until the Server is closed.
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                SetText(client);
                //create a thread to handle communication 
                //with connected client                
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;            

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }


                // Convert the Bytes received to a string and display it on the Server Screen
                string msg = Encoding.GetEncoding(1252).GetString(message, 0, bytesRead).ToLower();
                AcceptMessage(msg, clientStream, tcpClient.GetHashCode().ToString());

            }

            tcpClient.Close();
        }

        

        private void SetText(TcpClient client)
        {
            if (this.rtbServer.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { client });
            }
            else
            {
                this.rtbServer.AppendText("Client: " + client.GetHashCode().ToString() + ", connected successfuly" + Environment.NewLine);
            }
        }

        private void AcceptMessage(string msg, NetworkStream clientStream, string clientId)
        {
            if (this.rtbServer.InvokeRequired)
            {
                WriteMessageDelegate d = new WriteMessageDelegate(AcceptMessage);
                this.rtbServer.Invoke(d, new object[] { msg, clientStream, clientId });
            }
            else
            {
                this.rtbServer.AppendText("Client: " + clientId + ", asks for: " + msg + Environment.NewLine);
                HandleMessage(msg, clientStream);
            }
        }

        private void Echo(string msg, NetworkStream clientStream)
        {
            // Now Echo the message back
            byte[] buffer = Encoding.GetEncoding(1252).GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

        private void HandleMessage(String msg, NetworkStream clientStream)
        {
            String[] commandParams = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (commandParams[0])
            {
                case "reasons":
                    string reasons = CommandExecutor.ExecuteReasonsCommand();
                    if (reasons != null)
                    {
                        Echo(reasons, clientStream);
                    }
                    else
                    {
                        Echo("No such User", clientStream);
                    }
                    break;
                case "login":
                    string result = CommandExecutor.ExecuteLoginCommand(commandParams[1], commandParams[2]);
                    if (result != null)
                    {
                        Echo(result, clientStream);
                    }
                    else
                    {
                        Echo("No such User", clientStream);
                    }
                    break;
                case "add":
                    if (CommandExecutor.ExecuteAddCommand(commandParams[1], commandParams[2], commandParams[3], commandParams[4]))
                    {
                        Echo("Adding Successful!", clientStream);
                    }
                    else
                    {
                        Echo("Error.Failed enter the record!", clientStream);
                    }
                    break;
                case "getday":
                    double resultDay = 0;
                    try
                    {
                        resultDay = CommandExecutor.ExecuteGetDayCommand(commandParams[1], commandParams[2]);
                    }
                    catch (ArgumentException)
                    {
                        Echo("Wrong Input!", clientStream);
                        break;
                    }

                    if (resultDay >= 0)
                    {
                        Echo(resultDay.ToString(), clientStream);
                    }
                    break;
                case "getmonth":
                    double totalForMonth = 0;
                    try
                    {
                        totalForMonth = CommandExecutor.ExecuteTotalForMonthCommand(commandParams[1], commandParams[2]);
                    }
                    catch (ArgumentException)
                    {
                        Echo("Wrong Input!", clientStream);
                        break;
                    }
                    Echo(totalForMonth.ToString(), clientStream);
                    break;
                case "getyear":
                    double totalForYear = 0;
                    try
                    {
                        totalForYear = CommandExecutor.ExecuteTotalForYearCommand(commandParams[1], commandParams[2]);
                    }
                    catch (ArgumentException)
                    {
                        Echo("Wrong Input!", clientStream);
                        break;
                    }
                    Echo(totalForYear.ToString(), clientStream);
                    break;
                case "getreason":
                    String recordsForReason;
                    try
                    {
                        recordsForReason = CommandExecutor.ExecuteCostsForReasonCommand(commandParams[1], commandParams[2]);
                    }
                    catch (ArgumentException)
                    {
                        Echo("Wrong Input!", clientStream);
                        break;
                    }
                    Echo(recordsForReason, clientStream);
                    break;
                default:
                    Echo("Wrong command:" + msg, clientStream);
                    break;
            }
        }
    }
}
