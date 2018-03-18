using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class PingEventArgs : EventArgs
    {
        public int NumberInnings { get; private set; }
        public PingEventArgs(int numberInnings)
        {
            NumberInnings = numberInnings;
        }
    }
}
