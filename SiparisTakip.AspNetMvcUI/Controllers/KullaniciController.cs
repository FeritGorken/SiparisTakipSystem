using SiparisTakip.AspNetMvcUI.Models;
using SiparisTakip.Bll.KullaniciBll;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static SiparisTakip.AspNetMvcUI.Models.IslemSonucuEnum;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class KullaniciController : Controller
    {
        //IKullaniciService _kullaniciService = new KullaniciManager(new EfKullaniciRepository());

        IKullaniciService _kullaniciService;
        public KullaniciController(IKullaniciService kullaniciService)
        {
            this._kullaniciService = kullaniciService;
        }



        // GET: Kullanici
        [HttpGet]
        public ActionResult KullaniciGiris()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult KullaniciGiris(Kullanici kullanici)
        //{
        //    try
        //    {
        //        var _kullanici=_kullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);
        //        if(_kullanici!=null)
        //        {
        //            Session["KullaniciId"] = _kullanici.KullaniciID;
        //            Session["KullaniciAdi"] = _kullanici.KullaniciAdi+" "+_kullanici.KullaniciSoyadi;

        //            return RedirectToAction("Index", "AnaSayfa");
        //        }
        //        else
        //        {

        //        }
        //    }
        //    catch (System.Exception error)
        //    {

        //    }
        // //return Content("Hi there!");
        //    //return RedirectToAction("Index", "AnaSayfa");

        //    return new JsonResult();
        //}

        [HttpPost]
        public JsonResult KullaniciGiris(Kullanici kullanici)
        {
            IslemSonucModel islemSonucu;
            try
            {
                var _kullanici = _kullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);
                if(_kullanici!=null)
                {
                    //FormsAuthentication.SetAuthCookie("KullaniciId", false);
                    Session["KullaniciId"] = _kullanici.KullaniciID;
                    Session["KullaniciAdi"] = _kullanici.KullaniciAdi + " " + _kullanici.KullaniciSoyadi;

                    islemSonucu = new IslemSonucModel(IslemSonucKodlari.Basarili, "Kullanici Giris Basarili");
                     
                }
                else
                {
                    islemSonucu = new IslemSonucModel(IslemSonucKodlari.Uyari, "Kullanici Giris Basarisiz");
                }
            }
            catch (System.Exception error)
            {
                islemSonucu = new IslemSonucModel(IslemSonucKodlari.Hata, "Kullanıcı Giriş Kontrol Sırasında Hata Oluştu." + error.Message);
            }

            return Json(islemSonucu);
        }
        public ActionResult OturumuKapat()
        {
            //FormsAuthentication.SignOut();
            Session.Abandon();
            Session["adi"] = "dssd";
            Session.Add("soyadi", "ahmet");
            Session["adi"] = null;
            Session.Remove("adi");//belirtilen keyi iis üzerinden siler
            Session.RemoveAll();//tümünü siler
            return RedirectToAction("", "");
        }
    }
}