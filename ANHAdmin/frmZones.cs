using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ANHAdmin
{
    public partial class frmZones : Form
    {
        ProcessCaller tutorialzone = null;
        ProcessCaller tatooinezone = null;
        ProcessCaller corelliazone = null;
        ProcessCaller dantooinezone = null;
        ProcessCaller dathomirzone = null;
        ProcessCaller endorzone = null;
        ProcessCaller lokzone = null;
        ProcessCaller naboozone = null;
        ProcessCaller rorizone = null;
        ProcessCaller taluszone = null;
        ProcessCaller yavinzone = null;

        private bool flgTutorial = false;
        private bool flgCorellia = false;
        private bool flgDantooine = false;
        private bool flgDathomir = false;
        private bool flgEndor = false;
        private bool flgLok = false;
        private bool flgNaboo = false;
        private bool flgRori = false;
        private bool flgTalus = false;
        private bool flgTatooine = false;
        private bool flgYavin = false;

        private bool flgTutorialStarted = false;
        private bool flgCorelliaStarted = false;
        private bool flgDantooineStarted = false;
        private bool flgDathomirStarted = false;
        private bool flgEndorStarted = false;
        private bool flgLokStarted = false;
        private bool flgNabooStarted = false;
        private bool flgRoriStarted = false;
        private bool flgTalusStarted = false;
        private bool flgTatooineStarted = false;
        private bool flgYavinStarted = false;
        public frmZones()
        {
            InitializeComponent();
        }
        public void zonetutorial()
        {
            tutorialzone = new ProcessCaller(this);
            tutorialzone.FileName = "zoneserver.exe";
            tutorialzone.WorkingDirectory = "";
            tutorialzone.Arguments = "tutorial";
            tutorialzone.StdErrReceived += new DataReceivedHandler(writeTutorialStreamInfo);
            tutorialzone.StdOutReceived += new DataReceivedHandler(writeTutorialStreamInfo);
            tutorialzone.Completed += new EventHandler(processCompletedOrCanceled);
            tutorialzone.Cancelled += new EventHandler(processCompletedOrCanceled);
            tutorialzone.Start();
            flgTutorialStarted = true;
        }
        public void zonetatooine()
        {
            tatooinezone = new ProcessCaller(this);
            tatooinezone.FileName = "zoneserver.exe";
            tatooinezone.WorkingDirectory = "";
            tatooinezone.Arguments = "tatooine";
            tatooinezone.StdErrReceived += new DataReceivedHandler(writeTatooineStreamInfo);
            tatooinezone.StdOutReceived += new DataReceivedHandler(writeTatooineStreamInfo);
            tatooinezone.Completed += new EventHandler(processCompletedOrCanceled);
            tatooinezone.Cancelled += new EventHandler(processCompletedOrCanceled);
            tatooinezone.Start();
            flgTatooineStarted = true;
        }
        public void zonecorellia()
        {
            corelliazone = new ProcessCaller(this);
            corelliazone.FileName = "zoneserver.exe";
            corelliazone.WorkingDirectory = "";
            corelliazone.Arguments = "corellia";
            corelliazone.StdErrReceived += new DataReceivedHandler(writeCorelliaStreamInfo);
            corelliazone.StdOutReceived += new DataReceivedHandler(writeCorelliaStreamInfo);
            corelliazone.Completed += new EventHandler(processCompletedOrCanceled);
            corelliazone.Cancelled += new EventHandler(processCompletedOrCanceled);
            corelliazone.Start();
            flgCorelliaStarted = true;
        }
        public void zonedantooine()
        {
            dantooinezone = new ProcessCaller(this);
            dantooinezone.FileName = "zoneserver.exe";
            dantooinezone.WorkingDirectory = "";
            dantooinezone.Arguments = "dantooine";
            dantooinezone.StdErrReceived += new DataReceivedHandler(writeDantooineStreamInfo);
            dantooinezone.StdOutReceived += new DataReceivedHandler(writeDantooineStreamInfo);
            dantooinezone.Completed += new EventHandler(processCompletedOrCanceled);
            dantooinezone.Cancelled += new EventHandler(processCompletedOrCanceled);
            dantooinezone.Start();
            flgDantooineStarted = true;
        }
        public void zonedathomir()
        {
            dathomirzone = new ProcessCaller(this);
            dathomirzone.FileName = "zoneserver.exe";
            dathomirzone.WorkingDirectory = "";
            dathomirzone.Arguments = "dathomir";
            dathomirzone.StdErrReceived += new DataReceivedHandler(writeDathomirStreamInfo);
            dathomirzone.StdOutReceived += new DataReceivedHandler(writeDathomirStreamInfo);
            dathomirzone.Completed += new EventHandler(processCompletedOrCanceled);
            dathomirzone.Cancelled += new EventHandler(processCompletedOrCanceled);
            dathomirzone.Start();
            flgDathomirStarted = true;
        }
        public void zoneendor()
        {
            endorzone = new ProcessCaller(this);
            endorzone.FileName = "zoneserver.exe";
            endorzone.WorkingDirectory = "";
            endorzone.Arguments = "endor";
            endorzone.StdErrReceived += new DataReceivedHandler(writeEndorStreamInfo);
            endorzone.StdOutReceived += new DataReceivedHandler(writeEndorStreamInfo);
            endorzone.Completed += new EventHandler(processCompletedOrCanceled);
            endorzone.Cancelled += new EventHandler(processCompletedOrCanceled);
            endorzone.Start();
            flgEndorStarted = true;
        }
        public void zonelok()
        {
            lokzone = new ProcessCaller(this);
            lokzone.FileName = "zoneserver.exe";
            lokzone.WorkingDirectory = "";
            lokzone.Arguments = "lok";
            lokzone.StdErrReceived += new DataReceivedHandler(writeLokStreamInfo);
            lokzone.StdOutReceived += new DataReceivedHandler(writeLokStreamInfo);
            lokzone.Completed += new EventHandler(processCompletedOrCanceled);
            lokzone.Cancelled += new EventHandler(processCompletedOrCanceled);
            lokzone.Start();
            flgLokStarted = true;
        }
        public void zonenaboo()
        {
            naboozone = new ProcessCaller(this);
            naboozone.FileName = "zoneserver.exe";
            naboozone.WorkingDirectory = "";
            naboozone.Arguments = "naboo";
            naboozone.StdErrReceived += new DataReceivedHandler(writeNabooStreamInfo);
            naboozone.StdOutReceived += new DataReceivedHandler(writeNabooStreamInfo);
            naboozone.Completed += new EventHandler(processCompletedOrCanceled);
            naboozone.Cancelled += new EventHandler(processCompletedOrCanceled);
            naboozone.Start();
            flgNabooStarted = true;
        }
        public void zonerori()
        {
            rorizone = new ProcessCaller(this);
            rorizone.FileName = "zoneserver.exe";
            rorizone.WorkingDirectory = "";
            rorizone.Arguments = "rori";
            rorizone.StdErrReceived += new DataReceivedHandler(writeRoriStreamInfo);
            rorizone.StdOutReceived += new DataReceivedHandler(writeRoriStreamInfo);
            rorizone.Completed += new EventHandler(processCompletedOrCanceled);
            rorizone.Cancelled += new EventHandler(processCompletedOrCanceled);
            rorizone.Start();
            flgRoriStarted = true;
        }
        public void zonetalus()
        {
            taluszone = new ProcessCaller(this);
            taluszone.FileName = "zoneserver.exe";
            taluszone.WorkingDirectory = "";
            taluszone.Arguments = "talus";
            taluszone.StdErrReceived += new DataReceivedHandler(writeTalusStreamInfo);
            taluszone.StdOutReceived += new DataReceivedHandler(writeTalusStreamInfo);
            taluszone.Completed += new EventHandler(processCompletedOrCanceled);
            taluszone.Cancelled += new EventHandler(processCompletedOrCanceled);
            taluszone.Start();
            flgTalusStarted = true;
        }
        public void zoneyavin()
        {
            yavinzone = new ProcessCaller(this);
            yavinzone.FileName = "zoneserver.exe";
            yavinzone.WorkingDirectory = "";
            yavinzone.Arguments = "yavin4";
            yavinzone.StdErrReceived += new DataReceivedHandler(writeYavinStreamInfo);
            yavinzone.StdOutReceived += new DataReceivedHandler(writeYavinStreamInfo);
            yavinzone.Completed += new EventHandler(processCompletedOrCanceled);
            yavinzone.Cancelled += new EventHandler(processCompletedOrCanceled);
            yavinzone.Start();
            flgYavinStarted = true;
        }
        private void checktutorial()
        {
            if (flgTutorialStarted == true)
            {
                string host = "localhost";
                Int32 port = 5010;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgTutorial = true;
                }
                catch (SocketException ex)
                {
                    flgTutorial = false;
                }
            }
        }
        private void checkcorellia()
        {
            if (flgCorelliaStarted == true)
            {
                string host = "localhost";
                Int32 port = 5001;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgCorellia = true;
                }
                catch (SocketException ex)
                {
                    flgCorellia = false;
                }
            }
        }
        private void checkdantooine()
        {
            if (flgDantooineStarted == true)
            {
                string host = "localhost";
                Int32 port = 5002;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgDantooine = true;
                }
                catch (SocketException ex)
                {
                    flgDantooine = false;
                }
            }
        }
        private void checkdathomir()
        {
            if (flgDathomirStarted == true)
            {
                string host = "localhost";
                Int32 port = 5003;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgDathomir = true;
                }
                catch (SocketException ex)
                {
                    flgDathomir = false;
                }
            }
        }
        private void checkendor()
        {
            if (flgEndorStarted == true)
            {
                string host = "localhost";
                Int32 port = 5004;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgEndor = true;
                }
                catch (SocketException ex)
                {
                    flgEndor = false;
                }
            }
        }
        private void checklok()
        {
            if (flgLokStarted == true)
            {
                string host = "localhost";
                Int32 port = 5005;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgLok = true;
                }
                catch (SocketException ex)
                {
                    flgLok = false;
                }
            }
        }
        private void checknaboo()
        {
            if (flgNabooStarted == true)
            {
                string host = "localhost";
                Int32 port = 5006;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgNaboo = true;
                }
                catch (SocketException ex)
                {
                    flgNaboo = false;
                }
            }
        }
        private void checkrori()
        {
            if (flgRoriStarted == true)
            {
                string host = "localhost";
                Int32 port = 5007;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgRori = true;
                }
                catch (SocketException ex)
                {
                    flgRori = false;
                }
            }
        }
        private void checktalus()
        {
            if (flgTalusStarted == true)
            {
                string host = "localhost";
                Int32 port = 5008;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgTalus = true;
                }
                catch (SocketException ex)
                {
                    flgTalus = false;
                }
            }
        }
        private void checktatooine()
        {
            if (flgTatooineStarted == true)
            {
                string host = "localhost";
                Int32 port = 5009;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgTatooine = true;
                }
                catch (SocketException ex)
                {
                    flgTatooine = false;
                }
            }
        }
        private void checkyavin()
        {
            if (flgYavinStarted == true)
            {
                string host = "localhost";
                Int32 port = 5011;
                System.Net.Sockets.UdpClient client = new UdpClient();
                try
                {
                    client.Connect(host, port);
                    flgYavin = true;
                }
                catch (SocketException ex)
                {
                    flgYavin = false;
                }
            }
        }
        private void _processCheck(object sender, EventArgs e)
        {
            checktutorial();
            checkcorellia();
            checkdantooine();
            checkdathomir();
            checkendor();
            checklok();
            checknaboo();
            checkrori();
            checktalus();
            checktatooine();
            checkyavin();
            if (flgTutorialStarted = true && flgTutorial != true)
            {
                tutorialzone.Cancel();
                zonetutorial();
            }
            if (flgCorelliaStarted = true && flgCorellia != true)
            {
                corelliazone.Cancel();
                zonecorellia();
            }
            if (flgDantooineStarted = true && flgDantooine != true)
            {
                dantooinezone.Cancel();
                zonedantooine();
            }
            if (flgDathomirStarted = true && flgDathomir != true)
            {
                dathomirzone.Cancel();
                zonedathomir();
            }
            if (flgEndorStarted = true && flgEndor != true)
            {
                endorzone.Cancel();
                zoneendor();
            }
            if (flgLokStarted = true && flgLok != true)
            {
                lokzone.Cancel();
                zonelok();
            }
            if (flgNabooStarted = true && flgNaboo != true)
            {
                naboozone.Cancel();
                zonenaboo();
            }
            if (flgRoriStarted = true && flgRori != true)
            {
                rorizone.Cancel();
                zonerori();
            }
            if (flgTalusStarted = true && flgTalus != true)
            {
                taluszone.Cancel();
                zonetalus();
            }
            if (flgTatooineStarted = true && flgTatooine != true)
            {
                tatooinezone.Cancel();
                zonetatooine();
            }
            if (flgYavinStarted = true && flgYavin != true)
            {
                yavinzone.Cancel();
                zoneyavin();
            }
        }
        private void processCompletedOrCanceled(object sender, EventArgs e)
        {
            //txtConnection.AppendText("ConnectionServer Exited.");
        }
        private void writeTutorialStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtTutorial.AppendText(e.Text + Environment.NewLine);
        }
        private void writeTatooineStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtTatooine.AppendText(e.Text + Environment.NewLine);
        }
        private void writeCorelliaStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtCorellia.AppendText(e.Text + Environment.NewLine);
        }
        private void writeDantooineStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtDantooine.AppendText(e.Text + Environment.NewLine);
        }
        private void writeDathomirStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtDathomir.AppendText(e.Text + Environment.NewLine);
        }
        private void writeEndorStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtEndor.AppendText(e.Text + Environment.NewLine);
        }
        private void writeLokStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtLok.AppendText(e.Text + Environment.NewLine);
        }
        private void writeNabooStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtNaboo.AppendText(e.Text + Environment.NewLine);
        }
        private void writeRoriStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtRori.AppendText(e.Text + Environment.NewLine);
        }
        private void writeTalusStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtTalus.AppendText(e.Text + Environment.NewLine);
        }
        private void writeYavinStreamInfo(object sender, DataReceivedEventArgs e)
        {
            txtYavin.AppendText(e.Text + Environment.NewLine);
        }
        private void frmZones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tutorialzone != null)
            {
                tutorialzone.Cancel();
            }
            if (tatooinezone != null)
            {
                tatooinezone.Cancel();
            }
            if (corelliazone != null)
            {
                corelliazone.Cancel();
            }
            if (dantooinezone != null)
            {
                dantooinezone.Cancel();
            }
            if (dathomirzone != null)
            {
                dathomirzone.Cancel();
            }
            if (endorzone != null)
            {
                endorzone.Cancel();
            }
            if (lokzone != null)
            {
                lokzone.Cancel();
            }
            if (naboozone != null)
            {
                naboozone.Cancel();
            }
            if (rorizone != null)
            {
                rorizone.Cancel();
            }
            if (taluszone != null)
            {
                taluszone.Cancel();
            }
            if (yavinzone != null)
            {
                yavinzone.Cancel();
            }
        }

        private void btnTutorialLoad_Click(object sender, EventArgs e)
        {
            zonetutorial();
        }

        private void btnTattoine_Click(object sender, EventArgs e)
        {
            zonetatooine();
        }

        private void btnDantooine_Click(object sender, EventArgs e)
        {
            zonedantooine();
        }

        private void btnDathomir_Click(object sender, EventArgs e)
        {
            zonedathomir();
        }

        private void btnEndor_Click(object sender, EventArgs e)
        {
            zoneendor();
        }

        private void btnLok_Click(object sender, EventArgs e)
        {
            zonelok();
        }

        private void btnNaboo_Click(object sender, EventArgs e)
        {
            zonenaboo();
        }

        private void btnRori_Click(object sender, EventArgs e)
        {
            zonerori();
        }

        private void btnTalus_Click(object sender, EventArgs e)
        {
            zonetalus();
        }

        private void btnYavin_Click(object sender, EventArgs e)
        {
            zoneyavin();
        }
    }
}
