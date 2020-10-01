using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift_butik
{
    public class Store
    {
        public string VisitingAdress { get; set; }
        public string BillingAdress { get; set; }
        public string BothAdresses { get; set; }
        public int ZipCodeVisit { get; set; }
        public int ZipCodeBill { get; set; }
        public string NumberStore { get; set; }
        public string NumberOffice { get; set; }

        public void PrintVistingInfo()
        {
            Console.WriteLine($"Besöksadess: \n{VisitingAdress} \nPostnummer: \n{ZipCodeVisit} \nTelefonnummer: \n{NumberStore}");
        }

        public void PrintBillingInfo()
        {
            Console.WriteLine($"Fakturaadress: \n{BillingAdress} \nPostnummer: \n{ZipCodeBill}\nTelefonnumer: \n{NumberOffice}");
        }
         public void PrintBothAdresses()
        {
            PrintVistingInfo();
            Console.WriteLine();
            PrintBillingInfo();
        }
    }
}
