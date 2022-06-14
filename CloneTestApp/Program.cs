using System;

namespace CloneTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //init the person data
            Person person = new Person()
            {
                FirstName = "Nick",
                LastName = "Johnson",
                Age = 24,
                Address = new Address()
                {
                    Country = "Hungary",
                    City = "Budapest",
                    PostalCode = "1080",
                    Street = "Rákóczi street"
                }
            };

            //shallow clone
            Person shallowClone = person;

            //deep clone
            Person deepClone = (Person)person.Clone();

            Console.WriteLine(person);
            Console.WriteLine(shallowClone);
            Console.WriteLine(deepClone);

        }
    }
}
