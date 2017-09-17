namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_30
{
    class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(
            int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(int id) => Id = id;

        public int Id
        {
            get => Id;
            private set
            {
                // Look up employee name...
                // ...
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";


        // ...
    }
}
