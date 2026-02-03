using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Opgave3
{
    public static class StringOperations
    {
        public static string Cut(this string s, int n)
        {
            if (s.Length > n)
            {
                return s.Substring(0, n);
            }

            return s;

        }

        public static string LeftAdjust(this string s, int n, char c)
        {
            if (s.Length >= n)
            {
                return s.PadRight(n, c);
            }
            return s;
        }

        public static string RightAdjust(this string s, int n, char c)
        {
            if (s.Length >= n)
            {
                return s.PadLeft(n, c);
            }
            return s;
        }

        public static string CenterAdjust(this string s, int n, char c)
        {
            if(s.Length >= n)
            {
                return s;
            }

            int totalPadding = n - s.Length;
            int padLeft = totalPadding / 2;
            int padRight = totalPadding - padLeft;

            s = s.PadLeft(s.Length + padLeft, c);
            s = s.PadRight(s.Length + padRight, c);
            return s;
        }

        public static string RemoveChars(this string s, char c)
        {
            return string.Concat(s.Where(ch => ch != c)).ToString();
        }

        public static List<string> Split(this string s, string[] seperators, bool includeEmpty, bool includeSeperators)
        {
            string pattern = string.Join("|", seperators.Select(sep => Regex.Escape(sep)));

            string[] parts;
            if (includeSeperators)
            {
                parts = Regex.Split(s, $"({pattern})");
            }
            else
            {
                parts = Regex.Split(s, pattern);

            }

            if (includeEmpty)
            {
                return parts.ToList();
            }
            else
            {
                return parts.Where(p => p.Length > 0).ToList();
            }
        }
    }
}
