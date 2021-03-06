using System;
using System.Threading;
using System.Threading.Tasks;
using NetCoreCQRSMEdiatR.Commands;
using NetCoreCQRSMEdiatR.Mapping;
using NetCoreCQRSMEdiatR.Repositories;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;
using Microsoft.Extensions.Logging;

namespace NetCoreCQRSMEdiatR.Handlers
{
    public class CreateCustomerOrderHandler2 : IRequestHandler<CreateCustomerOrderCommand, OrderResponse>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCustomerOrderHandler2> _logger;

        public CreateCustomerOrderHandler2(ILogger<CreateCustomerOrderHandler2> logger, IOrdersRepository ordersRepository, IMapper mapper)
        {
            _logger = logger;
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        public async Task<OrderResponse> Handle(CreateCustomerOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _ordersRepository.CreateOrderAsync(request.CustomerId, request.ProductId);
            _logger.LogInformation($"Created order for customer: {order.CustomerId} for product: {order.ProductId}");

            return _mapper.MapOrderDtoToOrderResponse(order);
        }
    }
}