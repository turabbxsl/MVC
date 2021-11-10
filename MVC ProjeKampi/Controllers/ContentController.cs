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
    public class ContentController : Controller
    {

        ContentManager cm = new ContentManager(new EFContentDAL());
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContent(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var values = cm.GetList(p);
                return View(values);
            }
            else
            {
                var values = from x in c.Contents select x;
                return View(values.ToList());
            }
            
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}