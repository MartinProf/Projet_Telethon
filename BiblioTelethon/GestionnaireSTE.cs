using System;
using System.Collections.Generic;

namespace BiblioTelethon
{
	public class GestionnaireSTE
	{
		private int cntDonateurs = 0;
		private int cntComm = 0;
		private int cntPrix = 0;
		private int cntDons = 0;

		string nvLigne = Environment.NewLine;

		private List<Donateur> lesDonateurs = new List<Donateur>();
		private List<Commanditaire> lesCommanditaires = new List<Commanditaire>();
		private List<Don> lesDons = new List<Don>();
		private List<Prix> lesPrix = new List<Prix>();

		public GestionnaireSTE(List<Donateur> lesDonateurs, List<Commanditaire> lesCommanditaires, List<Don> lesDons, List<Prix> lesPrix)
		{
			this.lesDonateurs = lesDonateurs;
			this.lesCommanditaires = lesCommanditaires;
			this.lesDons = lesDons;
			this.lesPrix = lesPrix;
			initListeCommanditaires();
			initListeDonateurs();
			initListeDons();
			initListePrix();
		}

		#region Initialisation des listes
		public void initListeCommanditaires()
		{
			Commanditaire commanditaire1 = new Commanditaire(++cntComm, "George", "Orwell");
			lesCommanditaires.Add(commanditaire1);
			Commanditaire commanditaire2 = new Commanditaire(++cntComm, "Georg Wilhelm Friedrich", "Hegel");
			lesCommanditaires.Add(commanditaire2);
			Commanditaire commanditaire3 = new Commanditaire(++cntComm, "Jean-Paul", "Sartre");
			lesCommanditaires.Add(commanditaire3);
			Commanditaire commanditaire4 = new Commanditaire(++cntComm, "Baruch", "Spinoza");
			lesCommanditaires.Add(commanditaire4);
			Commanditaire commanditaire5 = new Commanditaire(++cntComm, "Adam", "Smith");
			lesCommanditaires.Add(commanditaire5);
			Commanditaire commanditaire6 = new Commanditaire(++cntComm, "Karl", "Marx");
			lesCommanditaires.Add(commanditaire6);
		}
		public void initListeDonateurs()
		{
			Donateur donateur1 = new Donateur(++cntDonateurs, "Bob", "Russ", "75 rue des Pruniers", "(111)789-9876", "M", "7896 1111 0123 0123", "01-01-2023", 99555.25);
			lesDonateurs.Add(donateur1);
			Donateur donateur2 = new Donateur(++cntDonateurs, "Bobby", "Luppo", "25 rue des Ananas", "(222)987-9876", "V", "7896 5432 1478 0123", "01-01-2021", 1555.25);
			lesDonateurs.Add(donateur2);
			Donateur donateur3 = new Donateur(++cntDonateurs, "Robert", "Langdon", "55 rue des Cerises", "(333)789-1111", "M", "0000 5432 0123 0123", "01-01-2022", 10055.25);
			lesDonateurs.Add(donateur3);
			Donateur donateur4 = new Donateur(++cntDonateurs, "Luc", "Skywalker", "65 rue des Palourdes", "(444)789-2226", "V", "7846 5432 0123 0123", "01-11-2022", 555);
			lesDonateurs.Add(donateur4);
			Donateur donateur5 = new Donateur(++cntDonateurs, "Yada", "Misere", "95 rue des Bananes", "(555)789-9333", "M", "7896 5488 0123 0123", "31-12-2024", 8555.25);
			lesDonateurs.Add(donateur5);
			Donateur donateur6 = new Donateur(++cntDonateurs, "Vador", "Mire", "15 rue des Oranges", "(666)789-9555", "V", "7896 5432 0999 0123", "61-61-2022", 25555.25);
			lesDonateurs.Add(donateur6);
		}

		public void initListeDons()
		{
			Don don1 = new Don(++cntDons, 1, "06-01-2022", 555.25);
			lesDons.Add(don1);
			Don don2 = new Don(++cntDons, 2, "06-01-2022", 1555.25);
			lesDons.Add(don2);
			Don don3 = new Don(++cntDons, 3, "06-01-2022", 55.25);
			lesDons.Add(don3);
			Don don4 = new Don(++cntDons, 4, "06-01-2022", 555);
			lesDons.Add(don4);
			Don don5 = new Don(++cntDons, 5, "06-01-2022", 8555.25);
			lesDons.Add(don5);
			Don don6 = new Don(++cntDons, 6, "06-01-2022", 25555.25);
			lesDons.Add(don6);
		}
		public void initListePrix()
		{
			Prix prix1 = new Prix(++cntPrix, 1, "Calendrier", 5.95, 25);
			lesPrix.Add(prix1);
			Prix prix2 = new Prix(++cntPrix, 2, "Repas familial", 45.95, 15);
			lesPrix.Add(prix2);
			Prix prix3 = new Prix(++cntPrix, 3, "Barbecue", 575.00, 5);
			lesPrix.Add(prix3);
			Prix prix4 = new Prix(++cntPrix, 4, "Téléviseur", 1722.15, 5);
			lesPrix.Add(prix4);
			Prix prix5 = new Prix(++cntPrix, 5, "Téléviseur", 1722.15, 2);
			lesPrix.Add(prix5);
			Prix prix6 = new Prix(++cntPrix, 6, "Barbecue", 575.00, 5);
			lesPrix.Add(prix6);
		}

