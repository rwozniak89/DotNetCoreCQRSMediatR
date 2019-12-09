using System;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {
        public Guid OrderId { get; }
        
        public GetOrderByIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}