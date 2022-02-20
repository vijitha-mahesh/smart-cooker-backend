using AutoMapper;
using smartCooker.DTOs;
using smartCooker.Repositories.IRepository;
using smartCooker.Services.IService;
using System.Collections.Generic;

namespace smartCooker.Services.Service
{
    public class OutletService: IOutletService
    {
        private readonly IMapper _mapper;
        private readonly IOutletRepository _outletRepository;

        public OutletService(IOutletRepository outletRepository, IMapper mapper)
        {
            _outletRepository = outletRepository;
            _mapper = mapper;
        }
        IEnumerable<CustomerOutletReadDTO> IOutletService.CustomerGetAllOutlets()
        {
            var outlets = _outletRepository.CustomerGetAllOutlets();
            return _mapper.Map<IEnumerable<CustomerOutletReadDTO>>(outlets);
        }
    }
}
