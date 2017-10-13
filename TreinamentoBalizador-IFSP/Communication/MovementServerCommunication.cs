using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

using TreinamentoBalizador_IFSP.Models;


namespace TreinamentoBalizador_IFSP.Communication
{
    class MovementServerCommunication
    {
        public Boolean VerifyMovement(FormatedCoordinatesModel formatedCoordinates, bool trainingFile)
        {
            Console.WriteLine("comunication" + trainingFile);
            String endPoint = trainingFile ? "save-movement" : "verify-movement";

            Console.WriteLine("comunication" + endPoint);
            var request = (HttpWebRequest)WebRequest.Create("http://192.168.0.49:8080/" + endPoint);
            request.ContentType = "application/json";
            request.Method = "POST";

            bool result = false;
            Console.Write("fazendo request");
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var json = new JavaScriptSerializer().Serialize(formatedCoordinates);

                Console.Write(json);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

            }

            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                try
                {
                    result = Boolean.Parse(streamReader.ReadToEnd());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return result;
        }
    }
}
