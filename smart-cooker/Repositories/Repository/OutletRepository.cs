using smartCooker.Data;
using smartCooker.Models;
using smartCooker.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace smartCooker.Repositories.Repository
{

    public class OutletRepository: IOutletRepository
    {
        private readonly ApiDbContext _context;

        public OutletRepository(ApiDbContext apiDbContext)
        {
            _context = apiDbContext;
        }

        IEnumerable<Outlet> IOutletRepository.CustomerGetAllOutlets()
        {
            return _context.Outlet.ToList();
        }

    }
}
