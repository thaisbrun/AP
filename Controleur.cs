using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_FormaFlix
{
    /// <summary>
    /// Classe Controleur : AP3 FORMA'FLIX
    /// Auteur : C.AUTRET
    /// Editeur : T.BRUN
    /// date : Septembre 2021
    /// </summary>
    /// 

        // Le controleur gère le traitement des requêtes HTTP entrants. 
    public static class Controleur
    {
        #region proprietes
        private static ModeleConnexion vmodeleC;
        private static ModeleFormation vmodeleF;
        private static ModeleCommentaire vmodeleCO;
        private static ModeleUtilisateur vmodeleU;
        #endregion

        #region accesseurs
        public static ModeleFormation VmodeleF { get => vmodeleF; set => vmodeleF = value; }
        public static ModeleConnexion VmodeleC { get => vmodeleC; set => vmodeleC = value; }
        public static ModeleCommentaire VmodeleCO { get => vmodeleCO; set => vmodeleCO = value; }
        public static ModeleUtilisateur VmodeleU { get => vmodeleU; set => vmodeleU = value; }
        #endregion

        #region methodes
        public static void initConnexion()
        {
            VmodeleC = new ModeleConnexion();
        }
        public static void initFormation()
        {
            VmodeleF = new ModeleFormation();
        }
        public static void initCommentaire()
        {
            VmodeleCO = new ModeleCommentaire();
        }
        
        public static void initUtilisateur()
        {
            VmodeleU = new ModeleUtilisateur();
        }
        #endregion
    }
}
