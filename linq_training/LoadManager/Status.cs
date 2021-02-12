namespace LoadManager
{
    public enum Status
    {
        on_time,
        late,
        delivered,
        unavailable
    }
    public static class StatusMethods
    {
        public static class Serializer
        {
            public static Status Serialize(string strStatus)
            {
                switch (strStatus)
                {
                    case "on_time": return Status.on_time;
                    case "on time": return Status.on_time;
                    case "late": return Status.late;
                    case "delivered": return Status.delivered;
                    default: return Status.unavailable;
                }
            }
        }
    }

}
