using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class LeituraDoTeclado
    {
        static void Main(string[] args)
        {
            TextReader teclado = Console.In;
            string linha = teclado.ReadLine();
            while(linha != null)
            {
                Console.WriteLine(linha);
                linha = teclado.ReadLine();
            }
        }
    }
}
