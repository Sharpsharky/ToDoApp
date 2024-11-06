using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentPartialView()
        {
            return PartialView();
        }

        public ActionResult Form()
        {
            var years = DataHelper.GetYears(DateTime.Now);
            ViewBag.Years = new SelectList(years, "ID", "Name");
            return View();
        }

        public ActionResult Student()
        {
            return View(new StudentViewModel());
        }

        [HttpPost]
        public ActionResult Student(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save the student data to the database or perform other actions
                TempData["Message"] = "Student data posted!";
                return RedirectToAction("Confirmation");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(int SelectedYear)
        {
            TempData["Message"] = $"Data posted! Selected year: {SelectedYear}";
            return RedirectToAction("Confirmation");
        }

        public ActionResult Confirmation()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.SelectedYear = TempData["SelectedYear"];
            return View();
        }
    }
}