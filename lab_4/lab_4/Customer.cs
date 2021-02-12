namespace lab_4_structs
{
    public struct Customer
    {
        public Person person { get; set; }
        public int id { get; set; }
        public int rate { get; set; }
        public int visitsCount { get; set; }
        public Customer(string name, string surname, char[] phone, Address homeAddress, int id, int rate)
        {
            this.person = new Person(name, surname, phone, homeAddress);
            this.id = id;
            this.rate = rate;
            this.visitsCount = 0;
        }
    }
}