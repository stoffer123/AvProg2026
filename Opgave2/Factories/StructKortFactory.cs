using Opgave2.Kort;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2.Factories
{
    internal class StructKortFactory : IKortFactory<StructKort>
    {
        public StructKort Create(EKulør kulør, ERang rang)
        {
            return new StructKort(kulør, rang);
        }
    }
}
