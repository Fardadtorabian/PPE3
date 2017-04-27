using LibraryToastNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatcher
{
    public static class MessageToast
    {
        //*************************************************************************************
        // Paramètre message obligatoire, titre facultatif et mis d'office à vide
        public static bool Show(String message,String titre="")
        {
            Notification maNotification = new Notification
                (
                titre,   //  titre vide
                message, // Le texte de la notification
                3,  // La durée en seconde de la visibilité de la notification
                FormAnimator.AnimationMethod.Slide, // Le mouvement d'appartion du texte
                FormAnimator.AnimationDirection.Up // Le sens d'apparition de la notification
                );

            maNotification.Show();
            return true;
        }

        //*************************************************************************************
       // Paramètres message,titre et durée notification obligatoires
        public static bool Show(String message, String titre,int duree)
        {
            Notification maNotification = new Notification
                (
                titre,   // un titre
                message, // Le texte de la notification
                duree,  // La durée en seconde de la visibilité de la notification
                FormAnimator.AnimationMethod.Slide, // Le mouvement d'appartion du texte
                FormAnimator.AnimationDirection.Up // Le sens d'apparition de la notification
                );

            maNotification.Show();
            return true;
        }

        //*************************************************************************************
        // Paramètre message, titre,durée obligatoire
        // Animation et direction facultatifs
        public static bool Show(String message,String titre,int duree,
            FormAnimator.AnimationMethod animationMethod = FormAnimator.AnimationMethod.Slide, 
            FormAnimator.AnimationDirection animationDirection = FormAnimator.AnimationDirection.Up)
        {
            Notification maNotification = new Notification
                (
                titre,   // un titre
                message, // Le texte de la notification
                duree,  // La durée en seconde de la visibilité de la notification
                animationMethod, // Le mouvement d'appartion du texte
                animationDirection // Le sens d'apparition de la notification
                );

            maNotification.Show();
            return true;
        }
        //*************************************************************************************
    }
}
