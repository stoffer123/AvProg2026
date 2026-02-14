using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.TransformStrategy
{
    public interface ITransformStrategy
    {
        int Transform(int data);
    }
}
