namespace ANHAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameplayConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWorldServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsAndCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serverConfigurationToolStripMenuItem,
            this.serverManagementToolStripMenuItem,
            this.accountsAndCharactersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // serverConfigurationToolStripMenuItem
            // 
            this.serverConfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalConfigToolStripMenuItem,
            this.gameplayConfigToolStripMenuItem,
            this.zoneConfigToolStripMenuItem});
            this.serverConfigurationToolStripMenuItem.Name = "serverConfigurationToolStripMenuItem";
            this.serverConfigurationToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.serverConfigurationToolStripMenuItem.Text = "Server Configuration";
            // 
            // globalConfigToolStripMenuItem
            // 
            this.globalConfigToolStripMenuItem.Name = "globalConfigToolStripMenuItem";
            this.globalConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.globalConfigToolStripMenuItem.Text = "Global Config";
            // 
            // gameplayConfigToolStripMenuItem
            // 
            this.gameplayConfigToolStripMenuItem.Name = "gameplayConfigToolStripMenuItem";
            this.gameplayConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gameplayConfigToolStripMenuItem.Text = "Gameplay Config";
            // 
            // zoneConfigToolStripMenuItem
            // 
            this.zoneConfigToolStripMenuItem.Name = "zoneConfigToolStripMenuItem";
            this.zoneConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoneConfigToolStripMenuItem.Text = "Zone Config";
            // 
            // serverManagementToolStripMenuItem
            // 
            this.serverManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWorldServersToolStripMenuItem,
            this.startZonesToolStripMenuItem});
            this.serverManagementToolStripMenuItem.Name = "serverManagementToolStripMenuItem";
            this.serverManagementToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.serverManagementToolStripMenuItem.Text = "Server Management";
            // 
            // startWorldServersToolStripMenuItem
            // 
            this.startWorldServersToolStripMenuItem.Name = "startWorldServersToolStripMenuItem";
            this.startWorldServersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.startWorldServersToolStripMenuItem.Text = "Start World Servers";
            this.startWorldServersToolStripMenuItem.Click += new System.EventHandler(this.startWorldServersToolStripMenuItem_Click);
            // 
            // startZonesToolStripMenuItem
            // 
            this.startZonesToolStripMenuItem.Name = "startZonesToolStripMenuItem";
            this.startZonesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.startZonesToolStripMenuItem.Text = "Start Zones";
            // 
            // accountsAndCharactersToolStripMenuItem
            // 
            this.accountsAndCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountManagerToolStripMenuItem,
            this.characterManagerToolStripMenuItem});
            this.accountsAndCharactersToolStripMenuItem.Name = "accountsAndCharactersToolStripMenuItem";
            this.accountsAndCharactersToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.accountsAndCharactersToolStripMenuItem.Text = "Accounts And Characters";
            // 
            // accountManagerToolStripMenuItem
            // 
            this.accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            this.accountManagerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.accountManagerToolStripMenuItem.Text = "Account Manager";
            // 
            // characterManagerToolStripMenuItem
            // 
            this.characterManagerToolStripMenuItem.Name = "characterManagerToolStripMenuItem";
            this.characterManagerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.characterManagerToolStripMenuItem.Text = "Character Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 482);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameplayConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWorldServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startZonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsAndCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterManagerToolStripMenuItem;
    }
}

