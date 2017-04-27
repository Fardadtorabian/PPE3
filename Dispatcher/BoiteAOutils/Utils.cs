using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Dispatcher
{
    public static class Utils
    {
        //*************************************************************************************
        public static Byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        //*************************************************************************************
        public static Image byteArrayToImage(Byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        //*************************************************************************************
        // methode qui fourni l'empreinte numérique de la chaine de caractères passée en paramètre
        public static String getMd5Hash(String input)
        {
            MD5 md5HashAlgo = MD5.Create();
            // Place le texte à hacher dans un tableau d'octets
            byte[] byteArrayToHash = Encoding.UTF8.GetBytes(input);

            // Hash le texte et place le résulat dans un tableau d'octets
            byte[] hashResult = md5HashAlgo.ComputeHash(byteArrayToHash);

            // representation du tableau d'octets en chaine de caractères
            string empreinte = BitConverter.ToString(hashResult)
                // Sans les tirets
               .Replace("-", string.Empty)
                // Chaine en minuscules
               .ToLower();
            return empreinte;
        }
        //*************************************************************************************
        // Il faut ajouter un 0 si un seul caractère avant la virgule
        public static String formatageLongitude(string sVal, char separateur)
        {
            string[] sDouble;
            string Val, val1, Val2;

            sDouble = sVal.Split(new char[1] { separateur });
            val1 = sDouble[0];
            if (val1.Length == 1)
            {
                val1 = "0" + val1;
                Val2 = sDouble[1];
                sVal = val1 + "." + Val2;
            }
            return sVal;
        }
        //*************************************************************************************
    }
}
