namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int nota { get; set; }

        public override void apresentar(){
            System.Console.WriteLine($"Salve Salve, meu nome é {this.nome}. E, eu sou um aluno nota {this.nota}");
        }
    }
}