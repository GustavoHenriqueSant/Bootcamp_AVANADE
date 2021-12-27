using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public int somar(int a, int b){
            return a + b;
        }

        public int subtrair(int a, int b)
        {
            return a - b;
        }
    }
}