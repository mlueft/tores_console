/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 02.01.2016
 * Time: 10:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tores
{
	/// <summary>
	/// Description of FrmDownload.
	/// </summary>
	public partial class FrmDownload : Form{
		
		public int address;
		public int size;
		
		public FrmDownload(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCancelClick(object sender, EventArgs e){
			this.Close();
		}
		
		void BtnDownloadClick(object sender, EventArgs e){
			
			if( txtAddress.Text.Trim() == ""){
				MessageBox.Show( "Please define an address." );
				return;
			}
			
			if( txtQtyBytes.Text.Trim() == ""){
				MessageBox.Show( "Please define the number of bytes." );
				return;
			}
			
			address = Convert.ToInt16(txtAddress.Text);
			size = Convert.ToInt16(txtQtyBytes.Text);
			
			DialogResult = System.Windows.Forms.DialogResult.OK;
			
			this.Close();
		}
		
		
	}
}
