﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;
        public Cliente cliente;

        public CartaoDeCredito(int numero)
        {
            this.numero = numero;
        }

    }
}
