using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livelearning2_HashCodes
{
    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return this.Id == ((Person)obj).Id;
        }
    }
}
