namespace TelethonNew
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.pnlLoginFull = new System.Windows.Forms.Panel();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.btnEffacer = new TelethonNew.Controls.RoundedButton();
			this.btnLogin = new TelethonNew.Controls.RoundedButton();
			this.tbMotDePasseLogin = new System.Windows.Forms.TextBox();
			this.tbNomUtilisateurLogin = new System.Windows.Forms.TextBox();
			this.pbEagle = new System.Windows.Forms.PictureBox();
			this.pnlLoginFull.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEagle)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlLoginFull
			// 
			this.pnlLoginFull.BackgroundImage = global::TelethonNew.Properties.Resources.feuille;
			this.pnlLoginFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlLoginFull.Controls.Add(this.btnQuitter);
			this.pnlLoginFull.Controls.Add(this.btnEffacer);
			this.pnlLoginFull.Controls.Add(this.btnLogin);
			this.pnlLoginFull.Controls.Add(this.tbMotDePasseLogin);
			this.pnlLoginFull.Controls.Add(this.tbNomUtilisateurLogin);
			this.pnlLoginFull.Controls.Add(this.pbEagle);
			this.pnlLoginFull.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLoginFull.Location = new System.Drawing.Point(0, 0);
			this.pnlLoginFull.Name = "pnlLoginFull";
			this.pnlLoginFull.Size = new System.Drawing.Size(637, 244);
			this.pnlLoginFull.TabIndex = 0;
			// 
			// btnQuitter
			// 
			this.btnQuitter.BackColor = System.Drawing.Color.ForestGreen;
			this.btnQuitter.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitter.ForeColor = System.Drawing.Color.White;
			this.btnQuitter.Location = new System.Drawing.Point(590, 12);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(35, 35);
			this.btnQuitter.TabIndex = 10;
			this.btnQuitter.Text = "X";
			this.btnQuitter.UseVisualStyleBackColor = false;
			this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
			this.btnQuitter.MouseLeave += new System.EventHandler(this.btnQuitter_MouseLeave);
			this.btnQuitter.MouseHover += new System.EventHandler(this.btnQuitter_MouseHover);
			// 
			// btnEffacer
			// 
			this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(4)))));
			this.btnEffacer.FlatAppearance.BorderSize = 0;
			this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEffacer.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEffacer.ForeColor = System.Drawing.Color.Black;
			this.btnEffacer.Location = new System.Drawing.Point(495, 73);
			this.btnEffacer.Name = "btnEffacer";
			this.btnEffacer.Size = new System.Drawing.Size(130, 40);
			this.btnEffacer.TabIndex = 9;
			this.btnEffacer.Text = "Effacer";
			this.btnEffacer.UseVisualStyleBackColor = false;
			this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(4)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.Location = new System.Drawing.Point(320, 73);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(130, 40);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
			// 
			// tbMotDePasseLogin
			// 
			this.tbMotDePasseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMotDePasseLogin.ForeColor = System.Drawing.Color.Silver;
			this.tbMotDePasseLogin.Location = new System.Drawing.Point(320, 188);
			this.tbMotDePasseLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbMotDePasseLogin.Multiline = true;
			this.tbMotDePasseLogin.Name = "tbMotDePasseLogin";
			this.tbMotDePasseLogin.Size = new System.Drawing.Size(305, 35);
			this.tbMotDePasseLogin.TabIndex = 7;
			this.tbMotDePasseLogin.Text = "Mot de passe";
			this.tbMotDePasseLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbMotDePasseLogin.TextChanged += new System.EventHandler(this.tbMotDePasseLogin_TextChanged);
			this.tbMotDePasseLogin.Enter += new System.EventHandler(this.tbMotDePasseLogin_Enter);
			this.tbMotDePasseLogin.Leave += new System.EventHandler(this.tbMotDePasseLogin_Leave);
			// 
			// tbNomUtilisateurLogin
			// 
			this.tbNomUtilisateurLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNomUtilisateurLogin.ForeColor = System.Drawing.Color.Silver;
			this.tbNomUtilisateurLogin.Location = new System.Drawing.Point(319, 134);
			this.tbNomUtilisateurLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbNomUtilisateurLogin.Multiline = true;
			this.tbNomUtilisateurLogin.Name = "tbNomUtilisateurLogin";
			this.tbNomUtilisateurLogin.Size = new System.Drawing.Size(306, 35);
			this.tbNomUtilisateurLogin.TabIndex = 6;
			this.tbNomUtilisateurLogin.Text = "Nom d\'utilisateur";
			this.tbNomUtilisateurLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbNomUtilisateurLogin.Enter += new System.EventHandler(this.tbNomUtilisateurLogin_Enter);
			this.tbNomUtilisateurLogin.Leave += new System.EventHandler(this.tbNomUtilisateurLogin_Leave);
			// 
			// pbEagle
			// 
			this.pbEagle.BackColor = System.Drawing.Color.Transparent;
			this.pbEagle.Image = global::TelethonNew.Properties.Resources.pygargue;
			this.pbEagle.Location = new System.Drawing.Point(0, 21);
			this.pbEagle.Name = "pbEagle";
			this.pbEagle.Size = new System.Drawing.Size(266, 230);
			this.pbEagle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbEagle.TabIndex = 0;
			this.pbEagle.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 244);
			this.ControlBox = false;
			this.Controls.Add(this.pnlLoginFull);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(653, 283);
			this.MinimumSize = new System.Drawing.Size(653, 283);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.pnlLoginFull.ResumeLayout(false);
			this.pnlLoginFull.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEagle)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginFull;
        private System.Windows.Forms.PictureBox pbEagle;
        private System.Windows.Forms.TextBox tbMotDePasseLogin;
        private System.Windows.Forms.TextBox tbNomUtilisateurLogin;
        private Controls.RoundedButton btnEffacer;
        private Controls.RoundedButton btnLogin;
        private System.Windows.Forms.Button btnQuitter;
    }
}