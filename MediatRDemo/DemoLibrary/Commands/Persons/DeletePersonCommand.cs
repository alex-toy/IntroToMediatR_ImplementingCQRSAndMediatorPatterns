using Repository.Models;
using MediatR;

namespace DemoLibrary.Commands.Persons
{
    public record DeletePersonCommand(PersonModel person) : IRequest<PersonModel>;
}
