using DemoLibrary.Queries.Articles;
using MediatR;
using Repository.ArticleRepo;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetArticleByIdHandler : IRequestHandler<GetArticleByIdQuery, Article>
    {
        private readonly IArticleRepo _data;

        public GetArticleByIdHandler(IArticleRepo data)
        {
            _data = data;
        }

        public async Task<Article> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            List<Article> result = _data.GetAll();
            Article article =  result.FirstOrDefault(p => p.Id == request.Id);
            return await Task.FromResult(article);
        }
    }
}
