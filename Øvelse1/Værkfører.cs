using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal class Værkfører : Mekaniker
    {
        public DateTime Udnævnelse { get; set; }
        public decimal Tillæg { get; set; }

        public Værkfører(string navn, Adresse adresse, CprNr cprNr, string medarbejderNummer, DateTime svendeprøve, decimal timeløn, DateTime udnævnelse, decimal tillæg) :
            base(navn, adresse, cprNr, medarbejderNummer, svendeprøve, timeløn)
        {
            Udnævnelse = udnævnelse;
            Tillæg = tillæg;
        }

        public override decimal BeregnUgeLøn()
        {
            decimal grundløn = base.BeregnUgeLøn();
            return grundløn + Tillæg;
        }
    }
}
