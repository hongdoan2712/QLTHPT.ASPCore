using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QLTHPT.Models;
namespace QLTHPT.Controllers
{
    public class THUsController : Controller
    {
        private acomptec_qlthptContext db = new acomptec_qlthptContext();

        // GET: THUs
        public ActionResult Index()
        {
            return View(db.Thu.ToList());
        }

        // GET: THUs/Details/5
       public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thu tHU = db.Thu.Find(id);
            if (tHU == null)
            {
                return HttpNotFound();
            }
            return View(tHU);
        }

        // GET: THUs/Create
        public ActionResult Create()
        {
            Thu obj = new Thu();
            obj.ThuMa = CreateID.CreateID_ByteText();
            return View(obj);
        }

        // POST: THUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThuMa,ThuTen")] Thu tHU)
        {
            if (ModelState.IsValid)
            {
                db.Thu.Add(tHU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tHU);
        }

        // GET: THUs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thu tHU = db.Thu.Find(id);
            if (tHU == null)
            {
                return HttpNotFound();
            }
            return View(tHU);
        }

        // POST: THUs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThuMa,ThuTen")] Thu tHU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tHU);
        }

        // GET: THUs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thu tHU = db.Thu.Find(id);
            if (tHU == null)
            {
                return HttpNotFound();
            }
            return View(tHU);
        }

        // POST: THUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Thu tHU = db.Thu.Find(id);
            db.Thu.Remove(tHU);
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
