using DemoLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "alex", LastName = "reaktor" });
            people.Add(new PersonModel { Id = 2, FirstName = "shirley", LastName = "pepette" });
            people.Add(new PersonModel { Id = 3, FirstName = "william", LastName = "amin" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPeople(string firtName, string lastName)
        {
            int newId = people.Max(people => people.Id) + 1;
            PersonModel personModel = new() { Id = newId, FirstName = firtName, LastName = lastName };
            people.Add(personModel);
            return personModel;
        }
    }
}
