using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
       
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {

                var Customers = db.Insurances.Where(x => x.Removed == null).ToList();

                var customers = new List<Insurance>();
                foreach (var customer in customers)
                {
                    var customersInfo = new Insurance();
                    customersInfo.Id = customer.Id;
                    customersInfo.FirstName = customer.FirstName;
                    customersInfo.LastName = customer.LastName;
                    customersInfo.EmailAddress = customer.EmailAddress;
                    customersInfo.DateOfBirth = customer.DateOfBirth;
                    customersInfo.CarYear = customer.CarYear;
                    customersInfo.CarMake = customer.CarMake;
                    customersInfo.CarModel = customer.CarModel;
                    customersInfo.DUI = customer.DUI;
                    customersInfo.SpeedingTickets = customer.SpeedingTickets;
                    customersInfo.Coverage = customer.Coverage;
                    customersInfo.Total = customer.Total;
                }

                return View(signupVms);

            }


        }
    }
}