using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class TestaFuncionarios
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Rafael Hiroshi";
            g.Salario = 2000;
            g.Usuario = "rafael.hiroshi";
            g.Senha = "12345";

            Telefonista t = new Telefonista();
            t.Nome = "Alow";
            t.Salario = 1000;
            t.EstacaoDeTrabalho = 13;

            Secretaria s = new Secretaria();
            s.Nome = "Aui";
            s.Salario = 1500;
            s.Ramal = 198;

            Console.WriteLine("GERENTE");
            Console.WriteLine("Nome: " + g.Nome);
            Console.WriteLine("Salario:" + g.Salario);
            Console.WriteLine("Usuario: " + g.Usuario);
            Console.WriteLine("Senha" +  g.Senha);
            Console.WriteLine("Bonificacao: " + g.CalculaBonificacao());

            Console.WriteLine("TELEFONISTA");
            Console.WriteLine("Nome: " + t.Nome);
            Console.WriteLine("Salario:" + t.Salario);
            Console.WriteLine("Estacao de Trabalho: " + t.EstacaoDeTrabalho);
            Console.WriteLine("Bonificacao : " + t.CalculaBonificacao());

            Console.WriteLine("SECRETARIA");
            Console.WriteLine("Nome: " + s.Nome);
            Console.WriteLine("Salario: " + s.Salario);
            Console.WriteLine("Ramal: " + s.Ramal);
            Console.WriteLine("Bonificacao: " + s.CalculaBonificacao());

        }
    }
}
