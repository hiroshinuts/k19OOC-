using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ContaCorrente : IConta
    {
        public double Saldo { get; set; }
        private double taxaPorOperacao = 0.45;
       

        public void Deposita(double valor)
        {
            this.Saldo += valor - this.taxaPorOperacao;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor + this.taxaPorOperacao;
        }
    }
}
