using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift_butik
{
    public class Media
    {

        //För filmer: Namn, Regissör, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Pris.
        //För musikalbum: Namn, Artist, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Antal låtar, Pris.

        public string Name { get; set; }
        public string Creator { get; set; }
        public int Rating { get; set; }
        public string Release { get; set; }
        public string PlayTime { get; set; }
        public double Price { get; set; }

    }
}

