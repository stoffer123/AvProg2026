using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7._2_PeerToPeer.Shapes
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public void PrintMe()
        {
            Console.WriteLine($"{this.GetType().Name} Area: {Area()}.");
        }
    }
}
