namespace ANHAdmin
{
    partial class frmAccounts
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPassUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdatePass = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtChars = new System.Windows.Forms.TextBox();
            this.txtBanned = new System.Windows.Forms.TextBox();
            this.txtCSR = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvAccounts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatePass = new System.Windows.Forms.TextBox();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPassUpdate);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtUpdatePass);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.txtChars);
            this.tabPage1.Controls.Add(this.txtBanned);
            this.tabPage1.Controls.Add(this.txtCSR);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lsvAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit Accounts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPassUpdate
            // 
            this.btnPassUpdate.Location = new System.Drawing.Point(170, 215);
            this.btnPassUpdate.Name = "btnPassUpdate";
            this.btnPassUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnPassUpdate.TabIndex = 17;
            this.btnPassUpdate.Text = "Update Password";
            this.btnPassUpdate.UseVisualStyleBackColor = true;
            this.btnPassUpdate.Click += new System.EventHandler(this.btnPassUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Change Password";
            // 
            // txtUpdatePass
            // 
            this.txtUpdatePass.Location = new System.Drawing.Point(197, 190);
            this.txtUpdatePass.Name = "txtUpdatePass";
            this.txtUpdatePass.Size = new System.Drawing.Size(201, 20);
            this.txtUpdatePass.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(273, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Account";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "# of Chars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Banned";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CSR?";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(134, 33);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(32, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Email";
            // 
            // txtChars
            // 
            this.txtChars.Location = new System.Drawing.Point(197, 111);
            this.txtChars.Name = "txtChars";
            this.txtChars.Size = new System.Drawing.Size(201, 20);
            this.txtChars.TabIndex = 6;
            // 
            // txtBanned
            // 
            this.txtBanned.Location = new System.Drawing.Point(197, 85);
            this.txtBanned.Name = "txtBanned";
            this.txtBanned.Size = new System.Drawing.Size(201, 20);
            this.txtBanned.TabIndex = 5;
            // 
            // txtCSR
            // 
            this.txtCSR.Location = new System.Drawing.Point(197, 59);
            this.txtCSR.Name = "txtCSR";
            this.txtCSR.Size = new System.Drawing.Size(201, 20);
            this.txtCSR.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(197, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // lsvAccounts
            // 
            this.lsvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lsvAccounts.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvAccounts.GridLines = true;
            this.lsvAccounts.Location = new System.Drawing.Point(7, 7);
            this.lsvAccounts.Name = "lsvAccounts";
            this.lsvAccounts.Size = new System.Drawing.Size(121, 180);
            this.lsvAccounts.TabIndex = 0;
            this.lsvAccounts.UseCompatibleStateImageBehavior = false;
            this.lsvAccounts.View = System.Windows.Forms.View.Details;
            this.lsvAccounts.DoubleClick += new System.EventHandler(this.lsvAccounts_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Acct. Name";
            this.columnHeader1.Width = 115;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCreatePass);
            this.tabPage2.Controls.Add(this.txtCreateEmail);
            this.tabPage2.Controls.Add(this.txtCreateUser);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(121, 85);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(179, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create New Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Location = new System.Drawing.Point(69, 59);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(201, 20);
            this.txtCreatePass.TabIndex = 12;
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(69, 33);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(201, 20);
            this.txtCreateEmail.TabIndex = 11;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(69, 7);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(201, 20);
            this.txtCreateUser.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "UserName";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.deleteMemberToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 273);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAccounts";
            this.Text = "SWG:ANH Account Manager";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lsvAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtChars;
        private System.Windows.Forms.TextBox txtBanned;
        private System.Windows.Forms.TextBox txtCSR;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreatePass;
        private System.Windows.Forms.TextBox txtCreateEmail;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPassUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdatePass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
    }
}