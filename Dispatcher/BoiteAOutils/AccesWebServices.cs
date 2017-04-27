using NETWORKLIST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dispatcher.refValidEmail;
using Dispatcher.refWsSms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

//https://www.codeproject.com/articles/34650/how-to-use-the-windows-nlm-api-to-get-notified-of
//https://domy59efficom.eu/WebServiceVerificationEmail.asmx
//https://domy59efficom.eu/WebServiceSms.asmx


namespace Dispatcher
{
    public class AccesWebServices
    {
        static String clePublicDuCerticatChiffrement = ""; // cle sera lue dans le fichier de configuration de l'application

        static bool connexionDomy59Valid = false;

        public static bool ConnexionDomy59Valid
        {
            get { return AccesWebServices.connexionDomy59Valid; }
        }
        // Déclaration des références en static pour pouvoir les utiliser directement 
        // dans les autres parties de l'application
        static WebServiceVerificationEmail proxyWsEmail = null;

        public static WebServiceVerificationEmail ProxyWsEmail
        {
            get { return AccesWebServices.proxyWsEmail; }
        }
        static WebServiceSms proxySMS = null;

        public static WebServiceSms ProxySMS
        {
            get { return AccesWebServices.proxySMS; }
        }

        //********************************************************************************************        
        // Vérification entrée DNS
        //********************************************************************************************        
        private static bool HasConnection()
        {
            try
            {
                // Vérifier que l'entrée dns est possible pour cette adresse
                // Il faudrait vider le cache DNS pour fiabiliser....
                IPHostEntry i = Dns.GetHostEntry("domy59efficom.eu");
                return true;
            }
            catch
            {
                return false;
            }
        }
        //********************************************************************************************
        // Vérification état du réseau (cable connecté?)
        //********************************************************************************************        
        private static bool NetworkIsAvailable()
        {
            var all = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in all)
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    continue; // On ne controle pas l'interface 127.0.0.1
                //if (item.Name.ToLower().Contains("virtual") || item.Description.ToLower().Contains("virtual"))
                //    continue; //On ne controle pas l'état des cartes réseaux virtuelles comme VmWare
                if (item.OperationalStatus == OperationalStatus.Up) // cable réseau branché ?
                {
                    return true;
                }
            }
            return false;
        }

        //*******************************************************************************************************
        // Cette methode est appelée par le delegue RemoteCertificateValidationDelegate
        // vérification de la validité du certificat
        //*******************************************************************************************************
       static bool demandeDeValidationDuCertificat(
           object sender,
           X509Certificate certificate,
           X509Chain chain,
           SslPolicyErrors sslPolicyErrors)
        {
           // On ne vérifie que la clé publique
            if (// vérification par rapport au contenu de la clé publique du certificat
                // le certificat a été installé sur le serveur web
                (certificate.GetPublicKeyString() == clePublicDuCerticatChiffrement)
)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       //********************************************************************************************        
        public static bool testAccesWS()
        {
            connexionDomy59Valid = false;
            clePublicDuCerticatChiffrement = ConfigurationManager.AppSettings["CLE_PUBLIC"].ToString();
            // Objet qui permet de vérifier l'état du réseau
            NetworkListManager networkListManager = new NetworkListManager();
            try
            {
                if ((NetworkIsAvailable()) &&
                (HasConnection()) &&
                networkListManager.IsConnectedToInternet) // test complet vers internet
                {
                    // Récupération du certificat publique de la liaison Https
                    ServicePointManager.ServerCertificateValidationCallback =
                       new RemoteCertificateValidationCallback(demandeDeValidationDuCertificat);

                    // Vérification de l'accès au webService WsEmail
                    proxyWsEmail = new WebServiceVerificationEmail();
                    if (proxyWsEmail.Test() != "")
                    {
                        // Le service de vérification des email a répondu
                        //MessageBox.Show(proxyWsEmail.Test());
                        // On teste la réponse du service d'envoi de SMS
                        proxySMS = new WebServiceSms();
                        // Vérification de l'accès au webService WsSMS
                        if (proxySMS.Test() == "OK")
                        {
                            // Le service Envoi de SMS a répondu
                            // MessageBox.Show(proxySMS.Test());
                            connexionDomy59Valid = true;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return connexionDomy59Valid;
        }
    }
}
