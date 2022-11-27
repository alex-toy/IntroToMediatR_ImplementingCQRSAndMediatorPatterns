using DemoLibrary.Queries.Persons;
using MediatR;
using Repository.DataAccess;
using Repository.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonsHandler : IRequestHandler<GetPersonsQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;

        public GetPersonsHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<PersonModel>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetAll());
        }
    }
}
