using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal class Synsmand : Mekaniker
    {

        public int SynPrUge { get; set; }
        public decimal LønPrSyn { get; set; }

        public Synsmand(string navn, Adresse adresse, CprNr cprNr, string medarbejderNummer, DateTime svendeprøve, decimal timeløn, int synPrUge, decimal lønPrSyn) 
            : base(navn, adresse, cprNr, medarbejderNummer, svendeprøve, timeløn)
        {
            SynPrUge = synPrUge;
            LønPrSyn = lønPrSyn;
        }

        public override decimal BeregnUgeLøn()
        {
            return SynPrUge * LønPrSyn;
        }
    }
}
