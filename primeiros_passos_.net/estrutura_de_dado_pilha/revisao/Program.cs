using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila_alunos = new Fila();
            string opcaoUser = obterOpcaoUser();

            while(opcaoUser != "4"){
                switch(opcaoUser){
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.setNome(Console.ReadLine());
                        Console.WriteLine("Informe a nota do aluno:");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.setNota(nota);
                        } else {
                            throw new ArgumentException("A nota deve ser um decimal");
                        }
                    
                        fila_alunos.insercao(aluno);

                        break;
                    case "2":
                        Fila.printFila(fila_alunos.getFinal(), 1);
                        
                        break;
                    case "3":
                        Fila.Node aux = fila_alunos.getFinal();
                        decimal notatotal = 0;
                        int contador = 0;
                        double mediaGeral = 0.0;
                        while(aux != null){
                            notatotal += aux.getAluno().getNota();
                            contador++;
                            aux = aux.getProx();
                        }

                        Conceito conceito;
                        mediaGeral = (double)(notatotal / contador);
                        if(mediaGeral < 2)
                            conceito = Conceito.E;
                        else if(mediaGeral < 4)
                            conceito = Conceito.D;
                        else if(mediaGeral < 6)
                            conceito = Conceito.C;
                        else if(mediaGeral < 8)
                            conceito = Conceito.B;
                        else
                            conceito = Conceito.A;

                        Console.WriteLine("Média final igual a : " + mediaGeral + ". Atribuindo a classe, conceito geral equivalente a " + conceito);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUser = obterOpcaoUser();
            }

        }

        static string obterOpcaoUser(){
            Console.WriteLine("===============================");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno.");
            Console.WriteLine("2 - Listar alunos cadastrados.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("4 - Sair.");
            Console.WriteLine("===============================");

            string opcaoUser = Console.ReadLine();
            return opcaoUser;
        }
    }
}
