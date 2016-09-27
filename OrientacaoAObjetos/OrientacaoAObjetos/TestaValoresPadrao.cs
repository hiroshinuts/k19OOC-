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
            Conta c = new OrientacaoAObjetos.Conta();
            Console.WriteLine(c.numero);
            Console.WriteLine(c.limite);
            Console.WriteLine(c.saldo);
        }

    }
}
