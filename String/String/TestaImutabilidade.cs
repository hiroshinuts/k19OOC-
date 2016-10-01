using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class TestaImutabilidade
    {
        static void Main(string[] args)
        {
            string nome = "Rafael Hiroshi";
            string nomeAlterado = nome.ToUpper();

            Console.WriteLine(nome);
            Console.WriteLine(nomeAlterado);
        }
    }
}
