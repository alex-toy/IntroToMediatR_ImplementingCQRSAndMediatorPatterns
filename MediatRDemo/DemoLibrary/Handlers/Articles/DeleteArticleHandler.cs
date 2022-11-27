using DemoLibrary.Commands.Articles;
using MediatR;
using Repository.ArticleRepo;
using Repository.Models;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class DeleteArticleHandler : IRequestHandler<DeleteArticleCommand, Article>
    {
        public readonly IArticleRepo _data;

        public DeleteArticleHandler(IArticleRepo data)
        {
            _data = data;
        }

        public Task<Article> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
        {
            Article person =  _data.Delete(request.article);
            return Task.FromResult(person);
        }
    }
}
