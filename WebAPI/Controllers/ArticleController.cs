using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService _articleService;
        public ArticleController(IArticleService _articleService)
        {
            this._articleService = _articleService;
        }

        [HttpGet("getall")]
        public List<Article> GetList()
        {
            return _articleService.GetList();
        }

        [HttpGet("getbyid/{articleId}")]
        public Article GetArticleById(int articleId)
        {
            return _articleService.GetById(articleId);
        }

        [HttpPost("add")]
        public IActionResult Add(Article article)
        {
            _articleService.Add(article);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Article article)
        {
            _articleService.Delete(article);
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(Article article)
        {
            _articleService.Update(article);
            return Ok();
        }

       
    }
}