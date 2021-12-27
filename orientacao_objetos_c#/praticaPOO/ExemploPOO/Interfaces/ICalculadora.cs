namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int somar(int a, int b);
        int subtrair(int a, int b);
        double dividir(int a, int b){
            return a/b;
        }
        int multiplicar(int a, int b); 
    }
}