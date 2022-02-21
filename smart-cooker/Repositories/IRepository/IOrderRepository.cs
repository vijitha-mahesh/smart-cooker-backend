using smartCooker.DTOs.Orders;
using smartCooker.Models;
using System.Threading.Tasks;

namespace smartCooker.Repositories.IRepository
{
    public interface IOrderRepository
    {
        Task<bool> CreateOrder(CreateOrderDTO orderCreateDto, IdentityUserModel orderUser);
    }
}
