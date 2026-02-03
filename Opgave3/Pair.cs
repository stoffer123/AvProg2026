using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    public class Pair<T1, T2> : IComparable<Pair<T1, T2>>
        where T1 : IComparable<T1>
        where T2 : IComparable<T2>
    {
        public T1 Arg1 { get; set; }
        public T2 Arg2 { get; set; }

        public Pair(T1 arg1, T2 arg2)
        {
            Arg1 = arg1;
            Arg2 = arg2;
        }

        public void Clear()
        {
            Arg1 = default(T1);
            Arg2 = default(T2);
        }

        public int CompareTo(Pair<T1, T2>? other)
        {
            var result = Arg1.CompareTo(other.Arg1);
            if (result == 0)
            {
                result = Arg2.CompareTo(other.Arg2);
            }

            return result;
        }
    }
}
