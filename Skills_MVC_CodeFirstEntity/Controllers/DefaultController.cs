using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skills_MVC_CodeFirstEntity.Models.siniflar;

namespace Skills_MVC_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler); 
        }
    }
}