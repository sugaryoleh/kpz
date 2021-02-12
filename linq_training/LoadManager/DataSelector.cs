using geolocmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoadManager
{
    public class DataSelector
    {
        public List<LoadData> GetLoadsTillDateNTime(DateNTime till, List<LoadData> incomingList)
        {
            var selects = (from data in incomingList
                               where data.arriveLate.CompareTo(till) == -1
                               select data).Union(
                                from data in incomingList
                                where data.arriveLate.CompareTo(till) == 0
                                select data);
                        
            return selects.ToList();
        }
        public List<LoadData> GetLoadsFromDateNTime(DateNTime from_, List<LoadData> incomingList)
        {
            var selects = (from data in incomingList
                          where data.arriveLate.CompareTo(from_) == 1
                          select data).Union(
                           from data in incomingList
                           where data.arriveLate.CompareTo(from_) == 0
                           select data);

            return selects.ToList();
        }
        public List<LoadData> GetLoadsBetweenDateNTime(DateNTime from, DateNTime till, List<LoadData> incomingList)
        {
            List<LoadData> selects = GetLoadsFromDateNTime(from, incomingList);
            selects = GetLoadsTillDateNTime(till, selects);
            return selects;

        }
        public List<LoadData> GetLoadsFrom(string city, List<LoadData> incomingList)
        {
            var selects = from data in incomingList
                          where data.fromCity.ToLower() == city.ToLower()
                          select data;
            return selects.ToList();
        }
        public List<LoadData> GetLoadsTo(string city, List<LoadData> incomingList)
        {
            var selects = from data in incomingList
                          where data.toCity.ToLower() == city.ToLower()
                          select data;
            return selects.ToList();
        }

        public List<LoadData> GetLoadsOfDispatch(string dispatchName, List<LoadData> incomingList)
        {
            var selects = from data in incomingList
                          where data.dispatch.ToLower() == dispatchName.ToLower()
                          select data;
            return selects.ToList();
        }
        public List<LoadData> GetLoadsToTimeZone(geolocmanager.TimeZone tz, List<LoadData> incomingList)
        {
            GeolocationManager gm = new GeolocationManager();
            var selects = from data in incomingList
                          where gm.getTimeZone(data.toCity, data.toState) == tz
                          select data;
            return selects.ToList();
        }
        public List<LoadData> GetLoadsFromTimeZone(geolocmanager.TimeZone tz, List<LoadData> incomingList)
        {
            GeolocationManager gm = new GeolocationManager();
            var selects = from data in incomingList
                          where gm.getTimeZone(data.fromCity, data.fromState) == tz
                          select data;
            return selects.ToList();
        }
        public List<LoadData> GetLoadsOfSpecificStatus(Status status, List<LoadData> incomingList)
        {
            var selects = from data in incomingList
                          where data.status == status
                          select data;
            return selects.ToList();
        }
        public List<LoadData> GetOrderedBy(OrderBy orderBy, List<LoadData> incomingList)
        {
            switch (orderBy)
            {
                case OrderBy.dispatcher: return incomingList.OrderBy(data => data.dispatch).ToList();
                case OrderBy.fromCity: return incomingList.OrderBy(data => data.fromCity).ToList();
                case OrderBy.fromState: return incomingList.OrderBy(data => data.fromState).ToList();
                case OrderBy.toCity: return incomingList.OrderBy(data => data.toCity).ToList();
                case OrderBy.toState: return incomingList.OrderBy(data => data.toState).ToList();
                case OrderBy.arriveEarly: return incomingList.OrderBy(data => data.arriveEarly).ToList();
                case OrderBy.arriveLate: return incomingList.OrderBy(data => data.arriveLate).ToList();
                case OrderBy.miles: return incomingList.OrderBy(data => data.milesToDelivery).ToList();
                default: return incomingList.OrderBy(data => data.arriveLate).ToList();
            }
        }
        public List<string> GetDispatchers(List<LoadData> incomingList)
        {
            var selects = (from data in incomingList
                          select data.dispatch).Distinct();
            return selects.ToList();
        }
        public List<string> GetShipperCities(List<LoadData> incomingList)
        {
            var selects = (from data in incomingList
                           select data.fromCity).Distinct();
            return selects.ToList();
        }
        public List<string> GetReceiverCities(List<LoadData> incomingList)
        {
            var selects = (from data in incomingList
                           select data.toCity).Distinct();
            return selects.ToList();
        }
        public List<DateNTime> GetTillDates(List<LoadData> incomingList)
        {
            var selects = (from data in incomingList
                           select data.arriveLate).Distinct();
            return selects.ToList();
        }
        public List<Status> GetStatuses()
        {
            List<Status> statuses = new List<Status>();
            statuses.Add(Status.delivered);
            statuses.Add(Status.on_time);
            statuses.Add(Status.late);
            return statuses;
        }
        public List<geolocmanager.TimeZone> GetTimezones()
        {
            List<geolocmanager.TimeZone> timeZones = new List<geolocmanager.TimeZone>();
            timeZones.Add(geolocmanager.TimeZone.Central);
            timeZones.Add(geolocmanager.TimeZone.Eastern);
            timeZones.Add(geolocmanager.TimeZone.other);
            return timeZones;
        }
    }
    public enum OrderBy
    {
        dispatcher,
        fromCity,
        fromState,
        toCity,
        toState,
        arriveEarly,
        arriveLate,
        miles
    }
}
