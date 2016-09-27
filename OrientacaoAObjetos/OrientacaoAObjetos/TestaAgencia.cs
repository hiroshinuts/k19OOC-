using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaAgencia
    {
        static void Main(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 1234;

            Agencia a2 = new Agencia();
            a2.numero = 5678;

            Console.WriteLine("Dados da primeira agencia");
            Console.WriteLine("Numero: " + a1.numero);

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Dados da segunda agencia");
            Console.WriteLine("Numero: " + a2.numero);
        }

    }
}
