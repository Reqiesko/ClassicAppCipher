using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ROT13 : ICipher
    {
        public string Decode(string message)
        {
            message = Incode(message);
            return message;
        }
        public string Incode(string message)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int halfLen = alphabet.Length / 2;
            int len = alphabet.Length;
            string incodeStr = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (alphabet.Contains(message[i]))
                {
                    int index = alphabet.IndexOf(message[i]);
                    incodeStr += alphabet[(index + halfLen) % len];
                }
                else
                {
                    incodeStr += message[i];
                }
            }
            return incodeStr;
        }
        public string Decode(string message, string key)
        {
            throw new NotImplementedException();
        }

        public string Incode(string message, string key)
        {
            throw new NotImplementedException();
        }
    }
}
