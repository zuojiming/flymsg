using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.flymsg.com.bll;
using www.flymsg.com.context;
using www.flymsg.com.Model;

namespace www.flymsg.com.Areas.Games.Controllers
{
    public class FlashController : Controller
    {
        // GET: Games/Flash
        public ActionResult Index()
        {
            var orderGameDB = new SiteGameEntities().V_GamesOrder;
            ViewBag.orderGameDB = orderGameDB;

            var userGameDB = new SiteGameEntities().V_UsersGames;
            ViewBag.usersGameDB = userGameDB;
            return View();
        }

        public ActionResult Detail() {
            return View();
        }

        public ActionResult PageTopLittleGame() {
            var orderGameDB = new SiteGameEntities().V_GamesOrder;
            ViewBag.orderGameDB = orderGameDB;
            return View();
        }
    }
}