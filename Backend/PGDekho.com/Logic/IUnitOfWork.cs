namespace PGDekho.com.Logic
{
    public interface IUnitOfWork : IDisposable
    {
        ICommon Common { get; }
        IPropertyOwner PropertyOwner { get; }

        void Dispose();

        int Save();
    }
}
