using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        //TODO: listar alunos
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        //TODO: Calcular media geral    
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                        EnumConceito conceitoGeral;
                        if (mediaGeral < 2)
                        {
                            conceitoGeral = EnumConceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = EnumConceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = EnumConceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = EnumConceito.B;
                        }
                        else 
                        {
                            conceitoGeral = EnumConceito.A;
                        }
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Informe a opcao desejada: ");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
