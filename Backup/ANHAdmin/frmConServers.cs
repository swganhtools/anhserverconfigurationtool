using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace ANHAdmin
{
    public partial class frmConServers : Form
    {
        ProcessCaller connectionserver = null;
        ProcessCaller chatserver = null;
        ProcessCaller pingserver = null;
        ProcessCaller loginserver = null;
        public frmConServers()
        {
            InitializeComponent();
        }
        public void conserver()
        {
            connectionserver = new ProcessCaller(this);
            connectionserver.FileName = "connectionserver.exe";
            connectionserver.WorkingDirectory = "";
            connectionserver.Arguments = "";
            connectionserver.StdErrReceived += new DataReceivedHandler(writeStreamInfo);
            connectionserver.StdOutReceived += new DataReceivedHandler(writeStreamInfo);
            connectionserver.Completed += new EventHandler(processCompletedOrCanceled);
            connectionserver.Cancelled += new EventHandler(processCompletedOrCanceled);
            connectionserver.Start();
        }
        public void chtserver()
        {
            chatserver = new ProcessCaller(this);
            chatserver.FileName = "chatserver.exe";
            chatserver.WorkingDirectory = "";
            chatserver.Arguments = "";
            chatserver.StdErrReceived += new DataReceivedHandler(writeStreamInfo);
            chatserver.StdOutReceived += new DataReceivedHandler(writeStreamInfo);
            chatserver.Completed += new EventHandler(processCompletedOrCanceled);
            chatserver.Cancelled += new EventHandler(processCompletedOrCanceled);
            chatserver.Start();
        }
        public void pngserver()
        {
            pingserver = new ProcessCaller(this);
            pingserver.FileName = "pingserver.exe";
            pingserver.WorkingDirectory = "";
            pingserver.Arguments = "";
            pingserver.StdErrReceived += new DataReceivedHandler(writeStreamInfo);
            pingserver.StdOutReceived += new DataReceivedHandler(writeStreamInfo);
            pingserver.Completed += new EventHandler(processCompletedOrCanceled);
            pingserver.Cancelled += new EventHandler(processCompletedOrCanceled);
            pingserver.Start();
        }
        public void logserver()
        {
            loginserver = new ProcessCaller(this);
            loginserver.FileName = "pingserver.exe";
            loginserver.WorkingDirectory = "";
            loginserver.Arguments = "";
            loginserver.StdErrReceived += new DataReceivedHandler(writeStreamInfo);
            loginserver.StdOutReceived += new DataReceivedHandler(writeStreamInfo);
            loginserver.Completed += new EventHandler(processCompletedOrCanceled);
            loginserver.Cancelled += new EventHandler(processCompletedOrCanceled);
            loginserver.Start();
        }
        private void frmConServers_Load(object sender, EventArgs e)
        {
            //conserver();
        }

        private void StartServers_Click(object sender, EventArgs e)
        {
            conserver();
            chtserver();
            pngserver();
            logserver();
        }
        private void writeStreamInfo(object sender, DataReceivedEventArgs e)
        {
            if (connectionserver != null)
            {
                txtConnection.AppendText(e.Text + Environment.NewLine);
            }
            if (chatserver != null)
            {
                txtChat.AppendText(e.Text + Environment.NewLine);
            }
            //txtConnection.AppendText(e.Text + Environment.NewLine);
        }
        private void processCompletedOrCanceled(object sender, EventArgs e)
        {
            txtConnection.AppendText("ConnectionServer Exited.");
        }

        private void frmConServers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connectionserver != null)
            {
                connectionserver.Cancel();                
            }
            if (chatserver != null)
            {
                chatserver.Cancel();
            }
            if (pingserver != null)
            {
                pingserver.Cancel();
            }
            if (loginserver != null)
            {
                loginserver.Cancel();
            }
        }
    }
}
