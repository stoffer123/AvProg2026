using System;
using System.Collections.Generic;
using System.Text;

namespace TextIO.TextIO
{
    public class SystemTextIO : ITextIO
    {

        private SystemTextIO()
        {
            // No initialization needed for console I/O
        }

        public static ITextIO CreateIO() //Factory method to create IO
        {
            return new SystemTextIO();
        }

        public string get()
        {
            string input = Console.ReadLine() ?? "";
            return input;
        }

        public int getInt()
        {
            while (true)
            {
                string input = get();
                try
                {
                    return int.Parse(input);
                }
                catch (FormatException)
                {
                    put("Invalid integer. Please try again:");
                }
            }
        }

        public void put(string text)
        {
            Console.WriteLine(text);
        }

        public int getIntInRange(int min, int max)
        {
            while (true)
            {
                int value = getInt();
                if (value >= min && value <= max)
                {
                    return value;
                }
                else
                {
                    put($"Input must be between {min} and {max}. Please try again:");
                }
            }
        }
    }
}
