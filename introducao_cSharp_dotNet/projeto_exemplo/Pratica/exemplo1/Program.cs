using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using identificacao;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var eu = new Pessoa("Gustavo");

            Console.Write("Meu nome é " + eu.getName() + "\n");

            Gato ninha = new Gato("Ninha");
            ninha.brincar(eu.getName() + "\n");
            ninha.comer("Peixe\n");
            ninha.dormir("Na cama do " + eu.getName() + "\n");
            Console.Read();
        }
    }
}
