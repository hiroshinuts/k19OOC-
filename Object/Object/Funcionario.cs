using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public override string ToString()
        {
            return "Funcionario: " + this.Nome + " - Salario: " + this.Salario;
        }

        public override bool Equals(object obj)
        {
            Funcionario outro = (Funcionario)obj;
            return this.Nome == outro.Nome;
        }
    }
}
