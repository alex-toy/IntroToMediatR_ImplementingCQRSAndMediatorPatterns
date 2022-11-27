using Repository.Models;
using MediatR;

namespace DemoLibrary.Queries.Persons
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
}
