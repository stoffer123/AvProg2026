using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2.Kort
{
    internal delegate bool FilterKortDelegate<TKort>(TKort kort) where TKort : IKort;
    internal interface IKort
    {
        EKulør Kulør { get; }
        ERang Rang { get; }
    }
}
