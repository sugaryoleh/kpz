using System;

namespace LoadManager
{
    public class DateNTime : IComparable
    {
        public int year;
        public int month;
        public int day;
        public int hours;
        public int minutes;
        public DateNTime(int m, int d, int y, int h, int mi)
        {
            year = y;
            month = m;
            day = d;
            hours = h;
            minutes = mi;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            DateNTime otherDateNTime = (DateNTime)obj;
            if (obj != null)
            {
                if (this.year > otherDateNTime.year)
                    return 1;
                else if (this.year == otherDateNTime.year)
                {
                    if (this.month > otherDateNTime.month)
                        return 1;
                    else if (this.month == otherDateNTime.month)
                    {
                        if (this.day > otherDateNTime.day)
                            return 1;
                        else if (this.day == otherDateNTime.day)
                        {
                            if (this.hours > otherDateNTime.hours)
                                return 1;
                            else if (this.hours == otherDateNTime.hours)
                            {
                                if (this.minutes > otherDateNTime.minutes)
                                    return 1;
                                else if (this.minutes == otherDateNTime.minutes)
                                {
                                    return 0;
                                }
                                else
                                    return -1;
                            }
                            else
                                return -1;
                        }
                        else 
                            return -1;
                    }
                    else
                        return -1;
                }
                else
                    return -1;
            }
            else
                return 1;
        }
        public string ToString()
        {
            string h;
            if (hours < 10)
                h = "0" + hours.ToString();
            else h = hours.ToString();
            string m;
            if (minutes < 10)
                m = "0" + minutes.ToString();
            else m = minutes.ToString();
            string repr = month + "/" + day + "/" + year + " " + h + m;
            return repr;
        }
        public static class Serializer
        {
            public static DateNTime Serialize(string repr)
            {
                string date = repr.Split(' ')[0];
                string time = repr.Split(' ')[1];
                string[] date_ = date.Split('/');
                int year = int.Parse(date_[2]);
                int month = int.Parse(date_[0]);
                int day = int.Parse(date_[1]);
                int hours = int.Parse(time.Substring(0, 2));
                int minutes = int.Parse(time.Substring(2));
                return new DateNTime(month, day, year, hours, minutes);
            }
            public static string Deserialize(DateNTime dnt)
            {
                string repr = dnt.month + "/" + dnt.day + "/" + dnt.year + " " + dnt.hours + dnt.minutes;
                return repr;
            }
        }
    }
}