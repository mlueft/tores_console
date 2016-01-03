/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 01.01.2016
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tores
{
	partial class FrmMain
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.ToolStripMenuItem ffileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uploadDumpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToresToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem saveDumpToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ffileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uploadDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ffileToolStripMenuItem,
			this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(640, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ffileToolStripMenuItem
			// 
			this.ffileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.configToolStripMenuItem,
			this.uploadDumpToolStripMenuItem,
			this.saveDumpToolStripMenuItem});
			this.ffileToolStripMenuItem.Name = "ffileToolStripMenuItem";
			this.ffileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.ffileToolStripMenuItem.Text = "File";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.configToolStripMenuItem.Text = "connect";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItemClick);
			// 
			// uploadDumpToolStripMenuItem
			// 
			this.uploadDumpToolStripMenuItem.Name = "uploadDumpToolStripMenuItem";
			this.uploadDumpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.uploadDumpToolStripMenuItem.Text = "upload dump";
			this.uploadDumpToolStripMenuItem.Click += new System.EventHandler(this.UploadDumpToolStripMenuItemClick);
			// 
			// saveDumpToolStripMenuItem
			// 
			this.saveDumpToolStripMenuItem.Name = "saveDumpToolStripMenuItem";
			this.saveDumpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveDumpToolStripMenuItem.Text = "save dump";
			this.saveDumpToolStripMenuItem.Click += new System.EventHandler(this.SaveDumpToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToresToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// aboutToresToolStripMenuItem
			// 
			this.aboutToresToolStripMenuItem.Name = "aboutToresToolStripMenuItem";
			this.aboutToresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.aboutToresToolStripMenuItem.Text = "about Tores";
			this.aboutToresToolStripMenuItem.Click += new System.EventHandler(this.AboutToresToolStripMenuItemClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtLog);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(640, 388);
			this.panel1.TabIndex = 1;
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.SystemColors.Window;
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Font = new System.Drawing.Font("Courier New", 10F);
			this.txtLog.Location = new System.Drawing.Point(0, 28);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(640, 360);
			this.txtLog.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtCommand);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(640, 28);
			this.panel2.TabIndex = 0;
			// 
			// txtCommand
			// 
			this.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCommand.Location = new System.Drawing.Point(0, 0);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(529, 20);
			this.txtCommand.TabIndex = 1;
			this.txtCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCommandKeyUp);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSend);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(529, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(111, 28);
			this.panel3.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(3, 0);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(108, 21);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSendClick);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 412);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(100, 100);
			this.Name = "FrmMain";
			this.Text = "Tores - Serial console";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
