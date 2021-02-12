using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public struct DataChangeRequest
    {
        public readonly string field;
        public readonly object newValue;
        public DataChangeRequest(string field, object newValue)
        {
            this.field = field;
            this.newValue = newValue;
        }
    }
}
