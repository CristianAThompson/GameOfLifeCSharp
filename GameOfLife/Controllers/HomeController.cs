using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameOfLife.Models;

namespace GameOfLife.Controllers
{
    public class HomeController : Controller
    {
        Game game = new Game();
        public ActionResult Index()
        {
            return View("Index", game.grid);
        }

        [HttpPost]
        public ActionResult UpdateGrid()
        {
            Game resetGrid = new Game();
            game.grid = resetGrid.grid;
            return View("Index", game.grid);
        }
    }

}