using System;
using pilha_ED.Folder_pilha;

namespace pilha_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha x = new Pilha();
            x.empilha(10);
            x.empilha(20);
            x.empilha(30);

            Console.WriteLine("O valor " + x.desempilha() + " foi desempilhado");
        }
    }
}
