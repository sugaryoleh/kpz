using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace geolocmanager
{
    public class GeolocationManager
    {
        private const string key = "AIzaSyDVHEmrqGJR-3BuxLYJqsVJ1ny6XoqqulA";
        public Tuple<double, double> getCoordinates(string city, string state)
        {
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?address="+city+",+" +state+"&key=" + key);
            WebResponse response = request.GetResponse();
            Tuple<double, double> coords = null;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JObject json = JObject.Parse(responseFromServer);
                var coord = json["results"].Select(t => t).ToList()[0]["geometry"]["location"];
                double lat = (double)coord["lat"];
                double lng = (double)coord["lng"];
                coords = new Tuple<double, double>(lat, lng);
            }
            response.Close();
            return coords;
        }
        public Tuple<double, double> getCoordinates(string address)
        {
            address = FormatURL(address);
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&key=" + key);
            WebResponse response = request.GetResponse();
            Tuple<double, double> coords = null;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JObject json = JObject.Parse(responseFromServer);
                var coord = json["results"].Select(t => t).ToList()[0]["geometry"]["location"];
                double lat = (double)coord["lat"];
                double lng = (double)coord["lng"];
                coords = new Tuple<double, double>(lat, lng);
            }
            response.Close();
            return coords;
        }
        public TimeZone getTimeZone(Tuple<double, double> coordinates)
        {
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/timezone/json?location=" + coordinates.Item1.ToString() + "," + coordinates.Item2.ToString() + "&timestamp=1458000000&key=" + key);
            WebResponse response = request.GetResponse();
            string timeZone;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JObject json = JObject.Parse(responseFromServer);
                timeZone = (string)json["timeZoneId"];
                //Console.Write(responseFromServer);
            }
            response.Close();
            switch (timeZone)
            {
                case "America/Chicago": return TimeZone.Central;
                case "America/New_York": return TimeZone.Eastern;
                default: return TimeZone.other;
            }
        }
        public TimeZone getTimeZone(string city, string state)
        {
            var coords = getCoordinates(city, state);
            return getTimeZone(coords);
        }
        public string GetAddress(Tuple<double, double> coords)
        {
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?latlng=" + coords.Item1.ToString() + "," + coords.Item2.ToString() + "&radius=10&key=" + key);
            WebResponse response = request.GetResponse();
            string address = null;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JObject json = JObject.Parse(responseFromServer);
                address = json["results"][0]["formatted_address"].ToString();//.Select(t => t).ToList()[0]["formatted_address"];
            }
            response.Close();
            return address;
        }
        public string FormatURL(string url)
        {
            return url.Replace(" ", "+");
        }
    }
}
