using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPim.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult CryptoMoedas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Conta()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
        public ActionResult Cadastro()
        {
            ViewBag.Message = "Your register page.";

            return View();
        }
    }
}