namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void creditar(double valor);

        public void getSaldo(){
            System.Console.WriteLine($"A conta possui um slaod de {this.saldo}");
        }
    }
}