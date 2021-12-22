namespace Classes.metodos
{
    public class Out
    {
        static void dividir(int x, int y, out int resultado, out int resto){
            resultado = x / y;
            resto = x % y;
        }

        public static void dividir(){
            dividir(10, 8, out int resultado, out int resto);
            System.Console.WriteLine($"Resultado = {resultado}, resto = {resto}");
        }
    }
}