namespace BiblioTelethon
{
	public class Donateur : Personne
	{
		private int idDonateur;
		private string email;
		private string telephone;
		private string typeDeCarte;
		private string numeroDeCarte;
		private string dateExpiration;
		private double totalDonsDonateur;

		public Donateur(int idDonateur, string prenom, string nom, string email, string telephone, string typeDeCarte, string numeroDeCarte, string dateExpiration, double totalDonsDonateur) : base(prenom, nom)
		{
			this.Prenom = prenom;
			this.Nom = nom;
			this.idDonateur = idDonateur;
			this.email = email;
			this.telephone = telephone;
			this.typeDeCarte = typeDeCarte;
			this.numeroDeCarte = numeroDeCarte;
			this.dateExpiration = dateExpiration;
			this.totalDonsDonateur = totalDonsDonateur;
		}

		public Donateur() { }

		public int IdDonateur { get { return idDonateur; } set { idDonateur = value; } }
		public string Email { get { return email; } set { email = value; } }
		public string Telephone { get { return telephone; } set { telephone = value; } }
		public string TypeDeCarte { get { return typeDeCarte; } set { typeDeCarte = value; } }
		public string NumeroDeCarte { get { return numeroDeCarte; } set { numeroDeCarte = value; } }
		public string DateExpiration { get { return dateExpiration; } set { dateExpiration = value; } }
		public double TotalDonsDonateur { get { return totalDonsDonateur; } set { totalDonsDonateur = value; } }

		public override string ToString()
		{
			return "Nom du donateur : " + this.Nom + ", prénom :" + this.Prenom + ", Id : " + idDonateur;
		}

	}
}
