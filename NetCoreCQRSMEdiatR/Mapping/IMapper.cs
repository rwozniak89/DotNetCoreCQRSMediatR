using System.Collections.Generic;
using NetCoreCQRSMEdiatR.Dtos;
using NetCoreCQRSMEdiatR.Responses;

namespace NetCoreCQRSMEdiatR.Mapping
{
    public interface IMapper
    {
        List<CustomerResponse> MapCustomerDtosToCustomerResponses(List<CustomerDto> dtos);
        
        CustomerResponse MapCustomerDtoToCustomerResponse(CustomerDto customerDto);

        List<OrderResponse> MapOrderDtosToOrderResponses(List<OrderDto> customerOrders);
        
        OrderResponse MapOrderDtoToOrderResponse(OrderDto order);
    }
}