using BiblioTelethon;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class MenuDonateurP2Dons : Form
	{
		string prenomDonateur;
		string nomDonateur;

		public MenuDonateurP2Dons(string prenomDonateur, string nomDonateur, string telDonateur)
		{

			InitializeComponent();
			string[] lesTel = Program.gestionnaire.AfficherTelephone();
			cmbTelephone.Items.Add("Votre choix...");
			cmbTelephone.SelectedItem = "Votre choix...";
			tbMontantDon.ForeColor = Color.DarkGray;
			tbMontantDon.Text = "Montant ";
			for (int i = 0; i < lesTel.Length; i++)
			{
				cmbTelephone.Items.Add(lesTel[i]);
			}
			this.prenomDonateur = prenomDonateur;
			this.nomDonateur = nomDonateur;
			cmbTelephone.Text = "Votre choix...";
			cmbTelephone.ForeColor = Color.DarkGray;
			if (this.prenomDonateur != string.Empty && this.nomDonateur != string.Empty)
			{
				tbTotalDons.Visible = true;
				pbDollarSignMini.Visible = true;

				this.tbNomsDons.Text = prenomDonateur + " " + nomDonateur;
				this.tbNomsDons.Visible = true;
			}
		}

		public MenuDonateurP2Dons()
		{
			InitializeComponent();
			tbMontantDon.ForeColor = Color.DarkGray;
			tbMontantDon.Text = "Montant ";
			string[] lesTel = Program.gestionnaire.AfficherTelephone();
			cmbTelephone.Items.Add("Votre choix...");
			cmbTelephone.SelectedItem = "Votre choix...";
			for (int i = 0; i < lesTel.Length; i++)
			{
				cmbTelephone.Items.Add(lesTel[i]);
			}
			cmbTelephone.ForeColor = Color.DarkGray;
		}

		private void tbMontantDon_Enter(object sender, EventArgs e)
		{
			tbMontantDon.Text = String.Empty;
			tbMontantDon.ForeColor = Color.Black;
		}

		private void tbMontantDon_Leave(object sender, EventArgs e)
		{
			if (tbMontantDon.Text == String.Empty)
			{
				tbMontantDon.ForeColor = Color.DarkGray;
				tbMontantDon.Text = "Montant ";
			}
		}

		private void btnEffacerMenuDonateurP2Don_Click(object sender, EventArgs e)
		{
			cmbTelephone.Text = "Votre choix...";
			cmbTelephone.ForeColor = Color.DarkGray;
			tbMontantDon.Text = "Montant ";
			tbMontantDon.ForeColor = Color.DarkGray;
		}

		private void btnRetourMenuDonateurPage1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnListeDonsEtCommanditesDonateur_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmListeDonsEtCommandties frmListeDonsEtCommandties = new frmListeDonsEtCommandties();
			frmListeDonsEtCommandties.Show();
		}

		private void btnSoumettreDon_Click(object sender, EventArgs e)
		{
			string telephone = "";
			double montant = 0;

			bool montantValide = double.TryParse(tbMontantDon.Text, out montant);

			if (!montantValide && !(Regex.Match(tbMontantDon.Text, @"^[0-9]{1,7}$").Success))
			{
				MessageBox.Show("Entrez un montant valide");
				tbMontantDon.ForeColor = Color.DarkGray;
				tbMontantDon.Text = string.Empty;
				tbMontantDon.Select();
			}
			else
			{
				montant = double.Parse(tbMontantDon.Text);

				telephone = cmbTelephone.Text;
				bool telValide = Regex.Match(telephone, @"^[\(][0-9]{3}[\)][0-9]{3}\-[0-9]{4}$").Success;

				if (!telValide)
				{
					MessageBox.Show("Le numéro de téléphone est invalide");
					cmbTelephone.ForeColor = Color.DarkGray;
					cmbTelephone.SelectedItem = "Votre choix...";
				}
				else
				{
					int id_Donateur = 0;

					for (int i = 0; i < Program.lesDonateurs.Count; i++)
					{
						if (telephone == Program.lesDonateurs[i].Telephone)
						{
							tbNomsDons.Visible = true;
							tbNomsDons.ForeColor = Color.Black;
							tbTotalDons.Visible = true;
							tbTotalDons.ForeColor = Color.Black;
							pbDollarSignMini.Visible = true;
							pbAbeille.Visible = false;

							tbTotalDons.Text = Program.lesDonateurs[i].TotalDonsDonateur.ToString();

							id_Donateur = i;

							prenomDonateur = Program.lesDonateurs[i].Prenom;
							nomDonateur = Program.lesDonateurs[i].Nom;
							tbNomsDons.Text = prenomDonateur + " " + nomDonateur;
						}
					}
					Don nouveauDon = new Don(0, id_Donateur, DateTime.Now.ToString(), montant);
					Program.gestionnaire.AjouterDon(nouveauDon);



					string message = "Le don de " + prenomDonateur + " " + nomDonateur + " de " + nouveauDon.MontantDuDon + "$ a été ajouté";
					const string caption = "Merci";
					MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

					rtbTopDonateurs.Text = Program.gestionnaire.top3Donateurs();
					rtbTopDonateurs.Refresh();

					var result = DialogResult.OK;
					string message2 = "Vous allez être redirigé vers les listes de dons et commandites.";
					const string caption2 = "Attention";

					DialogResult dialogResult = MessageBox.Show("Voulez-vous faire un autre don?", "Attention", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						tbMontantDon.ForeColor = Color.DarkGray;
						tbMontantDon.Text = string.Empty;
						cmbTelephone.SelectedItem = "Votre choix...";
						tbNomsDons.Text = string.Empty;
						tbTotalDons.Text = string.Empty;
						tbNomsDons.Visible = false;
						tbTotalDons.Visible = false;
						pbDollarSignMini.Visible = false;
						pbAbeille.Visible = true;
					}
					else if (dialogResult == DialogResult.No)
					{
						result = MessageBox.Show(message2, caption2, MessageBoxButtons.OK, MessageBoxIcon.Information);

						tbMontantDon.ForeColor = Color.DarkGray;
						tbMontantDon.Text = string.Empty;
						cmbTelephone.SelectedItem = "Votre choix...";
						tbNomsDons.Text = string.Empty;
						tbTotalDons.Text = string.Empty;
						tbNomsDons.Visible = false;
						tbTotalDons.Visible = false;
						pbDollarSignMini.Visible = false;
						pbAbeille.Visible = true;

						this.Hide();
						frmListeDonsEtCommandties frmListeDonsEtCommandties = new frmListeDonsEtCommandties();
						frmListeDonsEtCommandties.ShowDialog();
						this.Show();
					}
				}
			}

		}

		private void btnQuittter_Click(object sender, EventArgs e)
		{
			const string message = "Êtes-vous sûr de vouloir quitter l'application?";
			const string caption = "Quitter";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) Application.Exit();
		}

		private void tbMontantDon_TextChanged(object sender, EventArgs e)
		{
			tbMontantDon.Select(tbMontantDon.Text.Length, 0);
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

		private void MenuDonateurP2Dons_Load(object sender, EventArgs e)
		{
			tbMontantDon.ForeColor = Color.DarkGray;
			tbMontantDon.Text = "Montant ";
			rtbTopDonateurs.Text = Program.gestionnaire.top3Donateurs();
		}

		private void tbTelephoneDon_MouseLeave(object sender, EventArgs e)
		{

		}

		private void cmbTelephone_MouseEnter(object sender, EventArgs e)
		{
			if (cmbTelephone.ForeColor != Color.DarkGray) cmbTelephone.Text = cmbTelephone.Text;
			else
				cmbTelephone.Text = String.Empty;
			cmbTelephone.ForeColor = Color.Black;

		}

		private void cmbTelephone_MouseLeave(object sender, EventArgs e)
		{
			cmbTelephone.ForeColor = Color.DarkGray;
			cmbTelephone.Text = "Téléphone";
		}

		private void cmbTelephone_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbTelephone_SelectedValueChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < Program.lesDonateurs.Count; i++)
			{
				if (cmbTelephone.SelectedItem.ToString() == Program.lesDonateurs[i].Telephone)
				{
					tbNomsDons.Visible = true;
					tbNomsDons.ForeColor = Color.Black;
					tbTotalDons.Visible = true;
					tbTotalDons.ForeColor = Color.Black;
					pbDollarSignMini.Visible = true;
					pbAbeille.Visible = false;

					tbTotalDons.Text = Program.lesDonateurs[i].TotalDonsDonateur.ToString();

					prenomDonateur = Program.lesDonateurs[i].Prenom;
					nomDonateur = Program.lesDonateurs[i].Nom;
					tbNomsDons.Text = prenomDonateur + " " + nomDonateur;
				}
			}
		}

		private void pnlGBdonateur_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pbArbreMenuDonateurP2Dons_Click(object sender, EventArgs e)
		{

		}
	}
}
