using LibDao;
using LibDao.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dispatcher
{
    public class ChargementListes
    {
        //**************************************************************************
        // Déclaration des atributs static et des propriétés en lecture seule
        //**************************************************************************
        private static List<Civilite> listCivilites = null;
        private static List<EtatClient> listEtatClient = null;

        public static List<EtatClient> ListEtatClient
        {
            get { return ChargementListes.listEtatClient; }
        }

        public static List<Civilite> ListCivilites
        {
            get { return ChargementListes.listCivilites; }
        }
        //**************************************************************************
        // Méthode pour récupérer les listes
        //**************************************************************************
        public static void chargementDesListe()
        {
            using (Manager manager = new Manager())
            {
                manager.getListe(ref listCivilites, "civilite");
                manager.getListe(ref listEtatClient, "etatClient");
            }
        }
    }
}
