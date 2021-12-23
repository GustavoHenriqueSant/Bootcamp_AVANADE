namespace revisao
{
    public class Aluno
    {
        private string nome;
        private decimal nota;

        public string getNome(){
            return this.nome;
        }

        public decimal getNota(){
            return this.nota;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public void setNota(decimal nota){
            this.nota = nota;
        }
    }
}