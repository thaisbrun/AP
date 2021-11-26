using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_FormaFlix
{
    /// <summary>
    /// AP3 FORMA'FLIX : Vue principale de l'application, ouverte suite à la connexion
    /// Auteur : C.AUTRET
    /// Editeur : T.BRUN
    /// date : Septembre 2021
    /// </summary>
    public partial class FormPrincipale : Form
    {
        #region proprietes
        private string admin;
        private int idA;
        #endregion

        #region constructeur
        public FormPrincipale(string admin, int idU)
        {
            InitializeComponent();
            this.admin = admin;
            this.idA = idU;
            this.Text = "FORMA'FLIX : " + admin;
        }
        #endregion

        #region methodes
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controleur.VmodeleC.sedeconnecter();
            MessageBox.Show("Vous êtes déconnecté de la base de données");
            gestionDesFormationsToolStripMenuItem.Enabled = false;
        }

        private void ReconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion FC = new FormConnexion();
            FC.Show();
            this.Close();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            gestionDesFormationsToolStripMenuItem.Enabled = true;
            if (Convert.ToInt32(Controleur.VmodeleC.DT[0].Rows[0]["SUPERADMIN"]) == 1)
            {
                ajouterUnAdministrateurToolStripMenuItem.Visible = true;
            }

        }

        private void ListerToutesLesFormationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeFormations FF = new FormListeFormations();
            FF.Show();
        }

        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AjouterUneFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutFormation FA = new FormAjoutFormation(idA);
            FA.Show();
        }

        private void ModifierSupprimerUneFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutFormation FA = new FormAjoutFormation(true, idA);
            FA.Show();
        }

        private void listerTousLesCommentairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeCommentaires FC = new FormListeCommentaires();
            FC.Show();
        }

        private void rendrePublicUnCommentaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeCommentaires FC = new FormListeCommentaires(true);
            FC.Show();
        }

        private void AjouterUnAdministrateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeUtilisateur FLU = new FormListeUtilisateur();
            FLU.Show();
        }
        #endregion

        private void ajouterUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutUtilisateur FAU = new FormAjoutUtilisateur();
            FAU.Show();
        }
    }
}
