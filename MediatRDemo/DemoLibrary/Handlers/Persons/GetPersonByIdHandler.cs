using DemoLibrary.Queries.Persons;
using MediatR;
using Repository.DataAccess;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess _data;

        public GetPersonByIdHandler(IDataAccess data)
        {
            _data = data;
        }

        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            List<PersonModel> result = _data.GetAll();
            PersonModel person = result.FirstOrDefault(p => p.Id == request.Id);
            return await Task.FromResult(person);
        }
    }
}
