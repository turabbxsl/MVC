using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using MVC_ProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ProjeKampi.Controllers
{
    public class ChartController : Controller
    {

        HeadingManager hm = new HeadingManager(new EFHeadingDAL());
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(),JsonRequestBehavior.AllowGet);
        }

        public List<Category> BlogList()
        {
            List<Category> li = new List<Category>();
            List<string> cn = c.Categories.Select(x => x.CategoryName).ToList();
            List<int> ci = c.Categories.Select(y => y.CategoryID).ToList();
            li.Add(new Category()
            {
                CategoryName = "Spdasdasor",
                CategoryID = 51

            });
            li.Add(new Category()
            {
                CategoryName = "dsadas",
                CategoryID = 52

            });
            li.Add(new Category()
            {
                CategoryName = "dsadas",
                CategoryID = 57

            });
            li.Add(new Category()
            {
                CategoryName = "dksal;das",
                CategoryID = 53


            });
            li.Add(new Category()
            {
                CategoryName = "Kitap",
                CategoryID = 56

            });

            return li;
        }

    }
}