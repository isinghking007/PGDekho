using PGDekho.com.DataContext;

namespace PGDekho.com.Logic.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext context;
        public UnitOfWork(DBContext context) {
            this.context = context;
            Common = new CommonRepository(this.context);
            PropertyOwner = new PropertyRepository(this.context);
        }

        public ICommon Common { get; private set; }

        public IPropertyOwner PropertyOwner { get; private set; }

        public void Dispose()
        {
             context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
