using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelYonetim.Models.Entity;

namespace PersonelYonetim.Controllers
{
    public class DepeatmanController : Controller
    {
        PersoneldbEntities db = new PersoneldbEntities();

        // GET: Depeatman
        public ActionResult Index()
        {
            var model = db.Departmen.ToList(); 
            return View(model);
          
        }
        //Veriyi getirmek için kullanıyoruz
        [HttpGet]
        public ActionResult Yeni()
        {
            return View("DepartmanForm");
        }
        [HttpPost]
        public ActionResult Kaydet(Departman departman)
        {
            if (departman.Id==0) // Kaydet
            {
                db.Departmen.Add(departman);
            }
            else // ıdsi olan kaydı güncelle
            {
                var guncellecekdepertman = db.Departmen.Find(departman.Id);
                if (guncellecekdepertman==null)
                {
                    return HttpNotFound();
                }
                guncellecekdepertman.Ad = departman.Ad;
            }
            db.SaveChanges();

            return RedirectToAction("Index", "Depeatman");
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Departmen.Find(id);
            if (model==null)
            {
                return HttpNotFound();
            }
            return View("DepartmanForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecek = db.Departmen.Find(id);
            if (silinecek == null)
            {
                return HttpNotFound();
            }
            db.Departmen.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Index");  //dikkat et

            //personel ile dpartman birbiriyle ilişkili olduğundan ara yüz yapmamız lazım.
        }

    }
}