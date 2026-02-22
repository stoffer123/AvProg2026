using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7._2_PeerToPeer.Shapes
{
    public class Rectangle : IShape
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double Area()
        {
            return _height * _width;
        }

        public void PrintMe()
        {
            Console.WriteLine($"{this.GetType().Name} Area: {Area()}.");
        }
    }
}
