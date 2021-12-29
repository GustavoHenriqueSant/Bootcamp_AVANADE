namespace projeto_Pratica.Models
{
    public class Pessoa
    {
        // Na inicialização
        private readonly string name = "Gusta";
        private readonly string sobrenome;

        //dentro do construtor
        public Pessoa(string name, string sobrenome){
            this.name = name;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Terminando o construtor de Pessoa aquiiiii");
        }

        public void apresentar(){
            System.Console.WriteLine($"Olá! Me chamo {this.name} {this.sobrenome}, é um prazer conhecê-lo");
        }
    }
}