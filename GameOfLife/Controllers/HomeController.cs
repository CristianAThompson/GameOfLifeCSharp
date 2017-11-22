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
        Game game = new Game(100);
        public ActionResult Index()
        {
            return View("Index", game.grid);
        }

        [HttpPost]
        public ActionResult UpdateGrid()
        {
            foreach (Cell cell in game.grid)
            {
                int aliveCount = cell.neighbors.Count(c => c.state == true);
                if (aliveCount < 2 && cell.state)
                {
                    cell.state = false;
                }
                else if (aliveCount == 2 || aliveCount == 3 && cell.state)
                {
                    cell.state = true;
                }
                else if (aliveCount > 3 && cell.state)
                {
                    cell.state = false;
                }
                else if (aliveCount == 3 && !cell.state)
                {
                    cell.state = true;
                }
            }
            return View("Index", game.grid);
        }
    }

}