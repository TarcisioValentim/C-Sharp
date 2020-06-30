using System;

namespace Entrada_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, res;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite primeiro numero: ");
            n2 = double.Parse(Console.ReadLine());

            res = n1 + n2;

            Console.WriteLine(nome + " a soma é: " + res);

        }
    }
}