using BiblioTelethon;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class MenuDonateur : Form
	{
		public MenuDonateur()
		{
			InitializeComponent();
		}

		private void btnPageSuivanteMenuDonateur_Click(object sender, EventArgs e)
		{
			string prenomDonateur = tbPrenomDonateur.Text;
			string nomDonateur = tbNomDonateur.Text;
			string telephone = tbTelephoneDonateur.Text;
			this.Hide();
			MenuDonateurP2Dons menuDonateurP2Dons = new MenuDonateurP2Dons(prenomDonateur, nomDonateur, telephone);
			menuDonateurP2Dons.ShowDialog();
			this.Show();
		}

		private void txBxDonatTel_TextChanged(object sender, EventArgs e)
		{
			if (Regex.Match(tbTelephoneDonateur.Text, @"^[\(][0-9]{3}$").Success)
			{
				tbTelephoneDonateur.Text += ")";
				tbTelephoneDonateur.Select(tbTelephoneDonateur.Text.Length, 0);
			}

			if (Regex.Match(tbTelephoneDonateur.Text, @"^[\(][0-9]{3}[\)][0-9]{3}$").Success)
			{
				tbTelephoneDonateur.Text += "-";
				tbTelephoneDonateur.Select(tbTelephoneDonateur.Text.Length, 0);
			}
		}

		private void btnEffacerMenuDonateur_Click(object sender, EventArgs e)
		{
			tbPrenomDonateur.Text = "Prénom";
			tbPrenomDonateur.ForeColor = Color.DarkGray;
			tbNomDonateur.Text = "Nom";
			tbNomDonateur.ForeColor = Color.DarkGray;
			tbEmailOuAdresseDonateur.Text = "Courriel ou Adresse";
			tbEmailOuAdresseDonateur.ForeColor = Color.DarkGray;
			tbTelephoneDonateur.Text = "Téléphone";
			tbTelephoneDonateur.ForeColor = Color.DarkGray;
			tbNumeroCarteDonateur.Text = "Numéro de carte";
			tbNumeroCarteDonateur.ForeColor = Color.DarkGray;
			rbAmex.Checked = false;
			rbMC.Checked = false;
			rbVisa.Checked = false;
			dateTimePicker1.Value = DateTime.Now;
		}

		private void txBxNouveauPrenom_Enter(object sender, EventArgs e)
		{
			if (tbPrenomDonateur.ForeColor != Color.DarkGray) tbPrenomDonateur.Text = tbPrenomDonateur.Text;
			else
			{
				tbPrenomDonateur.Text = String.Empty;
				tbPrenomDonateur.ForeColor = Color.Black;
			}
		}

		private void tbNomDonateur_Enter(object sender, EventArgs e)
		{
			if (tbNomDonateur.ForeColor != Color.DarkGray) tbNomDonateur.Text = tbNomDonateur.Text;
			else
			{
				tbNomDonateur.Text = String.Empty;
				tbNomDonateur.ForeColor = Color.Black;
			}
		}

		private void tbEmailOuAdresseDonateur_Enter(object sender, EventArgs e)
		{
			if (tbEmailOuAdresseDonateur.ForeColor != Color.DarkGray) tbEmailOuAdresseDonateur.Text = tbEmailOuAdresseDonateur.Text;
			else
			{
				tbEmailOuAdresseDonateur.Text = String.Empty;
				tbEmailOuAdresseDonateur.ForeColor = Color.Black;
			}
		}

		private void tbTelephoneDonateur_Enter(object sender, EventArgs e)
		{
			if (tbTelephoneDonateur.ForeColor != Color.DarkGray) tbTelephoneDonateur.Text = tbTelephoneDonateur.Text;
			else
			{
				tbTelephoneDonateur.Text = "(";
				tbTelephoneDonateur.SelectionStart = 1;
				tbTelephoneDonateur.ForeColor = Color.Black;
			}
		}

		private void tbNumeroCarteDonateur_Enter(object sender, EventArgs e)
		{
			if (tbNumeroCarteDonateur.ForeColor != Color.DarkGray) tbNumeroCarteDonateur.Text = tbNumeroCarteDonateur.Text;
			else
			{
				tbNumeroCarteDonateur.Text = String.Empty;
				tbNumeroCarteDonateur.ForeColor = Color.Black;
			}
		}

		private void tbPrenomDonateur_Leave(object sender, EventArgs e)
		{
			if (tbPrenomDonateur.Text == String.Empty)
			{
				tbPrenomDonateur.ForeColor = Color.DarkGray;
				tbPrenomDonateur.Text = "Prénom";
			}
		}

		private void tbNomDonateur_Leave(object sender, EventArgs e)
		{
			if (tbNomDonateur.Text == String.Empty)
			{
				tbNomDonateur.ForeColor = Color.DarkGray;
				tbNomDonateur.Text = "Nom";
			}
		}

		private void tbEmailOuAdresseDonateur_Leave(object sender, EventArgs e)
		{
			if (tbEmailOuAdresseDonateur.Text == String.Empty)
			{
				tbEmailOuAdresseDonateur.ForeColor = Color.DarkGray;
				tbEmailOuAdresseDonateur.Text = "Courriel ou Adresse";
			}
		}

		private void tbTelephoneDonateur_Leave(object sender, EventArgs e)
		{
			if (tbTelephoneDonateur.Text == String.Empty || tbTelephoneDonateur.Text == "(")
			{
				tbTelephoneDonateur.ForeColor = Color.DarkGray;
				tbTelephoneDonateur.Text = "Téléphone";
			}
		}

		private void tbNumeroCarteDonateur_Leave(object sender, EventArgs e)
		{
			if (tbNumeroCarteDonateur.Text == String.Empty)
			{
				tbNumeroCarteDonateur.ForeColor = Color.DarkGray;
				tbNumeroCarteDonateur.Text = "Numéro de carte";
			}
		}

		private void btnAfficherPrix_Click(object sender, EventArgs e)
		{
			this.Hide();
			AffichagePrix affichagePrix = new AffichagePrix();
			affichagePrix.ShowDialog();
			this.Show();
		}

		private void btnAccueilMenuDonateurPage1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnValidation_Click(object sender, EventArgs e)
		{

			string prenom = "";
			string nom = "";
			string emailOuAdresse = "";
			string telephone = "";
			string carte = "";
			string numCarte = "";
			string dateCarte = "";
			bool saisieConforme = true;
			var result = DialogResult.OK;

			if (!Regex.Match(tbPrenomDonateur.Text, @"^[a-zA-Z]+[a-zA-Z-' ]+$").Success || tbPrenomDonateur.ForeColor == Color.DarkGray)
			{
				MessageBox.Show("Erreur de saisie du prénom");
				tbPrenomDonateur.ForeColor = Color.DarkGray;
				tbPrenomDonateur.Text = string.Empty;
				tbPrenomDonateur.Select();
				saisieConforme = false;
			}
			else prenom = tbPrenomDonateur.Text;

			if (!Regex.Match(tbNomDonateur.Text, @"^[a-zA-Z]+[a-zA-Z-' ]+$").Success || tbNomDonateur.ForeColor == Color.DarkGray && saisieConforme == true)
			{
				MessageBox.Show("Erreur de saisie du Nom");
				tbNomDonateur.ForeColor = Color.DarkGray;
				tbNomDonateur.Text = String.Empty;
				tbNomDonateur.Select();
				saisieConforme = false;
			}
			else nom = tbNomDonateur.Text;

			if (!Regex.Match(tbEmailOuAdresseDonateur.Text, @"^[a-zA-Z0-9-' .@_]+$").Success || tbEmailOuAdresseDonateur.ForeColor == Color.DarkGray && saisieConforme == true)
			{
				MessageBox.Show("Erreur de saisie de l'adresse ou du courriel");
				tbEmailOuAdresseDonateur.ForeColor = Color.DarkGray;
				tbEmailOuAdresseDonateur.Text = String.Empty;
				tbEmailOuAdresseDonateur.Select();
				saisieConforme = false;
			}
			else emailOuAdresse = tbEmailOuAdresseDonateur.Text;

			if (!Regex.Match(tbTelephoneDonateur.Text, @"^[\(][0-9]{3}[\)][0-9]{3}\-[0-9]{4}$").Success && saisieConforme == true)
			{
				MessageBox.Show("Le numéro de téléphone est incomplet");
				tbTelephoneDonateur.ForeColor = Color.DarkGray;
				tbTelephoneDonateur.Text = String.Empty;
				tbTelephoneDonateur.Select();
				saisieConforme = false;
			}
			else telephone = tbTelephoneDonateur.Text;

			if (rbVisa.Checked == false && rbMC.Checked == false && rbAmex.Checked == false && saisieConforme == true)
			{
				MessageBox.Show("Vous n'avez pas sélectionné de carte");
				saisieConforme = false;
			}
			else
			{
				if (rbVisa.Checked) carte = "V";
				else if (rbAmex.Checked) carte = "A";
				else carte = "M";
			}

			if (!Regex.Match(tbNumeroCarteDonateur.Text, @"^[0-9]{16}$").Success && saisieConforme == true)
			{
				MessageBox.Show("Le numéro de carte de crédit est invalide, entrez 16 chiffres");
				tbNumeroCarteDonateur.ForeColor = Color.DarkGray;
				tbNumeroCarteDonateur.Text = "Numéro de carte";
				tbNumeroCarteDonateur.Select();
				saisieConforme = false;
			}
			else numCarte = tbNumeroCarteDonateur.Text;

			dateCarte = dateTimePicker1.Text;

			if (saisieConforme == true)
			{
				Donateur nouveauDonateur = new Donateur(0, prenom, nom, emailOuAdresse, telephone, numCarte, carte, dateCarte, 0);

				Program.gestionnaire.AjouterDonateur(nouveauDonateur);
				string message = "Le nouveau donateur #" + nouveauDonateur.IdDonateur + " " + nouveauDonateur.Prenom + " " + nouveauDonateur.Nom + " a été ajouté!";
				const string caption = "Donateur ajouté";
				result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

				DialogResult dialogResult = MessageBox.Show("Voulez-vous faire un don maintenant?", "Attention", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{

					btnEffacerMenuDonateur.PerformClick();
					this.Hide();
					MenuDonateurP2Dons menuDonateurP2Dons2 = new MenuDonateurP2Dons();
					menuDonateurP2Dons2.ShowDialog();
					this.Show();
				}
				else if (dialogResult == DialogResult.No)
				{

					btnEffacerMenuDonateur.PerformClick();

				}

				MenuDonateurP2Dons menuDonateurP2Dons = new MenuDonateurP2Dons(prenom, nom, telephone);
			}
		}

		private void btnQuittter_Click(object sender, EventArgs e)
		{
			const string message = "Êtes-vous sûr de vouloir quitter l'application?";
			const string caption = "Quitter";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) Application.Exit();
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

		private void tbNumeroCarteDonateur_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
