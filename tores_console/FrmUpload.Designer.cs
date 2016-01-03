/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 02.01.2016
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tores
{
	partial class FrmUpload
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(398, 7);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(73, 53);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(250, 7);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(142, 53);
			this.btnUpload.TabIndex = 2;
			this.btnUpload.Text = "upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.BtnUploadClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Select the file to upload:";
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(160, 7);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(75, 23);
			this.btnFile.TabIndex = 5;
			this.btnFile.Text = "...";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.BtnFileClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Define the device address:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(160, 40);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(75, 20);
			this.txtAddress.TabIndex = 7;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FrmUpload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 70);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpload);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmUpload";
			this.Text = "Tores - upload file";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
