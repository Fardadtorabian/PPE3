using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDao
{
    public class Intervention
    {
        private int idIntervention = 0;

        public int IdIntervention
        {
            get { return idIntervention; }
            set { idIntervention = value; }
        }
        private string compteRendu = "";

        public string CompteRendu
        {
            get { return compteRendu; }
            set { compteRendu = value; }
        }

        private System.DateTime debutIntervention;

        public System.DateTime DebutIntervention
        {
            get { return debutIntervention; }
            set { debutIntervention = value; }
        }

        private System.DateTime finIntervention;

        public System.DateTime FinIntervention
        {
            get { return finIntervention; }
            set { finIntervention = value; }
        }

        private string objectifVisite = String.Empty;

        public string ObjectifVisite
        {
            get { return objectifVisite; }
            set { objectifVisite = value; }
        }

        private Byte[] photoLieu;
        public Byte[] PhotoLieu
        {
            get { return photoLieu; }
            set { photoLieu = value; }
        }

        private string nomContact = String.Empty;

        public string NomContact
        {
            get { return nomContact; }
            set { nomContact = value; }
        }

        private string prenomContact = String.Empty;

        public string PrenomContact
        {
            get { return prenomContact; }
            set { prenomContact = value; }
        }

        private string telContact = String.Empty;

        public string TelContact
        {
            get { return telContact; }
            set { telContact = value; }
        }

        private string etatVisite = "";

        public string EtatVisite
        {
            get { return etatVisite; }
            set { etatVisite = value; }
        }


        private String fkLoginE = String.Empty;

        public String FkLoginE
        {
            get { return fkLoginE; }
            set { fkLoginE = value; }
        }
        private int fkIdClient = 0;

        public int FkIdClient
        {
            get { return fkIdClient; }
            set { fkIdClient = value; }
        }
        private String fkLoginT = String.Empty;

        public String FkLoginT
        {
            get { return fkLoginT; }
            set { fkLoginT = value; }
        }
    }
}