		#endregion

		#region GETTERS et SETTERS

		public List<Donateur> Donateurs { get { return lesDonateurs; } set { lesDonateurs = value; } }
		public List<Commanditaire> Commanditaires { get { return lesCommanditaires; } set { lesCommanditaires = value; } }
		public List<Don> Dons { get { return lesDons; } set { lesDons = value; } }
		public List<Prix> Prix { get { return lesPrix; } set { lesPrix = value; } }

		public int CntDonateurs { get { return cntDonateurs; } }
		public int CntComm { get { return cntComm; } }
		public int CntDons { get { return cntDons; } }
		public int CntPrix { get { return cntPrix; } }
		#endregion


		#region Methodes AFFICHER
		public string AfficherDonateurs()
		{
			string lstDonatrsAffiche = "";
			foreach (Donateur donateur in lesDonateurs)
			{
				lstDonatrsAffiche += donateur + nvLigne;
			}
			return lstDonatrsAffiche;
		}

		public string AfficherComms()
		{
			string lstCommsAffiche = "";
			foreach (Commanditaire commanditaire in lesCommanditaires)
			{
				lstCommsAffiche += commanditaire + nvLigne;
			}
			return lstCommsAffiche;
		}

		public string AfficherPrix()
		{

			string lstPrixAffiche = "";
			foreach (Prix prix in lesPrix)
			{
				lstPrixAffiche += prix + nvLigne;
			}
			return lstPrixAffiche;
		}

		public string AfficherDons()
		{

			string lstDonsAffiche = "";
			foreach (Don don in lesDons)
			{
				lstDonsAffiche += don + nvLigne;
			}
			return lstDonsAffiche;
		}

		public string[] AfficherTelephone()
		{

			string[] listeTelephone = new string[lesDonateurs.Count];
			for (int i = 0; i < lesDonateurs.Count; i++)
			{
				listeTelephone[i] = lesDonateurs[i].Telephone;

			}
			return listeTelephone;
		}

		#endregion

		#region Methodes AJOUTER

		public void AjouterDonateur(Donateur donateur)
		{
			donateur.IdDonateur = ++cntDonateurs;
			lesDonateurs.Add(donateur);
		}

		public void AjouterCommanditaire(Commanditaire commanditaire)
		{
			commanditaire.IdCommanditaire = ++cntComm;
			lesCommanditaires.Add(commanditaire);
		}

		public void AjouterPrix(Prix prix)
		{
			prix.IdPrix = ++cntPrix;

			lesPrix.Add(prix);
		}

		public void AjouterDon(Don don)
		{
			don.IDDon = ++cntDons;
			lesDons.Add(don);
			lesDonateurs[don.IDDonateur].TotalDonsDonateur += don.MontantDuDon;

		}

		#endregion

		public Donateur TrouverDonateur(string telephone)
		{
			int IDdonateurTrouve = 0;

			for (int i = 0; i < lesDonateurs.Count; i++)
			{
				if (lesDonateurs[i].Telephone == telephone)
				{
					IDdonateurTrouve = i;
				}
			}

			return lesDonateurs[IDdonateurTrouve];
		}

		#region SYSTEME D'ATTRIBUTION DES PRIX
		public int CompterPoints(double MontantDuDon, int IDDonateur)
		{
			int nbPoints = 0;
			long tranches500;

			foreach (Donateur donateur in lesDonateurs)
			{
				if (IDDonateur == donateur.IdDonateur)
				{

					if (MontantDuDon >= 500)
					{
						MontantDuDon -= 500;
						tranches500 = Convert.ToInt64(MontantDuDon / 500);
						nbPoints = Convert.ToInt32(tranches500 * 4);
						nbPoints += 5;

					}
					else if (MontantDuDon < 500 && MontantDuDon >= 350)
					{
						nbPoints += 3;
					}
					else if (MontantDuDon < 350 && MontantDuDon >= 200)
					{
						nbPoints += 2;
					}
					else if (MontantDuDon < 200 && MontantDuDon >= 50)
					{
						nbPoints += 1;
					}
					else nbPoints = 0;

				}
			}

			return nbPoints;
		}

