using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDao
{
    public class PositionTechnicien
    {
        private int idPos = 0;

        public int IdPos
        {
            get {return idPos; }
            set { idPos = value; }
        }
        private string latitude = "";

        public string Latitude
        {
            get {return latitude; }
            set {latitude = value; }
        }
        private string longitude = "";

        public string Longitude
        {
            get {return longitude; }
            set { longitude = value; }
        }
        private System.DateTime datepos;

        public System.DateTime Datepos 
        {
            get {return datepos; }
            set {datepos = value; }
        }
        private string fkLoginT = "";

        public string FkLoginT
        {
            get {return fkLoginT; }
            set { fkLoginT = value; }
        }
    }
}
