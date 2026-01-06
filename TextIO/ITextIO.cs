using System;
using System.Collections.Generic;
using System.Text;

namespace TextIO
{
    public interface ITextIO
    {
        void put(string text);
        string get();
        int getInt();
    }
}
