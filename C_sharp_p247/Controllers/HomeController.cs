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
        public int GetAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (birthDate.DayOfYear > DateTime.Now.DayOfYear)
                age--;

            return age;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
            string carMake, string carModel, int carYear, string DUI, int tickets, string coverage)
        {
            using (InsuranceEntities2 db = new InsuranceEntities2())
            {
                DateTime today = DateTime.Today;
                TimeSpan age = today - dateOfBirth;
                double ageInDays = age.TotalDays;
                double daysInYear = 365.2425;
                double ageInYears = ageInDays / daysInYear;
                decimal quote = 50.0m;

                //Start with a base of $50 / month.
                //If the user is under 25, add $25 to the monthly total.
                //If the user is under 18, add $100 to the monthly total.
                //If the user is over 100, add $25 to the monthly total.
                //If the car's year is before 2000, add $25 to the monthly total.
                //If the car's year is after 2015, add $25 to the monthly total.
                //If the car's Make is a Porsche, add $25 to the price.
                //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                //Add $10 to the monthly total for every speeding ticket the user has.
                //If the user has ever had a DUI, add 25 % to the total.
                //If it's full coverage, add 50% to the total.
                if (ageInYears < 18.0)
                {
                    quote = quote + 100.0m;
                }
                else if (ageInYears < 25.0)
                {
                    quote = quote + 25.0m;
                }
                else if (ageInYears > 100.0)
                {
                    quote = quote + 25.0m;
                }
                if (carYear < 2000)
                {
                    quote = quote + 25.0m;
                }
                else if (carYear > 2015)
                {
                    quote = quote + 25.0m;
                }
                if (carMake == "Porsche")
                {
                    quote = quote + 25.0m;
                }
                if (carModel.Contains("911") || carModel.Contains("Carrera"))
                {
                    quote = quote + 25.0m;
                }
                if (tickets > 0)
                {
                    quote = quote + (10.0m * tickets);
                }
                if (DUI.ToLower() == "y")
                {
                    quote = quote + (quote * 1.25m);
                }
                if (coverage.ToLower() == "full")
                {
                    quote = quote + (quote * 1.5m);
                }

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
                signup.Quote = quote;

                db.SignUps.Add(signup);
                db.SaveChanges();
                return View("Success", signup);
            }

        }
    }
}