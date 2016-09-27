using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaValoresPadrao
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(1234);

            Conta c = new OrientacaoAObjetos.Conta(a);
            Console.WriteLine(c.numero);
            Console.WriteLine(c.limite);
            Console.WriteLine(c.saldo);
        }

    }
}
