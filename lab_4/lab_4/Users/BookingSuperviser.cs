using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public partial class Hotel
    {
        public struct BookingSuperviser : IBookingManager
        {
            public User user { get; set; }
            public BookingSuperviser(Hotel hotel, HotelWorker hw)
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
                Data.Bookings.Add(booking);
                return true;
            }
            public bool AddResident(Booking booking, Customer customer)
            {
                return booking.Residents.Add(customer);
            }
            public bool ChangeCheckIn(Booking booking, DateTime dt)
            {
                BookingDateComparer bdc = new BookingDateComparer();
                Booking b = new Booking(booking);
                b.CheckIn = dt;
                if (bdc.Equals(booking, b))
                    return false;
                else
                {
                    booking.CheckIn = dt;
                    return true;
                }
            }
            public bool ChangeCheckOut(Booking booking, DateTime dt)
            {
                BookingDateComparer bdc = new BookingDateComparer();
                Booking b = new Booking(booking);
                b.CheckOut = dt;
                if (bdc.Equals(booking, b))
                    return false;
                else
                {
                    booking.CheckOut = dt;
                    return true;
                }
            }
            public bool ChangeRoom(Booking booking, Room room)
            {
                BookingDateComparer bdc = new BookingDateComparer();
                Booking b = new Booking(booking);
                b.Room = room;
                if (bdc.Equals(booking, b))
                    return false;
                else
                {
                    booking.Room = room;
                    return true;
                }
            }
            public bool DeleteBooking(Booking booking)
            {
                BookingIDComparer bid = new BookingIDComparer();
                foreach (Booking b in Data.Bookings)
                {
                    if (bid.Equals(b, booking))
                    {
                        Data.Bookings.Remove(b);
                        return true;
                    }
                }
                return false;
            }
            public bool DeleteResident(Booking booking, Customer customer)
            {
                return booking.Residents.Remove(customer);
            }
        }
    }
}