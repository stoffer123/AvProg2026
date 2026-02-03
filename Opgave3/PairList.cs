using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    public class PairList<T1, T2>
        where T1 : Pair<T1, T2>
        where T2 : Pair<T1, T2>
    {
        private List<Pair<T1, T2>> _list = new();

        public void Add(Pair<T1, T2> pair)
        {
            _list.Add(pair);
        }

        public void Sort()
        {
            _list.Sort();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var pair in _list)
            {
                sb.AppendLine($"({pair.Arg1}, {pair.Arg2})");
            }
            return sb.ToString();
        }

    }
}
