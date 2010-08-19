using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

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
            tutorialzone.Completed += new EventHandler(tutorialCompleted);
            tutorialzone.Cancelled += new EventHandler(tutorialCanceled);
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
            tatooinezone.Completed += new EventHandler(tatooineCompleted);
            tatooinezone.Cancelled += new EventHandler(tatooineCanceled);
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
            corelliazone.Completed += new EventHandler(corelliaCompleted);
            corelliazone.Cancelled += new EventHandler(corelliaCanceled);
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
            dantooinezone.Completed += new EventHandler(dantooineCompleted);
            dantooinezone.Cancelled += new EventHandler(dantooineCanceled);
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
            dathomirzone.Completed += new EventHandler(dathomirCompleted);
            dathomirzone.Cancelled += new EventHandler(dathomirCanceled);
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
            endorzone.Completed += new EventHandler(endorCompleted);
            endorzone.Cancelled += new EventHandler(endorCanceled);
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
            lokzone.Completed += new EventHandler(lokCompleted);
            lokzone.Cancelled += new EventHandler(lokCanceled);
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
            naboozone.Completed += new EventHandler(nabooCompleted);
            naboozone.Cancelled += new EventHandler(nabooCanceled);
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
            rorizone.Completed += new EventHandler(roriCompleted);
            rorizone.Cancelled += new EventHandler(roriCanceled);
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
            taluszone.Completed += new EventHandler(talusCompleted);
            taluszone.Cancelled += new EventHandler(talusCanceled);
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
            yavinzone.Completed += new EventHandler(yavinCompleted);
            yavinzone.Cancelled += new EventHandler(yavinCanceled);
            yavinzone.Start();
            flgYavinStarted = true;
        }
        private void processCompletedOrCanceled(object sender, EventArgs e)
        {
            //txtConnection.AppendText("ConnectionServer Exited.");
        }
        //
        // Process Crashes or server stops
        //

        //
        //Tutorial
        //
        private void tutorialCompleted(object sender, EventArgs e)
        {
            txtTutorial.AppendText("Tutorial Crash.\n");
            Thread.Sleep(5000);
            zonetutorial();
        }
        private void tutorialCanceled(object sender, EventArgs e)
        {
            txtTutorial.AppendText("Tutorial Stopped by user.\n");
        }
        //
        //Corellia
        //
        private void corelliaCompleted(object sender, EventArgs e)
        {
            txtCorellia.AppendText("Corellia Crash.\n");
            Thread.Sleep(5000);
            zonecorellia();
        }
        private void corelliaCanceled(object sender, EventArgs e)
        {
            txtCorellia.AppendText("Corellia Stopped by user.\n");
        }
        //
        //Dantooine
        //
        private void dantooineCompleted(object sender, EventArgs e)
        {
            txtDantooine.AppendText("Dantooine Crash.\n");
            Thread.Sleep(5000);
            zonedantooine();
        }
        private void dantooineCanceled(object sender, EventArgs e)
        {
            txtDantooine.AppendText("Dantooine Stopped by user.");
        }
        //
        //Dathomir
        //
        private void dathomirCompleted(object sender, EventArgs e)
        {
            txtDathomir.AppendText("Dantooine Crash.\n");
            Thread.Sleep(5000);
            zonedathomir();
        }
        private void dathomirCanceled(object sender, EventArgs e)
        {
            txtDantooine.AppendText("Dathomir Stopped by user.\n");
        }
        //
        //Endor
        //
        private void endorCompleted(object sender, EventArgs e)
        {
            txtEndor.AppendText("Endor Crash.\n");
            Thread.Sleep(5000);
            zoneendor();
        }
        private void endorCanceled(object sender, EventArgs e)
        {
            txtEndor.AppendText("Endor Stopped by user.\n");
        }
        //
        //Lok
        //
        private void lokCompleted(object sender, EventArgs e)
        {
            txtLok.AppendText("Lok Crash.\n");
            Thread.Sleep(5000);
            zonelok();
        }
        private void lokCanceled(object sender, EventArgs e)
        {
            txtLok.AppendText("Lok Stopped by user.\n");
        }
        //
        //Naboo
        //
        private void nabooCompleted(object sender, EventArgs e)
        {
            txtNaboo.AppendText("Naboo Crash.\n");
            Thread.Sleep(5000);
            zonenaboo();
        }
        private void nabooCanceled(object sender, EventArgs e)
        {
            txtNaboo.AppendText("Naboo Stopped by user.\n");
        }
        //
        //Rori
        //
        private void roriCompleted(object sender, EventArgs e)
        {
            txtRori.AppendText("Rori Crash.\n");
            Thread.Sleep(5000);
            zonerori();
        }
        private void roriCanceled(object sender, EventArgs e)
        {
            txtRori.AppendText("Rori Stopped by user.\n");
        }
        //
        //Talus
        //
        private void talusCompleted(object sender, EventArgs e)
        {
            txtTalus.AppendText("Talus Crash.\n");
            Thread.Sleep(5000);
            zonetalus();
        }
        private void talusCanceled(object sender, EventArgs e)
        {
            txtTalus.AppendText("Talus Stopped by user.\n");
        }
        //
        //Tatooine
        //
        private void tatooineCompleted(object sender, EventArgs e)
        {
            txtTatooine.AppendText("Tatooine Crash.\n");
            Thread.Sleep(5000);
            zonetatooine();
        }
        private void tatooineCanceled(object sender, EventArgs e)
        {
            txtTatooine.AppendText("TAtooine Stopped by user.\n");
        }
        //
        //Yavin 4
        //
        private void yavinCompleted(object sender, EventArgs e)
        {
            txtEndor.AppendText("Yavin 4 Crash.\n");
            Thread.Sleep(5000);
            zoneyavin();
        }
        private void yavinCanceled(object sender, EventArgs e)
        {
            txtYavin.AppendText("Yavin 4 Stopped by user.\n");
        }

        //
        //Process The zoneserver output
        //
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

        private void btnStopTutorial_Click(object sender, EventArgs e)
        {
            tutorialzone.Cancel();
        }

        private void btnCorellia_Click(object sender, EventArgs e)
        {
            zonecorellia();
        }

        private void btnStopDantooine_Click(object sender, EventArgs e)
        {
            dantooinezone.Cancel();
        }

        private void btnStopCorellia_Click(object sender, EventArgs e)
        {
            corelliazone.Cancel();
        }

        private void btnStopDathomir_Click(object sender, EventArgs e)
        {
            dathomirzone.Cancel();
        }

        private void btnStopEndor_Click(object sender, EventArgs e)
        {
            endorzone.Cancel();
        }

        private void btnStopLok_Click(object sender, EventArgs e)
        {
            lokzone.Cancel();
        }

        private void btnStopNaboo_Click(object sender, EventArgs e)
        {
            naboozone.Cancel();
        }

        private void btnStopRori_Click(object sender, EventArgs e)
        {
            rorizone.Cancel();
        }

        private void btnStopTalus_Click(object sender, EventArgs e)
        {
            taluszone.Cancel();
        }

        private void btnStopTatooine_Click(object sender, EventArgs e)
        {
            tatooinezone.Cancel();
        }

        private void btnStopYavin_Click(object sender, EventArgs e)
        {
            yavinzone.Cancel();
        }
    }
}
