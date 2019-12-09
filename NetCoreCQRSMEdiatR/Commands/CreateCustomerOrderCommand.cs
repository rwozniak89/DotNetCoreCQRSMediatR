using System;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Commands
{
    public class CreateCustomerOrderCommand : IRequest<OrderResponse>
    {
        public Guid CustomerId { get; set; }

        public Guid ProductId { get; set; }
    }
}