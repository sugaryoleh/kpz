using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    interface IHRManager
    {
        public bool AddEmployee(HotelWorker hw);
        public bool DeleteEmployee(HotelWorker hw);
        public bool ChangeSalary(HotelWorker hw, int newSalary);
    }
}
