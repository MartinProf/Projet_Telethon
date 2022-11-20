using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelethonNew
{
	public partial class frmListeDonsEtCommandties : Form
	{
		public frmListeDonsEtCommandties()
		{
			InitializeComponent();
			BindingSource bsDonateurs = new BindingSource();
			bsDonateurs.DataSource = Program.gestionnaire.Donateurs;

			dgvDonateurs.DataSource = bsDonateurs;
			dgvDonateurs.Refresh();

			BindingSource bsCommand = new BindingSource();
			bsCommand.DataSource = Program.gestionnaire.Commanditaires;

			dgvCommanditaires.DataSource = bsCommand;
			dgvCommanditaires.Refresh();
		}

		private void btnAccueilrFrmDonsEtCommandites_Click(object sender, EventArgs e)
		{
			const string message = "Êtes-vous sûr de vouloir quitter l'application?";
			const string caption = "Quitter";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) Application.Exit();
		}

		private void btnRetourFrmDonsEtCommandites_Click(object sender, EventArgs e)
		{
			this.Hide();
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void frmListeDonsEtCommandties_Load(object sender, EventArgs e)
		{
			int nbPoints = 0;
			string prix = "";


			for (int i = 0; i < Program.gestionnaire.CntDonateurs; i++)
			{

				nbPoints = Program.gestionnaire.CompterPoints(Program.lesDonateurs[i].TotalDonsDonateur, Program.lesDonateurs[i].IdDonateur);
				prix = Program.gestionnaire.AttribuerPrix(Program.lesDonateurs[i].IdDonateur, nbPoints);
				dgvDonateurs.Rows[i].Cells[5].Value = nbPoints;
				dgvDonateurs.Rows[i].Cells[6].Value = prix;
			}
			for (int i = 0; i < Program.gestionnaire.CntComm; i++)
			{
				string idComma = dgvCommanditaires.Rows[i].Cells[0].Value.ToString();

				for (int j = 0; j < Program.lesPrix.Count; j++)
				{
					string idCommPrix = Program.lesPrix[j].IdCommanditaire.ToString();
					if (idComma == idCommPrix)
					{
						dgvCommanditaires.Rows[i].Cells[3].Value = Program.lesPrix[j].Description;
						dgvCommanditaires.Rows[i].Cells[4].Value = Program.lesPrix[j].Valeur;
						dgvCommanditaires.Rows[i].Cells[5].Value = Program.lesPrix[j].Quantite;
					}
				}
			}
		}

		private void dgvDonateurs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{

		}

		private void dgvCommanditaires_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{

		}

		private void dgvDonateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void gbDonateurs_Enter(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void commanditaireBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void pnlFondFrmListeDonsCommandites_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
