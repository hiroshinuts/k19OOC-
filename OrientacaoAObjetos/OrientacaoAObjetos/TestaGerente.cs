using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaGerente
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.salario = 1000;

            Console.WriteLine("Salario: " + g.salario);
            Console.WriteLine("Aumentando salario em 10%");
            g.AumentaSalario();
            Console.WriteLine("Salario: " + g.salario);

            Console.WriteLine("Aumentando salario em 30%");
            g.AumentaSalario(0.3);

            Console.WriteLine("Salario: " + g.salario);
        }
    }
}
