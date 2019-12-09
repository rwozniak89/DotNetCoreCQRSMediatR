using System.Collections.Generic;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Queries
{
    public class GetAllCustomersQuery : IRequest<List<CustomerResponse>>
    {
        
    }
}