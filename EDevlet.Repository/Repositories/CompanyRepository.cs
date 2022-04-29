using EDevlet.Core.Models;
using EDevlet.Core.Repositories;

namespace EDevlet.Repository.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }
    }
}
