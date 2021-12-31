using System;

namespace Collections_pratica.Helper
{
    public class OperacoesArray
    {
        public static void bubleSort(ref int[] array){
            int aux = 0;

            for(int i = 0; i < array.Length; i++)
                for(int j = 0; j < array.Length - 1; j++){
                    if(array[j] > array[j+1]){
                        aux = array[j];
                        array[j] = array[j+1];
                        array[j+1] = aux;
                    }
                }
        }

        public static void printarArray(int[] array){
            System.Console.WriteLine(string.Join(", ", array));
        }

        public static void sortArray(ref int[] array){
            Array.Sort(array);
        }

        public static void copiarArray(int[] arrayOriginal, ref int[] arrayRecebedor){
            Array.Copy(arrayOriginal, arrayRecebedor, arrayOriginal.Length);
        }

        public static bool existeValor(int[] array, int valor){
            return Array.Exists(array, value => value == valor);
        }

        public static bool todosMaiorQue(int[] array, int valor){
            return Array.TrueForAll(array, value => value > valor);
        }

        // O método Find() retorna 0 se o elemento n for encontrado.
        public static int obterElemento(int[] array, int elemento){
            return Array.Find(array, element => element == elemento);
        }

        public static int obterIndiceDeElemento(int[] array, int elemento){
            return Array.IndexOf(array, elemento);
        }

        public static void redimensinarArray(ref int[] array, int novoTamanho){
            Array.Resize(ref array, novoTamanho);
        }

        public static string[] converterParaString(int[] array){
            return Array.ConvertAll(array, converter => converter.ToString());
        }
    }
}