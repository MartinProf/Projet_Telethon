namespace BiblioTelethon
{
	public abstract class Personne
	{
		private string prenom;
		private string nom;

		public Personne(string prenom, string nom)
		{
			this.prenom = prenom;
			this.nom = nom;
		}
		public Personne() { }

		public string Prenom { get { return prenom; } set { prenom = value; } }

		public string Nom { get { return nom; } set { nom = value; } }

		public override string ToString()
		{
			return "Prénom : " + prenom + ", nom : " + nom;
		}
	}
}
