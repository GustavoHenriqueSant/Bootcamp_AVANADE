using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes(){
            int a;
            int b = 2, c = 4;
            const int d = 45;
            a = 1;

            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(string[] args){
            if(args.Length == 0){
                Console.WriteLine("Não há nenhum argumento meu chapa");
            } else if(args.Length == 1){
                Console.WriteLine("Há apenas um argumento meu caro");
            } else {
                Console.WriteLine($"HÁ INRÍVEIS {agrs.Length} MEU NOBRE");
            }
        }

        static void InstrucaoSwitch(string[] args){
            int numeroArgs = args.Length;

            switch(numeroArgs){
                case 0:
                    Console.WriteLine("Não há nenhum argumento meu chapa");
                    break;
                case 1:
                    Console.WriteLine("Há apenas um argumento meu caro");
                    break;
                default:
                    Console.WriteLine($"HÁ INRÍVEIS {agrs.Length} MEU NOBRE");
            }
        }

        static void InstrucaoWhile(string[] args){
            int contador = 0;
            while(contador < args.Length){
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo(string[] args){
            string text;

            //Usa-se Do sempre que se deseja que a primeira iteração do while ocorra
            do{
                text = Console.ReadLine();
                Console.WriteLine(text + "\n");
            }while(!string.IsNullOrEmpty(text));
        }

        static void InstrucaoFor(string[] args){
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args){
            foreach(string i in args){
                Console.WriteLine(i);
            }
        }

        static void InstrucaBreak(string[] args){
            while(true){
                string text = Console.ReadLine();

                if(string.IsNullOrEmpty(text)){
                    break;
                }

                Console.WriteLine(text);
            }
        }

        // O continue "força o próximo laço de repetição sem executar as instruções q estão abaixo dele."
        static void InstrucaoContinue(string[] args){
            foreach(string s in args){
                if(s.StartsWith("/"))
                    continue;

                Console.WriteLine(s);
            }
        }

        //Um funcionalidade mostrada na aula para o return, é de parar a execução de métodos em determinado ponto.
        static void IntrucaoReturn(string[] args){
            int multiplicar(int a, int b){
                return a * b;
            }

            Console.WriteLine(multiplicar(4, 5));
            Console.WriteLine(multiplicar(4, 10));
            Console.WriteLine(multiplicar(4, 15));

            return;
        }

        static void InstrucaoTryCatchFinallyThrow(string[] args){
            double dividir(double a, double b){
                if(b != 0){
                    return a/b;
                }

                throw new DivideByZeroException();
            }
            
            //se o bloco de operações der errado, cais nas cáusulas catch segundo o tratamento de exceção
            try {
                if(args.Length != 2){
                    throw new InvalidOperationException("Informe dois números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine();
            }
            catch(InvalidOperationException e){
                Console.WriteLine(e.Message);
            }
            catch(Exception e){
                Console.WriteLine($"Erro genérico {e.Message}");
            }
            //O try dadno certo ou n o finally corre
            finally{
                Console.WriteLine("Flw amigos!");
            }

        }

        static void InstrucaoUsing(){
            using(System.IO.TextWriter w = System.IO.File.CreateText("text.txt")){
                w.WriteLine("linha 1");
                w.WriteLine("linha 2");
                w.WriteLine("linha 3");
                w.WriteLine("linha 4");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
