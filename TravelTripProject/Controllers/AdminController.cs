using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var degerler = context.Blogs.Find(id);
            context.Blogs.Remove(degerler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var degerler = context.Blogs.Find(id);
            return View("BlogGetir", degerler);
        }
        public ActionResult BlogGuncelle(Blog blog)
        {
            var degerler = context.Blogs.Find(blog.ID);
            degerler.Aciklama= blog.Aciklama;
            degerler.Baslik = blog.Baslik;
            degerler.BlogImage = blog.BlogImage;
            degerler.Tarih = blog.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var degerler = context.Yorumlars.ToList();
            return View(degerler);
        }
        public ActionResult YorumSil(int id)
        {
            var degerler = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(degerler);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var degerler = context.Yorumlars.Find(id);
            return View("YorumGetir", degerler);
        }
        public ActionResult YorumGuncelle(Yorumlar yorumlar)
        {
            var degerler = context.Yorumlars.Find(yorumlar.ID);
            degerler.KullaniciAdi = yorumlar.KullaniciAdi;
            degerler.Mail = yorumlar.Mail;
            degerler.Yorum = yorumlar.Yorum;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

    }
}