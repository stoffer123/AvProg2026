using DataProcessor.TransformStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    public class DataProcessor
    {
        private List<int> _data;
        private ITransformStrategy _transformer;

        public DataProcessor(ITransformStrategy transformer)
        {
            _data = new()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            _transformer = transformer;
        }

        public void SetStrategy(ITransformStrategy transformer)
        {
            _transformer = transformer;
        }

        public string GetStrategyName()
        {
            return _transformer.GetType().Name;
        }

        public int SumOfTransforms()
        {
            int result = 0;
            foreach(var i in _data)
            {
                result += _transformer.Transform(i);
            }

            return result;
        }

        public List<int> ListOfTransforms()
        {
            List<int> result = new();

            foreach(var i in _data)
            {
                result.Add(_transformer.Transform(i));
            }

            return result;
        }

        public int MinOfTransforms()
        {
            List<int> list = new();

            foreach (var i in _data)
            {
                list.Add(_transformer.Transform(i));
            }

            return list.Min();
        }

        public int MaxOfTransforms()
        {
            List<int> list = new();

            foreach (var i in _data)
            {
                list.Add(_transformer.Transform(i));
            }

            return list.Max();
        }
    }
}
