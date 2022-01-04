using System;
using System.Collections.Generic;
using System.Linq;
using Collections_pratica.Helper;

namespace Collections_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arrayNumeros = new int[7]{1,2,3,12,5,2,3};

            // System.Console.WriteLine(arrayNumeros[10]);

            // var numerosParesQuery = 
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var  numerosParesMethod = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine(string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine(string.Join(", ", numerosParesMethod));

            // System.Console.WriteLine("Algumas outras operação que se tem:");
            // var minimo = arrayNumeros.Min();
            // var maximo = arrayNumeros.Max();
            // var medio = arrayNumeros.Average();

            // System.Console.WriteLine($"Minimo {minimo}, maximo {maximo}, medio {medio}");
            // System.Console.WriteLine($"A soma dos valores do array é {arrayNumeros.Sum()}");
            // System.Console.WriteLine($"Removendo os numero repetidos do array {string.Join(", ", arrayNumeros.Distinct().ToArray())}");
            //=================================================================================================================
            
            Dictionary<string, string> estados = new Dictionary<string, string>();
            estados.Add("Mg", "Minas Gerais");
            estados.Add("SP", "São Paulos");
            estados.Add("RJ", "Rio de Janeiro");
            estados.Add("SP", "São paulino");

            foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Key: {item.Key}; Value: {item.Value}");
            }

            string chave_do_valor_procurado = "RJ";
            System.Console.WriteLine(estados[chave_do_valor_procurado]);

            string chave_que_queremos_atualizar = "SP";
            estados[chave_que_queremos_atualizar] = "São Paulo";
            System.Console.WriteLine(estados[chave_que_queremos_atualizar]);
           
            System.Console.WriteLine("==========================================");
            string chave_do_valor_a_ser_removido = "Mg";
            System.Console.WriteLine($"Removendo o valor presente na chave {chave_do_valor_a_ser_removido}");
            estados.Remove(chave_do_valor_a_ser_removido);
            System.Console.WriteLine("Após a remoção");
            foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Key: {item.Key}; Value: {item.Value}");
            }

            System.Console.WriteLine("=====================================================");
            System.Console.WriteLine("Podemos faxer operações de escrita e leitura nos dicionários de maneira segura utilizando o método 'TryGetValue()' como abaixo:");
            string value_procurado = "SdsP";

            if(estados.TryGetValue(value_procurado, out string value_encontrado)){
                System.Console.WriteLine($"O valor {value_encontrado} foi achado");
            } else {
                System.Console.WriteLine("Tal chave não existe dentro do dicionário.");
            }
            //===================================================================================================================

            // Stack<string> pilaLivros = new Stack<string>();

            // pilaLivros.Push("Código limpo");
            // pilaLivros.Push("Codificador Limpo");
            // pilaLivros.Push("Arquitetura limpa");

            // System.Console.WriteLine($"Quantidade de livros para leitura {pilaLivros.Count}");
            // while (pilaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"The next book for reading {pilaLivros.Peek()}");
            //     System.Console.WriteLine($"Livro intutulado {pilaLivros.Pop()} foi lido");
            // }

            // System.Console.WriteLine($"Quantidade de livros para leitura {pilaLivros.Count}");
            //=============================================================================================

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Gustavo");
            // fila.Enqueue("Leonardo Buta");
            // fila.Enqueue("Iglá generoso");
            
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo da fila: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} foi atendido");
            // }

            // System.Console.WriteLine($"A fila possui {fila.Count} pessoas");
            //========================================================================================

            // List<string> estados = new List<string>();
            // string[] item_to_add_array = new string[2] {"SC", "PA"};

            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("RJ");

            // System.Console.WriteLine("Lista ants de remover o valor MG q está no índice 2:");
            // OperacoesList.pinrtarList(estados);

            // System.Console.WriteLine("Lista após a remoção");
            // estados.Remove("MG");
            // OperacoesList.pinrtarList(estados);

            // System.Console.WriteLine("Lista após a inserção do array:");
            // estados.AddRange(item_to_add_array);
            // OperacoesList.pinrtarList(estados);

            // System.Console.WriteLine("Adicionando o item 'BA' em um posição específica da lista, no caso no índice 1");
            // estados.Insert(1, "BA");
            // OperacoesList.pinrtarList(estados);
            // ================================================================================================================

            // int[] arraytest = new int[5] {14, 85, 77, 1, 2};
            // string[] arrayString = OperacoesArray.converterParaString(arraytest);
            // int[] arraytestII = new int[10];
            // int novoTmanho = 10;

            // OperacoesArray.redimensinarArray(ref arraytest, novoTmanho);
            // System.Console.WriteLine(arraytest.Length);
            //===============================================================================


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
