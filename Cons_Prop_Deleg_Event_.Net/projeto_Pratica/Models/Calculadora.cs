namespace ExemploPOO.Models
{
    public class Calculadora
    {
        public static int multiplicar(int a, int b)
        {
            return a * b;
        }

        public static void somar(int a, int b){
            System.Console.WriteLine(a + b);
        }

        public static int subtrair(int a, int b)
        {
            return a - b;
        }
    }
}