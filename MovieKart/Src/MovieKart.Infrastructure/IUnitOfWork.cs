namespace MovieKart.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}