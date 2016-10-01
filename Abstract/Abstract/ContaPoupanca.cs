using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class ContaPoupanca : Conta
    {
        public int DiaDoAniversario { get; set; }

        public override void ImprimeExtratoDetalhado()
        {
            Console.WriteLine("EXTRATO DETALHADO DA CONTA POUPANÇA");
            DateTime agora = DateTime.Now;
            Console.WriteLine("DATA: " + agora.ToString("D"));
            Console.WriteLine("SALDO: " + this.Saldo);
            Console.WriteLine("ANIVERSARIO: " + this.DiaDoAniversario);
        }
    }
}
