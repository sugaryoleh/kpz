using System;
using System.Collections.Generic;
using System.Text;
using static lab_4_structs.Hotel;

namespace lab_4_structs
{
    public partial class Hotel
    {
        public struct User
        {
            public Hotel hotel { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public readonly HotelWorker hw;
            public User(Hotel hotel, HotelWorker hw)
            {
                this.hotel = hotel;
                this.hw = hw;
                username = "rand";
                password = "rand";
            }
            public Tuple<string, string> Login()
            {
                return new Tuple<string, string>(username, password);
            }
        }
    }
}
