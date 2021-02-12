using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public partial class Hotel
    {
        public class RoomSuperviser : IRoomManager
        {
            public User user { get; set; }
            public RoomSuperviser(Hotel hotel, HotelWorker hw)
            {
                user = new User(hotel, hw);
            }
            public bool AddRoom(Room room)
            {
                return Data.Rooms.Add(room);
            }
            public bool ChangeRoomCost(Room room, int newCost)
            {
                room.Cost = newCost;
                return true;
            }
            public bool ChangeRoomID(Room room, int id)
            {
                foreach(Room r in Data.Rooms)
                {
                    if (r.ID == id)
                        return false;
                }
                room.ID = id;
                return true;
            }
            public bool ChangeRoomType(Room room, RoomType type)
            {
                room.Type = type;
                return true;
            }

            public bool DeleteRoom(Room room)
            {
                throw new NotImplementedException();
            }
        }
    }
}