namespace Classes.Henraca
{
    public class Ponto
    {
        public int x,y;
        private double distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        // Somento classes associadas a essa podem acessar esse método
        protected void calcularDistancia(){

        }

        //Só o domínio dessa classe pdoe acessar esse método
        private void calcularDistanciaII(){

        }

        //Definir um método com a palavra-chave virtual, significa que o mesmo pode ser sobreescrito na classe filha
        public virtual void calcularDistanciaIII(){

        }
    }
}