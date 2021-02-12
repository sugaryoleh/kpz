using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    interface IRoomManager
    {
        bool DeleteRoom(Room room);
        bool AddRoom(Room room);
        bool ChangeRoomID(Room room, int id);
        bool ChangeRoomCost(Room room, int newCost);
        bool ChangeRoomType(Room room, RoomType type);
    }
}