		public string AttribuerPrix(int idDonateur, double totalPoints)
		{
			string prixAttribue = "";


			foreach (Donateur donateur in lesDonateurs)
			{

				if (idDonateur == donateur.IdDonateur)
				{

					if (totalPoints > 0 && totalPoints < 10)
					{
						prixAttribue = "Calendrier";
					}
					else if (totalPoints >= 10 && totalPoints < 15)
					{
						prixAttribue = "Repas familial";
					}
					else if (totalPoints >= 15 && totalPoints < 20)
					{
						prixAttribue = "BBQ";
					}
					else if (totalPoints >= 20)
					{
						prixAttribue = "Téléviseur"; ;
					}
				}

			}
			return prixAttribue;
		}

		#endregion

		public string top3Donateurs()
		{

			string aAfficher = "";
			double sommeTop1 = 0;
			double sommeTop2 = 0;
			double sommeTop3 = 0;
			string prenomTop1 = "";
			string prenomTop2 = "";
			string prenomTop3 = "";

			for (int i = 0; i < lesDonateurs.Count; i++)
			{
				if (lesDonateurs[i].TotalDonsDonateur > sommeTop1)
				{
					sommeTop1 = lesDonateurs[i].TotalDonsDonateur;
					prenomTop1 = lesDonateurs[i].Prenom;

					for (int j = 0; j < lesDonateurs.Count; j++)
						if (lesDonateurs[j].TotalDonsDonateur > sommeTop2 && lesDonateurs[j].TotalDonsDonateur < sommeTop1)
						{
							sommeTop2 = lesDonateurs[j].TotalDonsDonateur;
							prenomTop2 = lesDonateurs[j].Prenom;

							for (int k = 0; k < lesDonateurs.Count; k++)
								if (lesDonateurs[k].TotalDonsDonateur > sommeTop3 && lesDonateurs[k].TotalDonsDonateur < sommeTop2)
								{
									sommeTop3 = lesDonateurs[k].TotalDonsDonateur;
									prenomTop3 = lesDonateurs[k].Prenom;
								}
						}
				}

			}

			var numOne = char.ConvertFromUtf32(0x1F947);
			var numTwo = char.ConvertFromUtf32(0x1F948);
			var numThree = char.ConvertFromUtf32(0x1F949);

			aAfficher += numOne + prenomTop1 + " " + sommeTop1 + Environment.NewLine;
			aAfficher += numTwo + prenomTop2 + " " + sommeTop2 + Environment.NewLine;
			aAfficher += numThree + prenomTop3 + " " + sommeTop3 + Environment.NewLine;

			return aAfficher;
		}

		public string top3Commanditaire()
		{
			string prenomTop1 = "";
			string prenomTop2 = "";
			string prenomTop3 = "";

			double sommeTop1 = 0;
			double sommeTop2 = 0;
			double sommeTop3 = 0;

			string aAfficher = "";

			for (int i = 0; i < lesCommanditaires.Count; i++)
			{
				int idCommenditaire = lesCommanditaires[i].IdCommanditaire;
				string prenomCommenditaire = lesCommanditaires[i].Prenom + " " + lesCommanditaires[i].Nom;
				double sommes = 0;

				for (int j = 0; j < lesPrix.Count; j++)
				{
					if (idCommenditaire == lesPrix[j].IdCommanditaire)
					{
						sommes += lesPrix[j].Valeur * lesPrix[j].Quantite;
					}

					if (sommes > sommeTop1)
					{
						sommeTop3 = sommeTop2;
						prenomTop3 = prenomTop2;
						sommeTop2 = sommeTop1;
						prenomTop2 = prenomTop1;
						sommeTop1 = sommes;
						prenomTop1 = prenomCommenditaire;
						break;
					}
					else if (sommes > sommeTop2)
					{
						sommeTop3 = sommeTop2;
						prenomTop3 = prenomTop2;
						sommeTop2 = sommes;
						prenomTop2 = prenomCommenditaire;
						break;
					}
					else if (sommes > sommeTop3)
					{
						sommeTop3 = sommes;
						prenomTop3 = prenomCommenditaire;
						break;
					}
					else { }
				}
			}

			var numOne = char.ConvertFromUtf32(0x1F947);
			var numTwo = char.ConvertFromUtf32(0x1F948);
			var numThree = char.ConvertFromUtf32(0x1F949);


			aAfficher += numOne + prenomTop1 + " " + sommeTop1 + Environment.NewLine;
			aAfficher += numTwo + prenomTop2 + " " + sommeTop2 + Environment.NewLine;
			aAfficher += numThree + prenomTop3 + " " + sommeTop3 + Environment.NewLine;

			return aAfficher;
		}

	}
}
