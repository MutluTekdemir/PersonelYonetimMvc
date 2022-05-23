using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelYonetim.View_Modal
{
    public class Modellerim
    {
        public Modellerim()
        {
            PersonelModeli = new PersonelModeli();
            DepartmanModeli = new DepartmanModeli();
        }
        public PersonelModeli PersonelModeli { get; set; }
        public DepartmanModeli DepartmanModeli { get; set; }
    }
}