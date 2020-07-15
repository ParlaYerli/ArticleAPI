using Business.Abstract;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;
        public ArticleManager(IArticleDal _articleDal)
        {
            this._articleDal = _articleDal;
        }
        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void Delete(Article article)
        {
            _articleDal.Delete(article);
        }

        public Article GetById(int articleId)
        {
            return _articleDal.Get(i=>i.Id==articleId);
        }

        public List<Article> GetList()
        {
            return _articleDal.GetList().ToList();
        }

        public void Update(Article article)
        {
            _articleDal.Update(article);
        }
    }
}
