using System;
using System.Text;

namespace lab_4_structs
{
    public struct HotelWorker
    {
        public Person Person { get; set; }
        public int ID { get; set; }
        public DateTime empDate { get; set; }
        public int monthSalary { get; set; }
        public HotelWorker(string name, string surname, char[] phone, Address address, int id, DateTime empDate, int monthSalary)
        {
            this.ID = id;
            this.Person = new Person(name, surname, phone, address);
            this.empDate = empDate;
            this.monthSalary = monthSalary;
        }
    }
}
