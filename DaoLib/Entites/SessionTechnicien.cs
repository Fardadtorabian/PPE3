using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibDao
{
    public class SessionTechnicien
    {
        private int idSession = 0;

        public int IdSession
        {
            get { return idSession; }
            set { idSession = value; }
        }
        private string jeton = String.Empty;

        public string Jeton
        {
            get { return jeton; }
            set { jeton = value; }
        }
        private DateTime dateDerniereRequete = DateTime.MinValue;

        public DateTime DateDerniereRequete
        {
            get { return dateDerniereRequete; }
            set { dateDerniereRequete = value; }
        }
        private string fkLoginT = "";

        public string FkLoginT
        {
            get { return fkLoginT; }
            set { fkLoginT = value; }
        }
    }
}
