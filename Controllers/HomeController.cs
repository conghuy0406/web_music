using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Model1 model = new Model1();
            return View(model.TacGia.ToList());
        }

        public ActionResult AlbumsStore()
        {
            return View("albums-store");
        }

        public ActionResult Event()
        {
            return View("event");
        }

        public ActionResult Blog()
        {
            return View("blog");
        }

        public ActionResult Contact()
        {
            return View("contact");
        }

        public ActionResult Elements()
        {
            return View("elements");
        }

        public ActionResult Login()
        {
            return View("login");
        }
    }
}