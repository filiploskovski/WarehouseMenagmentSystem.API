using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wms.Data.Entities;
using Wms.Service.Interfaces;

namespace WarehouseMenagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<Contact>>> Get()
        {
            var xxx = await _contactService.Get();
            return new List<Contact>();
        }
        [HttpPost]
        public async Task Create(Contact model)
        {
            await _contactService.Create(model);
        }

    }
}