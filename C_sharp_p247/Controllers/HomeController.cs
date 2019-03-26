using C_sharp_p247.Models;
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
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
            string carMake, string carModel, int carYear, string DUI, int tickets, string coverage)
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