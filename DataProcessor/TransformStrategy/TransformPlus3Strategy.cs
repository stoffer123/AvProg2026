using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.TransformStrategy
{
    public class TransformPlus3Strategy : ITransformStrategy
    {
        public int Transform(int data)
        {
            return data + 3;
        }
    }
}
