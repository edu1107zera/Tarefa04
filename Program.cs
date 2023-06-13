using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace educ_
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string nomeresp;
                string nomeprod;
                string nomeprod2;

                int quantidade1;
                int quantidade2;

                Console.WriteLine("Bem-vindo ao sistema de estoque do Eduzito!");

                Console.Write("Digite o nome do funcionario responsavel:");
                nomeresp = Console.ReadLine();

                Console.WriteLine("\n");

                Console.WriteLine($"O cadastro de estoque foi feito no nome de:{nomeresp} ");

                Console.WriteLine("\n");
                Console.WriteLine("--- CADASTRO DE PRODUTOS");

                //produto1
                Console.Write("Digite o nome do produto 1 :");
                nomeprod = Console.ReadLine();
                Console.WriteLine($"Digite a quatidade em estoque de {nomeprod} :");
                quantidade1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                //produto2
                Console.Write("Digite  nome do produto 2 :");
                nomeprod2 = Console.ReadLine();
                Console.WriteLine($"Digite a quantidade em estoque de {nomeprod2}");
                quantidade2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("-- Os produtos foram cadastrados com sucesso!");
                Console.WriteLine("\n");
                Console.WriteLine($"-- lISTAS DE PRODUTOS CADASTRADOS POR {nomeresp}");
                Console.WriteLine($"-{nomeprod} contem {quantidade1} itens em estoque. ");
                Console.WriteLine($"-{nomeprod2} contem {quantidade2} itens em estoque");
                Console.WriteLine("\n");
                Console.WriteLine($"Total de itens no estoque: {quantidade2 + quantidade1}");

                Console.WriteLine("---FIM DO SISTEMA---");
                Console.ReadKey();
            }
        }
    }
}
    }
}
