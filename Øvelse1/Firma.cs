using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal class Firma : IHarAdresse
    {
        public Adresse Adresse { get; set; }

        public Firma(Adresse adresse)
        {
            Adresse = adresse;
        }
    }
}
