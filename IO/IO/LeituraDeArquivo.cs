using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class LeituraDeArquivo
    {
        static void Main(string[] args)
        {
            TextReader arquivo = new StreamReader("entrada.txt");
            string linha = arquivo.ReadLine();
            while(linha != null)
            {
                Console.WriteLine(linha);
                linha = arquivo.ReadLine();

            }
            arquivo.Close();
        }
        
    }
}
