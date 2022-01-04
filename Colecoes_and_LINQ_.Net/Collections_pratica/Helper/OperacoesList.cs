using System.Collections.Generic;

namespace Collections_pratica.Helper
{
    public class OperacoesList
    {
        public static void pinrtarList(List<string> lista){
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"No índice {i} enconstra-se o valor {lista[i]}");
            }
        }
    }
}