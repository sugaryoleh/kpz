
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public struct RoomChangeRequest 
    {
        public readonly DataChangeRequest dtc;
        public readonly Room room;
        public RoomChangeRequest (Room room, string field, object value)
        {
            dtc = new DataChangeRequest(field, value);
            this.room = room;
        }
    }
}
