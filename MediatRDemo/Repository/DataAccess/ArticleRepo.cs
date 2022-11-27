using Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository.ArticleRepo
{
    public class ArticleRepo : IArticleRepo
    {
        private List<Article> articles = new();

        public ArticleRepo()
        {
            articles.Add(new Article { Id = 1, Name = "pantalon", Price = 12 });
            articles.Add(new Article { Id = 2, Name = "chemise", Price = 65 });
            articles.Add(new Article { Id = 3, Name = "veste", Price = 87 });
        }

        public List<Article> GetAll()
        {
            return articles;
        }

        public Article Create(string firtName, int Price)
        {
            int newId = articles.Max(a => a.Id) + 1;
            Article article = new() { Id = newId, Name = firtName, Price = Price };
            articles.Add(article);
            return article;
        }

        public Article Delete(Article article)
        {
            articles.Remove(article);
            return article;
        }
    }
}
