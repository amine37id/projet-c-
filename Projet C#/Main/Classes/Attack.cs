/*
 * Crée par SharpDevelop.
 * Utilisateur: magic
 * Date: 22/10/2018
 * Heure: 19:44
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;

namespace Main
{
	/// <summary>
	/// Description of Attack.
	/// </summary>
	public abstract class Attack
	{
		private abstract string name;
		protected List<Attacker> dataAttacker;
	
		
		public Attack() //Constructeur
		{
		}
		
		public abstract void analyze(string fichier);
		public abstract void makeReport();
		
		public void alert(){
			
		}
		
		public void showReport(){
			
		}
		
	}
}
