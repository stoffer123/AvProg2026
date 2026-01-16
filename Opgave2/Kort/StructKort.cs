using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2.Kort
{
    internal struct StructKort : IKort
    {
        public EKulør Kulør { get; }
        public ERang Rang { get; }

        public StructKort(EKulør kulør, ERang rang)
        {
            Kulør = kulør;
            Rang = rang;
        }

        public override string ToString()
        {
            return Rang == ERang.JOKER ?
                Rang.ToString() : $"{Kulør} {Rang}";
        }
    }
}
