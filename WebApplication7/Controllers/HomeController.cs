using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
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
        public ActionResult Test(Test model)
        {
            string FIO2 = "Вас зовут" + model.FIO;
            ViewBag.Message =  $"Вы ввели текст: {model.text1}, Ваша покупка это :{model.product},{model.yazik} это действительно хороший язык программирования. {FIO2}";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class Test
    {   public string product { get; set; }
        public string yazik { get; set; }
        public string text1 { get; set; }
        public string FIO { get; set; }
        public string serial { get; set; }
    }
}