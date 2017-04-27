using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using System.Globalization;
using LibDao;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dispatcher
{
    //[System.ComponentModel.DesignerCategory("Code")] // Pour faire disparaitre le designer
    public partial class DispatcherForm
    {
        GMapOverlay overlayOne; // objet qui contiendra les marqueurs et les routes
        // Permet de mémoriser le marqueur du client sélectionné pour pouvoir éffacer ce client lorsqu'un nouveau client
        // est sélectionné
        GMarkerGoogle markerClient = null;
        GMarkerGoogle markerTechnicienEnRouge = null;
        private void gMapDispatcher_Load(object sender, EventArgs e)
        {
            // Initialisation de la carte en utilisant la carte GoogleMaps:
            gMapDispatcher.MapProvider = GMapProviders.GoogleMap;
            // détermination des valeurs min, max et initiale du zoom
            gMapDispatcher.MinZoom = 3;
            gMapDispatcher.MaxZoom = 18;
            gMapDispatcher.Zoom = 13;

            gMapDispatcher.Manager.Mode = AccessMode.ServerAndCache;

            // centrage de départ de la carte sur Lille
            gMapDispatcher.SetPositionByKeywords("Lille, France");
            //ajout des sur-impression pour les marqueurs
            overlayOne = new GMapOverlay("OverlayOne");
            ////ajout de overlay à la map pour placer les marqueurs
            gMapDispatcher.Overlays.Add(overlayOne);
        }

        //**************************************************************************************************
        // Récupération des techniciens + Affichage sur la carte et Clients + Affichage dans les dataGridView
        //**************************************************************************************************    
        void afficherListeTechnicienActif() // Affiche que les techniciens qui ont une position enregistrée
        {
            List<VTechnicienItinerant> listTechnicienItinerant = null;
            try
            {
                using (Manager manager = new Manager())
                {
                    manager.getListe(ref listTechnicienItinerant, "viewPosTechniciensActifs");
                    // On rempli le dataGridView des techniciens itinérants
                    foreach (VTechnicienItinerant chaqueTechnicien in listTechnicienItinerant)
                    {
                        if (chaqueTechnicien.Latitude != String.Empty && chaqueTechnicien.Longitude != String.Empty)
                        {
                            dgvListeTechniciens.Rows.Add(
                                    chaqueTechnicien.LoginT,
                                    chaqueTechnicien.Prenom,
                                    chaqueTechnicien.Nom,
                                    chaqueTechnicien.Latitude,
                                    chaqueTechnicien.Longitude
                                    );
                            // Obliger de préciser la culture lors de la conversion car les valeurs sont inscrites 
                            // en BDD avec un point au lieu d'une virgule
                            Double dlatitude = Convert.ToDouble(chaqueTechnicien.Latitude, new CultureInfo("en-Gb"));
                            Double dlongitude = Convert.ToDouble(chaqueTechnicien.Longitude, new CultureInfo("en-Gb"));
                            PointLatLng latLongTechnicien = new PointLatLng(dlatitude, dlongitude);
                            GMarkerGoogle markerTechnicien = new GMarkerGoogle(latLongTechnicien, GMarkerGoogleType.green);
                            markerTechnicien.ToolTip = new GMapToolTip(markerTechnicien);
                            markerTechnicien.ToolTipText = chaqueTechnicien.Prenom + " " + chaqueTechnicien.Nom;
                            overlayOne.Markers.Add(markerTechnicien);
                        }
                    }
                    // Trier le dataGridView par ordre alphabétique des noms de technicien
                    dgvListeTechniciens.Sort(dgvListeTechniciens.Columns[2], ListSortDirection.Ascending);
                    dgvListeTechniciens.Rows[2].Selected = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        //**************************************************************************************************      
        private void dgvListeTechniciens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex; // indice de la ligne sélectionnée
            String prenom = (String)dgvListeTechniciens.Rows[IdxLigneActuelle].Cells[1].Value;
            String nom = (String)dgvListeTechniciens.Rows[IdxLigneActuelle].Cells[2].Value;

            // recherche du marqueur correspondant au technicien sélectionné           
            for (int index = 0; index < overlayOne.Markers.Count; index++)
            {
                if (overlayOne.Markers[index].ToolTipText == (prenom + " " + nom))
                {
                    // Marqueur technicien trouvé
                    GMarkerGoogle markerTechnicien = (GMarkerGoogle)overlayOne.Markers[index];
                    if (markerTechnicien.Type == (GMarkerGoogleType.green))
                    {
                        // Il faut faire passer le marqueur rouge en vert
                        // On supprime le marqueur rouge et on en crée un en vert avec les mêmes données
                        if (markerTechnicienEnRouge != null)
                        {
                            GMarkerGoogle newMarkerTechnicienVert = new GMarkerGoogle(markerTechnicienEnRouge.Position, GMarkerGoogleType.green);
                            newMarkerTechnicienVert.ToolTipText = markerTechnicienEnRouge.ToolTipText;                          
                            overlayOne.Markers.Remove(markerTechnicienEnRouge);
                            overlayOne.Markers.Add(newMarkerTechnicienVert);
                            markerTechnicienEnRouge = null;
                        }
                        // On enlève le marque vert pour le remplacer par un rouge
                        overlayOne.Markers.Remove(markerTechnicien);
                        markerTechnicien = new GMarkerGoogle(markerTechnicien.Position, GMarkerGoogleType.red);
                        markerTechnicien.ToolTipText = prenom + " " + nom;
                        overlayOne.Markers.Add(markerTechnicien);
                        markerTechnicienEnRouge = markerTechnicien;
                        calculerTrajet();
                    }
                }
            }
        }

        //**************************************************************************************************
        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex; // indice de la ligne sélectionnée
            int idClient = (int)dgvClient.Rows[IdxLigneActuelle].Cells[0].Value;
            String latitude = (String)dgvClient.Rows[IdxLigneActuelle].Cells[3].Value;
            String longitude = (String)dgvClient.Rows[IdxLigneActuelle].Cells[4].Value;

            // On a sélectionné un client on renseigne le marqueur pour ce client
            if (latitude != String.Empty && longitude != String.Empty)
            {
                // Obliger de préciser la culture lors de la conversion car les valeurs sont inscrites 
                // en BDD avec un point au lieu d'une virgule
                Double dlatitude = Convert.ToDouble(latitude, new CultureInfo("en-Gb"));
                Double dlongitude = Convert.ToDouble(longitude, new CultureInfo("en-Gb"));
                // Création d'un objet qui contient contients les lat long
                PointLatLng latLongClient = new PointLatLng(dlatitude, dlongitude);

                if (markerClient == null)
                {
                    // il faut créer le marqueur client et l'afficher
                    markerClient = new GMarkerGoogle(latLongClient, GMarkerGoogleType.yellow_small);
                    markerClient.Position = latLongClient;
                    markerClient.ToolTipText = (String)dgvClient.Rows[IdxLigneActuelle].Cells[1].Value;
                    overlayOne.Markers.Add(markerClient);
                }
                else
                {
                    // la marqueur existe, il faut seulement changer sa position et son ToolTipText
                    markerClient.Position = latLongClient;
                    markerClient.ToolTipText = (String)dgvClient.Rows[IdxLigneActuelle].Cells[1].Value;
                    gMapDispatcher.UpdateMarkerLocalPosition(markerClient);
                }

                gMapDispatcher.Invalidate(); // on force le "control" a se redessiner
                calculerTrajet();
            }
        }

        //**************************************************************************************************
        void calculerTrajet() // Via L'apiGoogle Distance
        {
            if ((markerTechnicienEnRouge != null) && (markerClient != null))
            {
                String latOrigine = markerTechnicienEnRouge.Position.Lat.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                String longOrigine = markerTechnicienEnRouge.Position.Lng.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                String latDestination = markerClient.Position.Lat.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                String longDestination = markerClient.Position.Lng.ToString(CultureInfo.CreateSpecificCulture("en-GB"));

                UseGoogleApiDistance useGoogleApiDistance =
                    new UseGoogleApiDistance(latOrigine + "," + longOrigine, latDestination + "," + longDestination);
                lblValDureeTransport.Text = useGoogleApiDistance.DuréeTrajet;
                lblValDistance.Text = useGoogleApiDistance.DistanceTrajet;
            }
        }
    }
}