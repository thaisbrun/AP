using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_FormaFlix
{
    public class ModeleCommentaire
    {
        #region constructeur
        public ModeleCommentaire()
        { }
        #endregion

        #region methodes       
        /// <summary>
        /// Méthode qui récupère toutes les informations sur les commentaires
        /// </summary>
        public void charger_Commentaires()
        {
            Controleur.VmodeleC.charger("select idCommentaire, commentaire, visibilite, note, idFormation, idInscrit from commentaire;", Controleur.VmodeleC.DT[5]);
        }
        /// <summary>
        /// Permet de modifier un commentaire à la table COMMENTAIRE avec les éléments du commentaire passés en paramètre
        /// </summary>
        public bool ModifCom(int idCommentaire, int visibilite)
        {
            try
            {
                // préparation de la requête 
                string requete = "update commentaire set visibilite=@visibilite where idCommentaire = @idCommentaire";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("idCommentaire", idCommentaire);
                command.Parameters.AddWithValue("visibilite", visibilite);
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
