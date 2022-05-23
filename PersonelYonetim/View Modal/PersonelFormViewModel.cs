using PersonelYonetim.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelYonetim.View_Modal
{
    public class PersonelFormViewModel
    {
      

        public IEnumerable<Departman> Departmanlar { get; set; }
        //public List<Departman> Departmanlar { get; set; } 
        public Personel Personel { get; set; }
        public List<Personel> Personeller { get; set; }
        public int Girilensayi { get; set; }
       
        public List<string> Yazilar { get; set; }
        public string Name { get; set; }
        public List<int> Sayilarim { get; set; }


        //Personel eklerken Departlamanları bağlayabilmek için ara katmanımı yazmak zorundayım.
    }
}