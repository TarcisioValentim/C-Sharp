using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resSoma, resSub, resMult, resDiv;
            string tmp;

            Console.WriteLine("Digite o primeiro valor: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite o segundo valor: ");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            resSoma = num1 + num2;
            resSub = num1 - num2;
            resMult = num1 * num2;
            resDiv = num1 / num2;

            Console.WriteLine("Soma: " + resSoma);
            Console.WriteLine("Subtração: " + resSub);
            Console.WriteLine("Multiplicação: " + resMult);
            Console.WriteLine("Divisão: " + resDiv);

        }
    }
}
