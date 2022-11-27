using DemoLibrary.Commands;
using DemoLibrary.Commands.Persons;
using DemoLibrary.Queries.Persons;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediatR)
        {
            _mediator = mediatR;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<PersonModel>> GetAll()
        {
            return await _mediator.Send(new GetPersonsQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id) => await _mediator.Send(new GetPersonByIdQuery(id));

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel person)
        {
            InsertPersonCommand model = new InsertPersonCommand(person.FirstName, person.LastName);
            return await _mediator.Send(model);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<PersonModel> Delete(int id)
        {
            PersonModel person = await _mediator.Send(new GetPersonByIdQuery(id));
            DeletePersonCommand model = new DeletePersonCommand(person);
            return await _mediator.Send(model);
        }
    }
}
