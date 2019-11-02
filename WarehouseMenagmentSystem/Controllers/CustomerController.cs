using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wms.Service.Interfaces;
using Wms.Service.Models;

namespace WarehouseMenagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerModel>> Get()
        {
            return await _customerService.Get();
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public async Task<CustomerModel> GetById(int id)
        {
            return await _customerService.GetById(id);
        }

        [HttpPost]
        public async Task<CustomerModel> Create(CustomerModel model)
        {
            throw new NotImplementedException();
        }
    }
}