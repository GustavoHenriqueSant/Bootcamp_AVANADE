using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using identificacao;
using Exemplo_Enum;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var eu = new Pessoa("Gustavo");

            Console.Write("Meu nome é " + eu.getName() + "\n");

            Gato ninha = new Gato("Ninha");
            Console.Write("Quando chega a " + (Estacoes)0 + " ou o " + Estacoes.verão + " Ninha fica super ativa. Sorria Estamos na " + Estacoes.primavera + "\n");
            ninha.brincar(eu.getName() + "\n");
            ninha.comer("Peixe\n");
            ninha.dormir("Na cama do " + eu.getName() + "\n");
            Console.Read();
        }
    }
}
