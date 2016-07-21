using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using www.flymsg.com.context;

namespace www.flymsg.com.Areas.Games.Controllers
{
    public class GameTypesController : Controller
    {
        private SiteGameEntities db = new SiteGameEntities();

        // GET: Games/GameTypes
        public ActionResult Index()
        {
            return View(db.GameType.ToList());
        }

        // GET: Games/GameTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameType gameType = db.GameType.Find(id);
            if (gameType == null)
            {
                return HttpNotFound();
            }
            return View(gameType);
        }

        // GET: Games/GameTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/GameTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Title,ParentId,Intro,OrderNum,BodyCss,JavaScript,Image,PageAction,IsVisible,CreateTime,CreateUser,UpdateTime,UpdateUser")] GameType gameType)
        {
            if (ModelState.IsValid)
            {
                db.GameType.Add(gameType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameType);
        }

        // GET: Games/GameTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameType gameType = db.GameType.Find(id);
            if (gameType == null)
            {
                return HttpNotFound();
            }
            return View(gameType);
        }

        // POST: Games/GameTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Title,ParentId,Intro,OrderNum,BodyCss,JavaScript,Image,PageAction,IsVisible,CreateTime,CreateUser,UpdateTime,UpdateUser")] GameType gameType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameType);
        }

        // GET: Games/GameTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameType gameType = db.GameType.Find(id);
            if (gameType == null)
            {
                return HttpNotFound();
            }
            return View(gameType);
        }

        // POST: Games/GameTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameType gameType = db.GameType.Find(id);
            db.GameType.Remove(gameType);
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
