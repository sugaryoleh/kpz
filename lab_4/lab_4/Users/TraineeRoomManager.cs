using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public partial class Hotel {
        public class TraineeRoomManager : IRoomManager
        {
            public User user { get; set; }
            public TraineeRoomManager(Hotel hotel, HotelWorker hw)
            {
                user = new User(hotel, hw);
            }
            public bool AddRoom(Room room)
            {
                Data.FakeRooms.Add(room);
                return true;
            }

            public bool ChangeRoomCost(Room room, int newCost)
            {
                Data.RoomChangeRequests.Add(new RoomChangeRequest(room, "room", (object)newCost));
                return true;
            }

            public bool ChangeRoomID(Room room, int id)
            {
                Data.RoomChangeRequests.Add(new RoomChangeRequest(room, "id", (object)id));
                return true;
            }

            public bool ChangeRoomType(Room room, RoomType type)
            {
                Data.RoomChangeRequests.Add(new RoomChangeRequest(room, "type", (object)type));
                return true;
            }

            public bool DeleteRoom(Room room)
            {
                return Data.FakeRooms.Remove(room);
            }
        }
    }
}