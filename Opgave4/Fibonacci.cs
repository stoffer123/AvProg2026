using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Fibonacci
    {
        public List<long> fiboList= new List<long>();

        public Fibonacci(long maxValue)
        {
            PopulateList(maxValue);
            
        }

        public long GetSumOfEvenValues()
        {
            long sum = 0;
            foreach (long value in fiboList)
            {
                if(value % 2 == 0)
                {
                    sum += value;
                }
            }
            return fiboList.Sum(x => x % 2 == 0 ? x : 0);
        }

        private void PopulateList(long maxValue)
        {
            fiboList.Clear();
            
            fiboList.Add(0);
            fiboList.Add(1);

            while (true)
            {
                long nextValue = fiboList[fiboList.Count - 1] + fiboList[fiboList.Count - 2];

                if(nextValue > maxValue)
                {
                    break;
                }

                fiboList.Add(nextValue);
            }


        }
    }
}
