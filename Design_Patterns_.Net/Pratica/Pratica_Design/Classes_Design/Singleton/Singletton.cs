namespace Pratica_Design.Classes_Design
{
    public class Singletton
    {
        public int id;
        private static Singletton instance = null;

        private Singletton(int id){this.id = id;}

        public static Singletton instanciacao(int id){
            if(instance == null)
                instance = new Singletton(id);
            
            return instance;
        }
    }
}