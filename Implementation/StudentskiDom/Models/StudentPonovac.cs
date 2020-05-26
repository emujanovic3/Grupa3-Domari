﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class StudentPonovac : Student, IStudent
    {
        public StudentPonovac(int id, LicniPodaci podaci, PrebivalisteInfo prebivaliste, SkolovanjeInfo skolovanje, Soba soba, int brojRucaka, int brojVecera) 
            : base(id, podaci, prebivaliste, skolovanje, soba, brojRucaka, brojVecera)
        {
        }

        public void uplatiDom(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
