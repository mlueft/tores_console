/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 02.01.2016
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tores
{
	/// <summary>
	/// Description of FrmUpload.
	/// </summary>
	public partial class FrmUpload : Form
	{
		public string file;
		public int address;
		
		public FrmUpload()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		
		void BtnFileClick(object sender, EventArgs e){
			
			if( openFileDialog1.ShowDialog() == DialogResult.OK ){
					file = openFileDialog1.FileName;
			}
	
		}
		
		void BtnCancelClick(object sender, EventArgs e){
			this.Close();
		}
		
		void BtnUploadClick(object sender, EventArgs e){
			
			if( txtAddress.Text.Trim() == ""){
				MessageBox.Show( "Please define an address." );
				return;
			}
				
			if( file.Trim() == ""){
				MessageBox.Show( "Please select a file." );
				return;
			}
			
			address = Convert.ToInt16(txtAddress.Text);
			
			if( MessageBox.Show("Are you sure? This can harm your device!","upload data",MessageBoxButtons.YesNo) == DialogResult.Yes )
				DialogResult = System.Windows.Forms.DialogResult.OK;
			
            Close();
		}
	}
}
