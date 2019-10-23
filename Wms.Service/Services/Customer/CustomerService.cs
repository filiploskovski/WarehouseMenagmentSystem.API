using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wms.Data.Entities;
using Wms.Repo;
using Wms.Service.Interfaces;
using Wms.Service.Models;

namespace Wms.Service.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<CCustomer> _customerRepository;

        public CustomerService(IRepository<CCustomer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<CustomerModel>> Get()
        {
            return await _customerRepository.Find(x => x.CustomerType != (short) Wms.Service.Enums.CustomerType.Vendor);
        }

        public Task<CustomerModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Create(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public Task Update(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CustomerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
