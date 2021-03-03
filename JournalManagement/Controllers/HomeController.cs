using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JournalManagement.Models;
using JournalManagement.Services;
using JournalManagement.ViewModels;

namespace JournalManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ArticleViewModel model = new ArticleViewModel();
            model.FullName = "Sercan Alkan";
            model.ArticleTitle = "DENEME";
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ArticleViewModel model)
        {
            ArticleService articleService = new ArticleService();
            
            var inserted = articleService.Insert(new Article
            {
                Title = model.ArticleTitle,
                Content = model.ArticleContent
            });
            
            EditorService editorService = new EditorService();
            editorService.Insert(new Editor
            {

            });
            
            return Json(inserted);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}