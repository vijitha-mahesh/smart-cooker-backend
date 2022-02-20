using smartCooker.Models;
using System.Collections.Generic;

namespace smartCooker.Repositories.IRepository
{
    public interface IOutletRepository
    {
        IEnumerable<Outlet> CustomerGetAllOutlets();
    }
}
