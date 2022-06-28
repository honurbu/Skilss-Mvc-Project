using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skills_MVC_CodeFirstEntity.Models.siniflar;
using System.Data.Entity;

namespace Skills_MVC_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin


        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.YETENEKLERS.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y)
        {
            c.YETENEKLERS.Add(y);
            c.SaveChanges();

            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = c.YETENEKLERS.Find(id);         //id ye ait değerleri bul
            c.YETENEKLERS.Remove(deger);                //id e ait değerleri sil
            c.SaveChanges();                            //vt. ye kaydet
            return RedirectToAction("Index");       //aksiyon olarak silince index e yönlendir demek.
        }

        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            var deger = c.YETENEKLERS.Find(id);         //id ye ait değerleri bul
                                    
            return View("YetenekGuncelle",deger);       //aksiyon olarak silince index e yönlendir demek.
        }
        [HttpPost]
        public ActionResult YetenekGuncelle(Yetenekler y)
        {
            var getir = c.YETENEKLERS.Find(y.ID);
            getir.ACIKLAMA = y.ACIKLAMA;
            getir.DEGER = y.DEGER;
            c.SaveChanges();
            return RedirectToAction("Index");
              
        }
    }
}