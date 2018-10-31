/*
 * Created by SharpDevelop.
 * User: VmWindows
 * Date: 31/10/2018
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Main.Classes
{
	/// <summary>
	/// Description of Attacker.
	/// </summary>
	public class Attacker
	{
		private string ip;
		private string mac;
		private string hourAttack;
		private string localisation;
		
		
		public Attacker() //Constructeur
		{
		}
		
		/*public string geolocalize(string ip){
			
		}*/
		
		//Getter & Setter
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
		
		public string gethourAttack(){
			return this.hourAttack;
		}
		
		public void sethourAttack(string hourAttack){
			this.hourAttack=hourAttack;
		}
		
		public string getlocalisation(){
			return this.localisation;
		}
		
		public void setlocalisation(string localisation){
			this.localisation=localisation;
		}
		
	}
}