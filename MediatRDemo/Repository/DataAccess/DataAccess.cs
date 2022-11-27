using Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "alex", LastName = "reaktor" });
            people.Add(new PersonModel { Id = 2, FirstName = "shirley", LastName = "pepette" });
            people.Add(new PersonModel { Id = 3, FirstName = "william", LastName = "amin" });
        }

        public List<PersonModel> GetAll()
        {
            return people;
        }

        public PersonModel Create(string firtName, string lastName)
        {
            int newId = people.Max(people => people.Id) + 1;
            PersonModel personModel = new() { Id = newId, FirstName = firtName, LastName = lastName };
            people.Add(personModel);
            return personModel;
        }

        public PersonModel Delete(PersonModel person)
        {
            people.Remove(person);
            return person;
        }
    }
}
