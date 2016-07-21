using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using www.flymsg.com.bll;
using www.flymsg.com.context;

namespace www.flymsg.com.Areas.Games.Controllers
{
    public class GamesController : Controller
    {
        private SiteGameEntities db = new SiteGameEntities();

        // GET: Games/Games
        public ActionResult Index()
        {
            return View(db.Game.ToList().Select(s => SampleCURDBLL<www.flymsg.com.context.Game>.GetPageModel<PageGame>(s)).ToList() );
        }

        // GET: Games/Games/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Game.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            PageGame pg = SampleCURDBLL<Game>.GetPageModel<PageGame>(game);
            return View(pg);
        }

        // GET: Games/Games/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SmallImage,BigImage,OrderNum,GamePath,Anthor,Title,OperationType,Intro,Label,GameType,Backup,IsVisible,CreateTime,CreateUser,UpdateTime,UpdateUser")] Game game, HttpPostedFileBase GamePathChoose)
        {
            int c = 0;
            if (game.GamePath.ToLower().IndexOf("http://") < 0 && GamePathChoose != null && GamePathChoose.ContentLength > 0)
            {
                ModelState.AddModelError("GamePath", "本地文件不完整");
            }
            else {
                db.Game.Add(game);
                c = db.SaveChanges();
            }
            if (c > 0)
                return RedirectToAction("Index");
            return View(game);
        }

        // GET: Games/Games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Game.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SmallImage,BigImage,OrderNum,GamePath,Anthor,Title,OperationType,Intro,Label,GameType,Backup,IsVisible,CreateTime,CreateUser,UpdateTime,UpdateUser")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Games/Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Game.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Game.Find(id);
            db.Game.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
