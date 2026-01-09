using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal abstract class Medarbejder : IHarAdresse
    {
        private const int _timerPrUge = 37;


        public string Navn { get; set; }
        public Adresse Adresse { get; set; }
        public int TimerPrUge => _timerPrUge;
        public CprNr CprNr { get; set; }
        public string MedarbejderNummer { get; set; }

        public Medarbejder(string navn, Adresse adresse, CprNr cprNr, string medarbejderNummer)
        {
            Navn = navn;
            Adresse = adresse;
            CprNr = cprNr;
            MedarbejderNummer = medarbejderNummer;
        }

        public abstract decimal BeregnUgeLøn();

        public override string ToString()
        {
            return "Navn:" + Navn + ", Adresse:" + Adresse.ToString() + ", Cpr nummer:" + CprNr + ", Medarbejdernummer:" + MedarbejderNummer;
        }

    }
}
