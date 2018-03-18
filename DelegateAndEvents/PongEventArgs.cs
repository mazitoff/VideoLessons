using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class PongEventArgs : EventArgs
    {
        public int NumberInnings { get; private set; }
        public PongEventArgs(int numberInnings)
        {
            NumberInnings = numberInnings;
        }
    }
}
