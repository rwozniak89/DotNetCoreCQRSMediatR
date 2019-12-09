using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreCQRSMEdiatR.Dtos;

namespace NetCoreCQRSMEdiatR.Repositories
{
    public interface ICustomersRepository
    {
        Task<CustomerDto> GetCustomerAsync(Guid customerId);
        
        Task<List<CustomerDto>> GetCustomersAsync();
    }
}