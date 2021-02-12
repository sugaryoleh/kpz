using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.DataModels
{
    [DataContract]
    public class Truck
    {
        [DataMember]
        public string Model;
        [DataMember]
        public int Number;
        [DataMember]
        public int Year;
        [DataMember]
        public int Odometers;
        public override string ToString()
        {
            return String.Format("mdoel: {0}; #{1}; year: {2}; odo: {3}", Model, Number, Year, Odometers);
        }
    }
}
