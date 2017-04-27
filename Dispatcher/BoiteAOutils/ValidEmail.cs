using System;
using Dispatcher.refValidEmail;


//Adresse du WebService proposé :  
//https://domy59efficom.eu/WebServiceVerificationEmail.asmx

namespace Dispatcher
{
    public class ValidEmail
    {     
        public ValidEmail(String emailAVerifier, ref String reponseWsValidEmail)
        {
            try
            {
                // On prépare un objet pour réaliser une authentification basique (login, mot de passe)
                // transmis via l'entete soap
                AuthentificationEnteteSoap authentification = new AuthentificationEnteteSoap();
                // Création et peuplement de l'objet utilisateur
                Utilisateur utilisateur = new Utilisateur();
                utilisateur.Login = UtilisateurConnecte.Login;
                utilisateur.Password = "P@sswd/59"; // le même pour utiliser le WS
                // L'objet autentification n'a qu'un attribut "user" qui est un objet utilisateur
                authentification.user = utilisateur;
                // on transmet l'authentification via l'entete Soap au Webservice
                AccesWebServices.ProxyWsEmail.AuthentificationEnteteSoapValue = authentification; // on transmet l'authentification
                // Appel de la méthode distante et affichage du message de retour du serveur
                String retourWS = AccesWebServices.ProxyWsEmail.VerifieEmail(emailAVerifier); // adresse email a vérifier
                if (retourWS != "4")
                {
                    if (retourWS == "0") 
                    {
                        reponseWsValidEmail = "Email valide";
                    }

                    if (retourWS == "3")
                    {
                        reponseWsValidEmail = "Email erroné";
                    }
                }
                else
                {
                    reponseWsValidEmail = "Erreur d'authentification";
                }
            }
            catch(Exception)
            {
                reponseWsValidEmail = "Pas de service vérification email disponible";
            }
        }       
    }
}
