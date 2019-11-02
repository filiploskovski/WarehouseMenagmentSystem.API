using System;
using System.Collections.Generic;
using System.Linq;
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
            return await _customerRepository.ListAllAsync(x => x.QueryModel());
        }

        public async Task<CustomerModel> GetById(int id)
        {
            return await _customerRepository.FindFirst(x => x.Where(y => y.Id == id).QueryModel());
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
