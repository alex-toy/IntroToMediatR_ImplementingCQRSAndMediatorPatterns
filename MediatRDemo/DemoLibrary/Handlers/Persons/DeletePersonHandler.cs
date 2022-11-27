using DemoLibrary.Commands.Persons;
using MediatR;
using Repository.DataAccess;
using Repository.Models;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonCommand, PersonModel>
    {
        public readonly IDataAccess _data;

        public DeletePersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            PersonModel person =  _data.Delete(request.person);
            return Task.FromResult(person);
        }
    }
}
