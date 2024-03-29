﻿namespace MyApplication
{
	partial class MainForm
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newUsersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.libraryToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.createResourceToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.searchResourceToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.welcomeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.libraryToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.mainMenuStrip.Size = new System.Drawing.Size(612, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// updateProfileToolStripMenuItem
			// 
			this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
			this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.updateProfileToolStripMenuItem.Text = "&Update Profile";
			this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.UpdateProfileToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.changePasswordToolStripMenuItem.Text = "&Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.logoutToolStripMenuItem.Text = "&Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem,
            this.newUsersListToolStripMenuItem});
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "&Admin";
			// 
			// usersListToolStripMenuItem
			// 
			this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
			this.usersListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.usersListToolStripMenuItem.Text = "&Users List";
			this.usersListToolStripMenuItem.Click += new System.EventHandler(this.UsersListToolStripMenuItem_Click);
			// 
			// newUsersListToolStripMenuItem
			// 
			this.newUsersListToolStripMenuItem.Name = "newUsersListToolStripMenuItem";
			this.newUsersListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.newUsersListToolStripMenuItem.Text = "New Users List";
			this.newUsersListToolStripMenuItem.Click += new System.EventHandler(this.NewUsersListToolStripMenuItem_Click);
			// 
			// libraryToolStripMenuItem
			// 
			this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createResourceToolStripMenuItem,
            this.searchResourceToolStripMenuItem});
			this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
			this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.libraryToolStripMenuItem.Text = "&Library";
			// 
			// createResourceToolStripMenuItem
			// 
			this.createResourceToolStripMenuItem.Name = "createResourceToolStripMenuItem";
			this.createResourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.createResourceToolStripMenuItem.Text = "&Create Resource";
			this.createResourceToolStripMenuItem.Click += new System.EventHandler(this.CreateResourceToolStripMenuItem_Click);
			// 
			// searchResourceToolStripMenuItem
			// 
			this.searchResourceToolStripMenuItem.Name = "searchResourceToolStripMenuItem";
			this.searchResourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.searchResourceToolStripMenuItem.Text = "&Search Resource";
			this.searchResourceToolStripMenuItem.Click += new System.EventHandler(this.SearchResourceToolStripMenuItem_Click);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 239);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.mainStatusStrip.Size = new System.Drawing.Size(612, 22);
			this.mainStatusStrip.TabIndex = 1;
			this.mainStatusStrip.Text = "statusStrip1";
			// 
			// welcomeToolStripStatusLabel
			// 
			this.welcomeToolStripStatusLabel.Name = "welcomeToolStripStatusLabel";
			this.welcomeToolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
			this.welcomeToolStripStatusLabel.Text = "-----";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(612, 261);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Management";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel welcomeToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newUsersListToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem createResourceToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem searchResourceToolStripMenuItem;
	}
}
