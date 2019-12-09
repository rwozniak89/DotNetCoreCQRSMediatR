using System.Collections.Generic;
using NetCoreCQRSMEdiatR.Responses;
using MediatR;

namespace NetCoreCQRSMEdiatR.Queries
{
    public class GetAllOrdersQuery : IRequest<List<OrderResponse>>
    {
        
    }
}