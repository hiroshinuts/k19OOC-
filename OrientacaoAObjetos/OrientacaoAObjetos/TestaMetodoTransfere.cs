using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaMetodoTransfere
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(1234);

            Conta origem = new Conta(a);
            origem.saldo = 1000;
            Console.WriteLine("Saldo da primeira conta: " + origem.saldo);

            Conta destino = new Conta(a);
            destino.saldo = 1000;
            Console.WriteLine("Saldo da segunda conta: " + destino.saldo);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Realizando a transferencia");
            origem.Transfere(destino, 500);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Saldo da primeira conta: " + origem.saldo);
            Console.WriteLine("Saldo da segunda conta: " + destino.saldo);
        }
    }
}
