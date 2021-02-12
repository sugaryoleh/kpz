using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public struct HotelChain
    {
        private static HotelChain instance;
        private ChainManager cm;
        static HotelChain()
        {
            instance = new HotelChain();
        }
        public HotelChain(int a = 0)
        {
           cm = new ChainManager();
        }
        public static HotelChain GetInsatnce()
        {
            return instance;
        }
        public bool AddHotel(Hotel hotel)
        {
            return cm.AddHotel(hotel);
        }
        public bool DeleteHotel(Hotel hotel)
        {
            return cm.DeleteHotel(hotel);
        }
        public bool ChangeID(Hotel hotel, int newID)
        {
            return cm.ChangeID(hotel, newID);
        }
        public bool ChangeAddress(Hotel hotel, Address newAddress)
        {
            return cm.ChangeAddress(hotel, newAddress);
        }
        private struct ChainManager
        {
            private HashSet<Hotel> chain;
            public ChainManager(int a =0)
            {
                chain = new HashSet<Hotel>();
            }
            public bool AddHotel(Hotel hotel)
            {
                return chain.Add(hotel);
            }
            public bool DeleteHotel(Hotel hotel)
            {
                return chain.Remove(hotel);
            }
            public bool ChangeID(Hotel hotel, int newID)
            {
                foreach (Hotel h in chain)
                {
                    if (h.Equals(hotel))
                    {
                        h.id = newID;
                        return true;
                    }
                }
                return false;
            }
            public bool ChangeAddress(Hotel hotel, Address newAddress)
            {
                foreach (Hotel h in chain)
                {
                    if (h.Equals(hotel))
                    {
                        h.address = newAddress;
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
