namespace Classes.metodos
{
    public class Ref
    {
        static void inverter(ref int a, ref int b){
            int aux = a;
            a = b;
            b = aux;
        }

        public static void inverter(){
            int i = 3, j = 4;
            inverter(ref i , ref j);
            System.Console.WriteLine($"{i}, {j}");
        }
    }
}