using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift_butik
{
    public class Movies : Media
    {
        //För filmer: Namn, Regissör, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Pris.

        public void WriteMovie()
        {
            Console.WriteLine($"Titel: {Name}\nRegissör: {Creator} \nSnittbetyg: {Rating} \nReleasedatum: {Release} \nSpeltid: {PlayTime} \nPris: {Price}kr\n");
        }

    }
}
