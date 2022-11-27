using DemoLibrary.Commands.Persons;
using MediatR;
using Repository.DataAccess;
using Repository.Models;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        public readonly IDataAccess _data;

        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            PersonModel temp = _data.Create(request.FirstName, request.LastName);
            return Task.FromResult(temp);
        }
    }
}
