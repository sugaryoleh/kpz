using System.Collections.Generic;

namespace lab_4_structs
{
    class HotelWorkerComparer : IEqualityComparer<HotelWorker>
    {
        public bool Equals(HotelWorker x, HotelWorker y)
        {
            return x.ID == y.ID;
        }
        public int GetHashCode(HotelWorker x)
        {
            int hashCode = x.ID;
            return hashCode.GetHashCode();
        }
    }
}
