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
    /// AP3 FORMA'FLIX : Vue permettant de lister toutes les formations de la BD (avec leurs compétences associées)
    /// Auteur : C.AUTRET
    /// Editeur : T.BRUN
    /// date : Septembre 2021
    /// </summary>
    public partial class FormListeFormations : Form
    {
        #region proprietes
        private BindingSource bS1;
        #endregion

        #region constructeur
        public FormListeFormations()
        {
            InitializeComponent();
        }
        #endregion

        #region methodes
        private void FormListeFormations_Load(object sender, EventArgs e)
        {
            // instanciation du ModeleFormation VmodeleF
            Controleur.initFormation();
            if (Controleur.VmodeleC.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                // chargement des données de la table FORMATION via DT[1] et affichage dans un dataGridView
                Controleur.VmodeleF.charger_Formations();      
                if (Controleur.VmodeleC.Chargement)
                {
                    bS1 = new BindingSource();

                    bS1.DataSource = Controleur.VmodeleC.DT[1];
                    dgvFormations.DataSource = bS1;
                    dgvFormations.Columns[0].HeaderText = "ID FORMATION";
                    dgvFormations.Columns[1].HeaderText = "LIBELLE";

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dgvFormations.Refresh();
                    dgvFormations.Visible = true;
                }

            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permet de lister les compétences de la formation sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeDesCompétencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // si une formation est bien sélectionnée dans le dataGridView
            if (dgvFormations.SelectedRows.Count == 1)
            {
                // on récupère l'identifiant de la formation sélectionnée
                int idF = Convert.ToInt32(dgvFormations.Rows[dgvFormations.SelectedRows[0].Index].Cells[0].Value);

                // on récupère les compétences liées à la fortmation sélectionnée dans DT[2]
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


        private void DgvFormations_SelectionChanged(object sender, EventArgs e)
        {
            gbCompetences.Visible = false;
        }
        #endregion

    }
}

