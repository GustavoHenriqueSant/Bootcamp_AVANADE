namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double largura;
        private double comprimento;
        private bool valido;

        public void definirMedidas(double largura, double comprimento){
            while(!this.valido){
                if(largura > 0 && comprimento > 0){
                    this.largura = largura;
                    this.comprimento = comprimento;
                    this.valido = true;
                } else {
                    System.Console.WriteLine("Comprimento ou largura inválidos. Tais parâmetros necessitam ser positivos.");
                    System.Console.WriteLine("Entre com medida de largura válida:");
                    largura = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("Entre com comprimento válido:");
                    comprimento = double.Parse(System.Console.ReadLine());
                }
            }
        }

        public double getArea(){
            if(this.valido)
                return this.comprimento * this.largura;
            else{
                System.Console.WriteLine("Não foi definido medidas válidas ao retângulo.");
                return 0;
            }   
        }
    }
}