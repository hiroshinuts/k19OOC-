﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class GeradorDeExtrato
    {
        public void GeraExtrato(IConta c)
        {
            Console.WriteLine("EXTRATO");
            Console.WriteLine("SALDO: " + c.Saldo);
        }
    }
}
