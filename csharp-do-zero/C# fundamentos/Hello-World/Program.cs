using System;//Os pacotes que vou utilizar

namespace Aprendendo_C_Sharp//Agrupador de instruções
{
    class Program//Modelo de um objeto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensagem!");
            classe2 msg = new classe2();//Instanciando nova mensagem
            msg.Msg();//Imprimindo mensagem
        }
    }

    class classe2{

        public void Msg(){
            Console.WriteLine("Olá..");
        }

    }
}
