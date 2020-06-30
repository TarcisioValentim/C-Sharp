using System;
using EstruturaDoProgramam;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desmpilha());
            Console.WriteLine(s.Desmpilha());
            Console.WriteLine(s.Desmpilha());
            }
        }
    }
}
