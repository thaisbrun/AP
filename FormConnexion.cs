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
    /// AP3 FORMA'FLIX : connexion en tant qu'utilisateur
    /// Auteur : C.AUTRET
    /// Editeur : T.BRUN
    /// date : Septembre 2021
    /// </summary>
    public partial class FormConnexion : Form
    {
        #region constructeur
        public FormConnexion()
        {
            InitializeComponent();
        }
        #endregion

        #region méthodes
        private void FormConnexion_Load(object sender, EventArgs e)
        {
            Controleur.initConnexion();
            Controleur.VmodeleC.seconnecter();
            if (Controleur.VmodeleC.Connopen == false)
            {
                 MessageBox.Show("Erreur dans la connexion");
               //throw new System.ArgumentException("Erreur dans la connexion", "connexion");
                Application.Exit();
            }
            else
            {
                //MessageBox.Show("BD connectée");
            }
        }

        private void FormConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controleur.VmodeleC.sedeconnecter();
            Application.Exit();
        }


        private void BtnConnecter_Click(object sender, EventArgs e)
        {
           // si la BD est connectée et si les champs login et mdp sont saisis
           if (Controleur.VmodeleC.Connopen && tbLogin.Text != "" && tbmdp.Text != "")
           {
               // on recherche l'utilisateur connecté avec le login
               Controleur.VmodeleC.charger_Utilisateur(tbLogin.Text);
        
               // s'il existe bien un utilisateur avec ce login
               if (Controleur.VmodeleC.Chargement)
               {
                   if (Controleur.VmodeleC.DT[0].Rows.Count !=0)
                   {
                        // on compare le mot de passe saisi avec le mot de passe crypté de la BD lié à ce login
                        if (BCrypt.Net.BCrypt.Verify(tbmdp.Text, Controleur.VmodeleC.DT[0].Rows[0]["MOTPASSE"].ToString()))
                        {
                            MessageBox.Show("Connecté en tant qu'utilisateur '" + Controleur.VmodeleC.DT[0].Rows[0]["NOM"].ToString()+ "'");

                            // on ouvre la vue principale de l'application en passant en paramètre le nom de l'utilisateur
                            FormPrincipale FC = new FormPrincipale(Controleur.VmodeleC.DT[0].Rows[0]["NOM"].ToString(), Convert.ToInt32(Controleur.VmodeleC.DT[0].Rows[0]["IDUTILISATEUR"]));
                            FC.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("ERREUR : Mot de passe incorrects");

                    }
                   else
                   {
                       MessageBox.Show("ERREUR : Nom incorrect");
                       tbmdp.Clear();
                       tbLogin.Focus();
                   }
               }

           }
           else
               MessageBox.Show("ERREUR : Saisir un nom et un mot de passe");
        }
        #endregion
    }
}