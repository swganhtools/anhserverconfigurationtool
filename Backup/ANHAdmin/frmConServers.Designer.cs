namespace ANHAdmin
{
    partial class frmConServers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPing = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.StartServers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(6, 7);
            this.txtConnection.Multiline = true;
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(617, 419);
            this.txtConnection.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtChat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(6, 7);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(617, 419);
            this.txtChat.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPing);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(629, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ping Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPing
            // 
            this.txtPing.Location = new System.Drawing.Point(6, 7);
            this.txtPing.Multiline = true;
            this.txtPing.Name = "txtPing";
            this.txtPing.Size = new System.Drawing.Size(617, 419);
            this.txtPing.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtLogin);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(629, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Login Server";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 7);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(617, 419);
            this.txtLogin.TabIndex = 1;
            // 
            // StartServers
            // 
            this.StartServers.Location = new System.Drawing.Point(647, 51);
            this.StartServers.Name = "StartServers";
            this.StartServers.Size = new System.Drawing.Size(75, 23);
            this.StartServers.TabIndex = 1;
            this.StartServers.Text = "button1";
            this.StartServers.UseVisualStyleBackColor = true;
            this.StartServers.Click += new System.EventHandler(this.StartServers_Click);
            // 
            // frmConServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 486);
            this.Controls.Add(this.StartServers);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConServers";
            this.Text = "frmConServers";
            this.Load += new System.EventHandler(this.frmConServers_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConServers_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtPing;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button StartServers;
    }
}