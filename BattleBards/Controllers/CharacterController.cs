using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BattleBards.Models;

namespace BattleBards.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Create()
        {
            return View();
        }
    }

    //public void ActionResult Create(CharacterModels model)
    //{

    //    context.SaveChanges();

    //}

}

