using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibDao;
using System.IO;
using Dispatcher;
using LibDao.Entites;

namespace PeuplerTables
{
    class ClassePeuplementTables
    {    
        //*****************************************************************************************************************
        // pour chaque employé il faut :
        // lire le fichier contenant les données à placer dans la table employé (employes.csv)
        // faire un split de chaque ligne du fichier représentant un employé
        // peupler une entité employé et la persister en BDD
        // (inutile dès que l'application est sur l'active directory)
        private void peuplerTableEmploye()
        {
            Employe employe = new Employe();
            using (EmployeManager employeManager = new EmployeManager())
            {
                // Lire chaque ligne du fichier. 
                // Chaque élément du tableau représente une ligne du fichier
                String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\employes.csv", Encoding.GetEncoding("iso-8859-1"));

                foreach (String line in tabLines) // pour toutes les lignes du jeux d'essais
                {
                    String[] str = line.Split(';'); // on a choisi ";" comme séparateur csv
                    employe.LoginE = str[0];
                    employe.Prenom = str[1];
                    employe.Nom = str[2];
                    employe.Groupe = str[3];
                    // On persiste l'entité en BDD
                    employeManager.ajoutModifEmploye(ref employe);
                }
            }
        }

        //*****************************************************************************************************************
        // pour chaque technicien il faut :
        // faire un split du string csv représentant un enregistrement technicien
        // peupler une entité technicien et l'inscrire en BDD
        // liste des valeurs pour peupler la table des techniciens
        // les techniciens ne sont pas enregistrés sur l'actice directory
        // login,mdp,prenom,nom,fk matériel affecté
        private void peuplerTableTechnicien()
        {
            Technicien technicien = new Technicien();
            using (TechnicienManager technicienManager = new TechnicienManager())
            {
                // Lire chaque ligne du fichier. 
                // Chaque élément du tableau représente une ligne du fichier
                String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\Techniciens.csv", Encoding.GetEncoding("iso-8859-1"));

                foreach (String line in tabLines) // pour toutes les lignes du jeux d'essais
                {
                    String[] str = line.Split(';'); // on a choisi # comme séparateur csv
                    if (str[0] != "#") // si oui c'est une ligne de commentaire
                    {
                        technicien.LoginT = str[0];
                        technicien.PasswdT = Utils.getMd5Hash(str[1]);
                        technicien.Prenom = str[2];
                        technicien.Nom = str[3];
                        if (str[4] != "")
                        {
                            technicien.FkIdMateriel = Convert.ToInt32(str[4]); // on pourra affecter d'office un matériel
                        }
                        // On persiste l'entité en BDD
                        technicienManager.ajoutModifTechnicien(ref technicien);
                    }                 
                }
            }
        }

        //*****************************************************************************************************************
        private void peuplerTablePositionTechnicien()
        {
            PositionTechnicien positionTechnicien = new PositionTechnicien();
            String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\PositionsTechniciens.csv", Encoding.GetEncoding("iso-8859-1"));
            using (TechnicienManager technicienManager = new TechnicienManager())
            {
                foreach (String line in tabLines) // pour toutes les lignes du jeux d'essais
                {
                    String[] str = line.Split(';'); // on a choisi ";" comme séparateur csv
                    if (str[0] != "#") // si oui c'est une ligne de commentaire
                    {
                        positionTechnicien.Latitude = str[0];
                        positionTechnicien.Longitude = str[1];
                        positionTechnicien.FkLoginT = str[2];
                        // On persiste l'entité en BDD
                        technicienManager.insUpdatePosTechnicien(ref positionTechnicien);
                    }
                }
            }
        }

        //*****************************************************************************************************************
        private void peuplerTableSessionTechnicien()
        {
            SessionTechnicien sessionTechnicien = new SessionTechnicien();
            String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\SessionTechnicien.csv", Encoding.GetEncoding("iso-8859-1"));
            using (TechnicienManager technicienManager = new TechnicienManager())
            {
                 foreach (String line in tabLines) // pour toutes les lignes du jeux d'essais
                {
                    String[] str = line.Split(';'); // on a choisi ";" comme séparateur csv
                    if (str[0] != "#") // si oui c'est une ligne de commentaire
                    {
                        sessionTechnicien.Jeton = str[0];
                        sessionTechnicien.FkLoginT = str[1];
                        // On persiste l'entité en BDD
                        technicienManager.insUpdateSessionTechnicien(ref sessionTechnicien);
                    }
                }
            }
        }
        //*****************************************************************************************************************
        // pour chaque materiel il faut :
        // faire un split du string csv représentant le materiel
        // peupler une entité materiel et l'inscrire en BDD
        private void peuplerTableMateriel()
        {
            Materiel materiel = new Materiel(); // Création d'un objet matériel qu'il faudra persister
            // Lire chaque ligne du fichier de peuplement de la table matériel 
            // Chaque élément du tableau "tabLines" représente une ligne du fichier
            String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\Materiels.csv", Encoding.GetEncoding("iso-8859-1"));
            using (MaterielManager materielManager = new MaterielManager()) // appel automatique de la methode dispose qui ferme la connexion
            {
                foreach (String line in tabLines) // pour toutes les lignes du jeux d'essais
                {
                    String[] str = line.Split(';'); // on a choisi ; comme séparateur csv
                    if (str[0]!="#") // si oui c'est une ligne de commentaire
                    {
                        materiel.TypeMateriel = str[0];
                        materiel.NumeroSerie = str[1];
                        materiel.NumeroTel = str[2];
                        materiel.Imei = str[3];
                        materiel.IdGoogle = str[4];
                        materiel.FkLoginE = str[5];
                        materiel.EtatMateriel = str[6];
                        // On persiste l'entité en BDD
                        materielManager.insertUpdateMateriel(ref materiel);
                    }
                }
            }
        }

