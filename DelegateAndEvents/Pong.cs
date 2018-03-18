using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class Pong
    {
        public event EventHandler<PongEventArgs> PongEvent;

        private Ping _ping;
        private int _countInnings;

        public Pong(Ping ping)
        {
            _countInnings = 0;
            _ping = ping;
            ping.PingEvent += Ping_PingEvent;
        }

        private void Ping_PingEvent(object sender, PingEventArgs e)
        {
            Console.WriteLine($"Pong - {_countInnings}");
            Innings();
        }

        public void Innings()
        {
            _countInnings++;
            Console.WriteLine("Pong производит подачу");
            PongEvent(this, new PongEventArgs(_countInnings));
        }
    }
}
