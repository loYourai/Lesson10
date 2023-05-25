

using System.Net;

namespace Lesson10
{
    public class Person
    {
        private string Variable;
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Address { get; set; }   
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, string address,int age,string phoneNumber)
        {
            FirstName = firstName;
                LastName = lastName;
            Address = address;
            Age = age;
            PhoneNumber = phoneNumber;

            Variable = "custom variable value";
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Address = person.Address;
            Age = person.Age;
        }

     
        public void FullName()
        {
               Console.WriteLine($"{FirstName} {LastName}");
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} Age: {Age} Adress: {Address}";
        }
    }
}
