using System;

namespace LibDao
{
    public class Technicien
    {
        private string loginT = String.Empty;
        public string LoginT
        {
            get { return loginT; }
            set { loginT = value; }
        }

        private string prenom = String.Empty;

        public string Prenom
        {
            get {return prenom; }
            set { prenom = value; }
        }

        private string nom = String.Empty;
        public string Nom
        {
            get {return nom; }
            set { nom = value; }
        }
        private string passwdT = String.Empty;

        public string PasswdT
        {
            get { return passwdT; }
            set { passwdT = value; }
        }

        private int fkIdMateriel=0;
        public int FkIdMateriel
        {
            get { return fkIdMateriel; }
            set { fkIdMateriel = value; }
        }
    }
}
