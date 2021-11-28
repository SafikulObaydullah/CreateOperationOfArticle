using MVCoperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCoperation.Controllers
{
    public class ArticleController : Controller
    {
        dbModel db = new dbModel();
        // GET: Article
        public ActionResult Index()
        {
            var article = db.Articles.ToList();
            return View(article);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Article article)
        {
            db.Articles.Add(article);
            if (db.SaveChanges() > 0)
            {
                return RedirectToAction("Index");
            }
            return View(article);
        }
    }
}