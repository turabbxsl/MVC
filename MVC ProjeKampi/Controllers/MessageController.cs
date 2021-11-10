using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDAL());
        TaslaklarManager tm = new TaslaklarManager(new EFTaslaklarDAL());
        MessageValidation messagevaliation = new MessageValidation();

        [Authorize]
        public ActionResult Inbox(string p)
        {
            var messagelist = mm.GetListİnbox(p);

            return View(messagelist);
        }

        public ActionResult Sendbox(string p)
        {
            var messagelist = mm.GetListSendİnbox(p);

            return View(messagelist);
        }



        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);

            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);

            return View(values);
        }


        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messagevaliation.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAddBL(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Taslaklar()
        {
            var taslaklar = tm.GetListTaslaklar();
            return View(taslaklar);
        }

        [HttpPost]
        public ActionResult TaslaklarAdd(Message p)
        {
            
            return RedirectToAction("NewMessage");
        }


    }
}