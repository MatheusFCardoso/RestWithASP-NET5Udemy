using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Services.Implemetations
{
    public class PersonServiceImplemetation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                Gender = "Male"
            };
        }
        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            var idValue = IncrementAndGet();
            return new Person
            {
                Id = idValue,
                FirstName = "Person Name " + idValue,
                LastName = "Person LastName " + idValue,
                Address = "Some Addres " + idValue,
                Gender = (idValue % 2 == 0) ? "Male" : "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
