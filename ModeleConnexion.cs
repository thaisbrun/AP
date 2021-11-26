using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace AP3_FormaFlix
{

    /// <summary>
    /// AP3 FORMA'FLIX : classe MODELECONNEXION pour la connexion à la BD 'ap"_bd_formaflix'
    /// Utilisateur d'une collection de DataTable
    /// dT[0] : dateTable des utilisateurs pour la connexion
    /// dT[1] : dataTable des formations
    /// dT[2] : dataTable des competences selon une formation
    /// dT[3] : dataTable des competences
    /// dT[4] : dataTable des competences selon un libellé
    /// dt[5] : dataTable des commentaires 
    /// dt[6] : dataTable des auteurs 
    /// dt[7] : dataTable des utilisateurs pour les formations
    /// Auteur : C.AUTRET
    /// date : Septembre 2021
    /// </summary>
    public class ModeleConnexion
    {
        #region propriétés
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool chargement = false;

        // collection de DataTable récupérant les données correspond au DA associé
        private List<DataTable> dT = new List<DataTable>();

        #endregion

        #region accesseurs
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public List<DataTable> DT { get => dT; set => dT = value; }
        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }

        #endregion

        #region constructeur
        public ModeleConnexion()
        {
            // instanciation des collections des Datatable et DataAdapter
            for (int i = 0; i < 20; i++)
            {
                dT.Add(new DataTable());
            }
        }

        #endregion

        #region methodes
        /// <summary>
        /// Méthode pour se connecter à la BD
        /// </summary>
        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=thaisrobin;Data Source=192.168.139.1;User Id=thaisrobin-1; Password=izKIuwhu;SslMode = none";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative 
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }

        /// <summary>
        /// Méthode pour se déconnecter de la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        /// <summary>
        /// Méthode pout charger les données issues d'une requête dans un dataTable
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="DT"></param>
        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            chargement = false;

            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Clear();
                DT.Load(reader);
                chargement = true;

                /*   while (reader.Read())

                   {

                       //   StringID = reader[0].ToString();

                   }*/

            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }

        /// <summary>
        /// méthode qui permet de récupérer les informations de l'utilisateur connecté selon son login, s'il existe
        /// </summary>
        /// <param name="login"></param>
        public void charger_Utilisateur(string login)
        {
            charger("select * from utilisateur where NOM = '" + login + "';", dT[0]);
        }
        #endregion
    }
}
