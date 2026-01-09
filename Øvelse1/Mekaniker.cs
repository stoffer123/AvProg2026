using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal class Mekaniker : Medarbejder
    {

        public DateTime Svendeprøve { get; set; }
        public decimal Timeløn { get; set; }
        
        public Mekaniker(string navn, Adresse adresse, CprNr cprNr, string medarbejderNummer, DateTime svendeprøve, decimal timeløn) :
            base(navn, adresse, cprNr, medarbejderNummer)
        {
            Svendeprøve = svendeprøve;
            Timeløn = timeløn;
        }


        public override decimal BeregnUgeLøn()
        {
            return Timeløn * TimerPrUge;
        }
    }
}
