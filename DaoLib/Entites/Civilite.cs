using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibDao
{
    public class Civilite
    {
        private int idCivilite = 0;
        public int IdCivilite
        {
            get { return idCivilite; }
            set { idCivilite = value; }
        }

        private string titre = "";
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        private string abreviation = "";

        public string Abreviation
        {
            get { return abreviation; }
            set { abreviation = value; }
        }
    }
}
