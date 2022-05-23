using PersonelYonetim.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelYonetim.View_Modal
{
    public class DepartmanModeli
    {
        public DepartmanModeli()
        {
            if (Departman == null)
                Departman = new Departman();
            if (Departmanlar ==null)
                Departmanlar=new List<Departman>();
        }
        public List<Departman> Departmanlar { get; set; }
        public Departman Departman { get; set; }
    }
}