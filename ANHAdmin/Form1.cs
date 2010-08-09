using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBI;
using DBI.MySQL;
using Utilities;
using MySql.Data.MySqlClient;

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

        private void startZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmZones fZone = new frmZones();
            fZone.MdiParent = this;
            fZone.Show();
            Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //MySQLRunner.ConnectionString = clsDBStrings.maindbcon;
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmDBConfig fDB = new frmDBConfig();
            fDB.MdiParent = this;
            fDB.Show();
            Cursor = Cursors.Default;
        }

        private void accountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmAccounts fAccounts = new frmAccounts();
            fAccounts.MdiParent = this;
            fAccounts.Show();
            Cursor = Cursors.Default;
        }
    }
}
