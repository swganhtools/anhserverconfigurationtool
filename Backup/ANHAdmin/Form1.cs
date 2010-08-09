using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ANHAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startWorldServersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmConServers fConServer = new frmConServers();
            fConServer.MdiParent = this;
            fConServer.Show();
            Cursor = Cursors.Default;
        }
    }
}
