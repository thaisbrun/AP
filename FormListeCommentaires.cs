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
    /// AP3 FORMA'FLIX : Vue permettant de lister tous les commentaires de la BD
    /// Auteur : T.BRUN
    /// date : Septembre 2021
    /// </summary>
    public partial class FormListeCommentaires : Form
    {
        #region proprietes
        private BindingSource bS2;
        private bool click;
        #endregion

        #region constructeur
        public FormListeCommentaires()
            {
                InitializeComponent();
            }
        public FormListeCommentaires(bool click)
        {
            InitializeComponent();
            this.click = click;
        }
        #endregion

        #region methodes
        private void FormListeCommentaires_Load(object sender, EventArgs e)
            {
                // instanciation du ModeleCommentaire VmodeleCO
                Controleur.initCommentaire();
                if (Controleur.VmodeleC.Connopen == false)
                {
                    MessageBox.Show("Erreur dans la connexion");
                }
                else
                {
                    // chargement des données de la table COMMENTAIRE via DT[5] et affichage dans un dataGridView
                    Controleur.VmodeleCO.charger_Commentaires();
                    if (Controleur.VmodeleC.Chargement)
                    {
                        bS2 = new BindingSource();

                        bS2.DataSource = Controleur.VmodeleC.DT[5];
                        dgvCommentaires.DataSource = bS2;
                        dgvCommentaires.Columns[0].HeaderText = "idCommentaire";
                        dgvCommentaires.Columns[1].HeaderText = "commentaire";
                        dgvCommentaires.Columns[2].HeaderText = "visibilite";
                        dgvCommentaires.Columns[3].HeaderText = "note";
                        dgvCommentaires.Columns[4].HeaderText = "idFormation";
                        dgvCommentaires.Columns[5].HeaderText = "idInscrit";

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                        dgvCommentaires.Refresh();
                        dgvCommentaires.Visible = true;
                    }

                }
            if (click == true)
            {
                btnRP.Visible = true;
                btnArchiver.Visible = false;
            }
            else
            {
                btnRP.Visible = false;

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            //Sélectionner une ligne et vérifier si une ligne est bien sélectionnée
            if (dgvCommentaires.SelectedRows.Count == 1)
            {
                // on récupère le statut de la formation sélectionnée
                int idCOM = Convert.ToInt32(dgvCommentaires.Rows[dgvCommentaires.SelectedRows[0].Index].Cells[0].Value);
                int statutCOM = Convert.ToInt32(dgvCommentaires.Rows[dgvCommentaires.SelectedRows[0].Index].Cells[2].Value);

                //Si la visibilite de la ligne sélectionnée est égale à 1 alors afficher "Le commentaire est déjà public"
                if (Controleur.VmodeleC.Chargement)
                {
                    if (statutCOM == 1)
                    {
                        MessageBox.Show("Le commentaire est déjà public");
                    }
                    else
                    {
                        //Si la visibilite de la ligne sélectionnée est égale à 0 alors modification du commentaire dans la BDD et affichage.
                        if (Controleur.VmodeleCO.ModifCom(idCOM, 1))
                        {
                        Controleur.VmodeleCO.charger_Commentaires();
                        MessageBox.Show("Commentaire modifié n° " + idCOM);
                        }
                        
                    }
                }
            }
            else
                MessageBox.Show("Il faut sélectionner une ligne");
        }

        private void btnArchiver_Click(object sender, EventArgs e)
        {
            //Sélectionner une ligne et vérifier si une ligne est bien sélectionnée
            if (dgvCommentaires.SelectedRows.Count == 1)
            {
                // on récupère le statut de la formation sélectionnée
                int idCOM = Convert.ToInt32(dgvCommentaires.Rows[dgvCommentaires.SelectedRows[0].Index].Cells[0].Value);
                int statutCOM = Convert.ToInt32(dgvCommentaires.Rows[dgvCommentaires.SelectedRows[0].Index].Cells[2].Value);

                //Si la visibilite de la ligne sélectionnée est égale à 1 alors afficher "Le commentaire est déjà public"
                if (Controleur.VmodeleC.Chargement)
                {
                    //Si la visibilite de la ligne sélectionnée est égale à 0 alors modification du commentaire dans la BDD et affichage.
                        if (Controleur.VmodeleCO.ModifCom(idCOM, 2))
                        {
                            Controleur.VmodeleCO.charger_Commentaires();
                            MessageBox.Show("Commentaire archivé n° " + idCOM);
                        }
                }
            }
            else
                MessageBox.Show("Il faut sélectionner une ligne");
        }
        #endregion
    }
}