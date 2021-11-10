using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.birinci = c.Categories.Count();
            ViewBag.ikinci = c.Headings.Where(x => x.CategoryID == 19).Count();
            ViewBag.ucuncu = c.Writers.Where(x => x.WriterName.Contains("a")).Count();

            var cc = c.Headings.Max(x=>x.CategoryID);
            var hc = c.Headings.FirstOrDefault(x => x.CategoryID == cc).Category.CategoryName;
            ViewBag.dorduncu = hc;

            int cat1 = c.Categories.Where(x => x.CategoryStatus == true).Count();
            int cat2 = c.Categories.Where(x => x.CategoryStatus == false).Count();
            
            if (cat1 > cat2)
            {
                int cat12 = cat1 - cat2;
                ViewBag.besinci = cat12;
            }
            if (cat1 < cat2)
            {
                int cat12 = cat2 - cat1;
                ViewBag.besinci = cat12;
            }
            

            return View();
        }
    }
}