using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
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
            //return Task.FromResult(new List<PersonModel>());
            return Task.FromResult(_data.GetPeople());
        }
    }
}
