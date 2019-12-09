using System;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerResponse>
    {
        public Guid CustomerId { get; }
        
        public GetCustomerByIdQuery(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}