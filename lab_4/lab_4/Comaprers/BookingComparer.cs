using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab_4_structs
{
    public class BookingDateComparer : IEqualityComparer<Booking>
    {
        public bool Equals([AllowNull] Booking x, [AllowNull] Booking y)
        {
            if(x.Room.ID == y.Room.ID)
            {
                if ((x.CheckIn < y.CheckIn && x.CheckOut < y.CheckIn) ||
                    (x.CheckIn > y.CheckOut && x.CheckOut < y.CheckOut))
                    return false;
                return true;
            }
            return false;
        }

        public int GetHashCode(Booking obj)
        {
            return obj.ID;
        }
    }
    public class BookingIDComparer : IEqualityComparer<Booking>
    {
        public bool Equals([AllowNull] Booking x, [AllowNull] Booking y)
        {
            if (x.ID == y.ID)
                return true;
            return false;
        }

        public int GetHashCode(Booking obj)
        {
            return obj.ID;
        }
    }
}
