/*
 * Crée par SharpDevelop.
 * Utilisateur: magic
 * Date: 22/10/2018
 * Heure: 19:42
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			string[] allLinesPro = File.ReadAllLines(@"lbProtection.txt"); // reads all lines from text file
			lbProtection.Items.AddRange(allLinesPro);
			
			string[] allLinesInfo = File.ReadAllLines(@"lbInfo.txt"); // reads all lines from text file
			lbInfo.Items.AddRange(allLinesInfo);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtActiverClick(object sender, EventArgs e)
		{
			/*Computer computer = new Computer();
			computer.setMail(tbEmail.Text);
			lbProtection.Items.Add(computer.getMail());*/
		}
		
		
			
		
		
		
		
	}
}
