using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDao
{
    public class Employe
    {
        private string loginE = "";

        public string LoginE
        {
            get { return loginE; }
            set { loginE = value; }
        }

        private string prenom = "";
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string nom = "";
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string groupe = "";

        public string Groupe
        {
            get { return groupe; }
            set { groupe = value; }
        }
    }
}
