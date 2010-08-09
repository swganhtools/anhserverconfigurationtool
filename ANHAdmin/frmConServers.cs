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
            connectionserver.StdErrReceived += new DataReceivedHandler(writeConnStreamInfo);
            connectionserver.StdOutReceived += new DataReceivedHandler(writeConnStreamInfo);
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
            chatserver.StdErrReceived += new DataReceivedHandler(writeChatStreamInfo);
            chatserver.StdOutReceived += new DataReceivedHandler(writeChatStreamInfo);
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
            pingserver.StdErrReceived += new DataReceivedHandler(writePingStreamInfo);
            pingserver.StdOutReceived += new DataReceivedHandler(writePingStreamInfo);
            pingserver.Completed += new EventHandler(processCompletedOrCanceled);
            pingserver.Cancelled += new EventHandler(processCompletedOrCanceled);
            pingserver.Start();
        }
        public void logserver()
        {
            loginserver = new ProcessCaller(this);
            loginserver.FileName = "loginserver.exe";
            loginserver.WorkingDirectory = "";
            loginserver.Arguments = "";
            loginserver.StdErrReceived += new DataReceivedHandler(writeLoginStreamInfo);
            loginserver.StdOutReceived += new DataReceivedHandler(writeLoginStreamInfo);
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
        private void writeConnStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtConnection.AppendText(e.Text + Environment.NewLine);
        }
        private void writeLoginStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtLogin.AppendText(e.Text + Environment.NewLine);
        }
        private void writePingStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtPing.AppendText(e.Text + Environment.NewLine);
        }
        private void writeChatStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtChat.AppendText(e.Text + Environment.NewLine);
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

        private void button1_Click(object sender, EventArgs e)
        {
            chtserver();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pngserver();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logserver();
        }
    }
}
