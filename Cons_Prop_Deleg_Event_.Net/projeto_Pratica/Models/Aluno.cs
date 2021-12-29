namespace projeto_Pratica.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string name, string sobrenome, string disciplina) : base(name, sobrenome){
            System.Console.WriteLine("Construtor do Aluno aquiiiiiiii");
        }
    }
}