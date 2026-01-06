using System;
using System.Collections.Generic;
using System.Text;

namespace TextIO
{
    public class SystemTextIO : ITextIO
    {
        public string get()
        {
            string input = Console.ReadLine();
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
    }
}
