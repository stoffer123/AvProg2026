using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    public class ParantesTæller
    {
        private Dictionary<char, int> dict = new()
        {
            {'(', 0 },
            {')', 0 },
            {'[', 0 },
            {']', 0 },
            {'{', 0 },
            {'}', 0 }
        };

        public void Tæl(string str)
        {
            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
            }
        }

        /// <summary>
        /// Returnere antallet af unikke paranteser af den givne type
        /// </summary>
        /// <param name="type"></param>
        /// <returns>int</returns>
        /// <exception cref="ArgumentException"></exception>
        public int GetUniqueTypeCount(char type)
        {
            if (dict.ContainsKey(type))
            {
                return dict[type];
            }
            else
            {
                throw new ArgumentException("Invalid type");
            }
        }

        /// <summary>
        /// Her skelnes kun imellem åbne og lukkede paranteser, og ikke mellem de forskellige typer
        /// </summary>
        /// <returns></returns>
        public int GetTypesCount(char type)
        {
            return type switch
            {
                '(' or '[' or '{' => dict['('] + dict['['] + dict['{'],
                ')' or ']' or '}' => dict[')'] + dict[']'] + dict['}'],
                _ => throw new ArgumentException("Invalid type"),
            };
        }
    }
}
