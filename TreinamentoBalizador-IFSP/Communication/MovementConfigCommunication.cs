using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

using TreinamentoBalizador_IFSP.Models;

namespace TreinamentoBalizador_IFSP.Communication
{
    class MovementConfigCommunication
    {
        public List<ActiveMovement> GetActiveMovementsList()
        {
            List<ActiveMovement> activeMovements = new List<ActiveMovement>();
            String endPoint = "get-movements";
            
            var request = (HttpWebRequest)WebRequest.Create("http://192.168.0.17:8080/" + endPoint);
            request.ContentType = "application/json";
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                HttpStatusCode statusCode = ((HttpWebResponse)response).StatusCode;
      
                if (statusCode.ToString() == "OK")
                {
                    activeMovements = new JavaScriptSerializer().Deserialize<List<ActiveMovement>>(streamReader.ReadToEnd());
                }
            }

            return activeMovements;
        }
    }
}
