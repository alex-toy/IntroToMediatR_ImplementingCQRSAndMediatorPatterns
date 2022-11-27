using Repository.Models;
using MediatR;

namespace DemoLibrary.Commands.Articles
{
    public record DeleteArticleCommand(Article article) : IRequest<Article>;
}
