using SiparisTakip.AspNetMvcUI.Araclar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    //[Authorize]
    [YetkiKontrolu]
    public class StokController : Controller
    {
        // GET: Stok
        public ActionResult Index()
        {
            //if (Session["KullaniciId"] == null)
            //    return RedirectToAction("KullaniciGiris","Kullanici");
            return View();
        }
        //[Authorize]
        //[YetkiKontrolu("Admin)]
        [YetkiKontrolu]
        public ActionResult Kaydet()
        {
            return View();
        }
       // [Authorize]
        public ActionResult Sil()
        {
            return View();
        }
       // [Authorize]
        public ActionResult Guncelle()
        {
            return View();
        }
    }
}