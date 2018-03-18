using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public delegate void ShowMessage(string message);

    public class Student
    {
        public void Move01(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Идет перемещение... Пройдено {i} километров.");
            }
        }

        public void Move02(int distance, ShowMessage method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(500);
                // заменяем на вызов метода
                //Console.WriteLine($"Идет перемещение... Пройдено {i} километров.");
                method(string.Format("Идет перемещение... Пройдено {0} километров.", i));
            }
        }

        public void Move03(int distance, Action<string> method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(500);
                method(string.Format("Идет перемещение... Пройдено {0} километров.", i));
            }
        }

        // переход к понятию События
        // используем поле-делегат
        public Action<string> Moving;

        public void Move04(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(500);
                if(Moving != null) // если подписались на событие )))
                {
                    Moving(string.Format("Идет перемещение... Пройдено {0} километров.", i));
                }
                
            }
        }

        // из предыдущего примера, заменив поле на событие, получаем код использования Событий
        public event EventHandler<MovingEventArgs> MovingEvent;

        public void Move05(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(500);
                MovingEvent(this, new MovingEventArgs(string.Format("Идет перемещение... Пройдено {0} километров.", i)));
            }
        }
    }
}
