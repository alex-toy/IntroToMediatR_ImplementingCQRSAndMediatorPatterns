using Repository.Models;
using MediatR;

namespace DemoLibrary.Queries.Articles
{
    public record GetArticleByIdQuery(int Id) : IRequest<Article>;
}
