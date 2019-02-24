using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class RESTManager
    {
        private const string APPID = "APPID=c4538c206256f7f44ab0a1a940fa8077";
        public RootObject GetWeatherInfo(string city)
        {
            string json = "";
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&" + APPID + "&units=metric";
            RootObject weather = new RootObject();
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(url);
                weather = JsonConvert.DeserializeObject<RootObject>(json);

            }
            return weather;
        }
        public Image GetImage(string imageCode)
        {
            string url = $"http://openweathermap.org/img/w/{imageCode}.png";
            WebRequest request = WebRequest.Create(url);
            Image image;
            using (WebResponse webResponse = request.GetResponse())
            {
                var stream = webResponse.GetResponseStream();           
                image = Bitmap.FromStream(stream);        
            }
            return image;

        }
    }
}
