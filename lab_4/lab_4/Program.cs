using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab_4_structs
{
    
    class Program
    {
        static void ChangeIntVal_Ref(ref int x)
        {
            x = x + 1;
        }
        static void ChangeIntVal(int x)
        {
            x = x + 1;
        }
        static void ReturnVal_Primitive(out int x)
        {
            x = 1;
        }
        static void ReturnVal_Object(out Address x)
        {
            x = new Address("UK", "Lviv", "Lukasha", 4);
        }
        static TimeSpan CreateClassObjects(int count, out List<Room> l)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            l = new List<Room>();
            for (int i = 0; i < count; i++)
            {
                l.Add(new Room(i, RoomType.Comfort, i));
            }
            sw.Stop();
            return sw.Elapsed;
        }
        static TimeSpan ClassObjListDisposion(ref List<Room> l)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (Room r in l)
            {
                r.Dispose();
            }
            sw.Stop();
            return sw.Elapsed;
        }
        static void Main(string[] args)
        {
            /*
            Address address = new Address("Ukraine", "Lviv", "Sakharova", 5);
            
            Coordinates coords = address;
            Console.WriteLine(coords.x.ToString() + ", " + coords.y);
            Address copy = (Address)coords;
            Console.WriteLine(copy);
            coords = copy;
            Console.WriteLine(coords.x.ToString() + ", " + coords.y);
            */

        }
        
    }
}
