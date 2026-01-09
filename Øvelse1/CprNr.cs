using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Øvelse1
{
    internal class CprNr
    {
        public string Fødselsdato { get; set; }
        public string sequenceNumber { get; set; }

        public CprNr(string fødselsdato, string sequenceNumber)
        {
            Fødselsdato = fødselsdato;
            this.sequenceNumber = sequenceNumber;
        }

        public override string ToString()
        {
            return $"{Fødselsdato}{sequenceNumber}";
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is CprNr))
            {
                return false;
            }

            CprNr cpr = (CprNr)obj;

            return Fødselsdato.Equals(cpr.Fødselsdato) && sequenceNumber.Equals(cpr.sequenceNumber);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Fødselsdato.GetHashCode(), sequenceNumber.GetHashCode());
        }
    }
}
