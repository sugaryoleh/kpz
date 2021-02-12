using System;
using System.Collections.Generic;
using DataModel.DataModels;

namespace ConsoleLoadManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel.DataModels.DataModel dm = DataModel.DataModels.DataModel.Load();
            List<Truck> l = new List<Truck>(dm.Trucks);
            l.Add(new Truck() { Model = "Man", Number = 2944, Odometers = 111323, Year = 2017 });
            dm.Trucks = l;
            dm.Save();
            foreach (Truck t in dm.Trucks)
            {
                Console.WriteLine(t);
            }
        }
    }
}
