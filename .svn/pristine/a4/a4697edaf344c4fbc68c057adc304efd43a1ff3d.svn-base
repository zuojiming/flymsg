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
    public class IpLogsController : Controller
    {
        private SiteGameEntities db = new SiteGameEntities();

        // GET: Games/IpLogs
        public ActionResult Index()
        {
            return View(db.IpLog.ToList());
        }

        // GET: Games/IpLogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IpLog ipLog = db.IpLog.Find(id);
            if (ipLog == null)
            {
                return HttpNotFound();
            }
            return View(ipLog);
        }

        // GET: Games/IpLogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/IpLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ip,ActionUrl,ClientUrl,UrlReferrer,CreateTime,CreateUser,UpdateTime,UpdateUser")] IpLog ipLog)
        {
            if (ModelState.IsValid)
            {
                db.IpLog.Add(ipLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ipLog);
        }

        // GET: Games/IpLogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IpLog ipLog = db.IpLog.Find(id);
            if (ipLog == null)
            {
                return HttpNotFound();
            }
            return View(ipLog);
        }

        // POST: Games/IpLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ip,ActionUrl,ClientUrl,UrlReferrer,CreateTime,CreateUser,UpdateTime,UpdateUser")] IpLog ipLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ipLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ipLog);
        }

        // GET: Games/IpLogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IpLog ipLog = db.IpLog.Find(id);
            if (ipLog == null)
            {
                return HttpNotFound();
            }
            return View(ipLog);
        }

        // POST: Games/IpLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IpLog ipLog = db.IpLog.Find(id);
            db.IpLog.Remove(ipLog);
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
