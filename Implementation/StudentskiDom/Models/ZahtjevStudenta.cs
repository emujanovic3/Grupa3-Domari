﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class ZahtjevStudenta : Zahtjev
    {
        public int ZahtjevStudentaId { get; set; }
        //public Student PodnosilacZahtjeva { get; set; }

        // Baza
        public int StudentId { get; set; }

        // Veze sa ostlalim klasama
        public virtual Student Student { get; set; }
        public virtual ZahtjevZaCimeraj ZahtjevZaCimeraj { get; set; }
        public virtual ZahtjevZaPremjestanje ZahtjevZaPremjestanje { get; set; }
        public virtual Zahtjev Zahtjev { get; set; }

        public ZahtjevStudenta(Student podnosilacZahtjeva, DateTime datum) : base(datum)
        {
            //PodnosilacZahtjeva = podnosilacZahtjeva;
        }
    }
}
