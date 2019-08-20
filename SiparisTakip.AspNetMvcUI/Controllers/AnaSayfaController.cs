using SiparisTakip.Interfaces.Fatura;
using SiparisTakip.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class AnaSayfaController : Controller
    {
        IStokService _stokService;
        IFaturaService _faturaService;

        public AnaSayfaController(IStokService stokService,IFaturaService faturaService)
        {
            this._stokService = stokService;
            this._faturaService = faturaService;
        }


        // GET: AnaSayfa
        public ActionResult Index()
        {
            var liste = _stokService.Listele();
            return View(liste);
        }
    }
}