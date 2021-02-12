using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{
    public struct Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public char[] phone { get; set; }
        public Address homeAddress { get; set; }
        public Person(string name, string surname, char[] phone, Address homeAddress)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.homeAddress = homeAddress;
        }
    }
}
