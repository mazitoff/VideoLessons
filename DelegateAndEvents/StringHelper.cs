using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public delegate int CountDelegate(string message);
    class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }
        public int GetCountSumbolA(string inputString)
        {
            return inputString.Count(x => x == 'A');
        }
        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(x => x == symbol);
        }
    }
}
