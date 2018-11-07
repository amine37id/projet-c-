/*
 * Created by SharpDevelop.
 * User: VmWindows
 * Date: 31/10/2018
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Main
{
	/// <summary>
	/// Description of Computer.
	/// </summary>
	public class Computer
	{
		private string mac;
		private string ip;
		private int interfa;
		private string mail;
		
		public Computer() //Constructeur
		{
		}
		
		/*public string [] getDatas(){
			
		}*/
		
		
		//Setter & getter
		public string getMac(){
			return this.mac;
		}
		
		public void setMac(string mac){
			this.mac = mac;
		}
		
		public string getIp(){
			return this.ip;
		}
		
		public void setIp(string ip){
			this.ip=ip;
		}
		
		public int getInterfa(){
			return this.interfa;
		}
		
		public void setInterfa(int interfa){
			this.interfa=interfa;
		}
		
		public string getMail(){
			return this.mail;
		}
		
		public void setMail(string mail){
			this.mail=mail;
		}
		
	}
}