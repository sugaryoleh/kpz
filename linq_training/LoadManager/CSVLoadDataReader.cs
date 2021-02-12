using System;
using System.Collections.Generic;
using System.Text;

namespace LoadManager
{
    public class CSVLoadDataReader
    {
        public List<LoadData> Read(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            List<LoadData> dataList = new List<LoadData>();
            foreach (string line in lines)
            {
                dataList.Add(LoadData.CSVSerializer.Serialize(line));
            }
            return dataList;
        }
    }
}
