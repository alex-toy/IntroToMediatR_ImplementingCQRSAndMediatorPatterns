using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetAll();

        PersonModel Create(string firtName, string lastName);

        PersonModel Delete(PersonModel person);
    }
}