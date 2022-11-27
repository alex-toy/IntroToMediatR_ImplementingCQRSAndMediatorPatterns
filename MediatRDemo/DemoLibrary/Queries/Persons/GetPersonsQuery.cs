using Repository.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries.Persons
{
    public record GetPersonsQuery() : IRequest<List<PersonModel>>;
}
