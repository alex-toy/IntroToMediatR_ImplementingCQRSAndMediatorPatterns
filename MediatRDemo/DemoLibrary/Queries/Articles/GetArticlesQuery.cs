using Repository.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries.Articles
{
    public record GetArticlesQuery() : IRequest<List<Article>>;
}
