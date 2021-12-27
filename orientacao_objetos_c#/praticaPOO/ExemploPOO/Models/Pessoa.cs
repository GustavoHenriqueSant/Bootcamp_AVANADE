namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string nome {get; set;}
        public int idade {get; set;}

        public virtual void apresentar(){
            System.Console.WriteLine($"Olá! Meu nome é {this.nome}, e tenho {this.idade} anos de idade.");
        }
    }
}