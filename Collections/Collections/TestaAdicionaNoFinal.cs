using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class TestaAdicionaNoFinal
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            long tempo = TestaAdicionaNoFinal.AdicionaNoFinal(arrayList);
            Console.WriteLine("ArrayList: " + tempo + "ms");
        }
        public static long AdicionaNoFinal(IList lista)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int size = 100000;

            for(int i = 0; i < size; i++)
            {
                lista.Add(i);
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
