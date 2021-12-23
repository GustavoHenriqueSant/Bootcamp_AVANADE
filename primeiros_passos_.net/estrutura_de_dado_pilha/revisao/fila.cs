namespace revisao
{
    public class Fila
    {
        private Node cabeca;
        private Node final;

        public void insercao(Aluno aluno){
            Node newNode = new Node(aluno);

            if(this.cabeca == null){
                this.cabeca = newNode;
                this.final = newNode;
            } else if(this.final.getProx() == null){
                this.final.setProx(newNode);
                this.cabeca.setProx(newNode);
                this.cabeca = newNode;
            } else {
                this.cabeca.setProx(newNode);
                this.cabeca = newNode;
            }
        }

        public Node getCabeca(){
            return this.cabeca;
        }

        public Node getFinal(){
            return this.final;
        }

        static public void printFila(Node fila, int indice){
            if(fila != null){
                System.Console.WriteLine("Aluno " + indice + ":");
                System.Console.WriteLine("\t Nome: " + fila.getAluno().getNome());
                System.Console.WriteLine("\t Nota: " + fila.getAluno().getNota());
                printFila(fila.getProx(), indice+1);
            }
        }

        public class Node{
            private Aluno aluno_value;
            private Node prox;

            public Node(Aluno aluno_value){
                this.aluno_value = aluno_value;
                this.prox = null;
            }

            public void setProx(Node prox){
                this.prox = prox;
            }

            public Node getProx(){
                return this.prox;
            }

            public Aluno getAluno(){
                return this.aluno_value;
            }
        }
    }
}