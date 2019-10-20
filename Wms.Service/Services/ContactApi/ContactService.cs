using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wms.Data.Entities;
using Wms.Repo;
using Wms.Service.Interfaces;

namespace Wms.Service.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task Create(Contact model)
        {
            await _contactRepository.Insert(model);
        }

        public Task Delete(Contact model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contact>> Get()
        {
            return await _contactRepository.Get();
        }

        public Task<Contact> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Contact model)
        {
            throw new NotImplementedException();
        }
    }
}
