using System;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Queries
{
    public class GetCustomerOrdersQuery : IRequest<CustomerOrdersResponse>
    {
        public Guid CustomerId { get; }
        
        public GetCustomerOrdersQuery(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}