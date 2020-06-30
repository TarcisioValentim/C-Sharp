using System;

namespace Operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {
             //Operadores lógicos &&(E), ||(OU), !(Negação)
             //Exemplo - número dentro do intervalo

            int num;

            Console.WriteLine("Digite um valor entre 20 e 50: ");
            num = Convert.ToInt32( Console.ReadLine());

            if(num >= 20 && num <=50){
                Console.WriteLine("O número digitado está dentro do intervalo.");
            }else{
                Console.WriteLine("O número digitado está fora do intervalo.");
            }

        }
    }
}
