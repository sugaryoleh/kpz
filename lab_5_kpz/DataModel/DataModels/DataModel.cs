using DataModel.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;


namespace DataModel.DataModels
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Load> Loads;
        [DataMember]
        public IEnumerable<Truck> Trucks;

        public static string dataPath = @"D:/data.xml";
        public DataModel()
        {
            Load l1 = new Load() { Destination = "Bethlehem, PA", Order = "001", Origin = "Chicago, IL", Price = 3000, Status = LoadStatus.Active, Truck = "1878" };
            Load l2 = new Load() { Destination = "Bethlehem, PA", Order = "002", Origin = "Chicago, IL", Price = 3000, Status = LoadStatus.Active, Truck = "1888" };
            List<Load> loads = new List<Load>() { l1, l2 };
            Truck t1 = new Truck() { Model = "Freightliner", Year = 2020, Number = 1888, Odometers = 100000 };
            Truck t2 = new Truck() { Model = "Freightliner", Year = 2021, Number = 2000, Odometers = 1 };
            List<Truck> trucks = new List<Truck>() { t1, t2 };
            //Trucks = trucks;
            //Loads = loads;
        }
        public static DataModel Load()
        {
            if (File.Exists(dataPath))
            {
                return DataSerializer.DeserializeData(dataPath);
            }
            else
                return new DataModel();
        }
        public void Save()
        {
            DataSerializer.SerializeData(dataPath, this);
        }
    }
}
