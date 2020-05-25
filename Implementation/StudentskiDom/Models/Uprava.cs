﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Uprava : Korisnik
    {
        public int UpravaId { get; set; }
        //public Blagajna Blagajna { get; set; }

        // Baza
        public int BlagajnaId { get; set; }
        public int KorisnikId { get; set; }

        // Veze sa ostalim klasama
        public virtual Korisnik Korisnik { get; set; }
        public virtual Blagajna Blagajna { get; set; }

        public Uprava()
        {
        }
    }
}
