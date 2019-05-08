using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeDB.Models;
using OfficeOpenXml;

namespace BikeDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Upload(FormCollection formCollection)
        {
            var ridesList = new List<Log>();
            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["UploadedFile"];
                if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
                {
                    string fileName = file.FileName;
                    string fileContentType = file.ContentType;
                    byte[] fileBytes = new byte[file.ContentLength];
                    var data = file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                    using (var package = new ExcelPackage(file.InputStream))
                    {
                        var currentSheet = package.Workbook.Worksheets;
                        var workSheet = currentSheet.First();
                        var noOfCol = workSheet.Dimension.End.Column;
                        var noOfRow = workSheet.Dimension.End.Row;
                        for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                        {
                            var ride = new Log();
                            double d = Convert.ToDouble(workSheet.Cells[rowIterator, 1]);
                            ride.Date = DateTime.FromOADate(d);
                            ride.Miles = Convert.ToDecimal(workSheet.Cells[rowIterator, 2].Value);
                            string timeConversion = workSheet.Cells[rowIterator, 1].ToString();
                            double h = double.Parse(timeConversion);
                            ride.Hours = DateTime.FromOADate(h);
                            ride.AvgMPH = Convert.ToDecimal(workSheet.Cells[rowIterator, 4].Value);
                            ride.DaysSince = Convert.ToInt32(workSheet.Cells[rowIterator, 5].Value);
                            ridesList.Add(ride);
                        }
                    }
                }
            }
            using (BikeLogEntities bikeLogEntities = new BikeLogEntities())
            {
                //foreach (var item in ridesList)
                //{
                //    bikeLogEntities.Logs.Add(item);
                //}
                bikeLogEntities.SaveChanges();
            }
            return View("Index");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}