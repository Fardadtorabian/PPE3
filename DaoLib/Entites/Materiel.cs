using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDao
{
    public class Materiel
    {
        private int idMateriel = 0;

        public int IdMateriel
        {
            get {return idMateriel; }
            set { idMateriel = value; }
        }
        private string typeMateriel = "";

        public string TypeMateriel
        {
            get {return typeMateriel; }
            set {typeMateriel = value; }
        }

        private string numeroSerie = "";

        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

        private string numeroTel = "";

        public string NumeroTel
        {
            get { return numeroTel; }
            set { numeroTel = value; }
        }

        private string imei = "";

        public string Imei
        {
            get { return imei; }
            set { imei = value; }
        }
        private string idGoogle = "";

        public string IdGoogle
        {
            get { return idGoogle; }
            set { idGoogle = value; }
        }
        private System.DateTime dateAffectation;

        public System.DateTime DateAffectation
        {
            get {return dateAffectation; }
            set { dateAffectation = value; }
        }

        private System.DateTime dateEnregistrement;

        public System.DateTime DateEnregistrement
        {
            get { return dateEnregistrement; }
            set { dateEnregistrement = value; }
        }


        private string fkLoginE = "";

        public string FkLoginE
        {
            get { return fkLoginE; }
            set { fkLoginE = value; }
        }

        private string etatMateriel = "";

        public string EtatMateriel
        {
            get { return etatMateriel; }
            set { etatMateriel = value; }
        }
    }
}
