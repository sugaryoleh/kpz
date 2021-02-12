using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public partial class Hotel
    {
        public interface IBookingManager
        {
            public bool AddBooking(Booking booking);
            public bool DeleteBooking(Booking booking);
            public bool ChangeRoom(Booking booking, Room room);
            public bool ChangeCheckIn(Booking booking, DateTime dt);
            public bool ChangeCheckOut(Booking booking, DateTime dt);
            public bool AddResident(Booking booking, Customer customer);
            public bool DeleteResident(Booking booking, Customer customer);
        }
    }
}
