using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            Console.WriteLine("Digite o nome do Cliente");
            cliente1.Nome = Console.ReadLine();
            c1.Titular = cliente1;
            Console.WriteLine("Digite o saldo inicial do Cliente");
            c1.Saldo = double.Parse(Console.ReadLine());

            //Criar cliente e conta 2
            ContaCorrente c2 = new ContaCorrente();
            Cliente cliente2 = new Cliente();
            Console.WriteLine("Digite o nome do Cliente");
            cliente2.Nome = Console.ReadLine();
            c2.Titular = cliente2;
            Console.WriteLine("Digite o saldo inicial do Cliente");
            c2.Saldo = double.Parse(Console.ReadLine());

            //Testar PIX
            Console.WriteLine("Digite o valor que sera Transferido do Cliente " + c1.Titular.Nome 
                + "para o Cliente 2 " + c2.Titular.Nome);
            double valor = double.Parse(Console.ReadLine());

            if (c1.Pix(valor, c2))
            {
                Console.WriteLine("Pix Realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("ERRO pix nao foi possivel Realizar!");
            }


            Console.ReadLine();
        }
    }
}
