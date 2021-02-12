using System.IO;
using System.Runtime.Serialization;
using DataModel.DataModels;

namespace DataModel.Serialization
{
    class DataSerializer
    {
        public static void SerializeData(string path , DataModel.DataModels.DataModel data)
        {
            var formatter = new DataContractSerializer(typeof(DataModel.DataModels.DataModel));
            var fileStream = new FileStream(path, FileMode.Create);
            formatter.WriteObject(fileStream , data);
            fileStream.Flush();
            fileStream.Close();
        }

        public static DataModel.DataModels.DataModel DeserializeData(string path)
        {
            var formatter = new DataContractSerializer(typeof(DataModel.DataModels.DataModel));
            var fileStream = new FileStream(path, FileMode.Open);
            var v = (DataModel.DataModels.DataModel) formatter.ReadObject(fileStream);
            fileStream.Close();
            return v;
        }
    }
}
