using Repository.Models;
using System.Collections.Generic;

namespace Repository.ArticleRepo
{
    public interface IArticleRepo
    {
        Article Create(string firtName, int Price);
        Article Delete(Article article);
        List<Article> GetAll();
    }
}