using System;

namespace pilha_ED.Folder_pilha
{
    class Pilha{
        Node cabeca;

        public object desempilha(){
            if(this.cabeca == null){
                throw new InvalidOperationException("A pilha está vazia!");
            }

            object resultado = this.cabeca.getValue();
            this.cabeca = this.cabeca.getProx();
            return resultado;
        }

        public void empilha(int value){
            Node new_Node = new Node(value, this.cabeca);
            this.cabeca = new_Node;
        }

        class Node{
            object value;
            Node prox;

            public Node(object value, Node prox){
                this.value = value;
                this.prox = prox;
            }

            public object getValue(){
                return this.value;
            }

            public Node getProx(){
                return this.prox;
            }
        }
    }

}
