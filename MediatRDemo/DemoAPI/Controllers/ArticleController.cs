using DemoLibrary.Commands.Articles;
using DemoLibrary.Queries.Articles;
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
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticleController(IMediator mediatR)
        {
            _mediator = mediatR;
        }

        // GET: api/<ArticleController>
        [HttpGet]
        public async Task<IEnumerable<Article>> GetAll()
        {
            return await _mediator.Send(new GetArticlesQuery());
        }

        // GET api/<ArticleController>/5
        [HttpGet("{id}")]
        public async Task<Article> Get(int id) => await _mediator.Send(new GetArticleByIdQuery(id));

        // POST api/<ArticleController>
        [HttpPost]
        public async Task<Article> Post([FromBody] Article article)
        {
            InsertArticleCommand model = new InsertArticleCommand(article.Name, article.Price);
            return await _mediator.Send(model);
        }

        // PUT api/<ArticleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticleController>/5
        [HttpDelete("{id}")]
        public async Task<Article> Delete(int id)
        {
            Article person = await _mediator.Send(new GetArticleByIdQuery(id));
            DeleteArticleCommand model = new DeleteArticleCommand(person);
            return await _mediator.Send(model);
        }
    }
}
