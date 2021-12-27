namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }
    
        public override void apresentar(){
            System.Console.WriteLine($"Olá meu caro amigo, me chamo {this.nome}, e ganho incríveis {this.salario} merreis.");
        }
    }
}