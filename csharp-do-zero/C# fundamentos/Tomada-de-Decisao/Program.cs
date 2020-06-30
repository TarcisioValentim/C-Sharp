using System;

namespace Tomada_de_Decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            String texto = "O valor digitado é: ";

            Console.WriteLine("Digite um valor: ");
            num = Convert.ToInt32(Console.ReadLine());

            /*
            if(num>0)
                Console.WriteLine(texto + "positivo.");
            if(num<0)
                Console.WriteLine(texto + "negativo.");
            */

            if(num > 0){
                Console.WriteLine(texto + "positivo.");
            }else{
                Console.WriteLine(texto + "negativo.");
            }
            
        }
    }
}
