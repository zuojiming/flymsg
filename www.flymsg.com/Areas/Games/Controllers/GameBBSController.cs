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
    public class GameBBSController : Controller
    {
        private SiteGameEntities db = new SiteGameEntities();

        // GET: Games/GameBBS
        public ActionResult Index()
        {
            return View(db.GameBBS.ToList());
        }

        // GET: Games/GameBBS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameBBS gameBBS = db.GameBBS.Find(id);
            if (gameBBS == null)
            {
                return HttpNotFound();
            }
            return View(gameBBS);
        }

        // GET: Games/GameBBS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/GameBBS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GameId,ParentId,Title,Context,Ip,Address,UserName,CreateTime,CreateUser,UpdateTime,UpdateUser")] GameBBS gameBBS)
        {
            if (ModelState.IsValid)
            {
                db.GameBBS.Add(gameBBS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameBBS);
        }

        // GET: Games/GameBBS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameBBS gameBBS = db.GameBBS.Find(id);
            if (gameBBS == null)
            {
                return HttpNotFound();
            }
            return View(gameBBS);
        }

        // POST: Games/GameBBS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GameId,ParentId,Title,Context,Ip,Address,UserName,CreateTime,CreateUser,UpdateTime,UpdateUser")] GameBBS gameBBS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameBBS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameBBS);
        }

        // GET: Games/GameBBS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameBBS gameBBS = db.GameBBS.Find(id);
            if (gameBBS == null)
            {
                return HttpNotFound();
            }
            return View(gameBBS);
        }

        // POST: Games/GameBBS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameBBS gameBBS = db.GameBBS.Find(id);
            db.GameBBS.Remove(gameBBS);
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
