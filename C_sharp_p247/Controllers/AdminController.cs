﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_sharp_p247.Controllers
{
    public class AdminController : Controller
    {
        private readonly string connectionString;

        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var signupVms = new List<SignUpVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignUpVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVm.DOB = signup.DOB;
                    signupVm.CarMake = signup.CarMake;
                    signupVm.CarModel = signup.CarModel;
                    signupVm.CarYear = signup.CarYear;
                    signupVm.DUI = signup.DUI;
                    signupVm.Tickets = signup.Tickets;
                    signupVm.Coverage = signup.Coverage;

                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}