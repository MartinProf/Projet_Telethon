using System;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class AffichagePrix : Form
	{
		public AffichagePrix()
		{
			InitializeComponent();
		}

		private void btnFermerAffichagePrix_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
