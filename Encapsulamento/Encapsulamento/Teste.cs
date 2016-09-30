using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Teste
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Nome = "Rafael Hiroshi";
            f.Salario = 2000;

            Console.WriteLine(f.Nome);
            Console.WriteLine(f.Salario);
        }

    }
}
