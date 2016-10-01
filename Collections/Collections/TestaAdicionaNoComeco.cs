using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class TestaAdicionaNoComeco
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            long tempo = TestaAdicionaNoComeco.AdicionaNoComeco(arrayList);
            Console.WriteLine("ArrayList: " + tempo + "ms");

        }

        public static long AdicionaNoComeco(IList lista)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                lista.Insert(0, 1);
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

    }
}
