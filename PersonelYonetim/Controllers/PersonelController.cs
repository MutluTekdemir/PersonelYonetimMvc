using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelYonetim.View_Modal;
using PersonelYonetim.Models.Entity;
using System.Data.Entity;


namespace PersonelYonetim.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
          PersoneldbEntities db = new PersoneldbEntities();
          Modellerim Modellerim = new Modellerim();
        

        public ActionResult Index()
        {
            Modellerim.PersonelModeli.Personeller = db.Personels.ToList();
            return View(Modellerim);
        }
        [HttpGet]
        public ActionResult PersonelForm(Modellerim modellerim)
        {

            Modellerim = modellerim;
            return View(Modellerim);
        }
        public ActionResult Yeni()
        {
            Modellerim.PersonelModeli.Personeller = db.Personels.ToList();
            Modellerim.DepartmanModeli.Departmanlar = db.Departmen.ToList();
            return View("PersonelForm",Modellerim);
        }
        [HttpPost]
        public ActionResult Kaydet(Modellerim personel)
        {
            if (personel.PersonelModeli.Personel.Id ==0)
                db.Personels.Add(personel.PersonelModeli.Personel);
            else
                db.Entry(personel.PersonelModeli.Personel).State = EntityState.Modified;
            //Bu satırda id bilgisini almadan o anki kaydın güncellenmesini sağlarız.
            db.SaveChanges();
            //return View("Index");
            return RedirectToAction("Index", "Personel");

        }
        public ActionResult Guncelle(int id)
        {
            Modellerim.DepartmanModeli.Departmanlar = db.Departmen.ToList();
            Modellerim.PersonelModeli.Personel = db.Personels.Find(id);
         
            return View("PersonelForm", Modellerim);
        }

        public ActionResult Sil(int id)
        {
            var silinecek = db.Personels.Find(id);
            if (silinecek == null)
            {
                return HttpNotFound();
            }
            db.Personels.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}