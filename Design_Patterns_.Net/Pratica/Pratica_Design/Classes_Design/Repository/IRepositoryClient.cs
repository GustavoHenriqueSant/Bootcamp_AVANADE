namespace Pratica_Design.Classes_Design
{
    public interface IRepositoryClient
    {
        Client getByID(int id);
        void delete(Client cliente);
    }
}