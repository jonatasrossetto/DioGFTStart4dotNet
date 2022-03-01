using System;
using static System.Console;

namespace Revisao
{
    class Program
    {
        static void Main (string[] args)
        {
            Aluno[] alunos = new Aluno[5]; //necessário inicializar com o tamanho da matriz
            int indiceAluno = 0;
            
            string opcaoUsuario = retornaOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                
                switch (opcaoUsuario)
                {
                    case "1":
                        {
                            //adicionar aluno
                            Clear();
                            WriteLine("opção 1 - cadastrar aluno");
                            WriteLine($"cadastro do aluno [{indiceAluno}]");
                            var aluno = new Aluno();
                            WriteLine("Informe o nome do aluno:");
                            aluno.Nome = ReadLine();
                            WriteLine("Informe a nota do aluno:");
                            if (decimal.TryParse(ReadLine(),out decimal nota))
                            {
                                aluno.Nota=nota;
                            } else
                            {
                                throw new ArgumentException("O valor da nota deve ser decimal!!!");
                            }
                            alunos[indiceAluno] = aluno;
                            indiceAluno++;
                            
                            break;
                        }
                    case "2":
                        {
                            // Listar alunos
                            Clear();
                            WriteLine("opção 2 - Listar os alunos");
                            for (int i=0;i<5;i++)
                            {
                                if (alunos[i].Nome != null)
                                {
                                WriteLine($"Aluno[{i+1}]: {alunos[i].Nome} Nota: {alunos[i].Nota}");
                                }
                            }
                            ReadKey();
                            break;
                        }
                    case "3":
                        {
                            // calcular média geral
                            Clear();
                            WriteLine("opção 3 - calcula a média geral");
                            decimal sum = 0;
                            int quantidade = 0;
                            for (int i=0;i<5;i++)
                            {
                                if (!string.IsNullOrEmpty(alunos[i].Nome))
                                {
                                    sum=sum+alunos[i].Nota;
                                    quantidade++;
                                }
                                
                            }
                            WriteLine($"A média geral da turma com {quantidade} alunos é {sum/quantidade} ");
                            ReadKey();
                            break;
                        }
                }
                
                opcaoUsuario = retornaOpcaoUsuario();
            }
        }

        private static string retornaOpcaoUsuario()
        {
            
            Clear();
            WriteLine("Informe a opção desejada:");
            WriteLine("1 - Inserir novo aluno");
            WriteLine("2 - Listar alunos");
            WriteLine("3 - Calcular média geral");
            WriteLine("X - Sair");
            WriteLine();
            string opcaoUsuario = ReadLine();
            return opcaoUsuario;
        }
    }
}
