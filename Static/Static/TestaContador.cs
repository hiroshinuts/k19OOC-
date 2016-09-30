using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class TestaContador
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador: " + Conta.contador);

            Conta c1 = new Conta();

            Console.WriteLine("Numero da Primeira conta: " + c1.numero);
            Console.WriteLine("Contador: " + Conta.contador);

            Conta c2 = new Conta();

            Console.WriteLine("Numero da Segunda conta: " + c2.numero);
            Console.WriteLine("Contador: " + Conta.contador);

            Conta.ZeraContador();
        }
    }
}
