using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            Console.WriteLine("-- Пример 01 -------");

            CountDelegate del01 = helper.GetCount;
            CountDelegate del02 = helper.GetCountSumbolA;

            // ошибочное объявление делегата из-за неподходящей сигнатуры
            // CountDelegate del03 = helper.GetCountSymbol;

            string testString = "CAPACITY";

            Console.WriteLine($"Общее количество символов = {del01(testString)}");
            Console.WriteLine($"Количество символов A = {del02(testString)}");
            Console.WriteLine("---------");
            Console.WriteLine($"Общее количество символов = {TestDelegate(del01, testString)}");
            Console.WriteLine($"Количество символов A = {TestDelegate(del02, testString)}");
            Console.WriteLine("---------");

            Console.WriteLine("-- Пример 02 -------");
            Student student = new Student();
            student.Move01(1);
            Console.WriteLine("---------");

            ShowMessage method = Show;
            student.Move02(2, method);

            // использование обобщенных делегатов
            Console.WriteLine("-- Пример 03 -------");
            Action<string> methodForExample03 = Show;
            student.Move03(3, methodForExample03);

            // использование поля класса в качестве хранения делегата - псевдособытие
            Console.WriteLine("-- Пример 04 -------");
            student.Moving = Show;
            student.Move04(4);

            // использование События
            Console.WriteLine("-- Пример 05 -------");
            student.MovingEvent += Student_MovingEvent;
            student.Move05(5);

            // Ping-Pong
            Console.WriteLine("-- Самостоятельная работа: Ping-Pong");
            Ping ping = new Ping();
            Pong pong = new Pong(ping);
            ping.Subscribe(pong);
            ping.Innings();

            // delay
            Console.ReadKey();
        }

        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }

        private static void Student_MovingEvent(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
