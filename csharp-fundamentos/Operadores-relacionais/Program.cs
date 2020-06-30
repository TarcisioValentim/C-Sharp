using System;

namespace Operadores_relacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string str;

            Console.WriteLine("...::Operadores relacionais::...");

            //Lendo o primeiro valor digitado
            Console.WriteLine("Digite um valor para X: ");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);

            //Lendo o segundo valor digitado
            Console.WriteLine("Digite um valor para Y: ");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);

            bool r;

            //Operador relacional igual
            Console.WriteLine("São iguais?");
            r = (x == y);
            Console.WriteLine("x == y: " + r);

            //Operador relacional diferente
            Console.WriteLine("São diferentes?");
            r = (x != y);
            Console.WriteLine("x != y: " + r);

            //Operador relacional maior
            Console.WriteLine("X é maior que Y?");
            r = (x > y);
            Console.WriteLine("x > y: " + r);

            //Operador relacional menor
            Console.WriteLine("Y é maior que X?");
            r = (x < y);
            Console.WriteLine("x < y: " + r);

            //Operador relacional maior igual
            Console.WriteLine("X é maior ou igual Y?");
            r = (x >= y);
            Console.WriteLine("x >= y: " + r);

            //Operador relacional menor igual
            Console.WriteLine("Y é maior ou igual X?");
            r = (x <= y);
            Console.WriteLine("x <= y: " + r);
            

        }
    }
}
