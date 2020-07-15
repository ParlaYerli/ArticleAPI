using Core.DataAccess;
using DataAccess.Concrete;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
    }
}
