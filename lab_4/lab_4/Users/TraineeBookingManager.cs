using System;
using System.Collections.Generic;
using System.Text;
using static lab_4_structs.Hotel;

namespace lab_4_structs
{
    public partial class Hotel
    {
        public class TraineeBookingManager : IBookingManager
        {
            public User user { get; set; }
            public TraineeBookingManager(Hotel hotel, HotelWorker hw)
            {
                user = new User(hotel, hw);
            }
            public bool AddBooking(Booking booking)
            {
                BookingDateComparer bdc = new BookingDateComparer();
                foreach (Booking b in Data.Bookings)
                {
                    if (bdc.Equals(b, booking))
                        return false;
                }
                Data.FakeBookings.Add(booking);
                return true;
            }
            public bool DeleteBooking(Booking booking)
            {
                return Data.FakeBookings.Remove(booking);
            }
            public bool ChangeRoom(Booking booking, Room room)
            {
                Data.BookingChangeRequests.Add(new BookingChangeRequest(booking, "room", (object)room));
                return true;
            }
            public bool ChangeCheckIn(Booking booking, DateTime dt)
            {
                Data.BookingChangeRequests.Add(new BookingChangeRequest(booking, "check in", (object)dt));
                return true;
            }
            public bool ChangeCheckOut(Booking booking, DateTime dt)
            {
                Data.BookingChangeRequests.Add(new BookingChangeRequest(booking, "check out", (object)dt));
                return true;
            }
            public bool AddResident(Booking booking, Customer customer)
            {
                Data.BookingChangeRequests.Add(new BookingChangeRequest(booking, "new resident", (object)customer));
                return true;
            }
            public bool DeleteResident(Booking booking, Customer customer)
            {
                Data.BookingChangeRequests.Add(new BookingChangeRequest(booking, "deleting residnet", (object)customer));
                return true;
            }
        }
    }
}
