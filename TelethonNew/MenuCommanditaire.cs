using BiblioTelethon;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class MenuCommanditaire : Form
	{
		public MenuCommanditaire()
		{
			InitializeComponent();
		}

		private void btnEffacerMenuCommanditaire_Click(object sender, EventArgs e)
		{
			cbChoixCommandite.Text = "Faites un choix de commandite";
			tbPrenomCopmmanditaire.Text = "Prénom";
			tbPrenomCopmmanditaire.ForeColor = Color.DarkGray;
			tbNomCommanditaire.Text = "Nom";
			tbNomCommanditaire.ForeColor = Color.DarkGray;
			tbQteCommandite.Text = "0";
			tbQteCommandite.ForeColor = Color.DarkGray;

			pbBBQmenuCommandite.Visible = false;
			pbRepasFamilialMenuCommandite.Visible = false;
			pbSkunk.Visible = true;
			pbTéléMenuCommandite.Visible = false;
			pbCalendrierMenuCommandite.Visible = false;
		}

		private void btnSoumettreCommandite_Click(object sender, EventArgs e)
		{
			string nomComm = "";
			string prenomComm = "";
			int quantite = 0;
			double valeur = 0;
			string prixSelectionne = "";
			bool saisieOK = true;
			var result = DialogResult.OK;
			string message = "Votre commandite a été acceptée";
			const string caption = "Merci";
			string message2 = "Vous allez être redirigé vers les listes de dons et commandites";
			const string caption2 = "Attention";

			if (!Regex.Match(tbPrenomCopmmanditaire.Text, @"^[a-zA-Z]+[a-zA-Z-' ]+$").Success || tbPrenomCopmmanditaire.ForeColor == Color.DarkGray)
			{
				MessageBox.Show("Erreur de saisie du prénom");
				tbPrenomCopmmanditaire.ForeColor = Color.DarkGray;
				tbPrenomCopmmanditaire.Text = string.Empty;
				tbPrenomCopmmanditaire.Select();
				saisieOK = false;
			}
			else prenomComm = tbPrenomCopmmanditaire.Text;

			if (!Regex.Match(tbNomCommanditaire.Text, @"^[a-zA-Z]+[a-zA-Z-' ]+$").Success || tbNomCommanditaire.ForeColor == Color.DarkGray && saisieOK == true)
			{
				MessageBox.Show("Erreur de saisie du nom");
				tbNomCommanditaire.ForeColor = Color.DarkGray;
				tbNomCommanditaire.Text = String.Empty;
				tbNomCommanditaire.Select();
				saisieOK = false;
			}
			else nomComm = tbNomCommanditaire.Text;

			bool qteValide = int.TryParse(tbQteCommandite.Text, out quantite);

			if (!qteValide || !Regex.Match(tbQteCommandite.Text, @"^[1-9][0-9]{0,3}$").Success && saisieOK == true)
			{
				MessageBox.Show("La quantité inscrite n'est pas incluse entre 1 et 9999");
				tbQteCommandite.ForeColor = Color.DarkGray;
				tbQteCommandite.Text = "0";
				tbQteCommandite.Select();
				saisieOK = false;
			}
			else quantite = Convert.ToInt32(tbQteCommandite.Text);

			if (cbChoixCommandite.Text.Equals("Faites un choix de commandite") && saisieOK == true)
			{
				MessageBox.Show("Veuillez sélectionner une commandite");
				saisieOK = false;
				cbChoixCommandite.Select();
			}
			else prixSelectionne = cbChoixCommandite.Text;

			if (saisieOK == true)
			{
				Commanditaire commanditaire = new Commanditaire(0, prenomComm, nomComm);
				Program.gestionnaire.AjouterCommanditaire(commanditaire);
				for (int i = 0; i < Program.lesPrix.Count; i++)
				{
					if (Program.lesPrix[i].Description == prixSelectionne)
					{
						valeur = Program.lesPrix[i].Valeur;
						break;

					}
				}

				Prix prix = new Prix(0, Program.lesCommanditaires[Program.lesCommanditaires.Count - 1].IdCommanditaire, cbChoixCommandite.Text, valeur, quantite);
				Program.gestionnaire.AjouterPrix(prix);
				result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult dialogResult = MessageBox.Show("Voulez-vous faire une autre commandite?", "Attention", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No)
				{
					result = MessageBox.Show(message2, caption2, MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					frmListeDonsEtCommandties frmListeDonsEtCommandties = new frmListeDonsEtCommandties();
					frmListeDonsEtCommandties.ShowDialog();
					this.Show();

				}

				btnEffacerMenuCommanditaire.PerformClick();
				rtbTopCommanditaires.Text = Program.gestionnaire.top3Commanditaire();
			}
		}

		private void btnAccueilMenuDonateurPage1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnDonsCommandites_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmListeDonsEtCommandties frmListeDonsEtCommandties = new frmListeDonsEtCommandties();
			frmListeDonsEtCommandties.ShowDialog();
			this.Show();
		}

		private void cbChoixCommandite_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbChoixCommandite.Text == "Barbecue")
			{
				pbBBQmenuCommandite.Visible = true;
				pbRepasFamilialMenuCommandite.Visible = false;
				pbSkunk.Visible = false;
				pbTéléMenuCommandite.Visible = false;
				pbCalendrierMenuCommandite.Visible = false;
			}
			else if (cbChoixCommandite.Text == "Téléviseur")
			{
				pbBBQmenuCommandite.Visible = false;
				pbRepasFamilialMenuCommandite.Visible = false;
				pbSkunk.Visible = false;
				pbTéléMenuCommandite.Visible = true;
				pbCalendrierMenuCommandite.Visible = false;

			}
			else if (cbChoixCommandite.Text == "Repas familial")
			{
				pbBBQmenuCommandite.Visible = false;
				pbRepasFamilialMenuCommandite.Visible = true;
				pbSkunk.Visible = false;
				pbTéléMenuCommandite.Visible = false;
				pbCalendrierMenuCommandite.Visible = false;

			}
			else if (cbChoixCommandite.Text == "Calendrier")
			{
				pbBBQmenuCommandite.Visible = false;
				pbRepasFamilialMenuCommandite.Visible = false;
				pbSkunk.Visible = false;
				pbTéléMenuCommandite.Visible = false;
				pbCalendrierMenuCommandite.Visible = true;

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

		private void tbPrenomCopmmanditaire_Enter(object sender, EventArgs e)
		{
			if (tbPrenomCopmmanditaire.ForeColor != Color.DarkGray) tbPrenomCopmmanditaire.Text = tbPrenomCopmmanditaire.Text;
			else
			{
				tbPrenomCopmmanditaire.Text = String.Empty;
				tbPrenomCopmmanditaire.ForeColor = Color.Black;
			}
		}

		private void tbNomCommanditaire_Enter(object sender, EventArgs e)
		{
			if (tbNomCommanditaire.ForeColor != Color.DarkGray) tbNomCommanditaire.Text = tbNomCommanditaire.Text;
			else
			{
				tbNomCommanditaire.Text = String.Empty;
				tbNomCommanditaire.ForeColor = Color.Black;
			}
		}

		private void tbPrenomCopmmanditaire_Leave(object sender, EventArgs e)
		{
			if (tbPrenomCopmmanditaire.Text == String.Empty)
			{
				tbPrenomCopmmanditaire.ForeColor = Color.DarkGray;
				tbPrenomCopmmanditaire.Text = "Prénom";
			}
		}

		private void tbNomCommanditaire_Leave(object sender, EventArgs e)
		{
			if (tbNomCommanditaire.Text == String.Empty)
			{
				tbNomCommanditaire.ForeColor = Color.DarkGray;
				tbNomCommanditaire.Text = "Nom";
			}
		}

		private void MenuCommanditaire_Load(object sender, EventArgs e)
		{
			rtbTopCommanditaires.Text = Program.gestionnaire.top3Commanditaire();
			tbQteCommandite.Text = "0";
			tbQteCommandite.ForeColor = Color.DarkGray;
		}





		private void tbQteCommandite_Enter(object sender, EventArgs e)
		{

			if (tbQteCommandite.ForeColor != Color.DarkGray) tbQteCommandite.Text = tbQteCommandite.Text;
			else
			{
				tbQteCommandite.Text = String.Empty;
				tbQteCommandite.ForeColor = Color.Black;
			}
		}

		private void tbQteCommandite_Leave(object sender, EventArgs e)
		{
			if (tbQteCommandite.Text == String.Empty)
			{
				tbQteCommandite.ForeColor = Color.DarkGray;
				tbQteCommandite.Text = "0";
			}
		}
	}
}