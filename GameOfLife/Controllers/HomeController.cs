﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameOfLife.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Game game = new Game();
            return View("Index", game.grid);
        }
    }

}