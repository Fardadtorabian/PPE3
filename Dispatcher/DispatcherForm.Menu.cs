using System;
using System.Windows.Forms;

namespace Dispatcher
{
    //[System.ComponentModel.DesignerCategory("Code")] // Pour faire disparaitre le designer
    public partial class DispatcherForm
    {
        //**************************************************************************************************
        // GESTION DES MENUS 
        //**************************************************************************************************   
        //**************************************************************************************************
        // Actions Menu Item Client
        //**************************************************************************************************
        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterClientForm formulaireAjouterClient = new AjouterClientForm();
            //formulaire modal
            formulaireAjouterClient.ShowDialog();
        }
        //**************************************************************************************************
        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierSupprimerClientForm formulaireModifierSupprimerClient = new ModifierSupprimerClientForm();
            formulaireModifierSupprimerClient.ShowDialog();
        }

        //**************************************************************************************************
        // Actions Menu Item Technicien
        //**************************************************************************************************       
        private void mAjoutTechnicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterTechnicienForm formulaireAjouterTechnicien = new AjouterTechnicienForm();
            formulaireAjouterTechnicien.ShowDialog();
        }

        //**************************************************************************************************
      
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterPrestForm formulaireAjouterPrest = new AjouterPrestForm();
            formulaireAjouterPrest.ShowDialog();
        }
        private void modifierTechnicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierSupprimerTechnicienForm formulaireModifierSupprimerTechnicien = new ModifierSupprimerTechnicienForm();
            formulaireModifierSupprimerTechnicien.ShowDialog();
        }

        //**************************************************************************************************
        // Actions Menu Item SMS
        //**************************************************************************************************      
        private void envoiSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnvoiSMSForm formulaireEnvoiSms = new EnvoiSMSForm();
            formulaireEnvoiSms.ShowDialog();
        }

        //**************************************************************************************************
        //**************************************************************************************************
        // Actions Menu Item Matériel
        //**************************************************************************************************
        //**************************************************************************************************
        private void ajouterMaterielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterMaterielForm formulaireAjouterMateriel = new AjouterMaterielForm();
            formulaireAjouterMateriel.ShowDialog();
        }
        //**************************************************************************************************
        private void modifierMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierSupprimerMaterielForm formulaireModifierSupprimerMateriel = new ModifierSupprimerMaterielForm();
            formulaireModifierSupprimerMateriel.ShowDialog();
        }
        //**************************************************************************************************
        private void affecterMaterielAUnTechnicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AffecterMaterielFormulaire affecterMaterielFormulaire = new AffecterMaterielFormulaire();
            affecterMaterielFormulaire.ShowDialog();
        }
        //**************************************************************************************************
        //**************************************************************************************************
        // Actions Menu Item Intervention
        //**************************************************************************************************
        //**************************************************************************************************
        private void ajouterToolStripMenuItemIntervention_Click(object sender, EventArgs e)
        {
            AjouterPlanningForm formulaireAjouterPlanning = new AjouterPlanningForm();
            formulaireAjouterPlanning.ShowDialog();
        }
        //**************************************************************************************************
        private void supprimerToolStripMenuItemIntervention_Click(object sender, EventArgs e)
        {
            SupprimerInterventionForm formulaireSupprimerPlanning = new SupprimerInterventionForm();
            formulaireSupprimerPlanning.ShowDialog();
        }
        //**************************************************************************************************
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierInterventionForm modifierInterventionForm = new ModifierInterventionForm();
            modifierInterventionForm.ShowDialog();
        }
        //**************************************************************************************************
        private void aperçuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApercuInterventionForm apercuInterventionForm = new ApercuInterventionForm();
            apercuInterventionForm.ShowDialog();
        }
        //**************************************************************************************************

        //**************************************************************************************************
        // Validation des menus par rapport au groupe de l'utilisateur connecté
        //**************************************************************************************************  
        void validMenu(String groupe)
        {
            switch (groupe)
            {
                case ("Dispatcher"):
                    {
                        // menu client
                        toolStripMenuItemClient.Enabled = true;
                        modifierClientToolStripMenuItem.Enabled = true;
                        // menu intervention
                        toolStripMenuItemIntervention.Enabled = true;
                        ajouterToolStripMenuItemIntervention.Enabled = true;
                        supprimerToolStripMenuItemIntervention.Enabled = true;
                        modifierToolStripMenuItem.Enabled = true;
                        aperçuToolStripMenuItem.Enabled = true;
                        // menu SMS
                        envoiSMSToolStripMenuItem.Enabled = true;
                    }
                    break;
                case ("Commercial"):
                    {
                        // menu client
                        toolStripMenuItemClient.Enabled = true;
                        ajouterClientToolStripMenuItem.Enabled = true;
                        modifierClientToolStripMenuItem.Enabled = true;
                        // menu intervention
                        toolStripMenuItemIntervention.Enabled = true;
                        aperçuToolStripMenuItem.Enabled = true;
                    }
                    break;
                case ("Informatique"):
                    {
                        // menu Matériel
                        gestionMatérielToolStripMenuItem.Enabled = true;
                        ajouterMaterielToolStripMenuItem.Enabled = true;
                        modifierMatérielToolStripMenuItem.Enabled = true;
                        affecterMaterielAUnTechnicienToolStripMenuItem.Enabled = true;
                    }
                    break;

                case ("Administration"):
                    {
                        // menu client
                        toolStripMenuItemClient.Enabled = true;
                        ajouterClientToolStripMenuItem.Enabled = true;
                        modifierClientToolStripMenuItem.Enabled = true;
                        // menu intervention
                        toolStripMenuItemIntervention.Enabled = true;
                        ajouterToolStripMenuItemIntervention.Enabled = true;
                        supprimerToolStripMenuItemIntervention.Enabled = true;
                        modifierToolStripMenuItem.Enabled = true;
                        aperçuToolStripMenuItem.Enabled = true;
                        // menu SMS
                        envoiSMSToolStripMenuItem.Enabled = true;
                        // menu Matériel
                        gestionMatérielToolStripMenuItem.Enabled = true;
                        ajouterMaterielToolStripMenuItem.Enabled = true;
                        modifierMatérielToolStripMenuItem.Enabled = true;
                        affecterMaterielAUnTechnicienToolStripMenuItem.Enabled = true;
                        // menu Technicien
                        TechnicienToolStripMenuItem.Enabled = true;
                        mAjoutTechnicienToolStripMenuItem.Enabled = true;
                        modifierTechnicienToolStripMenuItem.Enabled = true;
                    }
                    break;
                case ("Recherche"):
                    {
                        // menu client
                        toolStripMenuItemClient.Enabled = true;
                        ajouterClientToolStripMenuItem.Enabled = true;
                        modifierClientToolStripMenuItem.Enabled = true;
                        // menu intervention
                        toolStripMenuItemIntervention.Enabled = true;
                        ajouterToolStripMenuItemIntervention.Enabled = true;
                        supprimerToolStripMenuItemIntervention.Enabled = true;
                        modifierToolStripMenuItem.Enabled = true;
                        aperçuToolStripMenuItem.Enabled = true;
                        // menu SMS
                        envoiSMSToolStripMenuItem.Enabled = true;
                        // menu Matériel
                        gestionMatérielToolStripMenuItem.Enabled = true;
                        ajouterMaterielToolStripMenuItem.Enabled = true;
                        modifierMatérielToolStripMenuItem.Enabled = true;
                        affecterMaterielAUnTechnicienToolStripMenuItem.Enabled = true;
                        // menu Technicien
                        TechnicienToolStripMenuItem.Enabled = true;
                        mAjoutTechnicienToolStripMenuItem.Enabled = true;
                    }
                    break;
                default:
                    {
                        MessageToast.Show("Vous n'êtes pas autorisé à utiliser ce logiciel", "ATTENTION !!");
                    }
                    break;
            }
        }
    }
}