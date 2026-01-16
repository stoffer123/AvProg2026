using Opgave2.Kort;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2.Factories
{
    internal class ClassKortFactory
    {
        public ClassKort Create(EKulør kulør, ERang rang)
        {
            return new ClassKort(kulør, rang);
        }
    }
}
