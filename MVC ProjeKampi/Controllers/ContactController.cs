using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDAL());
        ContactValidation cv = new ContactValidation();

        Context c = new Context();

        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
           

            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);

            return View(contactvalues);
        }
        public PartialViewResult Partial()
        {
            ViewBag.iletisim = c.Contacts.Count();
            ViewBag.gelen = c.Messages.Where(x => x.ReceiverMail == "admin@gmail.com").Count();
            ViewBag.gonderilen = c.Messages.Where(x => x.SenderMail == "admin@gmail.com").Count();



            return PartialView();
        }
    }
}