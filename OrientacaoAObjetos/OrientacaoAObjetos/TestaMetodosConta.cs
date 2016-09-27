using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaMetodosConta
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(1234);

            Conta c = new Conta(a);
            Console.WriteLine("Chamando o metodo deposita passando o valor 1000");
            c.Deposita(1000);
            c.ImprimeExtrato();

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Chamando o metodo saca passando o valor 100");
            c.Saca(100);
            c.ImprimeExtrato();

            Console.WriteLine("-------------------------------------------------");

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine("SALDO DISPINIVEL: " + saldoDisponivel);
        }

    }
}
