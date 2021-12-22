namespace Classes.Henraca
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int z) : base(x,y){
            this.z = z;
        }

        public static void calcular(){

        }

        public override void calcularDistanciaIII()
        {
            base.calcularDistanciaIII();
        }
    }
}