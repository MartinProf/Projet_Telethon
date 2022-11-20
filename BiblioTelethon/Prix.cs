namespace BiblioTelethon
{
	public class Prix
	{
		private int idPrix;
		private string description;
		private double valeur;
		private int quantite;
		private int idCommanditaire;

		public Prix(int idPrix, int idCommanditaire, string description, double valeur, int quantite)
		{
			this.idPrix = idPrix;
			this.idCommanditaire = idCommanditaire;
			this.description = description;
			this.valeur = valeur;
			this.quantite = quantite;
		}
		public Prix() { }

		public int IdPrix { get { return idPrix; } set { idPrix = value; } }
		public string Description { get { return description; } set { description = value; } }
		public double Valeur { get { return valeur; } set { valeur = value; } }
		public int Quantite { get { return quantite; } set { quantite = value; } }
		public int IdCommanditaire { get { return idCommanditaire; } set { idCommanditaire = value; } }

		public override string ToString()
		{
			return "Description du prix : " + this.description + ", valeur :" + this.valeur + " , Id : " + idPrix;

		}
	}
}
