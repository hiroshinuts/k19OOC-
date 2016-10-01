using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class EscritaDeArquivo
    {
        static void Main(string[] args)
        {
            TextWriter arquivo = new StreamWriter("saida.txt");

            arquivo.WriteLine("Primeira Linha");
            arquivo.WriteLine("Segunda Linha!!");
            arquivo.WriteLine("Terceira Linha!!!");
            arquivo.Close();
        }
    }
}
