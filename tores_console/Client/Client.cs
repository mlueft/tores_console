/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 01.01.2016
 * Time: 15:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO.Ports;
using System.Threading.Tasks;

	
namespace tores.client
{
	
	public delegate void ErrorEventHandler(object sender, EventArgs e);
	
	/// <summary>
	/// Description of Toner.
	/// </summary>
	public class Client
	{
		
		private SerialPort port;
		
		private string _comPort = "COM3";
		public string comPort{
			set{ _comPort = value; }
			get{ return _comPort; }
		}
		
		private int _speed = 9600;
		public int  speed{
			set{ _speed = value; }
			get{ return _speed; }
		}
		
		private int _serialDelay = 250;
		public int serialDelay{
			set{ _serialDelay = value; }
			get{ return _serialDelay; }
		}
		
		private int _errorTimeout = 30;
		public int errorTimeout{
			set{ _errorTimeout = value;}
			get{ return _errorTimeout; }
		}
		
		public event ErrorEventHandler ErrorOcurred;
		protected virtual void OnErrorOccured( EventArgs e ) {
			if (ErrorOcurred != null)ErrorOcurred(this, e);
		}
		
		public event EventHandler ConnectionEstablished;
		protected virtual void OnConnectionEstablished(EventArgs e) {
			if (ConnectionEstablished != null)ConnectionEstablished(this, e);
		}
		
		public event EventHandler ConnectionClosed;
		protected virtual void OnConnectionClosed(EventArgs e) {
			if (ConnectionClosed != null)ConnectionClosed(this, e);
		}
		
		public event SerialDataReceivedEventHandler DataReceived;
		protected virtual void OnDataReceived(SerialDataReceivedEventArgs e) {
			if (DataReceived != null)DataReceived(this, e);
		}
		
		private void DataReceivedHandler( object sender, SerialDataReceivedEventArgs e){
			
			OnDataReceived( e );
	        	        
	    }

		private void ErrorReceivedHandler( object sender, SerialErrorReceivedEventArgs e){
			
			OnErrorOccured( e );
	        	        
	    }
		
		public Client()
		{
			
		}
		
		public bool connect(){
			try{
				
				if( port != null ){
					// TODO: do some cleanup with old port.
					
				}
				
				port = new SerialPort(comPort, speed);
				port.DataReceived  += new SerialDataReceivedEventHandler(DataReceivedHandler);
				port.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorReceivedHandler);
				port.Open();
				
				OnConnectionEstablished( new EventArgs( ) );
			}catch(Exception ){
				OnErrorOccured( new EventArgs() );
				return false;
			}
			return true;
		}
		
		public void disconnect(){
			try{
				
				if(port!=null)
					port.Close();
				OnConnectionClosed( new EventArgs( ) );
				
			}catch(Exception ){
				OnErrorOccured( new EventArgs( ) );
			}
		}
		
		public bool isConnected{
			get{
				if(port == null)
					return false;
				return port.IsOpen;
			}
		}
		
		public void send(string data){
			// TODO: It's a bad idea to manipulate 
			// data. Not every user is expecting it
			// when using the console for an other 
			// project!
			//
			// But it's needed when uploading a dump file
			// This way the arduino scetch recognizes
			// the end of an write command.
			port.Write( data + (char)0x00 );
		}
		
		public int writeBytes(int address, byte[] bytes){
			
			int i = 0;
			for( ; i < bytes.Length; i++){
				string command = "write "+ address.ToString() +" "+ i.ToString() +" "+ bytes[i];
				send( command );
				System.Threading.Thread.Sleep(50);
			}
			return i;
			
		}
		
		public byte[] readBytes(int address, int size){
			
			send( "read "+ address.ToString() +" "+ size );

			while( port.BytesToRead == 0 ){
				// TODO: trigger a time out if needed
			}
			
			byte[] result = new byte[ size ];
			int i = 0;
			
			while(true){
				
				while( port.BytesToRead > 0 ){
					result[i++] = (byte)port.ReadByte();
				}
				
				if(i == size)
					break;
				// TODO: trigger a time out if needed
			}
			
			return result;
		}
		
		public string getData(){
			
			return port.ReadExisting();
		}
		
	}
}
