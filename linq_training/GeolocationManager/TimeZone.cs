namespace geolocmanager
{
    public enum TimeZone
    {
        Central,
        Eastern,
        other
    }
    public static class TimeZoneMethods
    {
        public static class Serializer
        {
            public static TimeZone Serialize(string timeZone)
            {
                switch (timeZone)
                {
                    case "Central": return TimeZone.Central;
                    case "Eastern": return TimeZone.Eastern;
                    default: return TimeZone.other;
                }
            }
        }
    }
}
