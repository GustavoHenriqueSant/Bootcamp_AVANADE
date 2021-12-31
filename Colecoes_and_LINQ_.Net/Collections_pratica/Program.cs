using System;
using Collections_pratica.Helper;

namespace Collections_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraytest = new int[5] {14, 85, 77, 1, 2};
            string[] arrayString = OperacoesArray.converterParaString(arraytest);
            int[] arraytestII = new int[10];
            int novoTmanho = 10;

            OperacoesArray.redimensinarArray(ref arraytest, novoTmanho);
            System.Console.WriteLine(arraytest.Length);


            // int[] arraytest = new int[10] {14, 85, 77, 1, 2, 66, 43, 96, 4, 2};
            // int[] arraytestII = new int[10];
            // int valorTeste = 77;

            // int indice = OperacoesArray.obterIndiceDeElemento(arraytest, valorTeste);
            
            // if(indice != -1)
            //     System.Console.WriteLine("Elemento {0} encontrado, seu índice é igual a {1}", valorTeste, indice);
            // else
            //     System.Console.WriteLine("Elemento {0} não encontrado", valorTeste);
            //===============================================================================

            // int[] arraytest = new int[10] {14, 85, 77, 1, 2, 66, 43, 96, 4, 2};
            // int[] arraytestII = new int[10];
            // int valorTeste = 11;

            // int valorAchado = OperacoesArray.obterElemento(arraytest, valorTeste);

            // if(valorAchado == valorTeste)
            //     System.Console.WriteLine("Achei o valor");
            // else
            //     System.Console.WriteLine("Nao achei o valor");
            //================================================================================

            // int[] arraytest = new int[10] {14, 85, 77, 1, 2, 66, 43, 96, 4, 2};
            // int[] arraytestII = new int[10];
            // int valorTeste = 1;
            // if(OperacoesArray.todosMaiorQue(arraytest, valorTeste))
            //     System.Console.WriteLine($"Todos os valores são maiores que {valorTeste}");
            // else
            //     System.Console.WriteLine($"Há valores que são menores que {valorTeste}");
            //=====================================================================
            
            // int[] arraytest = new int[10] {14, 85, 77, 1, 2, 66, 43, 96, 4, 2};
            // int[] arraytestII = new int[10];

            // if(OperacoesArray.existeValor(arraytest, 43))
            //     System.Console.WriteLine("O valor encontra-se no array");
            // else
            //     System.Console.WriteLine("O valor não encontra-se no array");
            //====================================================================

            // int[] arraytest = new int[10] {14, 85, 77, 1, 2, 66, 43, 96, 4, 2};
            // int[] arraytestII = new int[10];

            // OperacoesArray.copiarArray(arraytest, ref arraytestII);
            // OperacoesArray.printarArray(arraytestII);
            //====================================================================

            // int[] arraytest = new int[10] {14, 85, 77, 1, 2, 66, 43, 96, 4, 2};

            // OperacoesArray.printarArray(arraytest);

            // //OperacoesArray.bubleSort(ref arraytest);
            // OperacoesArray.sortArray(ref arraytest);

            // OperacoesArray.printarArray(arraytest);

            // int[,] matriz = new int[4, 2] {
            //                                   {8, 8},
            //                                   {9, 9},
            //                                   {10, 10},
            //                                   {11, 11}
            //                               };
            
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.Write(matriz[i,j] + " ");
            //     }
            //     System.Console.WriteLine();
            // }
            // int[] vetor = new int[10];

            // for (int i = 0; i < vetor.Length; i++)
            // {
            //     vetor[i] = i;
            // }

            // foreach (var item in vetor)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
