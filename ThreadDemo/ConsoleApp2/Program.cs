using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int x = 0;
        static int y = 20;
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            Console.WriteLine("Сейчас будет запущен поток");
            t.Start();
            Thread.Sleep(200);
            //..
            //..
            //..
            //..
            Console.WriteLine("Ожидаем завершение работы потока");
            t.Join();
            Console.WriteLine((1100000 / x).ToString());

            Console.WriteLine("Завершение работы метода Main");
            Console.ReadKey();
        }

        private static void Method()
        {
            Console.WriteLine("Поток начинает работу");
            Thread.Sleep(2000);
            x  = (x + 20)*30;
            Console.WriteLine("Поток завершает работу");
        }
    }
}
