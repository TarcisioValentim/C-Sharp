using System;

namespace Exemplo_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4 = 0;

            string frase = "Digite a {0}º nota: ";

            Console.WriteLine(frase, 1);
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 2);
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 3);
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(frase, 4);
            num4 = Convert.ToDouble(Console.ReadLine());

            double  total, media = 0;

            total = num1+num2+num3+num4;

            media = total / 4;

            Console.WriteLine("A média é: " + media);

            //Se nota for <4 esta reprovado
            //Se nota for <7 esta de exame
            //Se nao, esta aprovado

            if(media < 4){
                Console.WriteLine("Está reprovado!");
            }else{
                if(media <7){
                    Console.WriteLine("Está de exame.");
                }else{
                    Console.WriteLine("Está aprovado.");
                }
            }

        }
    }
}
