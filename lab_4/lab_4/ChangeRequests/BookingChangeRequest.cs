using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public struct BookingChangeRequest 
    {
        public readonly DataChangeRequest dtc;
        public readonly Booking booking;
        public BookingChangeRequest(Booking booking, string field, object newValue)
        {
            this.dtc = new DataChangeRequest(field, newValue);
            this.booking = booking;
        }
    }
}
