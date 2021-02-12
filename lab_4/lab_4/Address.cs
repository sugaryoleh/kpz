using System;
using System.Text;

namespace lab_4_structs
{
    public struct Address
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }
        public Address(string country, string city, string street, int buildingNumber)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }
       
        public string Country
        {
           get { return country;  }
           set { country = value;  }
        }
        override public string ToString()
        {
            string repr = string.Format("{0}, {1}, {2}, {3}", country, city, street, buildingNumber);
            return repr;
        }
        public static implicit operator Coordinates(Address address) => new Coordinates(new geolocmanager.GeolocationManager().getCoordinates(address.ToString()));
        public static explicit operator Address(Coordinates coords) => Address.GeolocManagerSerializer(new geolocmanager.GeolocationManager().
            GetAddress(new Tuple<double, double>(coords.x, coords.y)));

        public static Address GeolocManagerSerializer(string address)
        {
            string[] parts = address.Split(",");
            return new Address(parts[4], parts[2], parts[0], int.Parse(parts[1]));
        }
    }
}