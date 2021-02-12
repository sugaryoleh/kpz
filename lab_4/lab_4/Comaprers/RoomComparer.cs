using System;
using System.Collections.Generic;

namespace lab_4_structs
{
    public class RoomComparer : IEqualityComparer<Room>
    {
        public bool Equals(Room x, Room y)
        {
            return x.ID == y.ID;
        }
        public int GetHashCode(Room bx)
        {
            int hCode = bx.ID;
            return hCode.GetHashCode();
        }
    }
}
