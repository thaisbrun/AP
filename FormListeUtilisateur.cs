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
    public partial class FormListeUtilisateur : Form
    {

        /// <summary>
        /// AP3 FORMA'FLIX : Vue permettant de lister tous les utilisateurs de la BD
        /// Auteur : T.BRUN
        /// date : Septembre 2021
        /// </summary>
        #region proprietes 
        private BindingSource bS3;
        #endregion
        #region constructeur
        public FormListeUtilisateur()
        {
            InitializeComponent();
        }
        #endregion
        #region methodes
        private void FormAjouterUtilisateur_Load(object sender, EventArgs e)
        {
            // instanciation du ModeleUtilisateur VmodeleU
            Controleur.initUtilisateur();
            if (Controleur.VmodeleC.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                // chargement des données de la table UTILISATEUR via DT[7] et affichage dans un dataGridView
                Controleur.VmodeleU.charger_Utilisateurs();
                if (Controleur.VmodeleC.Chargement)
                {
                    bS3 = new BindingSource();

                    bS3.DataSource = Controleur.VmodeleC.DT[7];
                    dgvUtilisateurs.DataSource = bS3;
                    dgvUtilisateurs.Columns[0].HeaderText = "IDUTILISATEUR";
                    dgvUtilisateurs.Columns[1].HeaderText = "NOM";
                    dgvUtilisateurs.Columns[2].HeaderText = "PRENOM";
                    dgvUtilisateurs.Columns[3].HeaderText = "EMAIL";
                    dgvUtilisateurs.Columns[4].HeaderText = "SUPERADMIN";

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dgvUtilisateurs.Refresh();
                    dgvUtilisateurs.Visible = true;
                }

            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            //Sélectionner une ligne et vérifier si une ligne est bien sélectionnée
            if (dgvUtilisateurs.SelectedRows.Count == 1)
            {
                // on récupère le statut de l'utilisateur sélectionné
                int idUtil = Convert.ToInt32(dgvUtilisateurs.Rows[dgvUtilisateurs.SelectedRows[0].Index].Cells[0].Value);
                int SAUtil = Convert.ToInt32(dgvUtilisateurs.Rows[dgvUtilisateurs.SelectedRows[0].Index].Cells[4].Value);

                //Si le statut de la ligne sélectionnée est égale à 1 alors afficher "L'utilisateur est déjà administrateur"
                if (Controleur.VmodeleC.Chargement)
                {
                    if (SAUtil == 1)
                    {
                        MessageBox.Show("L'utilisateur est déjà administrateur");
                    }
                    else
                    {
                        //Si la visibilite de la ligne sélectionnée est égale à 0 alors modification de l'utilisateur dans la BDD et affichage.
                        if (Controleur.VmodeleU.ModifUtil(idUtil, 1))
                        {
                            Controleur.VmodeleU.charger_Utilisateurs();
                            MessageBox.Show("Utilisateur " + idUtil + " devient administrateur");
                        }

                    }
                }
            }
            else 
                MessageBox.Show("Il faut sélectionner une ligne");
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
