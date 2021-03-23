using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ICipher
    {
        string Decode(string text);
        string Incode(string text, string key);
    }
}
