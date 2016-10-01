using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class App
    {
        public static void ImprimeHiro()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hirow");
                if(i % 10 == 0)
                {
                    Thread.Sleep(100);
                }
            };
        }

        public static void ImprimeBabara()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("BABARAAAAAAA");
                if (i % 10 == 0)
                {
                    Thread.Sleep(100);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(ImprimeHiro);
            Thread thread2 = new Thread(ImprimeBabara);

            thread1.Start();
            thread2.Start();
        }

    }
}
