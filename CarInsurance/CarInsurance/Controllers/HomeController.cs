using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CarInsurance; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstname, string lastname, string emailaddress, DateTime dateofbirth, int caryear, string carmake, string carmodel, string dui, int speedingtickets, string coverage)
        {
                    var customer = new Insurance();
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(emailaddress) || string.IsNullOrEmpty(carmake) || string.IsNullOrEmpty(carmodel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using(CarInsuranceEntities db = new CarInsuranceEntities())
                
                {
                    
                    customer.FirstName = firstname;
                    customer.LastName = lastname;
                    customer.EmailAddress = emailaddress;
                    customer.DateOfBirth = dateofbirth;
                    customer.CarYear = caryear;
                    customer.CarMake = carmake;
                    customer.CarModel = carmodel;
                    customer.DUI = dui;
                    customer.SpeedingTickets = speedingtickets;
                    customer.Coverage = coverage;
                    

                    db.Insurances.Add(customer);
                    db.SaveChanges();

                    int total = 50;
                    var today = DateTime.Now;
                    var age = today.Year - dateofbirth.Year;
                    if (dateofbirth > today.AddYears(-25))
                    {
                        total = total + 25;
                    }
                    else if (dateofbirth > today.AddYears(-18))
                    {
                        total = total + 100;

                    }
                    else if (dateofbirth > today.AddYears(-100))
                    {
                        total = total + 25;
                    }

                    if (caryear < 2000)
                    {
                        total = total + 25;
                    }
                    else if (caryear > 2015)
                    {
                        total = total + 25;
                    }

                    if (carmake == "Porsche")
                    {
                        total = total + 25;
                    }

                    if (carmake == "Porsche" && carmodel == "911 Carrera")
                    {
                        total = total + 25;
                    }

                    if (speedingtickets > 0)
                    {
                        total = total + (speedingtickets * 10);
                    }

                    if (dui == "Yes" || dui == "yes" || dui == "yeah")
                    {
                        total = total + (total * 25 / 100);
                    }
                    else
                    {
                        total = total + 0;
                    }

                    if (coverage == "Yes" || coverage == "yes" || coverage == "yeah")
                    {
                        total = total + (total * 50 / 100);
                    }
                    else
                    {
                        total = total + 0;
                    }
                    customer.Total = total;
                }
                return View("~/Views/Home/Success.cshtml");
            }
        }
        public ActionResult Admin()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var Customers = db.Insurances;
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
                return View(customers);
            }
            }
           
            
        }

      
    }
