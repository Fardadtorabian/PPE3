using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibDao.Entites
{
    public class EtatClient
    {
        private int idEtatClient = 0;
        public int IdEtatClient
        {
            get { return idEtatClient; }
            set { idEtatClient = value; }
        }
        private string etat = "";
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }
    }
}
