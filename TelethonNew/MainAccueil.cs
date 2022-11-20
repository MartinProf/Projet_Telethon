using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class MainAccueil : Form
	{
		public MainAccueil()
		{
			InitializeComponent();
		}

		private void tbDevenirDonateur_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuDonateur menuDonateur = new MenuDonateur();
			menuDonateur.ShowDialog();
			this.Show();
		}

		private void tbDevenirCommanditaire_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuCommanditaire menuCommanditaire = new MenuCommanditaire();
			menuCommanditaire.ShowDialog();
			this.Show();
		}

		private void btnQuittter_Click(object sender, EventArgs e)
		{
			const string message = "Êtes-vous sûr de vouloir quitter l'application?";
			const string caption = "Quitter";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) Application.Exit();
		}




		private void btnInfo_Click(object sender, EventArgs e)
		{
			string message = "Le projet intitulé \"Téléthon Éco S.O.S.\" consiste en une simulation" + Environment.NewLine;
			message += "de téléthon visant à ramasser des fonds pour la survie des animaux" + Environment.NewLine;
			message += "sauvages." + Environment.NewLine + Environment.NewLine;
			message += "Il vous sera simple de vous diriger au travers de l'application en" + Environment.NewLine;
			message += "suivant les liens bien identifiés à cet égard." + Environment.NewLine + Environment.NewLine;
			message += "Travail pratique de fin de session" + Environment.NewLine + Environment.NewLine;
			message += "Présenté à Hinde Anoual" + Environment.NewLine + Environment.NewLine;
			message += "Elisabeth Tremblay - 0144773" + Environment.NewLine;
			message += "Martin Forget - 0048400" + Environment.NewLine;
			message += "Martin Vézina - 6187167" + Environment.NewLine + Environment.NewLine;

			string caption = "Téléthon Éco S.O.S.";
			MessageBox.Show(message, caption);

		}

		private void btnInfo_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTipbtnInfo = new System.Windows.Forms.ToolTip();
			ToolTipbtnInfo.SetToolTip(this.btnInfo, "Click me");
			btnInfo.BackColor = Color.Gold;
		}

		private void btnQuittter_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTipbtnExit = new System.Windows.Forms.ToolTip();
			ToolTipbtnExit.SetToolTip(this.btnQuittter, "Quitter");
			btnQuittter.BackColor = Color.Red;
		}

		private void btnQuittter_MouseLeave(object sender, EventArgs e)
		{
			btnQuittter.BackColor = Color.ForestGreen;
		}

		private void btnInfo_MouseLeave(object sender, EventArgs e)
		{
			btnInfo.BackColor = Color.ForestGreen;
		}

		private void tbFaireDonAccueil_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuDonateurP2Dons menuDonateurP2Dons = new MenuDonateurP2Dons();
			menuDonateurP2Dons.ShowDialog();
			this.Show();
		}

		private void btnEnregistrerDonateurAccueil_MouseHover(object sender, EventArgs e)
		{
			btnEnregistrerDonateurAccueil.ForeColor = Color.ForestGreen;
			btnEnregistrerDonateurAccueil.BackColor = SystemColors.Control;

		}

		private void btnEnregistrerDonateurAccueil_MouseLeave(object sender, EventArgs e)
		{
			btnEnregistrerDonateurAccueil.BackColor = SystemColors.Control;
			btnEnregistrerDonateurAccueil.ForeColor = Color.Black;
		}

		private void btnEnregistrerDonateurAccueil_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuDonateur menuDonateur = new MenuDonateur();
			menuDonateur.ShowDialog();
			this.Show();
		}

		private void btnEnregistrerDonateurAccueil_MouseMove(object sender, MouseEventArgs e)
		{
			btnEnregistrerDonateurAccueil.BackColor = SystemColors.Control;
		}

		private void btnFaireDonAccueil_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuDonateurP2Dons menuDonateurP2Dons = new MenuDonateurP2Dons();
			menuDonateurP2Dons.ShowDialog();
			this.Show();
		}

		private void btnFaireDonAccueil_MouseHover(object sender, EventArgs e)
		{
			btnFaireDonAccueil.ForeColor = Color.ForestGreen;

		}

		private void btnFaireDonAccueil_MouseLeave(object sender, EventArgs e)
		{
			btnFaireDonAccueil.BackColor = SystemColors.Control;
			btnFaireDonAccueil.ForeColor = Color.Black;
		}

		private void btnFaireDonAccueil_MouseMove(object sender, MouseEventArgs e)
		{
			btnFaireDonAccueil.BackColor = SystemColors.Control;
		}

		private void btnDevenirCommanditaireAccueil_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuCommanditaire menuCommanditaire = new MenuCommanditaire();
			menuCommanditaire.ShowDialog();
			this.Show();
		}

		private void btnDevenirCommanditaireAccueil_MouseHover(object sender, EventArgs e)
		{
			btnDevenirCommanditaireAccueil.ForeColor = Color.ForestGreen;

		}

		private void btnDevenirCommanditaireAccueil_MouseLeave(object sender, EventArgs e)
		{
			btnDevenirCommanditaireAccueil.BackColor = SystemColors.Control;
			btnDevenirCommanditaireAccueil.ForeColor = Color.Black;
		}

		private void btnDevenirCommanditaireAccueil_MouseMove(object sender, MouseEventArgs e)
		{
			btnDevenirCommanditaireAccueil.BackColor = SystemColors.Control;

		}

		private void btnListesDoncCommanditesAccueil_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmListeDonsEtCommandties frmListeDonsEtCommandties = new frmListeDonsEtCommandties();
			frmListeDonsEtCommandties.ShowDialog();
			this.Show();
		}

		private void btnListesDoncCommanditesAccueil_MouseHover(object sender, EventArgs e)
		{
			btnListesDoncCommanditesAccueil.ForeColor = Color.ForestGreen;

		}

		private void btnListesDoncCommanditesAccueil_MouseLeave(object sender, EventArgs e)
		{
			btnListesDoncCommanditesAccueil.BackColor = SystemColors.Control;
			btnListesDoncCommanditesAccueil.ForeColor = Color.Black;
		}

		private void btnListesDoncCommanditesAccueil_MouseMove(object sender, MouseEventArgs e)
		{
			btnListesDoncCommanditesAccueil.BackColor = SystemColors.Control;

		}
	}
}
