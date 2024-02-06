using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogYorum blogYorum = new BlogYorum();

        public ActionResult Index()
        {
            //var degerler = context.Blogs.ToList();
            blogYorum.Deger1=context.Blogs.ToList();
            blogYorum.Deger3 = context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return View(blogYorum);
        }
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger1=context.Blogs.Where(x=>x.ID==id).ToList();
            blogYorum.Deger2=context.Yorumlars.Where(x=>x.Blogid==id).ToList();
            return View(blogYorum);
        }
    }
}