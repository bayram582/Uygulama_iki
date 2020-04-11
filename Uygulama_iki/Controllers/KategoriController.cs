using KutuphaneProgrami.Data;
using KutuphaneProgrami.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Uygulama_iki.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            Context context = new Context();
            var kitaplar=context.Kitaplar.ToList();  

            return View();


            //List<int> kategoriIds = new List<int>();
            //kategoriIds.Add(1);
            //kategoriIds.Add(2);

            //List<Kategori> kategoriler = new List<Kategori>();
            //foreach (var ktgID in kategoriIds)
            //{
            //    var ktg = context.Kategoriler.FirstOrDefault(x => x.Id == ktgID);
            //    kategoriler.Add(ktg);
            //}

            //Kitap kitap = new Kitap()
            //{
            //    Ad = "Ay yıldız",
            //    Adet = 100,
            //    EklenmeTarihi = DateTime.Now,
            //    SiraNo = "1",
            //    YazarId = 1,
            //    Kategoriler = kategoriler
            //};

            ////var model = context.Kitaplar.ToList();
            //context.Kitaplar.Add(kitap);
            //context.SaveChanges();
            //return View();
        }
    }
}