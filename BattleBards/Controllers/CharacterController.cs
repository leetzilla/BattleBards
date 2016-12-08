using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BattleBards.Models;
using BattleBards.Helpers;

namespace BattleBards.Controllers
{
    public class CharacterController : Controller
    {
        private readonly BbDb _db = new BbDb();

        // GET: Character
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CharacterModels model)
        {
            try
            {
                _db.Character.Add(model);
                _db.SaveChanges();
                ViewBag.Messgae = model.name;
                return Content(model.name, "text/html");
            }
            catch (Exception e)
            {
                ViewBag.Messgae = e.ToString();
                return Content(model.name, "text/html");
            }
        }
    }
}

