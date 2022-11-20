namespace BiblioTelethon
{
	public class Don
	{
		private int idDon;
		private int idDonateur;
		private string dateDuDon;
		private double montantDuDon;

		public Don(int idDon, int idDonateur, string dateDuDon, double montantDuDon)
		{
			this.idDon = idDon;
			this.idDonateur = idDonateur;
			this.dateDuDon = dateDuDon;
			this.montantDuDon = montantDuDon;
		}
		public Don() { }

		public int IDDon { get { return idDon; } set { idDon = value; } }
		public string DateDuDon { get { return dateDuDon; } set { dateDuDon = value; } }
		public double MontantDuDon { get { return montantDuDon; } set { montantDuDon = value; } }
		public int IDDonateur { get { return idDonateur; } set { idDonateur = value; } }

		public override string ToString()
		{
			return "Id Don : " + idDon + ", date : " + dateDuDon + ", montant : " + montantDuDon + ", id du donateur : " + idDonateur;
		}
	}
}
