using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaContaEAgencia
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia();
            Conta c = new Conta();

            a.numero = 178;
            c.numero = 123;
            c.limite = 500;

            Console.WriteLine("Dados da agencia");
            Console.WriteLine("Numero: " + a.numero);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Dados da conta");
            Console.WriteLine("Numero: " + c.numero);
            Console.WriteLine("Saldo: " + c.saldo);
            Console.WriteLine("Limite: " + c.limite);
            Console.WriteLine("------------------------------------------");
            c.agencia = a;
            Console.WriteLine("Dados da agencia obtidos atraves da conta");
            Console.WriteLine(c.agencia.numero);

        }

    }
}
