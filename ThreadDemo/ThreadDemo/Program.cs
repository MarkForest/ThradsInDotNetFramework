using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Если не надо передавать параметры
            //делегат без параметров
            ThreadStart threadStart = new ThreadStart(Method);
            //сам поток 
            Thread thread = new Thread(threadStart);
            //запуск потока
            thread.Start();

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Hello in Main");
            }

            Console.ReadLine();
        }

        private static void Method()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("\t\tHello in Thread");
            }
        }
    }
}
