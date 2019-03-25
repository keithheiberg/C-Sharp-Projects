using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_sharp_p247.Controllers
{
    public class HomeController : Controller
    {
        public int SignUp { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, string dateOfBirth,
            string carMake, string carModel, string carYear, string tickets, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var signup = new SignUp();
                    signup.Id = Id;
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    signup.DOB = dateOfBirth;
                    signup.CarMake = carMake;
                    signup.CarModel = carModel;
                    signup.CarYear = carYear;
                    signup.DUI = DUI;
                    signup.Tickets = tickets;
                    signup.Coverage = coverage;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }
                return View("Success");
            }
        }
    }
}