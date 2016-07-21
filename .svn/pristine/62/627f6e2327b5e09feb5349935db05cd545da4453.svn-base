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
    public class PageTitleLinksController : Controller
    {
        private SiteGameEntities db = new SiteGameEntities();

        // GET: Games/PageTitleLinks
        public ActionResult Index()
        {
            return View(db.PageTitleLink.ToList());
        }

        // GET: Games/PageTitleLinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageTitleLink pageTitleLink = db.PageTitleLink.Find(id);
            if (pageTitleLink == null)
            {
                return HttpNotFound();
            }
            return View(pageTitleLink);
        }

        // GET: Games/PageTitleLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/PageTitleLinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Title,ImagePath,ToUrl,OrderNum,IsVisible,CreateTime,CreateUser,UpdateTime,UpdateUser")] PageTitleLink pageTitleLink)
        {
            if (ModelState.IsValid)
            {
                db.PageTitleLink.Add(pageTitleLink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pageTitleLink);
        }

        // GET: Games/PageTitleLinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageTitleLink pageTitleLink = db.PageTitleLink.Find(id);
            if (pageTitleLink == null)
            {
                return HttpNotFound();
            }
            return View(pageTitleLink);
        }

        // POST: Games/PageTitleLinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Title,ImagePath,ToUrl,OrderNum,IsVisible,CreateTime,CreateUser,UpdateTime,UpdateUser")] PageTitleLink pageTitleLink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageTitleLink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pageTitleLink);
        }

        // GET: Games/PageTitleLinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageTitleLink pageTitleLink = db.PageTitleLink.Find(id);
            if (pageTitleLink == null)
            {
                return HttpNotFound();
            }
            return View(pageTitleLink);
        }

        // POST: Games/PageTitleLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PageTitleLink pageTitleLink = db.PageTitleLink.Find(id);
            db.PageTitleLink.Remove(pageTitleLink);
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
