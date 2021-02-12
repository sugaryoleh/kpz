using System;

namespace LoadManager
{
    public class LoadData
    {
        public string dispatch;
        public string order;
        public string fromCity;
        public string fromState;
        public string toCity;
        public string toState;
        public DateNTime arriveEarly;
        public DateNTime arriveLate;
        public string truck;
        public Status status;
        public int milesToDelivery;
        public LoadData(string dispatch, string order, string fromCity, string fromState,
            string toCity, string toState, DateNTime arriveEarly, DateNTime arriveLate, 
            string truck, Status status, int miles)
        {
            this.dispatch = dispatch;
            this.order = order;
            this.fromCity = fromCity;
            this.fromState = fromState;
            this.toCity = toCity;
            this.toState = toState;
            this.arriveEarly = arriveEarly;
            this.arriveLate = arriveLate;
            this.truck = truck;
            this.status = status;
            this.milesToDelivery = miles;
        }
        public string ToString()
        {
            string repr = dispatch + " | " + order + " | " + fromCity + ", " + fromState + " | " + toCity + ", " + toState + " | " +
                truck + " | " + " | " + arriveEarly.ToString() + " | " + arriveLate.ToString() + " | " + status.ToString() + " | " + milesToDelivery.ToString();
            return repr;
        }
        public static class CSVSerializer
        {
            public static LoadData Serialize(string csvRow)
            {
                string[] data = csvRow.Split(',');
                string dispatch = data[0];
                string order = data[1];
                string fromCity = data[2];
                string fromState = data[3];
                string toCity = data[4];
                string toState = data[5];
                DateNTime arriveEarly = DateNTime.Serializer.Serialize(data[6]);
                DateNTime arriveLate = DateNTime.Serializer.Serialize(data[7]);
                string truck = data[8];
                Status status = StatusMethods.Serializer.Serialize(data[9]);
                int miles = int.Parse(data[10]);
                return new LoadData(dispatch, order, fromCity, fromState, toCity, toState,
                    arriveEarly, arriveLate, truck, status, miles);
            }
        }
    }
}
