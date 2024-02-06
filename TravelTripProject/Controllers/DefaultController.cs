using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.Take(8).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = context.Blogs.Where(x => x.ID==2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = context.Blogs.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = context.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
    }

}