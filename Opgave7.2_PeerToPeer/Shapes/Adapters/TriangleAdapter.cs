using OtherShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7._2_PeerToPeer.Shapes.Adapters
{
    public class TriangleAdapter : IShape
    {
        private readonly Triangle _triangle;

        public TriangleAdapter(double a, double b, double c)
        {
            _triangle = new Triangle(a, b, c);
        }

        public double Area()
        {
            return _triangle.CalculateArea();
        }

        public void PrintMe()
        {
            Console.WriteLine(_triangle.GetDescription());
        }
    }
}
