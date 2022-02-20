using smartCooker.DTOs;
using System.Collections.Generic;

namespace smartCooker.Services.IService
{
    public interface IOutletService
    {
        IEnumerable<CustomerOutletReadDTO> CustomerGetAllOutlets();

    }
}
