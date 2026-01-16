using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2.Kort
{
    internal class ClassKort : IKort
    {
        public EKulør Kulør { get; }
        public ERang Rang { get; }

        public ClassKort(EKulør kulør, ERang rang)
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
