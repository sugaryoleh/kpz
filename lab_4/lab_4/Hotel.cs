using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public partial class Hotel
    {
        public int id { get; set; }
        public Address address { get; set; }
        public readonly BookingSuperviser bs;
        public readonly RoomSuperviser rs;
        public readonly EmployeeSuperviser employeeManager;
        public Hotel(int id, Address address)
        {
            this.id = id;
            this.address = address;
            bs = new BookingSuperviser(this, new HotelWorker("name", "surname", "0502265769".ToCharArray(), new Address("USA", "Broadview", "Mack Dr", 2310), 1, new DateTime(2019, 12, 12), 10000));
            rs = new RoomSuperviser(this, new HotelWorker("name", "surname", "0502265769".ToCharArray(), new Address("USA", "Broadview", "Mack Dr", 2310), 1, new DateTime(2019, 12, 12), 10000));

        }
        public static class Data
        {
            public static readonly HashSet<Booking> Bookings;
            public static readonly List<Booking> FakeBookings;
            public static readonly List<BookingChangeRequest> BookingChangeRequests;
            public static readonly HashSet<Room> Rooms;
            public static readonly List<Room> FakeRooms;
            public static readonly List<RoomChangeRequest> RoomChangeRequests;
            static Data()
            {
                Bookings = new HashSet<Booking>();
                FakeBookings = new List<Booking>();
                BookingChangeRequests = new List<BookingChangeRequest>();
                Rooms = new HashSet<Room>();
                FakeRooms = new List<Room>();
                RoomChangeRequests = new List<RoomChangeRequest>();

            }
        }
    }
}
/*
        public class EmployeeManager
        {
            private Hotel hotel;
            private HashSet<HotelWorker> emplyees;
            public EmployeeManager(Hotel _hotel)
            {
                hotel = _hotel;
                emplyees = new HashSet<HotelWorker>(new HotelWorkerComparer());
            }
            public bool AddEmployee(HotelWorker hw)
            {
                return emplyees.Add(hw);
            }
            public bool DeleteEmployee(int id)
            {
                foreach (HotelWorker hw in emplyees)
                {
                    if (hw.ID == id)
                    {
                        emplyees.Remove(hw);
                        return true;
                    }
                }
                return false;
            }
            public HashSet<HotelWorker> Employees
            {
                get { return emplyees; }
            }
        }*/