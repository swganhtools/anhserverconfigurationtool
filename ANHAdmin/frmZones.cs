using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
