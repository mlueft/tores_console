/*
 * Created by SharpDevelop.
 * User: Michael Lueftenegger, www.lueftenegger.at
 * Date: 01.05.2014
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tores
{
	/// <summary>
	/// Description of ComboItem.
	/// </summary>
	public class ComboItem{
		
		public ComboItem(string name, string value){
			Name = name;
			Value = value;
		}
		
		private string name;
		public string Name {
			set{ name = value;}
			get{ return name;}
		}
     	
		private string _value;
		public string Value {
			set{ _value = value;}
			get{ return _value;}
		}
     	
		public override string ToString(){
			return this.Name;
		}
	}
}
