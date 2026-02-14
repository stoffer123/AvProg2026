using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.TransformStrategy
{
    public class TransformDefaultStrategy : ITransformStrategy
    {
        public int Transform(int data)
        {
            return data;
        }
    }
}
