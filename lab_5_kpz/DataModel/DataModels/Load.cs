using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.DataModels

{
    [DataContract]
    public class Load
    {
        [DataMember]
        public string Order;
        [DataMember]
        public int Price;
        [DataMember]
        public string Origin;
        /*[DataMember]
        public DateTime Shipping;*/
        [DataMember]
        public string Destination;
        /*[DataMember]
        public DateTime Delivery;*/
        [DataMember]
        public string Truck;
        [DataMember]
        public LoadStatus Status;
        override public string ToString()
        {
            return String.Format("#{0}; ${1}; origin: {2}; destination: {3}; truck# {4}; status: {5};", Order, Price, Origin, Destination, Truck, Status);
        }
    }
}
