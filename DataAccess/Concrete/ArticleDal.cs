using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class ArticleDal : EfEntityRepositoryBase<Article, ArticleContext>, IArticleDal
    {
    }
}
