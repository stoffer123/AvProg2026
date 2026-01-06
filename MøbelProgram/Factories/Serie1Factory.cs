using MøbelProgram.Møbler;
using System;
using System.Collections.Generic;
using System.Text;

namespace MøbelProgram.Factories
{
    internal class Serie1Factory : IMøbelFactory
    {
        public IHjørneSofa CreateHjørneSofa()
        {
            return new Møbler.Serie1.HjørneSofa();
        }

        public ILænestol CreateLænestol()
        {
            return new Møbler.Serie1.Lænestol();
        }

        public ITaburet CreateTaburet()
        {
            return new Møbler.Serie1.Taburet();
        }

        public IToPersonerSofa CreateToPersonerSofa()
        {
            return new Møbler.Serie1.ToPersonerSofa();
        }

        public ITrePersonerSofa CreateTrePersonerSofa()
        {
            return new Møbler.Serie1.TrePersonerSofa();
        }
    }
}
