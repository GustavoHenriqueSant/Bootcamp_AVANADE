namespace projeto_Pratica.Models
{
    public class Data
    {
        private bool mesIsValid;
        private int mes;
            public int Mes { 
                get{
                    return this.mes;
                } 
                set{
                    if(value > 0 && value <= 12){
                        this.mes = value;
                        this.mesIsValid = true;
                    } else
                        this.mesIsValid = false;
                }    
            }

        public int getMes(){
            return this.mes;
        }

        public void setMes(int mes){
            if(mes > 0 && mes <= 12){
                this.mes = mes;
                this.mesIsValid = true;
            } else
                this.mesIsValid = false;
        }

        public void ApresentarMes(){
            if(this.mesIsValid)
                System.Console.WriteLine(this.mes);
            else
                System.Console.WriteLine("Mês inválido.");
        }
    }
}