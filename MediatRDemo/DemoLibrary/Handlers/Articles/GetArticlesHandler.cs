using DemoLibrary.Queries.Articles;
using MediatR;
using Repository.ArticleRepo;
using Repository.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetArticlesHandler : IRequestHandler<GetArticlesQuery, List<Article>>
    {
        private readonly IArticleRepo _data;

        public GetArticlesHandler(IArticleRepo data)
        {
            _data = data;
        }

        public Task<List<Article>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetAll());
        }
    }
}
