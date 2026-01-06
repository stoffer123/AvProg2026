using System;
using System.Collections.Generic;
using System.Text;

namespace TextIO.TextIO
{
    public interface ITextIO
    {
        void put(string text);
        string get();
        int getInt();
        int getIntInRange(int min, int max);
        int chooseFromList(List<string> options, string message);

    }
}
