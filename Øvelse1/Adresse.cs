using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal class Adresse
    {
        public required string Vejnavn { get; set; }
        public required int Nummer { get; set; }
        public required string By { get; set; }
        public required string Postnummer { get; set; }

        public override string ToString()
        {
            return Vejnavn + " " + Nummer + ", " + Postnummer + " " + By;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Adresse))
            {
                return false;
            }

            Adresse andenAdresse = (Adresse)obj;
            return Vejnavn == andenAdresse.Vejnavn &&
                   Nummer == andenAdresse.Nummer &&
                   By == andenAdresse.By &&
                   Postnummer == andenAdresse.Postnummer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Vejnavn, Nummer, By, Postnummer);
        }

    }
}
