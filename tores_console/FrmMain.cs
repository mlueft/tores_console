/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 01.01.2016
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using tores.client;
using System.IO.Ports;

namespace tores
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FrmMain : Form
	{
		
		private Client t;
		
		public FrmMain()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			t = new Client();
			t.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
			t.ErrorOcurred += new ErrorEventHandler(ErrorReceivedHandler);
			t.ConnectionEstablished += new EventHandler(connectionEstablished);
			t.ConnectionClosed += new EventHandler(connectionClosed);
			
			disableGUI();
			
			txtCommand.Focus();
		}
		
		
		void AboutToresToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmAbout frmAbout = new FrmAbout();
			frmAbout.ShowDialog(this);
			frmAbout.Dispose();
		}
		
		void ConfigToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmConnect frmConnect = new FrmConnect();
			if(frmConnect.ShowDialog(this) == DialogResult.OK){

				t.comPort = frmConnect.port;
				t.connect();
				
			}
			frmConnect.Dispose();
		}

		void enableGUI(){
			txtCommand.Enabled = true;
			btnSend.Enabled = true;
			uploadDumpToolStripMenuItem.Enabled = true;
			saveDumpToolStripMenuItem.Enabled = true;
		}

		void disableGUI(){
			txtCommand.Enabled = false;
			btnSend.Enabled = false;
			uploadDumpToolStripMenuItem.Enabled = false;
			saveDumpToolStripMenuItem.Enabled = false;
		}
		
		private void DataReceivedHandler( object sender, SerialDataReceivedEventArgs e){
			
			// TODO: clean that up. 
			// Uff, this is a code smell at its best.
			// We are not at the main thread here.
			// So we can't append test to the text box.
			
	    }

		private void ErrorReceivedHandler( object sender, EventArgs e){
			
			t.disconnect();
			MessageBox.Show("ErrorReceivedHandler");
	        	        
	    }
		
		private void connectionEstablished( object sender, EventArgs e){
			
			enableGUI();
			
		}

		private void connectionClosed( object sender, EventArgs e){
			
			disableGUI();
			MessageBox.Show("connectionClosed");
			
	    }
		
		
		private List<string> history = new List<string>();
		private int hPos = 0;
		void BtnSendClick(object sender = null, EventArgs e = null){
			t.send( txtCommand.Text );
			
			if(history.Count>0)
			history.RemoveAt(0);
			history.Insert(0,txtCommand.Text);
			history.Insert(0,"");
			if(history.Count > 50)
				history = history.GetRange(0,50);
			
			txtCommand.Text = "";
			hPos = 0;
		}
		
		void TxtCommandKeyUp(object sender, KeyEventArgs e){
			
			if( e.KeyCode == Keys.Down && hPos>0)
				hPos--;
			
			if( e.KeyCode == Keys.Up && hPos < history.Count-1)
				hPos++;
			
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down )
				txtCommand.Text = history[hPos];
			
			if(e.KeyCode == Keys.Enter)
				BtnSendClick();
			
		}
		
		void Timer1Tick(object sender, EventArgs e){
				
			if( t != null )
				if( t.isConnected )
				txtLog.AppendText( t.getData() );
			
		}
		
		void UploadDumpToolStripMenuItemClick(object sender, EventArgs e){
			FrmUpload frmUpload = new FrmUpload();
			if(frmUpload.ShowDialog(this) == DialogResult.OK){

				//MessageBox.Show( frmUpload.address.ToString() );
				uploadFile( frmUpload.address, frmUpload.file  );
				
			}
			frmUpload.Dispose();
		}
		
		private void uploadFile(int address, string file ){
			
			byte[] bytes = System.IO.File.ReadAllBytes( file );
			int i = t.writeBytes( address, bytes );
			MessageBox.Show( i.ToString() +" bytes written." );
			
		}
		
		private void SaveDumpToolStripMenuItemClick(object sender, EventArgs e){
			FrmDownload frmDownload = new FrmDownload();
			if(frmDownload.ShowDialog(this) == DialogResult.OK){
				
				timer1.Enabled = false;
				byte[] dump = t.readBytes( frmDownload.address, frmDownload.size );
				System.IO.File.WriteAllBytes( "dump.dat", dump );
				timer1.Enabled = true;
				
			}
			frmDownload.Dispose();
		}
		
	}
}
