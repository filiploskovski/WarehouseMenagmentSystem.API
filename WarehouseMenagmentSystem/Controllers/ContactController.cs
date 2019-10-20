using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wms.Data.Entities;
using Wms.Service.Interfaces;
using Wms.Service.Models;

namespace WarehouseMenagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<Contact>> Get()
        {
            var xxx = await _contactService.Get();
            return xxx;
        }
        [HttpPost]
        public async Task Create(ContactModel model)
        {
            Console.WriteLine("Test");

            var xx = new Contact()
            {
                CompanyName = model.CompanyName,
                CustomerType = model.CustomerType ==1,
                WorkPhone = model.WorkPhone,
                Website = model.Website,
                FirstName = model.FirstName,
                ContactType = model.ContactType == 0,
                Email = model.Email,
                LastName = model.LastName,
                Mobile = model.Mobile
            };

            await _contactService.Create(xx);
        }

    }
}