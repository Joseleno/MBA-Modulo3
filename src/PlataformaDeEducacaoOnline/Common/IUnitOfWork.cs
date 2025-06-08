namespace Common
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
