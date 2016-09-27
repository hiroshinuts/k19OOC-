using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaClienteECartao
    {

        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito();

            c.nome = "Rafael Hiroshi";
            c.codigo = 123;
            cdc.numero = 111111;
            cdc.dataDeValidade = "01/01/1010";

            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome: " + c.nome);
            Console.WriteLine("Codigo: " + c.codigo);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Dados do Cartao");
            Console.WriteLine("Numero: " + cdc.numero);
            Console.WriteLine("Data de validade: " + cdc.dataDeValidade);
            Console.WriteLine("----------------------------------");
            cdc.cliente = c;

            Console.WriteLine("Dados do cliente obtidos atraves do cartao" );
            Console.WriteLine(cdc.cliente.nome);
            Console.WriteLine(cdc.cliente.codigo);
        }
        
    }
}
