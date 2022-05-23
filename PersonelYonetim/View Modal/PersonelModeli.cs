using PersonelYonetim.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelYonetim.View_Modal
{
    public class PersonelModeli
    {
        public PersonelModeli()
        {
            if (Personel == null)
                Personel = new Personel();

            if (Personeller == null)
                Personeller = new List<Personel>();
        }
        public Personel Personel { get; set; }
        public List<Personel> Personeller { get; set; }
    }
}