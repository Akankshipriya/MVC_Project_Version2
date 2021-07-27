using MVC_Project_Version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project_Version2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            database_testEntities obj = new database_testEntities();
            return View(obj.displayData());
        }

        
    }
}