using Opgave2.Kort;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2.Factories
{
    internal interface IKortFactory<TKort> where TKort : IKort
    {
        TKort Create(EKulør kulør, ERang rang);
    }
}
