using System;
using mentoria_POO.src.Entities;

namespace mentoria_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("arus", "Guerreiro");
            Mago Wedge = new Mago("wedge", "Mago Negro");
            Inimigo mummy = new Inimigo("mummy", "Múmia");

            arus.batalhar(mummy);
            System.Console.WriteLine(arus);
            System.Console.WriteLine();
            System.Console.WriteLine(mummy);
        }
    }
}