        //*****************************************************************************************************************
        void listerLesMateriels()
        {
            try
            {
                using (Manager manager = new Manager())
                {
                    List<Materiel> listMateriel = new List<Materiel>();
                    manager.getListe(ref listMateriel, "materiel");

                    foreach (Materiel chaqueMateriel in listMateriel)
                    {
                        Console.Write(chaqueMateriel.TypeMateriel + "  " + chaqueMateriel.NumeroSerie
                            + "  " + chaqueMateriel.DateEnregistrement.ToString()
                            + "  " + chaqueMateriel.DateAffectation.ToString());
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //*****************************************************************************************************************
        // pour chaque client il faut :
        // // lire le fichier contenant les données à placer dans la table client (clients.csv)
        // faire un split du string csv représentatnt le client et éventuellment récupérer et convertir l'image du lieu
        // peupler une entité client et la persister en BDD

        private void peuplerTableClient()
        {
            Client client = new Client();
            String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\Clients.csv", Encoding.GetEncoding("iso-8859-1"));

            using (ClientManager clientManager = new ClientManager())
            {
                // chargement de la list de toutes les civilités
                // On utilise la connexion préalablement établie
                List<Civilite> listCivilites = new List<Civilite>();
                using (Manager manager = new Manager(clientManager.getConnexion()))
                {
                    manager.getListe(ref listCivilites, "civilite");
                    foreach (String line in tabLines) // pour tous les clients du jeux d'essais
                    {
                        String[] str = line.Split(';'); // on a choisi ; comme séparateur csv
                        client.Entreprise = str[0];
                        // Dans le fichier de peuplement la civilité est fournie sous forme d'abréviation
                        // Il faut donc retrouver l'id correspondante dans la liste des civilités
                        Civilite elementCivilite = listCivilites.Find(uneCivilite => uneCivilite.Abreviation == str[1]);
                        client.FkIdCivilite = elementCivilite.IdCivilite;
                        client.Prenom = str[2];
                        client.Nom = str[3];
                        client.Adresse = str[4];
                        client.CompAdresse = str[5];
                        client.Ville = str[6];
                        client.CodePostal = str[7];
                        client.NumeroTel = str[8];
                        client.Email = str[9];
                        if (str[10] != "") // y a t il une image correspondant à l'adresse fournie par le client
                        {
                            // il faut charger et convertir l'image
                            // Conversion fichier photo en tableau de byte pour enregistrement en BDD
                            FileStream fs = new FileStream(str[10], FileMode.OpenOrCreate, FileAccess.Read); // on ouvre le fichier de la photo
                            byte[] imageBytes = new byte[fs.Length]; // tableau de byte pour recevoir le contenu des octets de la photo
                            fs.Read(imageBytes, 0, Convert.ToInt32(fs.Length)); // on place le contenu des octets de la photo dans le tableau
                            client.Photoent = imageBytes; // on enregistre dans l'entité
                        }
                        else
                        {
                            client.Photoent = new Byte[0];
                        }
                        client.Latitude = str[11];
                        client.Longitude = str[12];
                        client.FkIdEtatClient = Convert.ToInt32(str[13]);
                        client.FkLoginE = str[14];
                        // On persiste l'entité en BDD
                        clientManager.insUpdateClient(client);
                    }
                }
            }
        }
        //*****************************************************************************************************************
        void listerLesClients()
        {
            try
            {
                using (ClientManager clientManager = new ClientManager())
                {
                    List<Client> listClient = new List<Client>();
                    List<EtatClient> listEtatClient = new List<EtatClient>();
                    List<Civilite> listCivilites = new List<Civilite>();
                    // chargement des listes utilisées
                    // On utilise la connexion préalablement établie
                    using (Manager manager = new Manager(clientManager.getConnexion()))
                    {
                        manager.getListe(ref listCivilites, "civilite");
                        manager.getListe(ref listEtatClient, "etatClient");
                        manager.getListe(ref listClient, "client"); ;

                        foreach (Client chaqueClient in listClient)
                        {
                            // la civilité est fournie via son Id
                            // Il faut retrouver l'abréviation correspondante dans la liste des civilités
                            Civilite elementCivilite = listCivilites.Find(uneCivilite => uneCivilite.IdCivilite == chaqueClient.FkIdCivilite);
                            // idem pour etat client
                            EtatClient elementEtatClient = listEtatClient.Find(unEtatClient => unEtatClient.IdEtatClient == chaqueClient.FkIdEtatClient);

                            Console.Write(elementCivilite.Abreviation + "   " + chaqueClient.Prenom + "  " + chaqueClient.Nom
                                + "  " + chaqueClient.DateCreation.ToString()
                                + "  " + chaqueClient.DateModification.ToString()
                                + "  " + elementEtatClient.Etat);

                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //*****************************************************************************************************************
        void peuplerTableIntervention()
        {
            DateTime dateDuJour = DateTime.Now.Date.AddHours(8); // la journée débute à 8 heures

            String[] tabLines = System.IO.File.ReadAllLines(@"..\..\..\DonneesInitialesBdd\Interventions.csv", Encoding.GetEncoding("iso-8859-1"));
            Intervention intervention = new Intervention();
            using (InterventionManager interventionManager = new InterventionManager()) // appel automatique de la methode dispose qui ferme la connexion
            {
                foreach (String line in tabLines) // pour toutes les lignes du jeux d'essais
                {
                    String[] str = line.Split(';'); // on a choisi ";" comme séparateur csv
                    if (str[0] != "#") // si oui c'est une ligne de commentaire
                    {
                        intervention.CompteRendu = str[0];
                        intervention.DebutIntervention = dateDuJour.AddDays(Convert.ToDouble(str[1]));
                        intervention.DebutIntervention = intervention.DebutIntervention.AddHours(Convert.ToDouble(str[2]));
                        intervention.FinIntervention = dateDuJour.AddDays(Convert.ToDouble(str[1]));
                        intervention.FinIntervention = intervention.FinIntervention.AddHours(Convert.ToDouble(str[3]));
                        intervention.ObjectifVisite = str[4];
                        if (str[5] != "") // y a t il une image correspondant à l'intervention
                        {
                            // il faut charger et convertir l'image
                            // Conversion fichier photo en tableau de byte pour enregistrement en BDD
                            FileStream fs = new FileStream(str[5], FileMode.OpenOrCreate, FileAccess.Read); // on ouvre le fichier de la photo
                            byte[] imageBytes = new byte[fs.Length]; // tableau de byte pour recevoir le contenu des octets de la photo
                            fs.Read(imageBytes, 0, Convert.ToInt32(fs.Length)); // on place le contenu des octes de la photo dans le tableau
                            intervention.PhotoLieu = imageBytes; // on enregistre dans l'entité
                        }
                        else
                        {
                            intervention.PhotoLieu = new Byte[0];
                        }
                        intervention.NomContact = str[6];
                        intervention.PrenomContact = str[7];
                        intervention.TelContact = str[8];
                        intervention.EtatVisite = str[9];
                        intervention.FkLoginE = str[10];
                        if (str[11] != "")
                        {
                            intervention.FkIdClient = Convert.ToInt32(str[11]); // on doit affecter d'office un client à l'intervention
                        }
                        intervention.FkLoginT = str[12];

                        // On persiste l'entité en BDD
                        interventionManager.ajouterIntervention(intervention);
                    }
                }
            }
        }
        //*****************************************************************************************************************
        void listerInterventions()
        {
            try
            {
                using (Manager manager = new Manager())
                {
                    List<Intervention> listIntervention = new List<Intervention> ();
                    manager.getListe(ref listIntervention, "intervention");
                    foreach (Intervention chaqueIntervention in listIntervention)
                    {
                        Console.Write(chaqueIntervention.NomContact + "  " + chaqueIntervention.FkLoginT
                            + "  " + chaqueIntervention.DebutIntervention.ToString()
                            + "  " + chaqueIntervention.FinIntervention.ToString());
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //*****************************************************************************************************************
        void listerInterventionsTechnicienDate()
        {
            Intervention uneIntervention = new Intervention();
            uneIntervention.DebutIntervention = DateTime.Now.Date;
            uneIntervention.FkLoginT = "tvsilvestre";
            try
            {
                using (InterventionManager interventionManager = new InterventionManager())
                {
                    List<Intervention> listIntervention = interventionManager.listeInterventionsTechnicien(uneIntervention);
                    foreach (Intervention chaqueIntervention in listIntervention)
                    {
                        Console.Write(chaqueIntervention.NomContact + "  " + chaqueIntervention.FkLoginT
                            + "  " + chaqueIntervention.DebutIntervention.ToString()
                            + "  " + chaqueIntervention.FinIntervention.ToString());
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //*****************************************************************************************************************
        ClassePeuplementTables()
        {
            // APPELS DES METHODES DE CLASSE DANS LE CONSTRUCTEUR
            //peuplerTableEmploye();
            peuplerTableMateriel();
            peuplerTableTechnicien();
            peuplerTableClient();
            listerLesClients();
            peuplerTableIntervention();
            listerInterventions();
            listerInterventionsTechnicienDate();
            listerLesMateriels();
            peuplerTablePositionTechnicien();
            peuplerTableSessionTechnicien();
        }
        //*****************************************************************************************************************
        static void Main(string[] args)
        {
            new ClassePeuplementTables();
        }
    }
}
