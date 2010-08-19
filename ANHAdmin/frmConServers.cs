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
        private bool flgConnection = false;
        private bool flgChat = false;
        private bool flgPing = false;
        private bool flgLogin = false;
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
            connectionserver.Completed += new EventHandler(connectionCompleted);
            connectionserver.Cancelled += new EventHandler(connectionCanceled);
            connectionserver.Start();
            flgConnection = true;
        }
        public void chtserver()
        {
            chatserver = new ProcessCaller(this);
            chatserver.FileName = "chatserver.exe";
            chatserver.WorkingDirectory = "";
            chatserver.Arguments = "";
            chatserver.StdErrReceived += new DataReceivedHandler(writeChatStreamInfo);
            chatserver.StdOutReceived += new DataReceivedHandler(writeChatStreamInfo);
            chatserver.Completed += new EventHandler(chatCompleted);
            chatserver.Cancelled += new EventHandler(chatCanceled);
            chatserver.Start();
            flgChat = true;
        }
        public void pngserver()
        {
            pingserver = new ProcessCaller(this);
            pingserver.FileName = "pingserver.exe";
            pingserver.WorkingDirectory = "";
            pingserver.Arguments = "";
            pingserver.StdErrReceived += new DataReceivedHandler(writePingStreamInfo);
            pingserver.StdOutReceived += new DataReceivedHandler(writePingStreamInfo);
            pingserver.Completed += new EventHandler(pingCompleted);
            pingserver.Cancelled += new EventHandler(pingCanceled);
            pingserver.Start();
            flgPing = true;
        }
        public void logserver()
        {
            loginserver = new ProcessCaller(this);
            loginserver.FileName = "loginserver.exe";
            loginserver.WorkingDirectory = "";
            loginserver.Arguments = "";
            loginserver.StdErrReceived += new DataReceivedHandler(writeLoginStreamInfo);
            loginserver.StdOutReceived += new DataReceivedHandler(writeLoginStreamInfo);
            loginserver.Completed += new EventHandler(loginCompleted);
            loginserver.Cancelled += new EventHandler(loginCanceled);
            //loginserver.Exited += new EventHandler(LaunchAgain);
            loginserver.Start();
            flgLogin = true;
        }
        
        private void frmConServers_Load(object sender, EventArgs e)
        {
            //conserver();
        }

        private void StartServers_Click(object sender, EventArgs e)
        {
            conserver();
        }
        //
        //Process server crashes and exits
        //

        //
        //Connection Server
        //
        private void connectionCanceled(object sender, EventArgs e)
        {
            txtConnection.AppendText("ConnectionServer Exited.\n");
        }
        private void connectionCompleted(object sender, EventArgs e)
        {
            txtConnection.AppendText("ConnectionServer crashed.\n");
            connectionserver.Cancel();
            chatserver.Cancel();
            pingserver.Cancel();
            loginserver.Cancel();
            conserver();
            chtserver();
            pngserver();
            logserver();
        }
        //
        //Chat Server
        //
        private void chatCanceled(object sender, EventArgs e)
        {
            txtChat.AppendText("Chat Server Exited.\n");
        }
        private void chatCompleted(object sender, EventArgs e)
        {
            txtChat.AppendText("Chat Server crashed.\n");
            connectionserver.Cancel();
            chatserver.Cancel();
            pingserver.Cancel();
            loginserver.Cancel();
            conserver();
            chtserver();
            pngserver();
            logserver();
        }
        //
        //Ping Server
        //
        private void pingCanceled(object sender, EventArgs e)
        {
            txtPing.AppendText("Ping Server Exited.\n");
        }
        private void pingCompleted(object sender, EventArgs e)
        {
            txtPing.AppendText("Ping Server crashed.\n");
            connectionserver.Cancel();
            chatserver.Cancel();
            pingserver.Cancel();
            loginserver.Cancel();
            conserver();
            chtserver();
            pngserver();
            logserver();
        }
        //
        //Login Server
        //
        private void loginCanceled(object sender, EventArgs e)
        {
            txtLogin.AppendText("Login Server Exited.\n");
        }
        private void loginCompleted(object sender, EventArgs e)
        {
            txtLogin.AppendText("Login Server crashed.\n");
                connectionserver.Cancel();
                chatserver.Cancel();
                pingserver.Cancel();
                loginserver.Cancel();
                conserver();
                chtserver();
                pngserver();
                logserver();
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

        private void btnStopCon_Click(object sender, EventArgs e)
        {
            connectionserver.Cancel();
        }

        private void btnStopChat_Click(object sender, EventArgs e)
        {
            chatserver.Cancel();
        }

        private void btnStopPing_Click(object sender, EventArgs e)
        {
            pingserver.Cancel();
        }

        private void btnStopLogin_Click(object sender, EventArgs e)
        {
            loginserver.Cancel();
        }
    }
}
