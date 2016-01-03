/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 01.01.2016
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace tores
{
	/// <summary>
	/// Description of frmConnect.
	/// </summary>
	public partial class FrmConnect : Form
	{
		
		public string port;
		
		public FrmConnect()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			string[] ports = SerialPort.GetPortNames();
			cmbPorts.Items.Clear();
			foreach(string port in ports){
				
				cmbPorts.Items.Add( new ComboItem( port, port ) );
				
				// Doing it in the loop prevents
				// Exceptions if no ports are
				// found on the machine.
				cmbPorts.SelectedIndex = cmbPorts.Items.Count-1;
				
            }
			
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnConnectClick(object sender, EventArgs e)
		{
			this.port = cmbPorts.SelectedItem.ToString();
			DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
		}

	}
}
