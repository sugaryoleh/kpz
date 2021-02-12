using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public struct EmployeeDataChangeRequest
    {
        public readonly DataChangeRequest dtc;

        public readonly HotelWorker employee;
        EmployeeDataChangeRequest(HotelWorker emp, string field, object newValue) 
        {
            this.dtc = new DataChangeRequest(field, newValue);
            this.employee = emp;
        }
    }
}
