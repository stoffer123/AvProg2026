using MøbelProgram.Møbler;
using System;
using System.Collections.Generic;
using System.Text;

namespace MøbelProgram.Factories
{
    internal interface IMøbelFactory
    {
        ILænestol CreateLænestol();
        IToPersonerSofa CreateToPersonerSofa();
        ITrePersonerSofa CreateTrePersonerSofa();
        IHjørneSofa CreateHjørneSofa();
        ITaburet CreateTaburet();
    }
}
