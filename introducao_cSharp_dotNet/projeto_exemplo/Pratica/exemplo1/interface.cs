using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1
{
    interface IAnimal
    {
        void brincar(string brinquedo);
        void comer(string comida);
        void dormir(string lugar);
    }

    class Gato : IAnimal
    {
        private string name;

        public Gato(string name)
        {
            this.name = name;
        }

        public void brincar(string brinquedo)
        {
            Console.Write("Brincando com o(a) " + brinquedo);
        } 

        public void comer(string comida)
        {
            Console.Write("Comendo " + comida);
        }

        public void dormir(string lugar)
        {
            Console.Write("dormindo na " + lugar);
        }
    } 
}
