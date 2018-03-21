using DZDPortfolio.DAL;
using DZDPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DZDPortfolio.Controllers
{
    public class HomeController : Controller
    {
        DZDPortfolioContext db = new DZDPortfolioContext();

        public ActionResult Index()
        {

            //var p = new DroneProject();
            //p.ProjectTitle = "test";
            //p.UploadDate = DateTime.Now;
            //db.DroneProjects.Add(p);
            //db.SaveChanges();
            db.Database.CreateIfNotExists();
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Programming()
        {
            return View();
        }

        public ActionResult Drones()
        {
            return View();
        }

        public ActionResult ThreeDPrinting()
        {
            return View();
        }
    }
}