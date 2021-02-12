using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab_4_structs
{
    public sealed class Room : IComparable, IDisposable
    {
        private int id;
        private RoomType type;
        private int cost;
        public Room(int id, RoomType type, int price)
        {
            this.id = id;
            this.type = type;
            cost = price;
        }
        public int ID 
        {   get { return this.id; }
            set { this.id = value; } 
        }
        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
        public RoomType Type 
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int CompareTo(object r)
        {
            Room nr = (Room)r;
            return this.id.CompareTo(nr.ID);
        }

        public void Dispose()
        {
        }
    }
}
