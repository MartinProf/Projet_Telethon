using BiblioTelethon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TelethonNew
{
	internal static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());


		}

		public static List<Donateur> lesDonateurs = new List<Donateur>();
		public static List<Commanditaire> lesCommanditaires = new List<Commanditaire>();
		public static List<Don> lesDons = new List<Don>();
		public static List<Prix> lesPrix = new List<Prix>();
		public static GestionnaireSTE gestionnaire = new GestionnaireSTE(lesDonateurs, lesCommanditaires, lesDons, lesPrix);


	}
}
