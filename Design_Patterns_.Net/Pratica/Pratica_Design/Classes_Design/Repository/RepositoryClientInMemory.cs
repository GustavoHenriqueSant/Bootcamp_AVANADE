namespace Pratica_Design.Classes_Design
{
    public class RepositoryClientInMemory : IRepositoryClient
    {
        public Client getByID(int ID){
            return new Client();
        }

        public void delete(Client cliente){
            //Code here
        }
    }
}