using System;
using System.Collections.Generic;

namespace lab_4_structs
{
    public struct Booking
    {
       
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Room Room { get; set; }
        public Customer Booker { get; set; }
        public HashSet<Customer> Residents { get; set; }
        public Booking(int id, DateTime checkIn, DateTime checkOut, Room room, Customer booker, HashSet<Customer> residents)
        {
            this.ID = id;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.Room = room;
            this.Booker = booker;
            this.Residents = residents;
        }
        public Booking(Booking booking)
        {
            this.ID = booking.ID; /// change
            this.CheckIn = booking.CheckIn;
            this.CheckOut = booking.CheckOut;
            this.Room = booking.Room;
            this.Booker = booking.Booker;
            this.Residents = booking.Residents;
        }
    }
}