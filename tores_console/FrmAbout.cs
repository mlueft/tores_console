/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 01.01.2016
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tores
{
	/// <summary>
	/// Description of frmAbout.
	/// </summary>
	public partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
