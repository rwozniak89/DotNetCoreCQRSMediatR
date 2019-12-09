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
    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, List<CustomerResponse>>
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly IMapper _mapper;

        public GetAllCustomersHandler(ICustomersRepository customersRepository, IMapper mapper)
        {
            _customersRepository = customersRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerResponse>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customerDtos = await _customersRepository.GetCustomersAsync();
            return _mapper.MapCustomerDtosToCustomerResponses(customerDtos);
        }
    }
}