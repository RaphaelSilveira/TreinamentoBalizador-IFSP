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
        public Boolean VerifyMovement(FormatedCoordinatesModel formatedCoordinates)
        {
            String endPoint = "verify-movement";

            Console.WriteLine("comunication" + endPoint);
            var request = (HttpWebRequest)WebRequest.Create("http://172.16.3.56:8080/" + endPoint);
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
                result = Boolean.Parse(streamReader.ReadToEnd());
            }

            return result;
        }

        public Boolean SaveMovement(FormatedCoordinatesModel formatedCoordinates)
        {
            String endPoint = "save-movement";

            Console.WriteLine("comunication" + endPoint);
            var request = (HttpWebRequest)WebRequest.Create("http://172.16.3.56:8080/" + endPoint);
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
                HttpStatusCode statusCode = ((HttpWebResponse)response).StatusCode;
                Console.WriteLine(statusCode.ToString());
                if (statusCode.ToString() == "200")
                {
                    result = true;
                }
            }

           
            return result;
        }


    }
}
