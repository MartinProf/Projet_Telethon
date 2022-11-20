using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click_1(object sender, EventArgs e)
		{
			
			if (tbNomUtilisateurLogin.Text == String.Empty || tbMotDePasseLogin.Text == String.Empty || tbNomUtilisateurLogin.Text == "Nom d'utilisateur" || tbMotDePasseLogin.Text == "Mot de passe")
			{
				MessageBox.Show("Veuillez remplir tous les champs");

			}
			else
			{
				
				if (tbNomUtilisateurLogin.Text == "téléthon2021" && tbMotDePasseLogin.Text == "Don@2021")
				{
					this.Hide();
					MainAccueil mainAccueil = new MainAccueil();
					mainAccueil.Show();
				}
				else
				{
					MessageBox.Show("Les informations entrées sont erronées");
				}
			}
		}

		private void tbNomUtilisateurLogin_Enter(object sender, EventArgs e)
		{
			tbNomUtilisateurLogin.Text = String.Empty;
			tbNomUtilisateurLogin.ForeColor = Color.Black;
		}

		private void tbMotDePasseLogin_Enter(object sender, EventArgs e)
		{
			tbMotDePasseLogin.PasswordChar = '*';
			tbMotDePasseLogin.Text = String.Empty;
			tbMotDePasseLogin.ForeColor = Color.Black;
		}

		private void tbNomUtilisateurLogin_Leave(object sender, EventArgs e)
		{
			if (tbNomUtilisateurLogin.Text == string.Empty)
			{

				tbNomUtilisateurLogin.ForeColor = Color.DarkGray;
				tbNomUtilisateurLogin.Text = "Nom d'utilisateur";
			}
		}

		private void tbMotDePasseLogin_Leave(object sender, EventArgs e)
		{
			if (tbMotDePasseLogin.ForeColor == Color.Black)
			{
				tbMotDePasseLogin.Text = tbMotDePasseLogin.Text;
			}
			else if (tbMotDePasseLogin.Text == string.Empty || tbMotDePasseLogin.PasswordChar == '*' )
			{
				
				tbMotDePasseLogin.PasswordChar = '\0';
				tbMotDePasseLogin.ForeColor = Color.DarkGray;
				tbMotDePasseLogin.Text = "Mot de passe";
			}
		}

		private void btnQuitter_Click(object sender, EventArgs e)
		{
			const string message = "Êtes-vous sûr de vouloir quitter l'application?";
			const string caption = "Quitter";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) Application.Exit();
		}

		private void btnQuitter_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTipbtnExit = new System.Windows.Forms.ToolTip();
			ToolTipbtnExit.SetToolTip(this.btnQuitter, "Quitter");
			btnQuitter.BackColor = Color.Red;
		}

		private void btnQuitter_MouseLeave(object sender, EventArgs e)
		{
			btnQuitter.BackColor = Color.ForestGreen;
		}

		private void btnEffacer_Click(object sender, EventArgs e)
		{
			tbMotDePasseLogin.PasswordChar = '\0';
			tbNomUtilisateurLogin.Text = String.Empty;
			tbMotDePasseLogin.Text = String.Empty;
			if (tbMotDePasseLogin.Text == String.Empty && tbNomUtilisateurLogin.Text == String.Empty)
			{
				tbNomUtilisateurLogin.Text = "Nom d'utilisateur";
				tbNomUtilisateurLogin.ForeColor = Color.DarkGray;
				tbMotDePasseLogin.Text = "Mot de passe";
				tbMotDePasseLogin.ForeColor = Color.DarkGray;
			}
		}

		private void tbMotDePasseLogin_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
