using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApplication.Models
{
    public class RainingMen
    {

        public Object getForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Seattle&APPID=146a5211dc2b5bde5090dd0c3b7aa38e&units=imperial";
            //sychronus client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);
            return jsonContent;
        }



    }
}