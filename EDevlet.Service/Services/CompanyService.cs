using EDevlet.Core.Models;
using EDevlet.Core.Repositories;
using EDevlet.Core.Services;
using EDevlet.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDevlet.Service.Services
{
    public class CompanyService : Service<Company>, ICompanyService
    {
        public CompanyService(IGenericRepository<Company> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
