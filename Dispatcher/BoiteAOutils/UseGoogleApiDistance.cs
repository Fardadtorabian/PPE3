using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.IO;

//https://developers.google.com/maps/documentation/distance-matrix/?hl=fr
//https://developers.google.com/maps/documentation/distance-matrix/intro?hl=fr#travel_modes

namespace Dispatcher
{
    // Pour sésérialiser le format Json le désérialisateur a besoin de connaitre les entités contenues dans la réponse JSON
    // Pour créer les classes on utilise l'outils suivant : http://json2csharp.com/
    public class Distance
    {
        public string text { get; set; }
        public int value { get; set; }
    }
    //*************************************************************************************************************
    public class Duration
    {
        public string text { get; set; }
        public int value { get; set; }
    }
    //*************************************************************************************************************
    public class Element
    {
        public Distance distance { get; set; }
        public Duration duration { get; set; }
        public string status { get; set; }
    }

    public class Row
    {
        public List<Element> elements { get; set; }
    }
    //*************************************************************************************************************
    public class RootObject
    {
        public List<string> destination_addresses { get; set; }
        public List<string> origin_addresses { get; set; }
        public List<Row> rows { get; set; }
        public string status { get; set; }
    }
    //*************************************************************************************************************
    class UseGoogleApiDistance
    {
        String duréeTrajet;

        public String DuréeTrajet
        {
            get { return duréeTrajet; }
        }
        String distanceTrajet;

        public String DistanceTrajet
        {
            get { return distanceTrajet; }
        }
        public UseGoogleApiDistance(string origine,String destination)
        {
            try
            {
                HttpWebRequest request =
               (HttpWebRequest)WebRequest.Create("http://maps.googleapis.com/maps/api/distancematrix/json?origins="
                + origine + "&destinations=" + destination
                + "&mode=driving&language=fr-FR&sensor=false");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    if (!string.IsNullOrEmpty(result))
                    {
                        RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(result);
                        distanceTrajet = rootObject.rows[0].elements[0].distance.text;
                        duréeTrajet = rootObject.rows[0].elements[0].duration.text;
                    }
                }
            }
            catch (Exception)
            {
                distanceTrajet = String.Empty;
                duréeTrajet = String.Empty;
            }
        }
    }
}
