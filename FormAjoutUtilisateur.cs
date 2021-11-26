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
    public partial class FormAjoutUtilisateur : Form
    {
        public FormAjoutUtilisateur()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbNomUtil.Clear();
            tbPrenomUtil.Clear();
            tbMDP.Clear();
            tbEmail.Clear();
 
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Controleur.initUtilisateur();
            // vérifier que les 4 textBox sont renseignés au minimum
            if (tbNomUtil.Text != "" && tbPrenomUtil.Text != "" && tbMDP.Text != "" && tbEmail.Text != "")
            {

                // enregistrement de l'utilisateur
                if (Controleur.VmodeleU.AjoutUtilisateur(tbNomUtil.Text, tbPrenomUtil.Text, BCrypt.Net.BCrypt.HashPassword(tbMDP.Text), tbEmail.Text))
                {
                    // recupérer l'IDUTILISATEUR
                    // récupération du dernier utilisateur ajouté pour avoir son id
                    Controleur.VmodeleU.charger_Utilisateurs();
                    int idU = Convert.ToInt32(Controleur.VmodeleC.DT[0].Rows[Controleur.VmodeleC.DT[0].Rows.Count - 1]["IDUTILISATEUR"]);
                    MessageBox.Show("Utilisateur ajouté dans la BDD");
                }
                btnAnnuler_Click(sender, e);
            }
            else
            {
                MessageBox.Show("ERREUR : Vous devez saisir les quatre textBox", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
