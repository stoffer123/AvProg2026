using OtherShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7._2_PeerToPeer.Shapes.Adapters
{
    public class RhombusAdapter : IShape
    {
        private Rhombus _rhombus;

        public RhombusAdapter(double a, double b)
        {
            _rhombus = new Rhombus(a, b);
        }


        public double Area()
        {
            return _rhombus.AreaFormula()(_rhombus);
        }

        public void PrintMe()
        {
            _rhombus.PrintDescriptionToConsole();
        }
    }
}
