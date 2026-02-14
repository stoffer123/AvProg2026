using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.TransformStrategy
{
    public class TransformSquareStrategy : ITransformStrategy
    {
        public int Transform(int data)
        {
            return (int)Math.Pow(data, 2);
        }
    }
}
