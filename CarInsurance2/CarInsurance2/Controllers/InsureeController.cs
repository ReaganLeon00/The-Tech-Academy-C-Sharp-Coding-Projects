using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (string.IsNullOrEmpty(table.FirstName) || string.IsNullOrEmpty(table.LastName) || string.IsNullOrEmpty(table.EmailAddress) || string.IsNullOrEmpty(table.DateOfBirth.ToString()) ||
                string.IsNullOrEmpty(table.CarYear.ToString()) || string.IsNullOrEmpty(table.CarMake) || string.IsNullOrEmpty(table.CarModel) || string.IsNullOrEmpty(table.SpeedingTickets.ToString()))
            {
                return View("~/Views/Shared/Error.cshtml");

            }

            else
            {
                int age = DateTime.Now.Year - table.DateOfBirth.Year;
                table.Quote = 50.00m;

                //ageCheck

                if (age < 18)
                {
                    table.Quote = table.Quote + 100.00m;

                }
                else if (age < 25 || age > 100)
                {
                    table.Quote = table.Quote + 25.00m;

                }

                //carYear
                if (table.CarYear < 2000 || table.CarYear > 2015)
                {
                    table.Quote = table.Quote + 25.00m;
                }

                //porsche 
                if (table.CarMake.ToLower() == "porsche")
                {
                    table.Quote = table.Quote + 25.00m;
                    if (table.CarModel.ToLower() == "911 carrera")
                    {
                        table.Quote = table.Quote + 25.00m;
                    }
                }

                //speedingTicket

                int ticketCount = Convert.ToInt32(table.SpeedingTickets);
                if (ticketCount < 0)
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
                for (int i = 0; i < ticketCount; i++)
                {
                    table.Quote = table.Quote + 10.00m;
                }

                //duiCheck

                if (table.DUI == true)
                {
                    table.Quote = table.Quote + (table.Quote * .25m);
                }

                //coverage

                if (table.CoverageType == true)
                {
                    table.Quote = table.Quote + (table.Quote * .50m);
                }


                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

        }

        

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
