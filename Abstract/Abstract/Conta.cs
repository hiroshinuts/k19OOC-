using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Conta
    {
        public double Saldo { get; set; }

        public abstract void ImprimeExtratoDetalhado();
    }
}
