using Repository.Models;
using MediatR;

namespace DemoLibrary.Commands.Articles
{
    public record InsertArticleCommand(string Name, int Price) : IRequest<Article>;
}
