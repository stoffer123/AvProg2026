using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    public class LINQQueryes
    {
        private List<int> list = new() { 1, 2, 3, 4, 5,
            6, 7, 8, 9, 10,
            11, 12, 13, 14, 15,
            16, 17, 18, 19, 20 };

        public List<int> GetEvenWithQueryMethods()
        {
            return list.Where(x => x % 2 == 0).ToList();
        }

        public List<int> GetEvenWithQueryExpressions()
        {
            var selection =
                from num in list
                where num % 2 == 0
                select num;

            return selection.ToList();
        }

        public List<int> Get2CifreWithQueryMethods()
        {
            return list.Where(x => x.ToString().Count() == 2).ToList();
        }

        public List<int> Get2CifreWithQueryExpressions()
        {
            var selection =
                from num in list
                where num.ToString().Count() == 2
                select num;

            return selection.ToList();
        }

    }
}
