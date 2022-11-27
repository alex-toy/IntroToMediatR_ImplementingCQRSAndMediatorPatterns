using DemoLibrary.Commands.Articles;
using MediatR;
using Repository.ArticleRepo;
using Repository.Models;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertArticleHandler : IRequestHandler<InsertArticleCommand, Article>
    {
        public readonly IArticleRepo _data;

        public InsertArticleHandler(IArticleRepo data)
        {
            _data = data;
        }

        public Task<Article> Handle(InsertArticleCommand request, CancellationToken cancellationToken)
        {
            Article temp = _data.Create(request.Name, request.Price);
            return Task.FromResult(temp);
        }
    }
}
