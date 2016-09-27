using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaCliente
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.nome = "Rafael Hiroshi";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Barbara Watanabe";
            c2.codigo = 2;

            Console.WriteLine("Dados do primeiro Cliente");
            Console.WriteLine("Nome: " + c1.nome);
            Console.WriteLine("Codigo: " + c1.codigo);

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Dados do segundo cliente");
            Console.WriteLine("Nome: " + c2.nome);
            Console.WriteLine("Codigo: " + c2.codigo);
        }
    }
}
