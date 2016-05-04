using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace BlackjackGame.Services
{
    public class ServiceManager
    {
        public Uri RestURI { get; set; }

        public ServiceManager(Uri serviceURI)
        {
            RestURI = serviceURI;
        }
        //CallService<int>
        public T CallService<T>()
        {
            WebRequest request = WebRequest.Create(RestURI);
            request.ContentType = "Application/json; charset=utf-8";
            WebResponse response = request.GetResponse();//get response back

            string responseFromServer = string.Empty;
            //opens, reads and closes input stream
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }



            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(responseFromServer));

            T dataObject = (T)serializer.ReadObject(ms);

            return dataObject;
        }
    }
}
