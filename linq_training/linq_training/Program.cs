using System;
using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using LoadManager;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
    static void Main(string[] args)
        {
             CSVLoadDataReader reader = new CSVLoadDataReader();
             List<LoadData> dataList = reader.Read(@"C:\Users\sugar\source\repos\linq_training\loads tracking 15-16_12 - short.csv");
             DateNTime till = DateNTime.Serializer.Serialize("12/16/2020 0800");
             DataSelector ds = new DataSelector();
             List<LoadData> lld = ds.GetLoadsToTimeZone(geolocmanager.TimeZone.Eastern, dataList);
             foreach (LoadData data in lld)
             {
                 Console.WriteLine(data.ToString());
             }
        }
    }
}
