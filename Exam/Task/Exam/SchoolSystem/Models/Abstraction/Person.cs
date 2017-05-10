using SchoolSystem.Models.Contracts;

namespace SchoolSystem.Models.Abstraction
{
    public abstract class Person : IPerson
    {
        protected Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
