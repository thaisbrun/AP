using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_FormaFlix
{
    public class ModeleUtilisateur
    {
        #region constructeur
        public ModeleUtilisateur()
        { }
        #endregion

        #region methodes
        /// <summary>
        /// Méthode qui récupère toutes les informations sur les utilisateurs
        /// </summary>
        public void charger_Utilisateurs()
        {
            Controleur.VmodeleC.charger("select IDUTILISATEUR, NOM, PRENOM, EMAIL, SUPERADMIN from utilisateur;", Controleur.VmodeleC.DT[7]);
        }
        public bool AjoutUtilisateur(string nom, string prenom, string mdp, string mail)
        {
            try
            {
                // préparation de la requête 
                string requete = "insert into utilisateur values (null, @nom, @prenom, @mdp, @mail, false)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("nom", nom);
                command.Parameters.AddWithValue("prenom", prenom);
                command.Parameters.AddWithValue("mdp", mdp);
                command.Parameters.AddWithValue("mail", mail);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Méthode qui met à jour les informations de l'utilisateur sélectionné 
        /// </summary>
        public bool ModifUtil(int idUtil, int SAUtil)
        {
            try
            {
                // préparation de la requête 
                string requete = "update utilisateur set SUPERADMIN=@SUPERADMIN where IDUTILISATEUR = @IDUTILISATEUR";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("IDUTILISATEUR", idUtil);
                command.Parameters.AddWithValue("SUPERADMIN", SAUtil);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
