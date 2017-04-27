using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dispatcher
{
    public class UtilisateurConnecte
    {
        static string login = string.Empty;

        public static string Login
        {
            get { return UtilisateurConnecte.login; }
            set { UtilisateurConnecte.login = value; }
        }

        static string prenom = string.Empty;

        public static string Prenom
        {
            get { return UtilisateurConnecte.prenom; }
            set { UtilisateurConnecte.prenom = value; }
        }
        static string nom = string.Empty;

        public static string Nom
        {
            get { return UtilisateurConnecte.nom; }
            set { UtilisateurConnecte.nom = value; }
        }
        static string groupe = string.Empty;

        public static string Groupe
        {
            get { return UtilisateurConnecte.groupe; }
            set { UtilisateurConnecte.groupe = value; }
        }
    }
}
