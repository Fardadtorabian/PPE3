using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibDao
{
    public class VTechnicienItinerant
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
            get { return prenom; }
            set { prenom = value; }
        }
        private string nom = String.Empty;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string latitude = String.Empty;

        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        private string longitude = String.Empty;

        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        private System.DateTime datepos = DateTime.MinValue;

        public System.DateTime Datepos
        {
            get { return datepos; }
            set { datepos = value; }
        }
    }
}
