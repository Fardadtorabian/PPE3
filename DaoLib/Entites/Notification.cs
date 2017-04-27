using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDao
{
    public class Notification
    {
        private int idNotification = 0;

        public int IdNotification
        {
            get {return idNotification; }
            set { idNotification = value; }
        }
        private System.DateTime dateEnvoi;

        public System.DateTime DateEnvoi
        {
            get {return dateEnvoi; }
            set { dateEnvoi = value; }
        }
        private string contenu = "";

        public string Contenu
        {
            get {return contenu; }
            set { contenu = value; }
        }
        private int fkIdTechnicien = 0;

        public int FkIdTechnicien
        {
            get {return fkIdTechnicien; }
            set {fkIdTechnicien = value; }
        }
    }
}
