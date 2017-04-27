using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDao
{
    public class Client
    {
        private int idClient = 0;
        public int IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        private string entreprise = "";
        public string Entreprise
        {
            get { return entreprise; }
            set { entreprise = value; }
        }

        private int fkIdCivilite = 0;
        public int FkIdCivilite
        {
            get { return fkIdCivilite; }
            set { fkIdCivilite = value; }
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
        private string adresse = "";

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private string compAdresse = "";

        public string CompAdresse
        {
            get { return compAdresse; }
            set { compAdresse = value; }
        }
   
        private string codePostal = "";
        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        private string ville = "";
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        private string numeroTel = "";
        public string NumeroTel
        {
            get { return numeroTel; }
            set { numeroTel = value; }
        }

        private string email = "";
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private Byte[] photoent;
        public Byte[] Photoent
        {
            get { return photoent; }
            set { photoent = value; }
        }

        private string latitude = "";
        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        private string longitude = "";
        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        DateTime dateCreation;

        public DateTime DateCreation
        {
            get { return dateCreation; }
            set { dateCreation = value; }
        }

        private DateTime dateModification;

        public DateTime DateModification
        {
            get { return dateModification; }
            set { dateModification = value; }
        }

        private int fkIdEtatClient = 0;

        public int FkIdEtatClient
        {
            get { return fkIdEtatClient; }
            set { fkIdEtatClient = value; }
        }

        private string fkLoginE = "";

        public string FkLoginE
        {
            get { return fkLoginE; }
            set { fkLoginE = value; }
        }

    }
}
