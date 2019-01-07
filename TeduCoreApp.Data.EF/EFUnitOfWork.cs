using TeduCoreApp.Infrastructure.Interfaces;

namespace TeduCoreApp.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        // private readonly AppDbContext _context;
        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}