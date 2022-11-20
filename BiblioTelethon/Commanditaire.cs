namespace BiblioTelethon
{
	public class Commanditaire : Personne
	{
		private int idCommanditaire;

		public Commanditaire(int idCommanditaire, string prenom, string nom) : base(prenom, nom)
		{
			this.Prenom = prenom;
			this.Nom = nom;
			this.idCommanditaire = idCommanditaire;
		}

		public Commanditaire() { }

		public int IdCommanditaire { get { return idCommanditaire; } set { idCommanditaire = value; } }

		public override string ToString()
		{
			return "Nom : " + Nom + ", prénom : " + Prenom + ", id : " + idCommanditaire;
		}

	}
}
