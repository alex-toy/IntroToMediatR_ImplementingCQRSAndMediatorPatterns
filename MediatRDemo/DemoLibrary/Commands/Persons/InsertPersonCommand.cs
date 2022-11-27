using Repository.Models;
using MediatR;

namespace DemoLibrary.Commands.Persons
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    //public class InsertPersonCommand : IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommand(string f, string l)
    //    {
    //        FirstName = f;
    //        LastName = l;
    //    }
    //}
}
