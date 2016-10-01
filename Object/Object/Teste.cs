using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Teste
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Nome = "Rafael Hiroshi";
            f1.Salario = 3000;
            Console.WriteLine(f1);

            Funcionario f2 = new Funcionario();

            f2.Nome = "Rafael Hiroshi";
            f2.Salario = 3000;

            Console.WriteLine(f1 == f2);
            Console.WriteLine(f1.Equals(f2));
        }
    }
}
