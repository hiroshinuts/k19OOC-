using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ContaPoupanca : IConta
    {
        public double Saldo { get; set; }
      

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
