using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NetCoreCQRSMEdiatR.Mapping;
using NetCoreCQRSMEdiatR.Queries;
using NetCoreCQRSMEdiatR.Repositories;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderResponse>>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;
        
        public GetAllOrdersHandler(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }
        
        public async Task<List<OrderResponse>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _ordersRepository.GetOrdersAsync();
            return _mapper.MapOrderDtosToOrderResponses(orders);
        }
    }
}