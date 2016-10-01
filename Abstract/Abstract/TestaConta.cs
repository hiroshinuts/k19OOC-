using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c = new ContaPoupanca();
            c.Saldo = 1000;

            c.ImprimeExtratoDetalhado();
        }
    }
}
