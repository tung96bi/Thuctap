using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothesShop.Controllers
{
    public class ShopController : Controller
    {
        private TestEntities db = new TestEntities();
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowMenu()
        {
            var model = (from u in db.Catalogs where u.fcatalogID == null select u ).ToList();
            var fmodel = (from u in db.Catalogs where u.fcatalogID == 2 select u).ToList();
            ViewBag.Fmodel = fmodel;
            return PartialView("ShowMenu", model);
        }

        public ActionResult Footer()
        {
           var model = (from u in db.Catalogs where u.fcatalogID == null select u).ToList();
            return PartialView("Footer", model);
        }
    }
}