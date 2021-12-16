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

            Console.Write("Meu nome é " + eu.getName());
            Console.Read();
        }
    }
}
