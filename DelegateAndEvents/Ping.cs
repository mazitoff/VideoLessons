using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class Ping
    {
        public event EventHandler<PingEventArgs> PingEvent;

        private Pong _pong;
        private int _countInnings;

        public Ping()
        {
            _countInnings = 0;
        }

        public void Subscribe(Pong pong)
        {
            _pong = pong;
            _pong.PongEvent += _pong_PongEvent;
        }

        private void _pong_PongEvent(object sender, PongEventArgs e)
        {
            Console.WriteLine($"Ping - {_countInnings}");
            Innings();
        }

        public void Innings()
        {
            if(_countInnings++ < 12)
            {
                Console.WriteLine("Ping производит подачу");
                PingEvent(this, new PingEventArgs(_countInnings));
            }
        }
    }
}
