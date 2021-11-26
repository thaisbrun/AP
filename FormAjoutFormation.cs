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
    /// AP3 FORMA'FLIX : Vue permettant l'ajout d'une formation avec les compétences associées
    /// Auteur : C.AUTRET
    /// Editeur : T.BRUN
    /// date : Septembre 2021
    /// </summary>
    public partial class FormAjoutFormation : Form
    {
        #region proprietes
        private bool click;
        private int idA;
        #endregion

        #region constructeur
        public FormAjoutFormation(int idA)
        {
            InitializeComponent();
            this.idA = idA;
        }
        // Ce constructeur permet de rendre visible la gb de modification et suppression des formations de la FormAjoutFormation. 
        public FormAjoutFormation(bool click, int idA)
        {
            InitializeComponent();
            this.click = click;
            this.idA = idA;
        }
        #endregion

        #region methodes 
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// méthode qui permet d'annuler et donc réinitialiser tous les champs de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbLibelle.Clear();
            tbDescription.Clear();
            tbVideo.Clear();
            tbImage.Clear();
            cbVisible.Checked = false;
            tbLibelle.Focus();
            DTPVisibilite.Value = DateTime.Today;
            chargerComboBoxCompetences();
            chargerComboBoxFormations();

        }

        /// <summary>
        /// Mtéhode qui permet d'ajouter dans la comboBox tous les libellés des compétences issus de la BD (via DT[3])
        /// </summary>
        private void chargerComboBoxCompetences()
        {
            cbCompetences.Items.Clear();
            if (Controleur.VmodeleC.DT[3].Rows.Count == 0)
            {
                cbCompetences.Items.Add("Pas de compétences enregistrées");
                lbCompetences.Visible = false;
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[3].Rows.Count; i++)
                {
                    cbCompetences.Items.Add(Controleur.VmodeleC.DT[3].Rows[i]["LIBELLECOMPETENCE"].ToString());
                }
                lbCompetences.Visible = true;
                lbCompetences.Items.Clear();
            }
        }

        /// <summary>
        /// Mtéhode qui permet d'ajouter dans la comboBox tous les libellés des formations issues de la BD (via DT[1])
        /// </summary>
        private void chargerComboBoxFormations()
        {
            cbFormationModif.Items.Clear();
            if (Controleur.VmodeleC.DT[1].Rows.Count == 0)
            {
                cbFormationModif.Items.Add("Pas de formations enregistrées");
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[1].Rows.Count; i++)
                {
                    cbFormationModif.Items.Add(Controleur.VmodeleC.DT[1].Rows[i]["LIBELLE"].ToString() + " - correspondant à l'id utilisateur : "+ Controleur.VmodeleC.DT[1].Rows[i]["IDAUTEUR"]);
                }
            }
        }


        /// <summary>
        /// au chargement de la vue : instanciation de l'objet vModeleF et récupération des compétences 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAjoutFormation_Load(object sender, EventArgs e)
        {
            tbLibelle.Focus();
            Controleur.initFormation();
            Controleur.VmodeleF.charger_Formations();
            Controleur.VmodeleF.charger_Competences();
            chargerComboBoxCompetences();
            chargerComboBoxFormations();

            // La gbFormation est visible si l'utilisateur clique sur ModifierSupprimerUneFormationToolStripMenuItem
            if (click == true)
            {
                gbFormation.Visible = true;
                btnAjouter.Visible = false;
            }
            else
            {
                gbFormation.Visible = false;
                btnAjouter.Visible = true;
            }
        }


        /// <summary>
        /// Méthode qui permet d'ajouter la formation dans la BD et les compétences associées ainsi que l'auteur renseigné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Controleur.initFormation();
            // vérifier que le libellé et le lien video sont renseignés au minimum
            if (tbLibelle.Text != "" && tbVideo.Text != "")
            {

                // enregistrement de la formation en lien avec l'auteur 
                if (Controleur.VmodeleF.AjoutFormation(tbLibelle.Text, tbDescription.Text, tbVideo.Text, tbImage.Text, cbVisible.Checked, DTPVisibilite.Value, idA))
                {
                    // recupérer l'IDFORMATION 
                    // récupération de la dernière formation ajoutée pour avoir son id
                    Controleur.VmodeleF.charger_Formations();
                    int idF = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[Controleur.VmodeleC.DT[1].Rows.Count - 1]["IDFORMATION"]);
                    //récupérer l'IDAUTEUR 
                    Controleur.VmodeleF.charger_auteur(idF);
                    int idA = Convert.ToInt32(Controleur.VmodeleC.DT[6].Rows[0]["IDAUTEUR"]);
                    MessageBox.Show("Formation ajoutée n° " + idF + "créée par" + idA);

                    // parcourir lbCompetence
                    // récuperer l'IDCOMPETENCE pour chaque compétence à ajouter
                    int idC = 0;
                    for (int i = 0; i < lbCompetences.Items.Count; i++)
                    {
                        Controleur.VmodeleF.charger_CompetenceSelonLibelle(lbCompetences.Items[i].ToString());
                        if (Controleur.VmodeleC.DT[4].Rows.Count != 0)
                        {
                            idC = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0]["IDCOMPETENCE"]);
                            // ajouter dans la table DEVELOPPER les compétences pour la formation
                            if (Controleur.VmodeleF.AjoutDevelopper(idF, idC))
                            {
                                MessageBox.Show("Lien Formation-Competence ajouté pour la compétence " + Controleur.VmodeleC.DT[4].Rows[0]["LIBELLECOMPETENCE"]);
                            }
                        }

                    }

                    BtnAnnuler_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Vous devez saisir au moins un libellé et un identifiant Video", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbCompetences_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCompetences.SelectedIndex;

            // à la sélection d'une compétence dans la comboBox : on l'ajoute dans la listBox et la supprime de la combo
            if (index != -1)
            {
                lbCompetences.Items.Add(cbCompetences.SelectedItem); // pour la lier à la formation dans la table DEVELOPPER lors de l'ajout
                cbCompetences.Items.RemoveAt(index); // pour éviter les doublons
            }
        }

        private void CbFormationModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFormationModif.SelectedIndex;

            // récupère les informations des formations enregistrées dans la DT[1]
            if (index != -1)
            {
                int idF = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[index]["IDFORMATION"]);
                tbLibelle.Text = Controleur.VmodeleC.DT[1].Rows[index]["LIBELLE"].ToString();
                tbDescription.Text = Controleur.VmodeleC.DT[1].Rows[index]["DESCRIPTION"].ToString();
                tbVideo.Text = Controleur.VmodeleC.DT[1].Rows[index]["IDENTIFIANTVIDEO"].ToString();
                tbImage.Text = Controleur.VmodeleC.DT[1].Rows[index]["IMAGE"].ToString();
                cbVisible.Checked = (Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[index]["VISIBILITEPUBLIC"]) == 1);
                DTPVisibilite.Value = Convert.ToDateTime(Controleur.VmodeleC.DT[1].Rows[index]["DATEVISIBILITE"]);
                int idA = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[index]["IDAUTEUR"]);

                Controleur.VmodeleF.charger_CompetencesSelonFormation(idF);
                if (Controleur.VmodeleC.Chargement)
                {
                    gbCompetences.Visible = true;
                    lbCompetences.Items.Clear();
                    if (Controleur.VmodeleC.DT[2].Rows.Count == 0)
                    {
                        lbCompetences.Items.Add("Pas de compétences associées");
                    }
                    else
                    {
                        // si des compétences existent pour cette formation, on les ajoute dans la listBox
                        int idC = 0;
                        for (int i = 0; i < Controleur.VmodeleC.DT[2].Rows.Count; i++)
                        {
                            lbCompetences.Items.Add(Controleur.VmodeleC.DT[2].Rows[i]["LIBELLECOMPETENCE"].ToString());
                        }
                    }
                }
            }
            else
                MessageBox.Show("Il faut sélectionner une ligne");
        }
        /// <summary>
        /// Méthode qui permet de modifier la formation dans la BD et les compétences associées 
        /// </summary>
        private void BtnModifier3_Click(object sender, EventArgs e)
        {
            if (tbLibelle.Text != "" && tbDescription.Text != "" && tbVideo.Text != "" && tbImage.Text != "")
            {
                int idF = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[cbFormationModif.SelectedIndex]["IDFORMATION"]);
                int idA = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[cbFormationModif.SelectedIndex]["IDAUTEUR"]);
                int index = cbFormationModif.SelectedIndex;
                // modification de la formation
                if (Controleur.VmodeleF.ModifFormation(idF, tbLibelle.Text, tbDescription.Text, tbVideo.Text, tbImage.Text, cbVisible.Checked, DTPVisibilite.Value))
                {
                    // chargement et MAJ des formations
                    Controleur.VmodeleF.charger_Formations();
                    MessageBox.Show("Formation modifiée n° " + idF + "écrite par" + idA);

                    // parcourir lbCompetence
                    // récuperer l'IDCOMPETENCE pour chaque compétence à ajouter
                    int idC = 0;
                    for (int i = 0; i < lbCompetences.Items.Count; i++)
                    {
                        Controleur.VmodeleF.charger_CompetenceSelonLibelle(lbCompetences.Items[i].ToString());
                        if (Controleur.VmodeleC.DT[4].Rows.Count != 0)
                        {
                            idC = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0]["IDCOMPETENCE"]);
                            // modifier dans la table DEVELOPPER les compétences pour la formation
                            if (Controleur.VmodeleF.AjoutDevelopper(idF, idC))
                            {
                                MessageBox.Show("Lien Formation-Competence ajouté pour la compétence " + Controleur.VmodeleC.DT[4].Rows[0]["LIBELLECOMPETENCE"]);
                            }
                        }

                    }

                    BtnAnnuler_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de supprimer la formation dans la BD et les compétences associées 
        /// </summary>

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            int index = cbFormationModif.SelectedIndex;
            if (index != -1)
            {
                int idF = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[cbFormationModif.SelectedIndex]["IDFORMATION"]);
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette formation ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // Supprimer la formation sélectionnée 
                    Controleur.VmodeleF.SupprimerFormation(idF);
                    FormAjoutFormation_Load(sender, e); // pour mettre à jour la comboBox
                }
            }
        }

        private void boutonRetirer_Click(object sender, EventArgs e)
        {
            int index = lbCompetences.SelectedIndex;
            if (index != -1)
            {
                int idC = Convert.ToInt32(Controleur.VmodeleC.DT[2].Rows[index]["IDCOMPETENCE"]);
                int idF = Convert.ToInt32(Controleur.VmodeleC.DT[2].Rows[index]["IDFORMATION"]);
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette compétence ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // Supprimer la formation et les compétences sélectionnées
                    Controleur.VmodeleF.SuppDevelopper(idF, idC);
                    FormAjoutFormation_Load(sender, e); // pour mettre à jour la comboBox
                }
            }
        }
        #endregion
    }
}
